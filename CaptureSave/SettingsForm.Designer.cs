namespace CaptureSave
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBoxRunAtStartup = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveClipboard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxRunAtStartup
            // 
            this.checkBoxRunAtStartup.AutoSize = true;
            this.checkBoxRunAtStartup.Location = new System.Drawing.Point(13, 13);
            this.checkBoxRunAtStartup.Name = "checkBoxRunAtStartup";
            this.checkBoxRunAtStartup.Size = new System.Drawing.Size(143, 17);
            this.checkBoxRunAtStartup.TabIndex = 0;
            this.checkBoxRunAtStartup.Text = "Run on Windows startup";
            this.checkBoxRunAtStartup.UseVisualStyleBackColor = true;
            this.checkBoxRunAtStartup.CheckedChanged += new System.EventHandler(this.checkBoxRunAtStartup_CheckedChanged);
            // 
            // checkBoxSaveClipboard
            // 
            this.checkBoxSaveClipboard.AutoSize = true;
            this.checkBoxSaveClipboard.Checked = true;
            this.checkBoxSaveClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveClipboard.Location = new System.Drawing.Point(13, 36);
            this.checkBoxSaveClipboard.Name = "checkBoxSaveClipboard";
            this.checkBoxSaveClipboard.Size = new System.Drawing.Size(109, 17);
            this.checkBoxSaveClipboard.TabIndex = 7;
            this.checkBoxSaveClipboard.Text = "Save to clipboard";
            this.checkBoxSaveClipboard.UseVisualStyleBackColor = true;
            this.checkBoxSaveClipboard.CheckedChanged += new System.EventHandler(this.checkBoxSaveClipboard_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 61);
            this.Controls.Add(this.checkBoxSaveClipboard);
            this.Controls.Add(this.checkBoxRunAtStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "CaptureSave Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxRunAtStartup;
        private System.Windows.Forms.CheckBox checkBoxSaveClipboard;
    }
}