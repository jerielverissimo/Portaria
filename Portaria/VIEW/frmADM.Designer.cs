namespace Portaria.VIEW
{
    partial class frmADM
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
            this.panADM = new System.Windows.Forms.Panel();
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbWindowMini = new System.Windows.Forms.PictureBox();
            this.ptbMaxRestore = new System.Windows.Forms.PictureBox();
            this.ptbWindowClose = new System.Windows.Forms.PictureBox();
            this.panADM.SuspendLayout();
            this.panTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panADM
            // 
            this.panADM.Controls.Add(this.panTitleBar);
            this.panADM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panADM.Location = new System.Drawing.Point(0, 0);
            this.panADM.Name = "panADM";
            this.panADM.Size = new System.Drawing.Size(927, 541);
            this.panADM.TabIndex = 1;
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panTitleBar.Controls.Add(this.ptbWindowMini);
            this.panTitleBar.Controls.Add(this.ptbMaxRestore);
            this.panTitleBar.Controls.Add(this.label1);
            this.panTitleBar.Controls.Add(this.ptbWindowClose);
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(927, 40);
            this.panTitleBar.TabIndex = 1;
            this.panTitleBar.DoubleClick += new System.EventHandler(this.panTitleBar_DoubleClick);
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.panTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            this.label1.DoubleClick += new System.EventHandler(this.panTitleBar_DoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // ptbWindowMini
            // 
            this.ptbWindowMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbWindowMini.Image = global::Portaria.Properties.Resources.window_minimize;
            this.ptbWindowMini.Location = new System.Drawing.Point(831, 8);
            this.ptbWindowMini.Name = "ptbWindowMini";
            this.ptbWindowMini.Size = new System.Drawing.Size(24, 24);
            this.ptbWindowMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbWindowMini.TabIndex = 3;
            this.ptbWindowMini.TabStop = false;
            this.ptbWindowMini.Click += new System.EventHandler(this.ptbWindowMini_Click);
            // 
            // ptbMaxRestore
            // 
            this.ptbMaxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaxRestore.Image = global::Portaria.Properties.Resources.window_restore;
            this.ptbMaxRestore.Location = new System.Drawing.Point(861, 8);
            this.ptbMaxRestore.Name = "ptbMaxRestore";
            this.ptbMaxRestore.Size = new System.Drawing.Size(24, 24);
            this.ptbMaxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMaxRestore.TabIndex = 2;
            this.ptbMaxRestore.TabStop = false;
            this.ptbMaxRestore.Click += new System.EventHandler(this.ptbMaxRestore_Click);
            // 
            // ptbWindowClose
            // 
            this.ptbWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbWindowClose.Image = global::Portaria.Properties.Resources.window_close;
            this.ptbWindowClose.Location = new System.Drawing.Point(891, 8);
            this.ptbWindowClose.Name = "ptbWindowClose";
            this.ptbWindowClose.Size = new System.Drawing.Size(24, 24);
            this.ptbWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbWindowClose.TabIndex = 0;
            this.ptbWindowClose.TabStop = false;
            this.ptbWindowClose.Click += new System.EventHandler(this.ptbWindowClose_Click);
            // 
            // frmADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 541);
            this.Controls.Add(this.panADM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmADM";
            this.Text = "frmADM";
            this.panADM.ResumeLayout(false);
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbWindowClose;
        private System.Windows.Forms.Panel panADM;
        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbMaxRestore;
        private System.Windows.Forms.PictureBox ptbWindowMini;
    }
}