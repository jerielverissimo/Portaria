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
            this.lblVisitantes = new System.Windows.Forms.Label();
            this.ptbVisitantes = new System.Windows.Forms.PictureBox();
            this.ptbMember = new System.Windows.Forms.PictureBox();
            this.pctCloseWindow = new System.Windows.Forms.PictureBox();
            this.panLoginMember = new System.Windows.Forms.Panel();
            this.lblEntrarMembro = new System.Windows.Forms.Label();
            this.lblPront = new System.Windows.Forms.Label();
            this.txtPront = new System.Windows.Forms.TextBox();
            this.TmLoginMembro = new System.Windows.Forms.Timer(this.components);
            this.lblADM = new System.Windows.Forms.Label();
            this.ptbADM = new System.Windows.Forms.PictureBox();
            this.TmLoginVisitantes = new System.Windows.Forms.Timer(this.components);
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCloseWindow)).BeginInit();
            this.panLoginMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbADM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembro
            // 
            this.lblMembro.AutoSize = true;
            this.lblMembro.Font = new System.Drawing.Font("Noto Sans UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembro.ForeColor = System.Drawing.Color.White;
            this.lblMembro.Location = new System.Drawing.Point(346, 240);
            this.lblMembro.Name = "lblMembro";
            this.lblMembro.Size = new System.Drawing.Size(76, 22);
            this.lblMembro.TabIndex = 2;
            this.lblMembro.Text = "Membro";
            // 
            // lblVisitantes
            // 
            this.lblVisitantes.AutoSize = true;
            this.lblVisitantes.Font = new System.Drawing.Font("Noto Sans UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitantes.ForeColor = System.Drawing.Color.White;
            this.lblVisitantes.Location = new System.Drawing.Point(206, 240);
            this.lblVisitantes.Name = "lblVisitantes";
            this.lblVisitantes.Size = new System.Drawing.Size(84, 22);
            this.lblVisitantes.TabIndex = 4;
            this.lblVisitantes.Text = "Visitantes";
            // 
            // ptbVisitantes
            // 
            this.ptbVisitantes.Image = global::Portaria.Properties.Resources.ic_people_white_36dp;
            this.ptbVisitantes.Location = new System.Drawing.Point(212, 155);
            this.ptbVisitantes.Name = "ptbVisitantes";
            this.ptbVisitantes.Size = new System.Drawing.Size(72, 72);
            this.ptbVisitantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbVisitantes.TabIndex = 3;
            this.ptbVisitantes.TabStop = false;
            this.ptbVisitantes.Click += new System.EventHandler(this.ptbVisitantes_Click);
            // 
            // ptbMember
            // 
            this.ptbMember.Image = global::Portaria.Properties.Resources.ic_person_white_36dp;
            this.ptbMember.Location = new System.Drawing.Point(350, 155);
            this.ptbMember.Name = "ptbMember";
            this.ptbMember.Size = new System.Drawing.Size(72, 72);
            this.ptbMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMember.TabIndex = 1;
            this.ptbMember.TabStop = false;
            this.ptbMember.Click += new System.EventHandler(this.ptbMember_Click);
            this.ptbMember.MouseEnter += new System.EventHandler(this.ptbMember_MouseEnter);
            this.ptbMember.MouseLeave += new System.EventHandler(this.ptbMember_MouseLeave);
            // 
            // pctCloseWindow
            // 
            this.pctCloseWindow.Image = global::Portaria.Properties.Resources.window_close;
            this.pctCloseWindow.Location = new System.Drawing.Point(452, 12);
            this.pctCloseWindow.Name = "pctCloseWindow";
            this.pctCloseWindow.Size = new System.Drawing.Size(24, 24);
            this.pctCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctCloseWindow.TabIndex = 0;
            this.pctCloseWindow.TabStop = false;
            this.pctCloseWindow.Click += new System.EventHandler(this.pctCloseWindow_Click);
            // 
            // panLoginMember
            // 
            this.panLoginMember.BackColor = System.Drawing.Color.White;
            this.panLoginMember.Controls.Add(this.lblEntrarMembro);
            this.panLoginMember.Controls.Add(this.lblPront);
            this.panLoginMember.Controls.Add(this.txtPront);
            this.panLoginMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLoginMember.Location = new System.Drawing.Point(0, 0);
            this.panLoginMember.Name = "panLoginMember";
            this.panLoginMember.Size = new System.Drawing.Size(0, 350);
            this.panLoginMember.TabIndex = 5;
            // 
            // lblEntrarMembro
            // 
            this.lblEntrarMembro.AutoSize = true;
            this.lblEntrarMembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEntrarMembro.Font = new System.Drawing.Font("Noto Sans UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrarMembro.ForeColor = System.Drawing.Color.White;
            this.lblEntrarMembro.Location = new System.Drawing.Point(86, 207);
            this.lblEntrarMembro.Name = "lblEntrarMembro";
            this.lblEntrarMembro.Padding = new System.Windows.Forms.Padding(10);
            this.lblEntrarMembro.Size = new System.Drawing.Size(78, 42);
            this.lblEntrarMembro.TabIndex = 2;
            this.lblEntrarMembro.Text = "Entrar";
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPront.ForeColor = System.Drawing.Color.DimGray;
            this.lblPront.Location = new System.Drawing.Point(68, 94);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(115, 26);
            this.lblPront.TabIndex = 1;
            this.lblPront.Text = "Prontuário";
            // 
            // txtPront
            // 
            this.txtPront.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPront.Location = new System.Drawing.Point(44, 140);
            this.txtPront.Name = "txtPront";
            this.txtPront.Size = new System.Drawing.Size(162, 29);
            this.txtPront.TabIndex = 0;
            // 
            // TmLoginMembro
            // 
            this.TmLoginMembro.Interval = 1;
            this.TmLoginMembro.Tick += new System.EventHandler(this.TmLoginMembro_Tick);
            // 
            // lblADM
            // 
            this.lblADM.AutoSize = true;
            this.lblADM.Font = new System.Drawing.Font("Noto Sans UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADM.ForeColor = System.Drawing.Color.White;
            this.lblADM.Location = new System.Drawing.Point(88, 240);
            this.lblADM.Name = "lblADM";
            this.lblADM.Size = new System.Drawing.Size(47, 22);
            this.lblADM.TabIndex = 7;
            this.lblADM.Text = "ADM";
            // 
            // ptbADM
            // 
            this.ptbADM.Image = global::Portaria.Properties.Resources.ic_people_white_36dp;
            this.ptbADM.Location = new System.Drawing.Point(75, 155);
            this.ptbADM.Name = "ptbADM";
            this.ptbADM.Size = new System.Drawing.Size(72, 72);
            this.ptbADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbADM.TabIndex = 6;
            this.ptbADM.TabStop = false;
            // 
            // TmLoginVisitantes
            // 
            this.TmLoginVisitantes.Interval = 1;
            this.TmLoginVisitantes.Tick += new System.EventHandler(this.TmLoginVisitantes_Tick);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Noto Sans UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(194, 66);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(108, 43);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.panLoginMember);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblADM);
            this.Controls.Add(this.ptbADM);
            this.Controls.Add(this.lblVisitantes);
            this.Controls.Add(this.ptbVisitantes);
            this.Controls.Add(this.lblMembro);
            this.Controls.Add(this.ptbMember);
            this.Controls.Add(this.pctCloseWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCloseWindow)).EndInit();
            this.panLoginMember.ResumeLayout(false);
            this.panLoginMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbADM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCloseWindow;
        private System.Windows.Forms.PictureBox ptbMember;
        private System.Windows.Forms.Label lblMembro;
        private System.Windows.Forms.Label lblVisitantes;
        private System.Windows.Forms.PictureBox ptbVisitantes;
        private System.Windows.Forms.Panel panLoginMember;
        private System.Windows.Forms.Label lblPront;
        private System.Windows.Forms.TextBox txtPront;
        private System.Windows.Forms.Timer TmLoginMembro;
        private System.Windows.Forms.Label lblEntrarMembro;
        private System.Windows.Forms.Label lblADM;
        private System.Windows.Forms.PictureBox ptbADM;
        private System.Windows.Forms.Timer TmLoginVisitantes;
        private System.Windows.Forms.Label lblLogin;
    }
}