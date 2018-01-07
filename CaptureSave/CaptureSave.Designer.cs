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
            this.labelScreenResolution = new System.Windows.Forms.Label();
            this.textScreenWidth = new System.Windows.Forms.TextBox();
            this.textScreenHeight = new System.Windows.Forms.TextBox();
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
            // CaptureSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.textScreenHeight);
            this.Controls.Add(this.textScreenWidth);
            this.Controls.Add(this.labelScreenResolution);
            this.MaximizeBox = false;
            this.Name = "CaptureSave";
            this.Text = "CaptureSave";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureSave_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScreenResolution;
        private System.Windows.Forms.TextBox textScreenWidth;
        private System.Windows.Forms.TextBox textScreenHeight;
    }
}

