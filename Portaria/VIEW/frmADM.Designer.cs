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
            this.components = new System.ComponentModel.Container();
            this.panADM = new System.Windows.Forms.Panel();
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.fadeInEffectADM = new System.Windows.Forms.Timer(this.components);
            this.panSideBar = new System.Windows.Forms.Panel();
            this.panActionBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbWindowMini = new System.Windows.Forms.PictureBox();
            this.ptbMaxRestore = new System.Windows.Forms.PictureBox();
            this.ptbWindowClose = new System.Windows.Forms.PictureBox();
            this.panADM.SuspendLayout();
            this.panTitleBar.SuspendLayout();
            this.panSideBar.SuspendLayout();
            this.panActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panADM
            // 
            this.panADM.BackColor = System.Drawing.Color.White;
            this.panADM.Controls.Add(this.panSideBar);
            this.panADM.Controls.Add(this.panActionBar);
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
            this.panTitleBar.Controls.Add(this.lblTitle);
            this.panTitleBar.Controls.Add(this.ptbWindowClose);
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(927, 35);
            this.panTitleBar.TabIndex = 1;
            this.panTitleBar.DoubleClick += new System.EventHandler(this.panTitleBar_DoubleClick);
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.panTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(388, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Administrador";
            this.lblTitle.DoubleClick += new System.EventHandler(this.panTitleBar_DoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // fadeInEffectADM
            // 
            this.fadeInEffectADM.Interval = 1;
            this.fadeInEffectADM.Tick += new System.EventHandler(this.fadeEffectADM_Tick);
            // 
            // panSideBar
            // 
            this.panSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panSideBar.Controls.Add(this.label2);
            this.panSideBar.Controls.Add(this.label1);
            this.panSideBar.Controls.Add(this.lblUsuarios);
            this.panSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSideBar.Location = new System.Drawing.Point(0, 105);
            this.panSideBar.Name = "panSideBar";
            this.panSideBar.Size = new System.Drawing.Size(250, 436);
            this.panSideBar.TabIndex = 2;
            // 
            // panActionBar
            // 
            this.panActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panActionBar.Controls.Add(this.pictureBox1);
            this.panActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panActionBar.Location = new System.Drawing.Point(0, 35);
            this.panActionBar.Name = "panActionBar";
            this.panActionBar.Size = new System.Drawing.Size(927, 70);
            this.panActionBar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Portaria.Properties.Resources.glassdoor;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 120);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(250, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portarias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Portaria.Properties.Resources.google_circles_communities;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 60);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(250, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Associações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuarios.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Image = global::Portaria.Properties.Resources.ic_group_white_36dp;
            this.lblUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblUsuarios.Size = new System.Drawing.Size(250, 60);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Usuários";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Portaria.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptbWindowMini
            // 
            this.ptbWindowMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbWindowMini.Image = global::Portaria.Properties.Resources.window_minimize;
            this.ptbWindowMini.Location = new System.Drawing.Point(831, 5);
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
            this.ptbMaxRestore.Location = new System.Drawing.Point(861, 5);
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
            this.ptbWindowClose.Location = new System.Drawing.Point(891, 5);
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
            this.Load += new System.EventHandler(this.frmADM_Load);
            this.panADM.ResumeLayout(false);
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            this.panSideBar.ResumeLayout(false);
            this.panActionBar.ResumeLayout(false);
            this.panActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbWindowClose;
        private System.Windows.Forms.Panel panADM;
        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox ptbMaxRestore;
        private System.Windows.Forms.PictureBox ptbWindowMini;
        private System.Windows.Forms.Timer fadeInEffectADM;
        private System.Windows.Forms.Panel panSideBar;
        private System.Windows.Forms.Panel panActionBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}