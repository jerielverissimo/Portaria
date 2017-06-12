namespace Portaria.UI.FORMS
{
    partial class frmUsuarios
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
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panCenter = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbExteron = new System.Windows.Forms.RadioButton();
            this.rdbServidor = new System.Windows.Forms.RadioButton();
            this.rdbAluno = new System.Windows.Forms.RadioButton();
            this.panTitleBar.SuspendLayout();
            this.panCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panTitleBar.Controls.Add(this.lblTitle);
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(975, 35);
            this.panTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(447, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Usuários";
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.gpbFiltro);
            this.panCenter.Controls.Add(this.lblCancelar);
            this.panCenter.Controls.Add(this.lblAdd);
            this.panCenter.Controls.Add(this.dgvUsuarios);
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.ForeColor = System.Drawing.Color.DimGray;
            this.panCenter.Location = new System.Drawing.Point(0, 35);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(975, 515);
            this.panCenter.TabIndex = 1;
            // 
            // lblCancelar
            // 
            this.lblCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Tomato;
            this.lblCancelar.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(686, 432);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Padding = new System.Windows.Forms.Padding(10);
            this.lblCancelar.Size = new System.Drawing.Size(100, 42);
            this.lblCancelar.TabIndex = 2;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.lblAdd.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(802, 432);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Padding = new System.Windows.Forms.Padding(10);
            this.lblAdd.Size = new System.Drawing.Size(102, 42);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "Adcionar";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.Color.White;
            this.dgvUsuarios.Location = new System.Drawing.Point(66, 33);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsuarios.Size = new System.Drawing.Size(838, 370);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbFiltro.Controls.Add(this.rdbAluno);
            this.gpbFiltro.Controls.Add(this.rdbServidor);
            this.gpbFiltro.Controls.Add(this.rdbExteron);
            this.gpbFiltro.Location = new System.Drawing.Point(66, 415);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(417, 77);
            this.gpbFiltro.TabIndex = 3;
            this.gpbFiltro.TabStop = false;
            // 
            // rdbExteron
            // 
            this.rdbExteron.AutoSize = true;
            this.rdbExteron.Checked = true;
            this.rdbExteron.Location = new System.Drawing.Point(49, 33);
            this.rdbExteron.Name = "rdbExteron";
            this.rdbExteron.Size = new System.Drawing.Size(87, 26);
            this.rdbExteron.TabIndex = 0;
            this.rdbExteron.TabStop = true;
            this.rdbExteron.Text = "Externo";
            this.rdbExteron.UseVisualStyleBackColor = true;
            this.rdbExteron.CheckedChanged += new System.EventHandler(this.rdbExteron_CheckedChanged);
            // 
            // rdbServidor
            // 
            this.rdbServidor.AutoSize = true;
            this.rdbServidor.Location = new System.Drawing.Point(166, 33);
            this.rdbServidor.Name = "rdbServidor";
            this.rdbServidor.Size = new System.Drawing.Size(92, 26);
            this.rdbServidor.TabIndex = 1;
            this.rdbServidor.TabStop = true;
            this.rdbServidor.Text = "Servidor";
            this.rdbServidor.UseVisualStyleBackColor = true;
            // 
            // rdbAluno
            // 
            this.rdbAluno.AutoSize = true;
            this.rdbAluno.Location = new System.Drawing.Point(288, 33);
            this.rdbAluno.Name = "rdbAluno";
            this.rdbAluno.Size = new System.Drawing.Size(72, 26);
            this.rdbAluno.TabIndex = 2;
            this.rdbAluno.TabStop = true;
            this.rdbAluno.Text = "Aluno";
            this.rdbAluno.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 550);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panTitleBar);
            this.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            this.panCenter.ResumeLayout(false);
            this.panCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.RadioButton rdbAluno;
        private System.Windows.Forms.RadioButton rdbServidor;
        private System.Windows.Forms.RadioButton rdbExteron;
    }
}