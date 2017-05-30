namespace Portaria
{
    partial class frmVisitantes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.pctCloseWindow = new System.Windows.Forms.PictureBox();
            this.lblAssociações = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblPortarias = new System.Windows.Forms.Label();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.lblMembros = new System.Windows.Forms.Label();
            this.panelAssociaçoes = new System.Windows.Forms.Panel();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.panTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCloseWindow)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(190)))), ((int)(((byte)(96)))));
            this.panTitleBar.Controls.Add(this.pctCloseWindow);
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(667, 29);
            this.panTitleBar.TabIndex = 0;
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.panTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // pctCloseWindow
            // 
            this.pctCloseWindow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pctCloseWindow.Image = global::Portaria.Properties.Resources.window_close;
            this.pctCloseWindow.Location = new System.Drawing.Point(631, 3);
            this.pctCloseWindow.Name = "pctCloseWindow";
            this.pctCloseWindow.Size = new System.Drawing.Size(24, 24);
            this.pctCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctCloseWindow.TabIndex = 1;
            this.pctCloseWindow.TabStop = false;
            this.pctCloseWindow.Click += new System.EventHandler(this.pctCloseWindow_Click);
            // 
            // lblAssociações
            // 
            this.lblAssociações.AutoSize = true;
            this.lblAssociações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAssociações.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociações.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAssociações.Location = new System.Drawing.Point(0, 57);
            this.lblAssociações.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblAssociações.Name = "lblAssociações";
            this.lblAssociações.Padding = new System.Windows.Forms.Padding(10);
            this.lblAssociações.Size = new System.Drawing.Size(150, 43);
            this.lblAssociações.TabIndex = 1;
            this.lblAssociações.Text = "Associações";
            this.lblAssociações.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(143)))));
            this.panelMenu.Controls.Add(this.lblPortarias);
            this.panelMenu.Controls.Add(this.lblRelatorios);
            this.panelMenu.Controls.Add(this.lblMembros);
            this.panelMenu.Controls.Add(this.lblAssociações);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 72);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 422);
            this.panelMenu.TabIndex = 2;
            // 
            // lblPortarias
            // 
            this.lblPortarias.AutoSize = true;
            this.lblPortarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPortarias.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortarias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPortarias.Location = new System.Drawing.Point(0, 163);
            this.lblPortarias.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblPortarias.Name = "lblPortarias";
            this.lblPortarias.Padding = new System.Windows.Forms.Padding(10);
            this.lblPortarias.Size = new System.Drawing.Size(150, 43);
            this.lblPortarias.TabIndex = 4;
            this.lblPortarias.Text = "Portarias";
            this.lblPortarias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.lblRelatorios.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRelatorios.Location = new System.Drawing.Point(21, 3);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Padding = new System.Windows.Forms.Padding(10);
            this.lblRelatorios.Size = new System.Drawing.Size(105, 43);
            this.lblRelatorios.TabIndex = 3;
            this.lblRelatorios.Text = "Relatorios";
            // 
            // lblMembros
            // 
            this.lblMembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembros.AutoSize = true;
            this.lblMembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMembros.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMembros.Location = new System.Drawing.Point(0, 110);
            this.lblMembros.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMembros.Name = "lblMembros";
            this.lblMembros.Padding = new System.Windows.Forms.Padding(10);
            this.lblMembros.Size = new System.Drawing.Size(150, 43);
            this.lblMembros.TabIndex = 2;
            this.lblMembros.Text = "Membros";
            this.lblMembros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAssociaçoes
            // 
            this.panelAssociaçoes.BackColor = System.Drawing.Color.White;
            this.panelAssociaçoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssociaçoes.Location = new System.Drawing.Point(0, 0);
            this.panelAssociaçoes.Name = "panelAssociaçoes";
            this.panelAssociaçoes.Size = new System.Drawing.Size(667, 494);
            this.panelAssociaçoes.TabIndex = 3;
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisa.Location = new System.Drawing.Point(0, 29);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(667, 43);
            this.panelPesquisa.TabIndex = 0;
            // 
            // frmVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 494);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.panTitleBar);
            this.Controls.Add(this.panelAssociaçoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisitantes";
            this.Text = "Form1";
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCloseWindow)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Label lblAssociações;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelAssociaçoes;
        private System.Windows.Forms.Label lblMembros;
        private System.Windows.Forms.Label lblPortarias;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.PictureBox pctCloseWindow;
    }
}

