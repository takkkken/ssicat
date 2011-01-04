using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using FTPLib;
using ASFTBase.Graphic;
using System.Drawing.Imaging;
using System.Threading;
using System.Collections;

namespace SICAT
{
    public partial class formConfiguration : Form
    {
        #region Hotkey variables

        [DllImport("user32", SetLastError = true)]
        private static extern int RegisterHotKey(IntPtr hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32", SetLastError = true)]
        private static extern int UnregisterHotKey(IntPtr hwnd, int id);
        [DllImport("kernel32", SetLastError = true)]
        private static extern short GlobalAddAtom(string lpString);
        [DllImport("kernel32", SetLastError = true)]
        private static extern short GlobalDeleteAtom(short nAtom);

        private const int MOD_ALT = 1;
        private const int MOD_CONTROL = 2;
        private const int MOD_SHIFT = 4;
        private const int MOD_WIN = 8;

        #endregion

        /// <summary>
        /// Helper to handle the file formats
        /// </summary>
        ImageFormatHandler handlers = new ImageFormatHandler();

        /// <summary>
        /// The class instance used to capture the screen
        /// </summary>
        ScreenCapture capture = new ScreenCapture();

        private const string FILE_NAME = "settings.dat";
        private SettingsFile settings;
        public static ArrayList logRecord = new ArrayList();
        private FTP ftplib = new FTP();
        private Int32 count = new Int32();
        public ImageFormatHandler.ImageFormatTypes selectedImageFormat;
        public String selectedImageFormatExtension;
        public ScreenCapture.CaptureType selectedCapType;
        private Object imageLock = new Object();
        private Object ftpLock = new Object();
        private Keys hotkey = new Keys();
        private Keys modkeys = new Keys();
        private int modifiers = 0;
        
        public formConfiguration()
        {
            InitializeComponent();
            if (File.Exists(FILE_NAME))
            {
                Stream input = File.OpenRead(FILE_NAME);
                BinaryFormatter bRead = new BinaryFormatter();
                settings = (SettingsFile)bRead.Deserialize(input);
                input.Close();
                try
                {
                    String[] address = settings.serverAddress.Split(new Char[] { ':' });
                    textboxServerAddress.Text = address[0];
                    try
                    {
                        textboxPort.Text = address[1];
                    }
                    catch
                    {
                        textboxPort.Text = "21";
                    }
                    textboxUsername.Text = settings.username;
                    textboxPassword.Text = settings.password;
                    textboxPath.Text = settings.path;
                    checkboxEnable.Checked = settings.urlEnable;
                    passive_on.Checked = settings.passiveOn;

                    textboxURLToImages.Text = settings.urlToImages;
                    logRecord = settings.log;
                    textboxPrefix.Text = settings.imagePrefix;
                    count = settings.count;
                    selectedImageFormat = settings.imageFormat;
                    selectedImageFormatExtension = settings.imageFormatExt;
                    selectedCapType = settings.capType;
                }
                catch
                {
                    MessageBox.Show("Failed to load settings file.\nBackup created; using default settings.");
                    File.Copy(FILE_NAME, "settings_backup.dat");
                    settings = new SettingsFile();
                    String[] address = settings.serverAddress.Split(new Char[] { ':' });
                    textboxPort.Text = address[1];
                    textboxPath.Text = settings.path;
                    textboxPrefix.Text = settings.imagePrefix;
                    count = settings.count;
                    selectedImageFormat = settings.imageFormat;
                    selectedImageFormatExtension = settings.imageFormatExt;
                    selectedCapType = settings.capType;
                }
            }
            else
            {
                settings = new SettingsFile();
                String[] address = settings.serverAddress.Split(new Char[] { ':' });
                textboxPort.Text = address[1];
                textboxPath.Text = settings.path;
                textboxPrefix.Text = settings.imagePrefix;
                count = settings.count;
                selectedImageFormat = settings.imageFormat;
                selectedImageFormatExtension = settings.imageFormatExt;
                selectedCapType = settings.capType; 
            }
            hotkey = settings.hotkey;
            modkeys = settings.modkeys;
            modifiers = settings.modifiers;
            RegisterGlobalHotKey(hotkey, modifiers);
            if(modkeys.ToString().Equals("None"))
                labelCurrentHotkey.Text = hotkey.ToString();
            else
                labelCurrentHotkey.Text = modkeys.ToString() + " + " + hotkey.ToString();
            setRadioButtons();
            
        }

        private void setRadioButtons()
        {
            if (selectedImageFormat.Equals(ImageFormatHandler.ImageFormatTypes.imgJPEG))
                radiobuttonJPG.Checked = true;
            else if (selectedImageFormat.Equals(ImageFormatHandler.ImageFormatTypes.imgPNG))
                radiobuttonPNG.Checked = true;
            else if (selectedImageFormat.Equals(ImageFormatHandler.ImageFormatTypes.imgBMP))
                radiobuttonBMP.Checked = true;
            else if (selectedImageFormat.Equals(ImageFormatHandler.ImageFormatTypes.imgGIF))
                radiobuttonGIF.Checked = true;

            if (selectedCapType.Equals(ScreenCapture.CaptureType.PrimaryScreen))
                radiobuttonPrimaryMonitor.Checked = true;
            else if (selectedCapType.Equals(ScreenCapture.CaptureType.VirtualScreen))
                radiobuttonAllMonitorsSingle.Checked = true;
            else if (selectedCapType.Equals(ScreenCapture.CaptureType.AllScreens))
                radiobuttonAllMonitorsMultiple.Checked = true;
        }

        private void formConfiguration_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void formConfiguration_Closed(object sender, System.EventArgs e)
        {
            saveSettings();
            // unregister the hotkey (NEVER FORGET THIS!)
            UnregisterGlobalHotKey();
            Application.Exit();
        }

        private void saveSettings()
        {
            settings.serverAddress = textboxServerAddress.Text + ":" + textboxPort.Text;
            settings.username = textboxUsername.Text;
            settings.password = textboxPassword.Text;
            settings.path = textboxPath.Text;
            settings.urlEnable = checkboxEnable.Checked;
            settings.passiveOn = passive_on.Checked;

            settings.urlToImages = textboxURLToImages.Text;
            settings.log = logRecord;
            settings.count = count;
            settings.imagePrefix = textboxPrefix.Text;
            settings.imageFormat = selectedImageFormat;
            settings.imageFormatExt = selectedImageFormatExtension;
            settings.capType = selectedCapType;
            settings.hotkey = hotkey;
            settings.modkeys = modkeys;
            settings.modifiers = modifiers;
            Stream output = File.Create(FILE_NAME);
            BinaryFormatter bWrite = new BinaryFormatter();
            bWrite.Serialize(output, settings);
            output.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Visible = false;
        }

        private void testConnection()
        {
            try
            {
                //パッシブモードの場合
                if (passive_on.Checked)
                {
                    ftplib.PassiveMode = true;
                }
                else
                {
                    ftplib.PassiveMode = false;
                }
                ftplib.Connect(textboxServerAddress.Text, int.Parse(textboxPort.Text), textboxUsername.Text, textboxPassword.Text);
            }
            catch (Exception ex)
            {
            }
            if (ftplib.IsConnected)
            {
                labelConnectionStatus.Text = "接続ＯＫ";
                ftplib.Disconnect();
            }
            else
            {
                labelConnectionStatus.Text = "接続エラー";
            }

        }

        #region Code for registering hotkey

        // the id for the hotkey
        short hotkeyID;

        // register a global hot key
        void RegisterGlobalHotKey(Keys hotkey, int modifiers)
        {
            try
            {
                // use the GlobalAddAtom API to get a unique ID (as suggested by MSDN docs)
                string atomName = AppDomain.GetCurrentThreadId().ToString("X8") + this.Name;
                hotkeyID = GlobalAddAtom(atomName);
                if (hotkeyID == 0)
                {
                    throw new Exception("Unable to generate unique hotkey ID. Error code: " +
                       Marshal.GetLastWin32Error().ToString());
                }

                // register the hotkey, throw if any error
                if (RegisterHotKey(this.Handle, hotkeyID, modifiers, (int)hotkey) == 0)
                {
                    throw new Exception("Unable to register hotkey. Error code: " + Marshal.GetLastWin32Error()
                       .ToString());
                }
            }
            catch (Exception e)
            {
                // clean up if hotkey registration failed
                UnregisterGlobalHotKey();
            }
        }

        // unregister a global hotkey
        void UnregisterGlobalHotKey()
        {
            if (this.hotkeyID != 0)
            {
                UnregisterHotKey(this.Handle, hotkeyID);
                // clean up the atom list
                GlobalDeleteAtom(hotkeyID);
                hotkeyID = 0;
            }
        }
        #endregion

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // let the base class process the message
            base.WndProc(ref m);

            // if this is a WM_HOTKEY message, notify the parent object
            const int WM_HOTKEY = 0x312;
            if (m.Msg == WM_HOTKEY)
            {
                // do whatever you wish to do when the hotkey is pressed
                // in this example we activate the form and display a messagebox

                // this.Activate();
                // MessageBox.Show("Hotkey has been pressed");
                Thread image = new Thread(new ThreadStart(takeImage));
                image.SetApartmentState(ApartmentState.STA);
                image.Start();
            }

        }

        private void takeImage()
        {
            int localCount;

            lock (imageLock)
            {
                localCount = count;
                Bitmap[] temp = capture.Capture(selectedCapType, ".\\" + textboxPrefix.Text + localCount.ToString(), selectedImageFormat);
                count++;
            }

            lock (ftpLock)
            {
                try
                {
                    //パッシブモードの場合
                    if (passive_on.Checked)
                    {
                        ftplib.PassiveMode = true;
                    }
                    else
                    {
                        ftplib.PassiveMode = false;
                    }
                    ftplib.Connect(textboxServerAddress.Text, int.Parse(textboxPort.Text), textboxUsername.Text, textboxPassword.Text);
                    String[] split = textboxPath.Text.Split(new Char[] {'/'});
                    foreach (String s in split)
                    {
                        if (!s.Equals(""))
                            ftplib.ChangeDir(s);
                    }
                    if (selectedCapType.Equals(ScreenCapture.CaptureType.AllScreens) && File.Exists(textboxPrefix.Text + localCount.ToString() + ".01" + selectedImageFormatExtension))
                    {
                        int fileNum = 1;
                        while (File.Exists(textboxPrefix.Text + localCount.ToString() + ".0" + fileNum.ToString() + selectedImageFormatExtension))
                        {
                            ftplib.OpenUpload(".\\" + textboxPrefix.Text + localCount.ToString() + ".0" + fileNum.ToString() + selectedImageFormatExtension, textboxPrefix.Text + localCount.ToString() + ".0" + fileNum.ToString() + selectedImageFormatExtension);
                            while (ftplib.DoUpload() > 0)
                            {
                            }
                            addToLog(textboxServerAddress.Text, textboxPort.Text, textboxUsername.Text, textboxPath.Text, textboxPrefix.Text + localCount.ToString() + ".0" + fileNum.ToString() + selectedImageFormatExtension);
                            fileNum++;
                        }
                        ftplib.Disconnect();
                        setClipboard(textboxPrefix.Text + localCount.ToString() + ".01" + selectedImageFormatExtension);
                    }
                    else
                    {
                        ftplib.OpenUpload(".\\" + textboxPrefix.Text + localCount.ToString() + selectedImageFormatExtension, textboxPrefix.Text + localCount.ToString() + selectedImageFormatExtension);
                        while (ftplib.DoUpload() > 0)
                        {
                        }
                        ftplib.Disconnect();
                        setClipboard(textboxPrefix.Text + localCount.ToString() + selectedImageFormatExtension);
                        addToLog(textboxServerAddress.Text, textboxPort.Text, textboxUsername.Text, textboxPath.Text, textboxPrefix.Text + localCount.ToString() + selectedImageFormatExtension);
                    }
                }
                catch (Exception ex)
                {
                    ftplib.Disconnect();
//                    Console.Write(ex.ToString());
                    MessageBox.Show("Error has occured");
                }
                
                saveSettings();

            }
        }

        private void addToLog(String server, String port, String user, String path, String imageName)
        {
            LogEntry newEntry = new LogEntry(server, user, path, imageName);
            
            logRecord.Add(newEntry);
        }

        [STAThread]
        private void setClipboard(String imageName)
        {
            if (checkboxEnable.Checked)
            {
                Clipboard.SetText(textboxURLToImages.Text + imageName);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            resetSettings();
            this.Visible = false;
        }

        private void resetSettings()
        {
            String[] address = settings.serverAddress.Split(new Char[] { ':' });
            textboxServerAddress.Text = address[0];
            try
            {
                textboxPort.Text = address[1];
            }
            catch
            {
                textboxPort.Text = "21";
            }
            textboxUsername.Text = settings.username;
            textboxPassword.Text = settings.password;
            textboxPath.Text = settings.path;
            checkboxEnable.Checked = settings.urlEnable;
            passive_on.Checked = settings.passiveOn;

            textboxURLToImages.Text = settings.urlToImages;
            textboxPrefix.Text = settings.imagePrefix;
            selectedImageFormat = settings.imageFormat;
            selectedImageFormatExtension = settings.imageFormatExt;
            selectedCapType = settings.capType;
            UnregisterGlobalHotKey();
            hotkey = settings.hotkey;
            modkeys = settings.modkeys;
            modifiers = settings.modifiers;
            if(modkeys.ToString().Equals("None"))
                labelCurrentHotkey.Text = hotkey.ToString();
            else
                labelCurrentHotkey.Text = modkeys.ToString() + " + " + hotkey.ToString();
            RegisterGlobalHotKey(hotkey, modifiers);
            setRadioButtons();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            labelImageCount.Text = count.ToString();
            textboxChangeICValue.Text = "";
        }

        private void buttonSetHotkey_Click(object sender, EventArgs e)
        {
            changeHotKey();
        }

        private void changeHotKey()
        {
            labelCurrentHotkey.Text = "Please press desired hotkey";
        }
 
        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            testConnection();
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you wish to erase all your settings?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer.Equals(DialogResult.Yes))
            {
                defaultSettings();
                resetSettings();
            }
        }

        private void defaultSettings()
        {
            settings.defaultSettings();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings();
            Close();
            Application.Exit();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogWindow log = new LogWindow();
            log.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            labelImageCount.Text = count.ToString();
            textboxChangeICValue.Text = "";
        }

        private void checkboxEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxEnable.Checked)
            {
                textboxURLToImages.Enabled = true;
                textboxURLToImages.Text = "http://" + textboxServerAddress.Text + textboxPath.Text;
            }

            if (!checkboxEnable.Checked)
            {
                textboxURLToImages.Enabled = false;
                textboxURLToImages.Text = "";
            }

        }

        private void textboxPath_Leave(object sender, EventArgs e)
        {
            if(textboxPath.Text.Equals(""))
                textboxPath.Text = "/";
        }

        private void buttonChangeICValue_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 newCount = Int32.Parse(textboxChangeICValue.Text);
                count = newCount;
                labelImageCount.Text = count.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input; Please enter a number");
            }

        }

        private void linklabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sicat.sourceforge.net/");
        }

        private void textboxPrefix_Leave(object sender, EventArgs e)
        {
            if(textboxPrefix.Text.Equals(""))
                textboxPrefix.Text = "sicatimage";
        }

        private void radiobuttonJPG_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonJPG.Checked)
            {
                selectedImageFormat = ImageFormatHandler.ImageFormatTypes.imgJPEG;
                selectedImageFormatExtension = ".jpg";
            }
        }

        private void radiobuttonPNG_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonPNG.Checked)
            {
                selectedImageFormat = ImageFormatHandler.ImageFormatTypes.imgPNG;
                selectedImageFormatExtension = ".png";
            }
        }

        private void radiobuttonBMP_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonBMP.Checked)
            {
                selectedImageFormat = ImageFormatHandler.ImageFormatTypes.imgBMP;
                selectedImageFormatExtension = ".bmp";
            }
        }

        private void radiobuttonGIF_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonGIF.Checked)
            {
                selectedImageFormat = ImageFormatHandler.ImageFormatTypes.imgGIF;
                selectedImageFormatExtension = ".gif";
            }
        }

        private void radiobuttonPrimaryMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonPrimaryMonitor.Checked)
                selectedCapType = ScreenCapture.CaptureType.PrimaryScreen;
        }

        private void radiobuttonAllMonitorsSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonAllMonitorsSingle.Checked)
                selectedCapType = ScreenCapture.CaptureType.VirtualScreen;
        }

        private void radiobuttonAllMonitorsMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonAllMonitorsMultiple.Checked)
                selectedCapType = ScreenCapture.CaptureType.AllScreens;
        }
        private void radioButtonActiveForm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonActiveForm.Checked)
                selectedCapType = ScreenCapture.CaptureType.ActiveWindow;
        }
        private void buttonSetHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            int modnum;
            UnregisterGlobalHotKey();
            modnum = getModNum(e);
            RegisterGlobalHotKey(e.KeyCode, modnum);
            if(e.Modifiers.ToString().Equals("None"))
                labelCurrentHotkey.Text = e.KeyCode.ToString();
            else
                labelCurrentHotkey.Text = e.Modifiers.ToString() + " + " + e.KeyCode.ToString();
            hotkey = e.KeyCode;
            modifiers = modnum;
            modkeys = e.Modifiers;
            buttonSave.Focus();
        }

        private int getModNum(KeyEventArgs e)
        {
            int modnum = 0;
            if (e.Alt)
                modnum += 1;
            if (e.Control)
                modnum += 2;
            if (e.Shift)
                modnum += 4;
            return modnum;
        }

        private void groupboxFTPSettings_Enter(object sender, EventArgs e)
        {

        }

        private void labelChangeICValue_Click(object sender, EventArgs e)
        {

        }




    }

    [System.Serializable]
    public class SettingsFile
    {
        public String version;
        public String serverAddress;
        public String username;
        public String password;
        public String path;
        public Boolean urlEnable;
        public Boolean passiveOn;

        public String urlToImages;
        public ArrayList log;
        public String imagePrefix;
        public Int32 count;
        public ImageFormatHandler.ImageFormatTypes imageFormat;
        public String imageFormatExt;
        public ScreenCapture.CaptureType capType;
        public Keys hotkey;
        public Keys modkeys;
        public int modifiers;

        public SettingsFile()
        {
            urlEnable = new Boolean();
            passiveOn = new Boolean();
            log = new ArrayList();
            count = new Int32();
            hotkey = new Keys();
            modkeys = new Keys();
            modifiers = 0;
            defaultSettings();
        }

        public void defaultSettings()
        {
            serverAddress = ":21";
            username = "";
            password = "";
            path = "/";
            urlEnable = false;
            passiveOn = true;
            urlToImages = "";
            imagePrefix = "sicatimage";
            count = 1;
            imageFormat = ImageFormatHandler.ImageFormatTypes.imgJPEG;
            imageFormatExt = ".jpg";
            capType = ScreenCapture.CaptureType.PrimaryScreen;
            hotkey = Keys.PrintScreen;
        }
    }
    
    [System.Serializable]
    public class LogEntry
    {
        String upServer;
        String upLogin;
        String upPath;
        String upFile;
        String webAddress;
        DateTime timeStamp;

        public LogEntry(String server, String login, String path, String imageName)
        {
            upServer = server;
            upLogin = login;
            upPath = path;
            upFile = imageName;
            timeStamp = DateTime.Now;
        }

        public LogEntry(String server, String login, String path, String imageName, String address)
        {
            upServer = server;
            upLogin = login;
            upPath = path;
            upFile = imageName;
            webAddress = address;
            timeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return "[" + timeStamp.ToShortDateString() + " " + timeStamp.ToShortTimeString() + "]  " + upServer + " (" + upLogin + ") : " + upPath + upFile;
        }

    }
}