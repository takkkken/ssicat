namespace SICAT
{
    partial class LogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listboxLog
            // 
            this.listboxLog.FormattingEnabled = true;
            this.listboxLog.Location = new System.Drawing.Point(12, 12);
            this.listboxLog.Name = "listboxLog";
            this.listboxLog.Size = new System.Drawing.Size(520, 238);
            this.listboxLog.TabIndex = 0;
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 266);
            this.Controls.Add(this.listboxLog);
            this.Name = "LogWindow";
            this.Text = "SICAT Log";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxLog;

    }
}