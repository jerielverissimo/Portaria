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
            this.panSideBar = new System.Windows.Forms.Panel();
            this.lblPortarias = new System.Windows.Forms.Label();
            this.lblAssociacoes = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.panActionBar = new System.Windows.Forms.Panel();
            this.ptbSideMenu = new System.Windows.Forms.PictureBox();
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.ptbWindowMini = new System.Windows.Forms.PictureBox();
            this.ptbMaxRestore = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptbWindowClose = new System.Windows.Forms.PictureBox();
            this.fadeInEffectADM = new System.Windows.Forms.Timer(this.components);
            this.panUsers = new System.Windows.Forms.Panel();
            this.lblNomeUsr = new System.Windows.Forms.Label();
            this.txtNomeUsr = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.mskTelUsr = new System.Windows.Forms.MaskedTextBox();
            this.lblTelUsr = new System.Windows.Forms.Label();
            this.mskDataCria = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCria = new System.Windows.Forms.Label();
            this.gboxTipoUsr = new System.Windows.Forms.GroupBox();
            this.rdbTipoExt = new System.Windows.Forms.RadioButton();
            this.rdbTipoServ = new System.Windows.Forms.RadioButton();
            this.rdbTipoAlluno = new System.Windows.Forms.RadioButton();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEsp = new System.Windows.Forms.Label();
            this.cboxEsp = new System.Windows.Forms.ComboBox();
            this.lblAddEsp = new System.Windows.Forms.Label();
            this.lblProntUsr = new System.Windows.Forms.Label();
            this.mskProntAlun = new System.Windows.Forms.MaskedTextBox();
            this.ckbADM = new System.Windows.Forms.CheckBox();
            this.txtSenhaADM = new System.Windows.Forms.TextBox();
            this.lblSenhaADM = new System.Windows.Forms.Label();
            this.lblCadUser = new System.Windows.Forms.Label();
            this.mskSIAPE = new System.Windows.Forms.MaskedTextBox();
            this.lblSIAPE = new System.Windows.Forms.Label();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.panADM.SuspendLayout();
            this.panSideBar.SuspendLayout();
            this.panActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSideMenu)).BeginInit();
            this.panTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowClose)).BeginInit();
            this.panUsers.SuspendLayout();
            this.gboxTipoUsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panADM
            // 
            this.panADM.BackColor = System.Drawing.Color.White;
            this.panADM.Controls.Add(this.panUsers);
            this.panADM.Controls.Add(this.panSideBar);
            this.panADM.Controls.Add(this.panActionBar);
            this.panADM.Controls.Add(this.panTitleBar);
            this.panADM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panADM.Location = new System.Drawing.Point(0, 0);
            this.panADM.Name = "panADM";
            this.panADM.Size = new System.Drawing.Size(950, 650);
            this.panADM.TabIndex = 1;
            // 
            // panSideBar
            // 
            this.panSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panSideBar.Controls.Add(this.lblPortarias);
            this.panSideBar.Controls.Add(this.lblAssociacoes);
            this.panSideBar.Controls.Add(this.lblUsuarios);
            this.panSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSideBar.Location = new System.Drawing.Point(0, 105);
            this.panSideBar.Name = "panSideBar";
            this.panSideBar.Size = new System.Drawing.Size(250, 545);
            this.panSideBar.TabIndex = 2;
            // 
            // lblPortarias
            // 
            this.lblPortarias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPortarias.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortarias.ForeColor = System.Drawing.Color.White;
            this.lblPortarias.Image = global::Portaria.Properties.Resources.glassdoor;
            this.lblPortarias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPortarias.Location = new System.Drawing.Point(0, 120);
            this.lblPortarias.Name = "lblPortarias";
            this.lblPortarias.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblPortarias.Size = new System.Drawing.Size(250, 60);
            this.lblPortarias.TabIndex = 2;
            this.lblPortarias.Text = "Portarias";
            this.lblPortarias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssociacoes
            // 
            this.lblAssociacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssociacoes.Font = new System.Drawing.Font("Noto Sans UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociacoes.ForeColor = System.Drawing.Color.White;
            this.lblAssociacoes.Image = global::Portaria.Properties.Resources.google_circles_communities;
            this.lblAssociacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAssociacoes.Location = new System.Drawing.Point(0, 60);
            this.lblAssociacoes.Name = "lblAssociacoes";
            this.lblAssociacoes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblAssociacoes.Size = new System.Drawing.Size(250, 60);
            this.lblAssociacoes.TabIndex = 1;
            this.lblAssociacoes.Text = "Associações";
            this.lblAssociacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panActionBar
            // 
            this.panActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panActionBar.Controls.Add(this.lblTitleForm);
            this.panActionBar.Controls.Add(this.ptbSideMenu);
            this.panActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panActionBar.Location = new System.Drawing.Point(0, 35);
            this.panActionBar.Name = "panActionBar";
            this.panActionBar.Size = new System.Drawing.Size(950, 70);
            this.panActionBar.TabIndex = 3;
            // 
            // ptbSideMenu
            // 
            this.ptbSideMenu.Image = global::Portaria.Properties.Resources.menu;
            this.ptbSideMenu.Location = new System.Drawing.Point(23, 21);
            this.ptbSideMenu.Name = "ptbSideMenu";
            this.ptbSideMenu.Size = new System.Drawing.Size(24, 24);
            this.ptbSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbSideMenu.TabIndex = 0;
            this.ptbSideMenu.TabStop = false;
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
            this.panTitleBar.Size = new System.Drawing.Size(950, 35);
            this.panTitleBar.TabIndex = 1;
            this.panTitleBar.DoubleClick += new System.EventHandler(this.panTitleBar_DoubleClick);
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.panTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // ptbWindowMini
            // 
            this.ptbWindowMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbWindowMini.Image = global::Portaria.Properties.Resources.window_minimize;
            this.ptbWindowMini.Location = new System.Drawing.Point(854, 5);
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
            this.ptbMaxRestore.Location = new System.Drawing.Point(884, 5);
            this.ptbMaxRestore.Name = "ptbMaxRestore";
            this.ptbMaxRestore.Size = new System.Drawing.Size(24, 24);
            this.ptbMaxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMaxRestore.TabIndex = 2;
            this.ptbMaxRestore.TabStop = false;
            this.ptbMaxRestore.Click += new System.EventHandler(this.ptbMaxRestore_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(400, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Administrador";
            this.lblTitle.DoubleClick += new System.EventHandler(this.panTitleBar_DoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // ptbWindowClose
            // 
            this.ptbWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbWindowClose.Image = global::Portaria.Properties.Resources.window_close;
            this.ptbWindowClose.Location = new System.Drawing.Point(914, 5);
            this.ptbWindowClose.Name = "ptbWindowClose";
            this.ptbWindowClose.Size = new System.Drawing.Size(24, 24);
            this.ptbWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbWindowClose.TabIndex = 0;
            this.ptbWindowClose.TabStop = false;
            this.ptbWindowClose.Click += new System.EventHandler(this.ptbWindowClose_Click);
            // 
            // fadeInEffectADM
            // 
            this.fadeInEffectADM.Interval = 1;
            this.fadeInEffectADM.Tick += new System.EventHandler(this.fadeEffectADM_Tick);
            // 
            // panUsers
            // 
            this.panUsers.Controls.Add(this.mskSIAPE);
            this.panUsers.Controls.Add(this.lblSIAPE);
            this.panUsers.Controls.Add(this.lblCadUser);
            this.panUsers.Controls.Add(this.txtSenhaADM);
            this.panUsers.Controls.Add(this.lblSenhaADM);
            this.panUsers.Controls.Add(this.ckbADM);
            this.panUsers.Controls.Add(this.mskProntAlun);
            this.panUsers.Controls.Add(this.lblProntUsr);
            this.panUsers.Controls.Add(this.lblAddEsp);
            this.panUsers.Controls.Add(this.cboxEsp);
            this.panUsers.Controls.Add(this.lblEsp);
            this.panUsers.Controls.Add(this.mskCPF);
            this.panUsers.Controls.Add(this.lblCPF);
            this.panUsers.Controls.Add(this.gboxTipoUsr);
            this.panUsers.Controls.Add(this.mskDataCria);
            this.panUsers.Controls.Add(this.lblDataCria);
            this.panUsers.Controls.Add(this.mskTelUsr);
            this.panUsers.Controls.Add(this.lblTelUsr);
            this.panUsers.Controls.Add(this.mskEmail);
            this.panUsers.Controls.Add(this.lblEmail);
            this.panUsers.Controls.Add(this.txtNomeUsr);
            this.panUsers.Controls.Add(this.lblNomeUsr);
            this.panUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panUsers.Location = new System.Drawing.Point(250, 105);
            this.panUsers.Name = "panUsers";
            this.panUsers.Size = new System.Drawing.Size(700, 545);
            this.panUsers.TabIndex = 4;
            // 
            // lblNomeUsr
            // 
            this.lblNomeUsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeUsr.AutoSize = true;
            this.lblNomeUsr.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsr.Location = new System.Drawing.Point(63, 38);
            this.lblNomeUsr.Name = "lblNomeUsr";
            this.lblNomeUsr.Size = new System.Drawing.Size(56, 22);
            this.lblNomeUsr.TabIndex = 0;
            this.lblNomeUsr.Text = "Nome";
            // 
            // txtNomeUsr
            // 
            this.txtNomeUsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeUsr.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsr.Location = new System.Drawing.Point(142, 35);
            this.txtNomeUsr.Name = "txtNomeUsr";
            this.txtNomeUsr.Size = new System.Drawing.Size(391, 29);
            this.txtNomeUsr.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(68, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // mskEmail
            // 
            this.mskEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskEmail.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskEmail.Location = new System.Drawing.Point(142, 84);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(391, 29);
            this.mskEmail.TabIndex = 3;
            // 
            // mskTelUsr
            // 
            this.mskTelUsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskTelUsr.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mskTelUsr.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelUsr.Location = new System.Drawing.Point(142, 133);
            this.mskTelUsr.Mask = "  (00) 0000-0000";
            this.mskTelUsr.Name = "mskTelUsr";
            this.mskTelUsr.PromptChar = ' ';
            this.mskTelUsr.Size = new System.Drawing.Size(135, 29);
            this.mskTelUsr.TabIndex = 5;
            // 
            // lblTelUsr
            // 
            this.lblTelUsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelUsr.AutoSize = true;
            this.lblTelUsr.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelUsr.Location = new System.Drawing.Point(44, 136);
            this.lblTelUsr.Name = "lblTelUsr";
            this.lblTelUsr.Size = new System.Drawing.Size(75, 22);
            this.lblTelUsr.TabIndex = 4;
            this.lblTelUsr.Text = "Telefone";
            // 
            // mskDataCria
            // 
            this.mskDataCria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskDataCria.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mskDataCria.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCria.Location = new System.Drawing.Point(142, 182);
            this.mskDataCria.Mask = "00/00/0000";
            this.mskDataCria.Name = "mskDataCria";
            this.mskDataCria.PromptChar = ' ';
            this.mskDataCria.Size = new System.Drawing.Size(135, 29);
            this.mskDataCria.TabIndex = 7;
            this.mskDataCria.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCria
            // 
            this.lblDataCria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataCria.AutoSize = true;
            this.lblDataCria.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCria.Location = new System.Drawing.Point(52, 185);
            this.lblDataCria.Name = "lblDataCria";
            this.lblDataCria.Size = new System.Drawing.Size(67, 22);
            this.lblDataCria.TabIndex = 6;
            this.lblDataCria.Text = "Criação";
            // 
            // gboxTipoUsr
            // 
            this.gboxTipoUsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboxTipoUsr.Controls.Add(this.rdbTipoAlluno);
            this.gboxTipoUsr.Controls.Add(this.rdbTipoServ);
            this.gboxTipoUsr.Controls.Add(this.rdbTipoExt);
            this.gboxTipoUsr.Location = new System.Drawing.Point(142, 276);
            this.gboxTipoUsr.Name = "gboxTipoUsr";
            this.gboxTipoUsr.Size = new System.Drawing.Size(391, 68);
            this.gboxTipoUsr.TabIndex = 8;
            this.gboxTipoUsr.TabStop = false;
            this.gboxTipoUsr.Text = "Tipo";
            // 
            // rdbTipoExt
            // 
            this.rdbTipoExt.AutoSize = true;
            this.rdbTipoExt.Location = new System.Drawing.Point(39, 32);
            this.rdbTipoExt.Name = "rdbTipoExt";
            this.rdbTipoExt.Size = new System.Drawing.Size(61, 17);
            this.rdbTipoExt.TabIndex = 0;
            this.rdbTipoExt.TabStop = true;
            this.rdbTipoExt.Text = "Externo";
            this.rdbTipoExt.UseVisualStyleBackColor = true;
            this.rdbTipoExt.CheckedChanged += new System.EventHandler(this.rdbTipoExt_CheckedChanged);
            // 
            // rdbTipoServ
            // 
            this.rdbTipoServ.AutoSize = true;
            this.rdbTipoServ.Location = new System.Drawing.Point(143, 32);
            this.rdbTipoServ.Name = "rdbTipoServ";
            this.rdbTipoServ.Size = new System.Drawing.Size(64, 17);
            this.rdbTipoServ.TabIndex = 1;
            this.rdbTipoServ.TabStop = true;
            this.rdbTipoServ.Text = "Servidor";
            this.rdbTipoServ.UseVisualStyleBackColor = true;
            this.rdbTipoServ.CheckedChanged += new System.EventHandler(this.rdbTipoServ_CheckedChanged);
            // 
            // rdbTipoAlluno
            // 
            this.rdbTipoAlluno.AutoSize = true;
            this.rdbTipoAlluno.Location = new System.Drawing.Point(265, 32);
            this.rdbTipoAlluno.Name = "rdbTipoAlluno";
            this.rdbTipoAlluno.Size = new System.Drawing.Size(52, 17);
            this.rdbTipoAlluno.TabIndex = 2;
            this.rdbTipoAlluno.TabStop = true;
            this.rdbTipoAlluno.Text = "Aluno";
            this.rdbTipoAlluno.UseVisualStyleBackColor = true;
            this.rdbTipoAlluno.CheckedChanged += new System.EventHandler(this.rdbTipoAlluno_CheckedChanged);
            // 
            // mskCPF
            // 
            this.mskCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskCPF.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mskCPF.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(142, 231);
            this.mskCPF.Mask = "0000000000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.PromptChar = ' ';
            this.mskCPF.Size = new System.Drawing.Size(135, 29);
            this.mskCPF.TabIndex = 10;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(81, 234);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 22);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF";
            // 
            // lblEsp
            // 
            this.lblEsp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEsp.AutoSize = true;
            this.lblEsp.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsp.Location = new System.Drawing.Point(357, 185);
            this.lblEsp.Name = "lblEsp";
            this.lblEsp.Size = new System.Drawing.Size(113, 22);
            this.lblEsp.TabIndex = 11;
            this.lblEsp.Text = "Especialidade";
            // 
            // cboxEsp
            // 
            this.cboxEsp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxEsp.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEsp.FormattingEnabled = true;
            this.cboxEsp.Location = new System.Drawing.Point(297, 230);
            this.cboxEsp.Name = "cboxEsp";
            this.cboxEsp.Size = new System.Drawing.Size(233, 30);
            this.cboxEsp.TabIndex = 12;
            // 
            // lblAddEsp
            // 
            this.lblAddEsp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddEsp.AutoSize = true;
            this.lblAddEsp.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAddEsp.Font = new System.Drawing.Font("Noto Sans UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEsp.ForeColor = System.Drawing.Color.White;
            this.lblAddEsp.Location = new System.Drawing.Point(549, 224);
            this.lblAddEsp.Name = "lblAddEsp";
            this.lblAddEsp.Padding = new System.Windows.Forms.Padding(10);
            this.lblAddEsp.Size = new System.Drawing.Size(39, 42);
            this.lblAddEsp.TabIndex = 13;
            this.lblAddEsp.Text = "+";
            // 
            // lblProntUsr
            // 
            this.lblProntUsr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProntUsr.AutoSize = true;
            this.lblProntUsr.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProntUsr.Location = new System.Drawing.Point(26, 374);
            this.lblProntUsr.Name = "lblProntUsr";
            this.lblProntUsr.Size = new System.Drawing.Size(93, 22);
            this.lblProntUsr.TabIndex = 14;
            this.lblProntUsr.Text = "Prontuário";
            // 
            // mskProntAlun
            // 
            this.mskProntAlun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskProntAlun.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mskProntAlun.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskProntAlun.Location = new System.Drawing.Point(142, 371);
            this.mskProntAlun.Mask = "000000-0";
            this.mskProntAlun.Name = "mskProntAlun";
            this.mskProntAlun.PromptChar = ' ';
            this.mskProntAlun.Size = new System.Drawing.Size(188, 29);
            this.mskProntAlun.TabIndex = 15;
            // 
            // ckbADM
            // 
            this.ckbADM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbADM.AutoSize = true;
            this.ckbADM.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbADM.Location = new System.Drawing.Point(464, 372);
            this.ckbADM.Name = "ckbADM";
            this.ckbADM.Size = new System.Drawing.Size(66, 26);
            this.ckbADM.TabIndex = 16;
            this.ckbADM.Text = "ADM";
            this.ckbADM.UseVisualStyleBackColor = true;
            // 
            // txtSenhaADM
            // 
            this.txtSenhaADM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaADM.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaADM.Location = new System.Drawing.Point(142, 421);
            this.txtSenhaADM.Name = "txtSenhaADM";
            this.txtSenhaADM.Size = new System.Drawing.Size(188, 29);
            this.txtSenhaADM.TabIndex = 18;
            // 
            // lblSenhaADM
            // 
            this.lblSenhaADM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenhaADM.AutoSize = true;
            this.lblSenhaADM.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaADM.Location = new System.Drawing.Point(62, 424);
            this.lblSenhaADM.Name = "lblSenhaADM";
            this.lblSenhaADM.Size = new System.Drawing.Size(57, 22);
            this.lblSenhaADM.TabIndex = 17;
            this.lblSenhaADM.Text = "Senha";
            // 
            // lblCadUser
            // 
            this.lblCadUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCadUser.AutoSize = true;
            this.lblCadUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCadUser.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadUser.ForeColor = System.Drawing.Color.White;
            this.lblCadUser.Location = new System.Drawing.Point(293, 485);
            this.lblCadUser.Name = "lblCadUser";
            this.lblCadUser.Padding = new System.Windows.Forms.Padding(10);
            this.lblCadUser.Size = new System.Drawing.Size(105, 42);
            this.lblCadUser.TabIndex = 19;
            this.lblCadUser.Text = "Cadastrar";
            // 
            // mskSIAPE
            // 
            this.mskSIAPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskSIAPE.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mskSIAPE.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSIAPE.Location = new System.Drawing.Point(142, 371);
            this.mskSIAPE.Mask = "000000-0";
            this.mskSIAPE.Name = "mskSIAPE";
            this.mskSIAPE.PromptChar = ' ';
            this.mskSIAPE.Size = new System.Drawing.Size(188, 29);
            this.mskSIAPE.TabIndex = 21;
            // 
            // lblSIAPE
            // 
            this.lblSIAPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSIAPE.AutoSize = true;
            this.lblSIAPE.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIAPE.Location = new System.Drawing.Point(66, 374);
            this.lblSIAPE.Name = "lblSIAPE";
            this.lblSIAPE.Size = new System.Drawing.Size(53, 22);
            this.lblSIAPE.TabIndex = 20;
            this.lblSIAPE.Text = "SIAPE";
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Noto Sans UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleForm.Location = new System.Drawing.Point(70, 19);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(223, 28);
            this.lblTitleForm.TabIndex = 1;
            this.lblTitleForm.Text = "Cadastro de Usuário";
            // 
            // frmADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panADM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmADM";
            this.Text = "frmADM";
            this.Load += new System.EventHandler(this.frmADM_Load);
            this.panADM.ResumeLayout(false);
            this.panSideBar.ResumeLayout(false);
            this.panActionBar.ResumeLayout(false);
            this.panActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSideMenu)).EndInit();
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWindowClose)).EndInit();
            this.panUsers.ResumeLayout(false);
            this.panUsers.PerformLayout();
            this.gboxTipoUsr.ResumeLayout(false);
            this.gboxTipoUsr.PerformLayout();
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
        private System.Windows.Forms.PictureBox ptbSideMenu;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblPortarias;
        private System.Windows.Forms.Label lblAssociacoes;
        private System.Windows.Forms.Panel panUsers;
        private System.Windows.Forms.TextBox txtNomeUsr;
        private System.Windows.Forms.Label lblNomeUsr;
        private System.Windows.Forms.MaskedTextBox mskTelUsr;
        private System.Windows.Forms.Label lblTelUsr;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskDataCria;
        private System.Windows.Forms.Label lblDataCria;
        private System.Windows.Forms.GroupBox gboxTipoUsr;
        private System.Windows.Forms.RadioButton rdbTipoAlluno;
        private System.Windows.Forms.RadioButton rdbTipoServ;
        private System.Windows.Forms.RadioButton rdbTipoExt;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblAddEsp;
        private System.Windows.Forms.ComboBox cboxEsp;
        private System.Windows.Forms.Label lblEsp;
        private System.Windows.Forms.TextBox txtSenhaADM;
        private System.Windows.Forms.Label lblSenhaADM;
        private System.Windows.Forms.CheckBox ckbADM;
        private System.Windows.Forms.MaskedTextBox mskProntAlun;
        private System.Windows.Forms.Label lblProntUsr;
        private System.Windows.Forms.Label lblCadUser;
        private System.Windows.Forms.MaskedTextBox mskSIAPE;
        private System.Windows.Forms.Label lblSIAPE;
        private System.Windows.Forms.Label lblTitleForm;
    }
}