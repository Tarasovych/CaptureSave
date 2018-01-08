namespace CaptureSave
{
    partial class CaptureSave
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureSave));
            this.labelScreenResolution = new System.Windows.Forms.Label();
            this.textScreenWidth = new System.Windows.Forms.TextBox();
            this.textScreenHeight = new System.Windows.Forms.TextBox();
            this.labelHotkeyAllScreen = new System.Windows.Forms.Label();
            this.textHotkeyAllScreen = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.checkBoxSaveClipboard = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textHotkeySnippet = new System.Windows.Forms.TextBox();
            this.labelHotkeySnippet = new System.Windows.Forms.Label();
            this.contextMenuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScreenResolution
            // 
            this.labelScreenResolution.AutoSize = true;
            this.labelScreenResolution.Location = new System.Drawing.Point(13, 13);
            this.labelScreenResolution.Name = "labelScreenResolution";
            this.labelScreenResolution.Size = new System.Drawing.Size(94, 13);
            this.labelScreenResolution.TabIndex = 0;
            this.labelScreenResolution.Text = "Screen Resolution";
            // 
            // textScreenWidth
            // 
            this.textScreenWidth.Enabled = false;
            this.textScreenWidth.Location = new System.Drawing.Point(16, 30);
            this.textScreenWidth.MaxLength = 4;
            this.textScreenWidth.Name = "textScreenWidth";
            this.textScreenWidth.Size = new System.Drawing.Size(50, 20);
            this.textScreenWidth.TabIndex = 1;
            // 
            // textScreenHeight
            // 
            this.textScreenHeight.Enabled = false;
            this.textScreenHeight.Location = new System.Drawing.Point(72, 30);
            this.textScreenHeight.MaxLength = 4;
            this.textScreenHeight.Name = "textScreenHeight";
            this.textScreenHeight.Size = new System.Drawing.Size(50, 20);
            this.textScreenHeight.TabIndex = 2;
            // 
            // labelHotkeyAllScreen
            // 
            this.labelHotkeyAllScreen.AutoSize = true;
            this.labelHotkeyAllScreen.Location = new System.Drawing.Point(13, 53);
            this.labelHotkeyAllScreen.Name = "labelHotkeyAllScreen";
            this.labelHotkeyAllScreen.Size = new System.Drawing.Size(96, 13);
            this.labelHotkeyAllScreen.TabIndex = 3;
            this.labelHotkeyAllScreen.Text = "Hotkey (All screen)";
            // 
            // textHotkeyAllScreen
            // 
            this.textHotkeyAllScreen.Enabled = false;
            this.textHotkeyAllScreen.Location = new System.Drawing.Point(16, 69);
            this.textHotkeyAllScreen.Name = "textHotkeyAllScreen";
            this.textHotkeyAllScreen.Size = new System.Drawing.Size(106, 20);
            this.textHotkeyAllScreen.TabIndex = 4;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(129, 30);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 59);
            this.buttonOpenFolder.TabIndex = 5;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // checkBoxSaveClipboard
            // 
            this.checkBoxSaveClipboard.AutoSize = true;
            this.checkBoxSaveClipboard.Checked = true;
            this.checkBoxSaveClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveClipboard.Location = new System.Drawing.Point(16, 134);
            this.checkBoxSaveClipboard.Name = "checkBoxSaveClipboard";
            this.checkBoxSaveClipboard.Size = new System.Drawing.Size(109, 17);
            this.checkBoxSaveClipboard.TabIndex = 6;
            this.checkBoxSaveClipboard.Text = "Save to clipboard";
            this.checkBoxSaveClipboard.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "CaptureSave";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuExit});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(93, 26);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // textHotkeySnippet
            // 
            this.textHotkeySnippet.Enabled = false;
            this.textHotkeySnippet.Location = new System.Drawing.Point(16, 108);
            this.textHotkeySnippet.Name = "textHotkeySnippet";
            this.textHotkeySnippet.Size = new System.Drawing.Size(106, 20);
            this.textHotkeySnippet.TabIndex = 8;
            // 
            // labelHotkeySnippet
            // 
            this.labelHotkeySnippet.AutoSize = true;
            this.labelHotkeySnippet.Location = new System.Drawing.Point(13, 92);
            this.labelHotkeySnippet.Name = "labelHotkeySnippet";
            this.labelHotkeySnippet.Size = new System.Drawing.Size(86, 13);
            this.labelHotkeySnippet.TabIndex = 7;
            this.labelHotkeySnippet.Text = "Hotkey (Snippet)";
            // 
            // CaptureSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 161);
            this.Controls.Add(this.textHotkeySnippet);
            this.Controls.Add(this.labelHotkeySnippet);
            this.Controls.Add(this.checkBoxSaveClipboard);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.textHotkeyAllScreen);
            this.Controls.Add(this.labelHotkeyAllScreen);
            this.Controls.Add(this.textScreenHeight);
            this.Controls.Add(this.textScreenWidth);
            this.Controls.Add(this.labelScreenResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CaptureSave";
            this.Text = "CaptureSave";
            this.Resize += new System.EventHandler(this.CaptureSave_Resize);
            this.contextMenuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScreenResolution;
        private System.Windows.Forms.TextBox textScreenWidth;
        private System.Windows.Forms.TextBox textScreenHeight;
        private System.Windows.Forms.Label labelHotkeyAllScreen;
        private System.Windows.Forms.TextBox textHotkeyAllScreen;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.CheckBox checkBoxSaveClipboard;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.TextBox textHotkeySnippet;
        private System.Windows.Forms.Label labelHotkeySnippet;
    }
}

