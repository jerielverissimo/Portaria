namespace Portaria.VIEW
{
    partial class frmLogin
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
            this.lblMembro = new System.Windows.Forms.Label();
            this.lblADM = new System.Windows.Forms.Label();
            this.lblVisitantes = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panLogin = new System.Windows.Forms.Panel();
            this.panLoginMember = new System.Windows.Forms.Panel();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.lblEntrarMembro = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.panLoginADM = new System.Windows.Forms.Panel();
            this.lblEntrarADM = new System.Windows.Forms.Label();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSIAPE = new System.Windows.Forms.TextBox();
            this.lblSiape = new System.Windows.Forms.Label();
            this.pctCloseWindow = new System.Windows.Forms.PictureBox();
            this.ptbMember = new System.Windows.Forms.PictureBox();
            this.ptbADM = new System.Windows.Forms.PictureBox();
            this.ptbVisitantes = new System.Windows.Forms.PictureBox();
            this.tmLoginADM = new System.Windows.Forms.Timer(this.components);
            this.tmLoginMembro = new System.Windows.Forms.Timer(this.components);
            this.fadeOutEffect = new System.Windows.Forms.Timer(this.components);
            this.panLogin.SuspendLayout();
            this.panLoginMember.SuspendLayout();
            this.panLoginADM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembro
            // 
            this.lblMembro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMembro.AutoSize = true;
            this.lblMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembro.ForeColor = System.Drawing.Color.White;
            this.lblMembro.Location = new System.Drawing.Point(590, 350);
            this.lblMembro.Name = "lblMembro";
            this.lblMembro.Size = new System.Drawing.Size(67, 20);
            this.lblMembro.TabIndex = 2;
            this.lblMembro.Text = "Membro";
            // 
            // lblADM
            // 
            this.lblADM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblADM.AutoSize = true;
            this.lblADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADM.ForeColor = System.Drawing.Color.White;
            this.lblADM.Location = new System.Drawing.Point(428, 350);
            this.lblADM.Name = "lblADM";
            this.lblADM.Size = new System.Drawing.Size(45, 20);
            this.lblADM.TabIndex = 4;
            this.lblADM.Text = "ADM";
            // 
            // lblVisitantes
            // 
            this.lblVisitantes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVisitantes.AutoSize = true;
            this.lblVisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitantes.ForeColor = System.Drawing.Color.White;
            this.lblVisitantes.Location = new System.Drawing.Point(229, 350);
            this.lblVisitantes.Name = "lblVisitantes";
            this.lblVisitantes.Size = new System.Drawing.Size(79, 20);
            this.lblVisitantes.TabIndex = 7;
            this.lblVisitantes.Text = "Visitantes";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(396, 55);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(101, 37);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.panLoginMember);
            this.panLogin.Controls.Add(this.panLoginADM);
            this.panLogin.Controls.Add(this.pctCloseWindow);
            this.panLogin.Controls.Add(this.lblMembro);
            this.panLogin.Controls.Add(this.ptbMember);
            this.panLogin.Controls.Add(this.ptbADM);
            this.panLogin.Controls.Add(this.lblADM);
            this.panLogin.Controls.Add(this.ptbVisitantes);
            this.panLogin.Controls.Add(this.lblVisitantes);
            this.panLogin.Controls.Add(this.lblLogin);
            this.panLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLogin.Location = new System.Drawing.Point(0, 0);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(900, 550);
            this.panLogin.TabIndex = 9;
            this.panLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panLogin_MouseDown);
            this.panLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panLogin_MouseMove);
            // 
            // panLoginMember
            // 
            this.panLoginMember.BackColor = System.Drawing.Color.White;
            this.panLoginMember.Controls.Add(this.txtProntuario);
            this.panLoginMember.Controls.Add(this.lblEntrarMembro);
            this.panLoginMember.Controls.Add(this.lblProntuario);
            this.panLoginMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panLoginMember.Location = new System.Drawing.Point(0, 550);
            this.panLoginMember.Name = "panLoginMember";
            this.panLoginMember.Size = new System.Drawing.Size(900, 0);
            this.panLoginMember.TabIndex = 10;
            // 
            // txtProntuario
            // 
            this.txtProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProntuario.Location = new System.Drawing.Point(355, 106);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(191, 26);
            this.txtProntuario.TabIndex = 3;
            // 
            // lblEntrarMembro
            // 
            this.lblEntrarMembro.AutoSize = true;
            this.lblEntrarMembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEntrarMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrarMembro.ForeColor = System.Drawing.Color.White;
            this.lblEntrarMembro.Location = new System.Drawing.Point(411, 175);
            this.lblEntrarMembro.Name = "lblEntrarMembro";
            this.lblEntrarMembro.Padding = new System.Windows.Forms.Padding(10);
            this.lblEntrarMembro.Size = new System.Drawing.Size(73, 40);
            this.lblEntrarMembro.TabIndex = 2;
            this.lblEntrarMembro.Text = "Entrar";
            this.lblEntrarMembro.Click += new System.EventHandler(this.lblEntrarMembro_Click);
            this.lblEntrarMembro.MouseEnter += new System.EventHandler(this.lblEntrarMembro_MouseEnter);
            this.lblEntrarMembro.MouseLeave += new System.EventHandler(this.lblEntrarMembro_MouseLeave);
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProntuario.Location = new System.Drawing.Point(396, 53);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(96, 24);
            this.lblProntuario.TabIndex = 0;
            this.lblProntuario.Text = "Prontuário";
            // 
            // panLoginADM
            // 
            this.panLoginADM.BackColor = System.Drawing.Color.White;
            this.panLoginADM.Controls.Add(this.lblEntrarADM);
            this.panLoginADM.Controls.Add(this.mskSenha);
            this.panLoginADM.Controls.Add(this.lblSenha);
            this.panLoginADM.Controls.Add(this.txtSIAPE);
            this.panLoginADM.Controls.Add(this.lblSiape);
            this.panLoginADM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panLoginADM.Location = new System.Drawing.Point(0, 550);
            this.panLoginADM.Name = "panLoginADM";
            this.panLoginADM.Size = new System.Drawing.Size(900, 0);
            this.panLoginADM.TabIndex = 9;
            // 
            // lblEntrarADM
            // 
            this.lblEntrarADM.AutoSize = true;
            this.lblEntrarADM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEntrarADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrarADM.ForeColor = System.Drawing.Color.White;
            this.lblEntrarADM.Location = new System.Drawing.Point(411, 183);
            this.lblEntrarADM.Name = "lblEntrarADM";
            this.lblEntrarADM.Padding = new System.Windows.Forms.Padding(10);
            this.lblEntrarADM.Size = new System.Drawing.Size(73, 40);
            this.lblEntrarADM.TabIndex = 4;
            this.lblEntrarADM.Text = "Entrar";
            this.lblEntrarADM.Click += new System.EventHandler(this.lblEntrarADM_Click);
            this.lblEntrarADM.MouseEnter += new System.EventHandler(this.lblEntrarADM_MouseEnter);
            this.lblEntrarADM.MouseLeave += new System.EventHandler(this.lblEntrarADM_MouseLeave);
            // 
            // mskSenha
            // 
            this.mskSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenha.Location = new System.Drawing.Point(327, 121);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PromptChar = ' ';
            this.mskSenha.Size = new System.Drawing.Size(247, 26);
            this.mskSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(422, 88);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // txtSIAPE
            // 
            this.txtSIAPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSIAPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSIAPE.Location = new System.Drawing.Point(327, 51);
            this.txtSIAPE.Name = "txtSIAPE";
            this.txtSIAPE.Size = new System.Drawing.Size(247, 26);
            this.txtSIAPE.TabIndex = 1;
            // 
            // lblSiape
            // 
            this.lblSiape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSiape.AutoSize = true;
            this.lblSiape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiape.ForeColor = System.Drawing.Color.Black;
            this.lblSiape.Location = new System.Drawing.Point(424, 17);
            this.lblSiape.Name = "lblSiape";
            this.lblSiape.Size = new System.Drawing.Size(57, 20);
            this.lblSiape.TabIndex = 0;
            this.lblSiape.Text = "SIAPE";
            // 
            // pctCloseWindow
            // 
            this.pctCloseWindow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pctCloseWindow.Image = global::Portaria.Properties.Resources.window_close;
            this.pctCloseWindow.Location = new System.Drawing.Point(864, 12);
            this.pctCloseWindow.Name = "pctCloseWindow";
            this.pctCloseWindow.Size = new System.Drawing.Size(24, 24);
            this.pctCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctCloseWindow.TabIndex = 0;
            this.pctCloseWindow.TabStop = false;
            this.pctCloseWindow.Click += new System.EventHandler(this.pctCloseWindow_Click);
            // 
            // ptbMember
            // 
            this.ptbMember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ptbMember.Image = global::Portaria.Properties.Resources.ic_person_white_36dp;
            this.ptbMember.Location = new System.Drawing.Point(590, 250);
            this.ptbMember.Name = "ptbMember";
            this.ptbMember.Size = new System.Drawing.Size(72, 72);
            this.ptbMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMember.TabIndex = 1;
            this.ptbMember.TabStop = false;
            this.ptbMember.Click += new System.EventHandler(this.ptbMember_Click);
            this.ptbMember.MouseEnter += new System.EventHandler(this.ptbMember_MouseEnter);
            this.ptbMember.MouseLeave += new System.EventHandler(this.ptbMember_MouseLeave);
            // 
            // ptbADM
            // 
            this.ptbADM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ptbADM.Image = global::Portaria.Properties.Resources.ic_account_circle_white_36dp;
            this.ptbADM.Location = new System.Drawing.Point(410, 250);
            this.ptbADM.Name = "ptbADM";
            this.ptbADM.Padding = new System.Windows.Forms.Padding(5);
            this.ptbADM.Size = new System.Drawing.Size(82, 82);
            this.ptbADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbADM.TabIndex = 3;
            this.ptbADM.TabStop = false;
            this.ptbADM.Click += new System.EventHandler(this.ptbADM_Click);
            this.ptbADM.MouseEnter += new System.EventHandler(this.ptbADM_MouseEnter);
            this.ptbADM.MouseLeave += new System.EventHandler(this.ptbADM_MouseLeave);
            // 
            // ptbVisitantes
            // 
            this.ptbVisitantes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ptbVisitantes.Image = global::Portaria.Properties.Resources.ic_people_white_36dp;
            this.ptbVisitantes.Location = new System.Drawing.Point(230, 250);
            this.ptbVisitantes.Name = "ptbVisitantes";
            this.ptbVisitantes.Padding = new System.Windows.Forms.Padding(5);
            this.ptbVisitantes.Size = new System.Drawing.Size(82, 82);
            this.ptbVisitantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbVisitantes.TabIndex = 6;
            this.ptbVisitantes.TabStop = false;
            this.ptbVisitantes.Click += new System.EventHandler(this.ptbVisitantes_Click);
            this.ptbVisitantes.MouseEnter += new System.EventHandler(this.ptbVisitantes_MouseEnter);
            this.ptbVisitantes.MouseLeave += new System.EventHandler(this.ptbVisitantes_MouseLeave);
            // 
            // tmLoginADM
            // 
            this.tmLoginADM.Interval = 1;
            this.tmLoginADM.Tick += new System.EventHandler(this.tmLoginADM_Tick);
            // 
            // tmLoginMembro
            // 
            this.tmLoginMembro.Interval = 1;
            this.tmLoginMembro.Tick += new System.EventHandler(this.tmLoginMembro_Tick);
            // 
            // fadeOutEffect
            // 
            this.fadeOutEffect.Interval = 25;
            this.fadeOutEffect.Tick += new System.EventHandler(this.fadeOutEffect_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panLoginMember.ResumeLayout(false);
            this.panLoginMember.PerformLayout();
            this.panLoginADM.ResumeLayout(false);
            this.panLoginADM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisitantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCloseWindow;
        private System.Windows.Forms.PictureBox ptbMember;
        private System.Windows.Forms.Label lblMembro;
        private System.Windows.Forms.Label lblADM;
        private System.Windows.Forms.PictureBox ptbADM;
        private System.Windows.Forms.Label lblVisitantes;
        private System.Windows.Forms.PictureBox ptbVisitantes;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panLoginADM;
        private System.Windows.Forms.TextBox txtSIAPE;
        private System.Windows.Forms.Label lblSiape;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEntrarADM;
        private System.Windows.Forms.Timer tmLoginADM;
        private System.Windows.Forms.Timer tmLoginMembro;
        private System.Windows.Forms.Panel panLoginMember;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label lblEntrarMembro;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.Timer fadeOutEffect;
    }
}