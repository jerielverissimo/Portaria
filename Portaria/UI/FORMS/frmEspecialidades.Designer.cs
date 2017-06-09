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
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(426, 35);
            this.panTitleBar.TabIndex = 0;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Tomato;
            this.lblCancelar.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(170, 382);
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
            this.lblCadastrar.Location = new System.Drawing.Point(298, 382);
            this.lblCadastrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Padding = new System.Windows.Forms.Padding(10);
            this.lblCadastrar.Size = new System.Drawing.Size(109, 42);
            this.lblCadastrar.TabIndex = 2;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.panTitleBar);
            this.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEspecialidades";
            this.Text = "frmEspecialidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label label1;
    }
}