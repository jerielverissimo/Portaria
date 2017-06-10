namespace Portaria.UI.FORMS
{
    partial class frmEspecialidades
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
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panCenter = new System.Windows.Forms.Panel();
            this.lblNotify = new System.Windows.Forms.Label();
            this.panNotify = new System.Windows.Forms.Panel();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.ptbNotify = new System.Windows.Forms.PictureBox();
            this.panTitleBar.SuspendLayout();
            this.panCenter.SuspendLayout();
            this.panNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panTitleBar.Controls.Add(this.lblTitle);
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(426, 35);
            this.panTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(101, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 22);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Cadastro de Especialidades";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Tomato;
            this.lblCancelar.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(100, 144);
            this.lblCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Padding = new System.Windows.Forms.Padding(10);
            this.lblCancelar.Size = new System.Drawing.Size(100, 42);
            this.lblCancelar.TabIndex = 1;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCadastrar.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadastrar.Location = new System.Drawing.Point(226, 144);
            this.lblCadastrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Padding = new System.Windows.Forms.Padding(10);
            this.lblCadastrar.Size = new System.Drawing.Size(109, 42);
            this.lblCadastrar.TabIndex = 2;
            this.lblCadastrar.Text = "Cadastrar";
            this.lblCadastrar.Click += new System.EventHandler(this.lblCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 22);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 29);
            this.txtNome.TabIndex = 4;
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.panNotify);
            this.panCenter.Controls.Add(this.lblCancelar);
            this.panCenter.Controls.Add(this.lblCadastrar);
            this.panCenter.Controls.Add(this.lblNome);
            this.panCenter.Controls.Add(this.txtNome);
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(0, 35);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(426, 215);
            this.panCenter.TabIndex = 5;
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(58, 5);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(323, 22);
            this.lblNotify.TabIndex = 5;
            this.lblNotify.Text = "Especialidade Cadastrada com sucesso!";
            // 
            // panNotify
            // 
            this.panNotify.BackColor = System.Drawing.Color.SpringGreen;
            this.panNotify.Controls.Add(this.ptbNotify);
            this.panNotify.Controls.Add(this.lblNotify);
            this.panNotify.Location = new System.Drawing.Point(113, 0);
            this.panNotify.Name = "panNotify";
            this.panNotify.Size = new System.Drawing.Size(0, 32);
            this.panNotify.TabIndex = 6;
            // 
            // tmNotify
            // 
            this.tmNotify.Interval = 1;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // ptbNotify
            // 
            this.ptbNotify.Image = global::Portaria.Properties.Resources.alert;
            this.ptbNotify.Location = new System.Drawing.Point(378, -2);
            this.ptbNotify.Name = "ptbNotify";
            this.ptbNotify.Size = new System.Drawing.Size(24, 24);
            this.ptbNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbNotify.TabIndex = 6;
            this.ptbNotify.TabStop = false;
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 250);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panTitleBar);
            this.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEspecialidades";
            this.Load += new System.EventHandler(this.frmEspecialidades_Load);
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            this.panCenter.ResumeLayout(false);
            this.panCenter.PerformLayout();
            this.panNotify.ResumeLayout(false);
            this.panNotify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Panel panNotify;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.PictureBox ptbNotify;
    }
}