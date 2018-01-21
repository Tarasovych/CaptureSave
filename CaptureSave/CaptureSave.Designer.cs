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
            this.labelHotkeyAllScreen = new System.Windows.Forms.Label();
            this.textScreenshotHotkey = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textSnippetHotkey = new System.Windows.Forms.TextBox();
            this.labelHotkeySnippet = new System.Windows.Forms.Label();
            this.buttonEditScreenshotHotkey = new System.Windows.Forms.Button();
            this.buttonEditSnippetHotkey = new System.Windows.Forms.Button();
            this.buttonSaveScreenshotHotkey = new System.Windows.Forms.Button();
            this.buttonSaveSnippetHotkey = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.toolTipHotkey = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHotkeyAllScreen
            // 
            this.labelHotkeyAllScreen.AutoSize = true;
            this.labelHotkeyAllScreen.Location = new System.Drawing.Point(10, 55);
            this.labelHotkeyAllScreen.Name = "labelHotkeyAllScreen";
            this.labelHotkeyAllScreen.Size = new System.Drawing.Size(96, 13);
            this.labelHotkeyAllScreen.TabIndex = 3;
            this.labelHotkeyAllScreen.Text = "Screenshot hotkey";
            // 
            // textScreenshotHotkey
            // 
            this.textScreenshotHotkey.Enabled = false;
            this.textScreenshotHotkey.Location = new System.Drawing.Point(10, 71);
            this.textScreenshotHotkey.MaxLength = 255;
            this.textScreenshotHotkey.Name = "textScreenshotHotkey";
            this.textScreenshotHotkey.ShortcutsEnabled = false;
            this.textScreenshotHotkey.Size = new System.Drawing.Size(106, 20);
            this.textScreenshotHotkey.TabIndex = 2;
            this.textScreenshotHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textHotkeys_KeyDown);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFolder.Image")));
            this.buttonOpenFolder.Location = new System.Drawing.Point(10, 10);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(106, 40);
            this.buttonOpenFolder.TabIndex = 1;
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
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
            // textSnippetHotkey
            // 
            this.textSnippetHotkey.Enabled = false;
            this.textSnippetHotkey.Location = new System.Drawing.Point(10, 110);
            this.textSnippetHotkey.MaxLength = 255;
            this.textSnippetHotkey.Name = "textSnippetHotkey";
            this.textSnippetHotkey.ShortcutsEnabled = false;
            this.textSnippetHotkey.Size = new System.Drawing.Size(106, 20);
            this.textSnippetHotkey.TabIndex = 4;
            this.textSnippetHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textHotkeys_KeyDown);
            // 
            // labelHotkeySnippet
            // 
            this.labelHotkeySnippet.AutoSize = true;
            this.labelHotkeySnippet.Location = new System.Drawing.Point(10, 94);
            this.labelHotkeySnippet.Name = "labelHotkeySnippet";
            this.labelHotkeySnippet.Size = new System.Drawing.Size(78, 13);
            this.labelHotkeySnippet.TabIndex = 7;
            this.labelHotkeySnippet.Text = "Snippet hotkey";
            // 
            // buttonEditScreenshotHotkey
            // 
            this.buttonEditScreenshotHotkey.Location = new System.Drawing.Point(122, 71);
            this.buttonEditScreenshotHotkey.Name = "buttonEditScreenshotHotkey";
            this.buttonEditScreenshotHotkey.Size = new System.Drawing.Size(60, 20);
            this.buttonEditScreenshotHotkey.TabIndex = 3;
            this.buttonEditScreenshotHotkey.Text = "Edit";
            this.buttonEditScreenshotHotkey.UseVisualStyleBackColor = true;
            this.buttonEditScreenshotHotkey.Click += new System.EventHandler(this.buttonEditScreenshotHotkey_Click);
            // 
            // buttonEditSnippetHotkey
            // 
            this.buttonEditSnippetHotkey.Location = new System.Drawing.Point(122, 110);
            this.buttonEditSnippetHotkey.Name = "buttonEditSnippetHotkey";
            this.buttonEditSnippetHotkey.Size = new System.Drawing.Size(60, 20);
            this.buttonEditSnippetHotkey.TabIndex = 5;
            this.buttonEditSnippetHotkey.Text = "Edit";
            this.buttonEditSnippetHotkey.UseVisualStyleBackColor = true;
            this.buttonEditSnippetHotkey.Click += new System.EventHandler(this.buttonEditSnippetHotkey_Click);
            // 
            // buttonSaveScreenshotHotkey
            // 
            this.buttonSaveScreenshotHotkey.Location = new System.Drawing.Point(122, 71);
            this.buttonSaveScreenshotHotkey.Name = "buttonSaveScreenshotHotkey";
            this.buttonSaveScreenshotHotkey.Size = new System.Drawing.Size(60, 20);
            this.buttonSaveScreenshotHotkey.TabIndex = 8;
            this.buttonSaveScreenshotHotkey.Text = "Save";
            this.buttonSaveScreenshotHotkey.UseVisualStyleBackColor = true;
            this.buttonSaveScreenshotHotkey.Visible = false;
            this.buttonSaveScreenshotHotkey.Click += new System.EventHandler(this.buttonSaveScreenshotHotkey_Click);
            // 
            // buttonSaveSnippetHotkey
            // 
            this.buttonSaveSnippetHotkey.Location = new System.Drawing.Point(122, 110);
            this.buttonSaveSnippetHotkey.Name = "buttonSaveSnippetHotkey";
            this.buttonSaveSnippetHotkey.Size = new System.Drawing.Size(60, 20);
            this.buttonSaveSnippetHotkey.TabIndex = 9;
            this.buttonSaveSnippetHotkey.Text = "Save";
            this.buttonSaveSnippetHotkey.UseVisualStyleBackColor = true;
            this.buttonSaveSnippetHotkey.Visible = false;
            this.buttonSaveSnippetHotkey.Click += new System.EventHandler(this.buttonSaveSnippetHotkey_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(122, 10);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(60, 40);
            this.buttonSettings.TabIndex = 10;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // toolTipHotkey
            // 
            this.toolTipHotkey.AutoPopDelay = 5000;
            this.toolTipHotkey.InitialDelay = 100;
            this.toolTipHotkey.ReshowDelay = 100;
            // 
            // CaptureSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 141);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSaveSnippetHotkey);
            this.Controls.Add(this.buttonSaveScreenshotHotkey);
            this.Controls.Add(this.buttonEditSnippetHotkey);
            this.Controls.Add(this.buttonEditScreenshotHotkey);
            this.Controls.Add(this.textSnippetHotkey);
            this.Controls.Add(this.labelHotkeySnippet);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.textScreenshotHotkey);
            this.Controls.Add(this.labelHotkeyAllScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CaptureSave";
            this.Text = "CaptureSave";
            this.Resize += new System.EventHandler(this.CaptureSave_Resize);
            this.contextMenuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHotkeyAllScreen;
        private System.Windows.Forms.TextBox textScreenshotHotkey;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.TextBox textSnippetHotkey;
        private System.Windows.Forms.Label labelHotkeySnippet;
        private System.Windows.Forms.Button buttonEditScreenshotHotkey;
        private System.Windows.Forms.Button buttonEditSnippetHotkey;
        private System.Windows.Forms.Button buttonSaveScreenshotHotkey;
        private System.Windows.Forms.Button buttonSaveSnippetHotkey;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ToolTip toolTipHotkey;
    }
}

