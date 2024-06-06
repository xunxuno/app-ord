namespace ProyectoSegundoParcial
{
    partial class principalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDelPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarPrepagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.planesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesión";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDelPlanToolStripMenuItem,
            this.comprarPrepagoToolStripMenuItem});
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.planesToolStripMenuItem.Text = "Planes";
            // 
            // informacionDelPlanToolStripMenuItem
            // 
            this.informacionDelPlanToolStripMenuItem.Name = "informacionDelPlanToolStripMenuItem";
            this.informacionDelPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacionDelPlanToolStripMenuItem.Text = "Información del plan";
            this.informacionDelPlanToolStripMenuItem.Click += new System.EventHandler(this.informacionDelPlanToolStripMenuItem_Click);
            // 
            // comprarPrepagoToolStripMenuItem
            // 
            this.comprarPrepagoToolStripMenuItem.Name = "comprarPrepagoToolStripMenuItem";
            this.comprarPrepagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprarPrepagoToolStripMenuItem.Text = "Comprar prepago";
            this.comprarPrepagoToolStripMenuItem.Click += new System.EventHandler(this.comprarPrepagoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gestión de Planes de Internet Móvil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDelPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarPrepagoToolStripMenuItem;
    }
}

#region Código generado por el Diseñador de Windows Forms

/// <summary>
/// Método necesario para admitir el Diseñador. No se puede modificar
/// el contenido de este método con el editor de código.
/// </summary>
private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principalForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.userNameTLabel = new System.Windows.Forms.Label();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.marcaPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.cerrarSesionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cerrarSesionPictureBox = new System.Windows.Forms.PictureBox();
            this.servicioLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pagosLinkLabel = new System.Windows.Forms.LinkLabel();
            this.billeteraIconPictureBox = new System.Windows.Forms.PictureBox();
            this.wifiIconPictureBox = new System.Windows.Forms.PictureBox();
            this.miCuentaPanel = new System.Windows.Forms.Panel();
            this.miCuentaTLabel = new System.Windows.Forms.Label();
            this.ServiciosPanel = new System.Windows.Forms.Panel();
            this.servicioTLabel = new System.Windows.Forms.Label();
            this.dataUsuarioPanel = new System.Windows.Forms.Panel();
            this.userPhoneLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIconPictureBox = new System.Windows.Forms.PictureBox();
            this.planTLabel = new System.Windows.Forms.Label();
            this.ultCompTLabel = new System.Windows.Forms.Label();
            this.planesContratadosComboBox = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lineaDiviPanel = new System.Windows.Forms.Panel();
            this.vencimientoTLabel = new System.Windows.Forms.Label();
            this.fechaVenRecargaLabel = new System.Windows.Forms.Label();
            this.misConsumosTLabel = new System.Windows.Forms.Label();
            this.gbsTotalesPanel = new System.Windows.Forms.Panel();
            this.gbsTLabel = new System.Windows.Forms.Label();
            this.gbsNumLabel = new System.Windows.Forms.Label();
            this.gbsUtilizadosPanel = new System.Windows.Forms.Panel();
            this.gbsUTLabel = new System.Windows.Forms.Label();
            this.gbsNumULabel = new System.Windows.Forms.Label();
            this.diasRestantesPanel = new System.Windows.Forms.Panel();
            this.diasRestantesTLabel = new System.Windows.Forms.Label();
            this.diasRestNumLabel = new System.Windows.Forms.Label();
            this.redesSocialesPanel = new System.Windows.Forms.Panel();
            this.gbsRedesSTLabel = new System.Windows.Forms.Label();
            this.gbsNumRedesSocialesLabel = new System.Windows.Forms.Label();
            this.miRecargaPanel = new System.Windows.Forms.Panel();
            this.separadorPanel1 = new System.Windows.Forms.Panel();
            this.comprarOfertPrepButton = new System.Windows.Forms.Button();
            this.fechaVenLabel = new System.Windows.Forms.Label();
            this.ofertaApliLabel = new System.Windows.Forms.Label();
            this.fechaVenciTLabel = new System.Windows.Forms.Label();
            this.ofertaTLabel = new System.Windows.Forms.Label();
            this.informativeLabel = new System.Windows.Forms.Label();
            this.informativeIconpictureBox = new System.Windows.Forms.PictureBox();
            this.miRecargaTLabel = new System.Windows.Forms.Label();
            this.masIformacionButton = new System.Windows.Forms.Button();
            this.separadorPanel2 = new System.Windows.Forms.Panel();
            this.separadorPanel3 = new System.Windows.Forms.Panel();
            this.detallesFacturaPanel = new System.Windows.Forms.Panel();
            this.activarFacturacionCheckBox = new System.Windows.Forms.CheckBox();
            this.editarDatosButton = new System.Windows.Forms.Button();
            this.facturaTLlabel = new System.Windows.Forms.Label();
            this.factTLabel = new System.Windows.Forms.Label();
            this.iconInfopictureBox = new System.Windows.Forms.PictureBox();
            this.facturacionTiLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaPictureBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarSesionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeteraIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wifiIconPictureBox)).BeginInit();
            this.miCuentaPanel.SuspendLayout();
            this.ServiciosPanel.SuspendLayout();
            this.dataUsuarioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).BeginInit();
            this.gbsTotalesPanel.SuspendLayout();
            this.gbsUtilizadosPanel.SuspendLayout();
            this.diasRestantesPanel.SuspendLayout();
            this.redesSocialesPanel.SuspendLayout();
            this.miRecargaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informativeIconpictureBox)).BeginInit();
            this.detallesFacturaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInfopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.userNameTLabel);
            this.topPanel.Controls.Add(this.iconUser);
            this.topPanel.Controls.Add(this.marcaPictureBox);
            this.topPanel.Location = new System.Drawing.Point(12, 12);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(890, 100);
            this.topPanel.TabIndex = 0;
            // 
            // userNameTLabel
            // 
            this.userNameTLabel.AutoSize = true;
            this.userNameTLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameTLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.userNameTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.userNameTLabel.Location = new System.Drawing.Point(744, 44);
            this.userNameTLabel.Name = "userNameTLabel";
            this.userNameTLabel.Size = new System.Drawing.Size(127, 20);
            this.userNameTLabel.TabIndex = 2;
            this.userNameTLabel.Text = "Rodrigo Arturo";
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(680, 27);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(58, 50);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUser.TabIndex = 1;
            this.iconUser.TabStop = false;
            // 
            // marcaPictureBox
            // 
            this.marcaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("marcaPictureBox.Image")));
            this.marcaPictureBox.Location = new System.Drawing.Point(16, 27);
            this.marcaPictureBox.Name = "marcaPictureBox";
            this.marcaPictureBox.Size = new System.Drawing.Size(148, 50);
            this.marcaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.marcaPictureBox.TabIndex = 0;
            this.marcaPictureBox.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.leftPanel.Controls.Add(this.cerrarSesionLinkLabel);
            this.leftPanel.Controls.Add(this.cerrarSesionPictureBox);
            this.leftPanel.Controls.Add(this.servicioLinkLabel);
            this.leftPanel.Controls.Add(this.pagosLinkLabel);
            this.leftPanel.Controls.Add(this.billeteraIconPictureBox);
            this.leftPanel.Controls.Add(this.wifiIconPictureBox);
            this.leftPanel.Controls.Add(this.miCuentaPanel);
            this.leftPanel.Controls.Add(this.ServiciosPanel);
            this.leftPanel.Location = new System.Drawing.Point(12, 183);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 645);
            this.leftPanel.TabIndex = 1;
            // 
            // cerrarSesionLinkLabel
            // 
            this.cerrarSesionLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.cerrarSesionLinkLabel.AutoSize = true;
            this.cerrarSesionLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.cerrarSesionLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cerrarSesionLinkLabel.LinkColor = System.Drawing.Color.White;
            this.cerrarSesionLinkLabel.Location = new System.Drawing.Point(61, 602);
            this.cerrarSesionLinkLabel.Name = "cerrarSesionLinkLabel";
            this.cerrarSesionLinkLabel.Size = new System.Drawing.Size(103, 20);
            this.cerrarSesionLinkLabel.TabIndex = 7;
            this.cerrarSesionLinkLabel.TabStop = true;
            this.cerrarSesionLinkLabel.Text = "Cerrar sesión";
            // 
            // cerrarSesionPictureBox
            // 
            this.cerrarSesionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionPictureBox.Image")));
            this.cerrarSesionPictureBox.Location = new System.Drawing.Point(6, 595);
            this.cerrarSesionPictureBox.Name = "cerrarSesionPictureBox";
            this.cerrarSesionPictureBox.Size = new System.Drawing.Size(38, 35);
            this.cerrarSesionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarSesionPictureBox.TabIndex = 8;
            this.cerrarSesionPictureBox.TabStop = false;
            // 
            // servicioLinkLabel
            // 
            this.servicioLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.servicioLinkLabel.AutoSize = true;
            this.servicioLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.servicioLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicioLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.servicioLinkLabel.LinkColor = System.Drawing.Color.White;
            this.servicioLinkLabel.Location = new System.Drawing.Point(58, 50);
            this.servicioLinkLabel.Name = "servicioLinkLabel";
            this.servicioLinkLabel.Size = new System.Drawing.Size(64, 20);
            this.servicioLinkLabel.TabIndex = 6;
            this.servicioLinkLabel.TabStop = true;
            this.servicioLinkLabel.Text = "Servicio";
            // 
            // pagosLinkLabel
            // 
            this.pagosLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.pagosLinkLabel.AutoSize = true;
            this.pagosLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.pagosLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagosLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.pagosLinkLabel.LinkColor = System.Drawing.Color.White;
            this.pagosLinkLabel.Location = new System.Drawing.Point(61, 130);
            this.pagosLinkLabel.Name = "pagosLinkLabel";
            this.pagosLinkLabel.Size = new System.Drawing.Size(54, 20);
            this.pagosLinkLabel.TabIndex = 3;
            this.pagosLinkLabel.TabStop = true;
            this.pagosLinkLabel.Text = "Pagos";
            this.pagosLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pagosLinkLabel_LinkClicked);
            // 
            // billeteraIconPictureBox
            // 
            this.billeteraIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("billeteraIconPictureBox.Image")));
            this.billeteraIconPictureBox.Location = new System.Drawing.Point(6, 123);
            this.billeteraIconPictureBox.Name = "billeteraIconPictureBox";
            this.billeteraIconPictureBox.Size = new System.Drawing.Size(38, 35);
            this.billeteraIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.billeteraIconPictureBox.TabIndex = 5;
            this.billeteraIconPictureBox.TabStop = false;
            this.billeteraIconPictureBox.Click += new System.EventHandler(this.billeteraIconPictureBox_Click);
            // 
            // wifiIconPictureBox
            // 
            this.wifiIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wifiIconPictureBox.Image")));
            this.wifiIconPictureBox.Location = new System.Drawing.Point(6, 42);
            this.wifiIconPictureBox.Name = "wifiIconPictureBox";
            this.wifiIconPictureBox.Size = new System.Drawing.Size(38, 35);
            this.wifiIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wifiIconPictureBox.TabIndex = 3;
            this.wifiIconPictureBox.TabStop = false;
            // 
            // miCuentaPanel
            // 
            this.miCuentaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.miCuentaPanel.Controls.Add(this.miCuentaTLabel);
            this.miCuentaPanel.Location = new System.Drawing.Point(0, 81);
            this.miCuentaPanel.Name = "miCuentaPanel";
            this.miCuentaPanel.Size = new System.Drawing.Size(200, 34);
            this.miCuentaPanel.TabIndex = 1;
            // 
            // miCuentaTLabel
            // 
            this.miCuentaTLabel.AutoSize = true;
            this.miCuentaTLabel.BackColor = System.Drawing.Color.Transparent;
            this.miCuentaTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miCuentaTLabel.ForeColor = System.Drawing.Color.White;
            this.miCuentaTLabel.Location = new System.Drawing.Point(19, 5);
            this.miCuentaTLabel.Name = "miCuentaTLabel";
            this.miCuentaTLabel.Size = new System.Drawing.Size(101, 24);
            this.miCuentaTLabel.TabIndex = 6;
            this.miCuentaTLabel.Text = "Mi cuenta";
            // 
            // ServiciosPanel
            // 
            this.ServiciosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.ServiciosPanel.Controls.Add(this.servicioTLabel);
            this.ServiciosPanel.Location = new System.Drawing.Point(0, 3);
            this.ServiciosPanel.Name = "ServiciosPanel";
            this.ServiciosPanel.Size = new System.Drawing.Size(200, 34);
            this.ServiciosPanel.TabIndex = 0;
            // 
            // servicioTLabel
            // 
            this.servicioTLabel.AutoSize = true;
            this.servicioTLabel.BackColor = System.Drawing.Color.Transparent;
            this.servicioTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicioTLabel.ForeColor = System.Drawing.Color.White;
            this.servicioTLabel.Location = new System.Drawing.Point(16, 6);
            this.servicioTLabel.Name = "servicioTLabel";
            this.servicioTLabel.Size = new System.Drawing.Size(85, 24);
            this.servicioTLabel.TabIndex = 7;
            this.servicioTLabel.Text = "Servicio";
            // 
            // dataUsuarioPanel
            // 
            this.dataUsuarioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.dataUsuarioPanel.Controls.Add(this.userPhoneLabel);
            this.dataUsuarioPanel.Controls.Add(this.userNameLabel);
            this.dataUsuarioPanel.Controls.Add(this.userIconPictureBox);
            this.dataUsuarioPanel.Location = new System.Drawing.Point(12, 118);
            this.dataUsuarioPanel.Name = "dataUsuarioPanel";
            this.dataUsuarioPanel.Size = new System.Drawing.Size(200, 69);
            this.dataUsuarioPanel.TabIndex = 2;
            // 
            // userPhoneLabel
            // 
            this.userPhoneLabel.AutoSize = true;
            this.userPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.userPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.userPhoneLabel.Location = new System.Drawing.Point(56, 39);
            this.userPhoneLabel.Name = "userPhoneLabel";
            this.userPhoneLabel.Size = new System.Drawing.Size(95, 15);
            this.userPhoneLabel.TabIndex = 3;
            this.userPhoneLabel.Text = "999 324 1768";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(56, 14);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(108, 16);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Rodrigo Arturo";
            // 
            // userIconPictureBox
            // 
            this.userIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userIconPictureBox.Image")));
            this.userIconPictureBox.Location = new System.Drawing.Point(6, 9);
            this.userIconPictureBox.Name = "userIconPictureBox";
            this.userIconPictureBox.Size = new System.Drawing.Size(47, 50);
            this.userIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIconPictureBox.TabIndex = 1;
            this.userIconPictureBox.TabStop = false;
            // 
            // planTLabel
            // 
            this.planTLabel.AutoSize = true;
            this.planTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.planTLabel.Location = new System.Drawing.Point(513, 151);
            this.planTLabel.Name = "planTLabel";
            this.planTLabel.Size = new System.Drawing.Size(107, 31);
            this.planTLabel.TabIndex = 3;
            this.planTLabel.Text = "PLAN #";
            // 
            // ultCompTLabel
            // 
            this.ultCompTLabel.AutoSize = true;
            this.ultCompTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultCompTLabel.Location = new System.Drawing.Point(507, 126);
            this.ultCompTLabel.Name = "ultCompTLabel";
            this.ultCompTLabel.Size = new System.Drawing.Size(118, 20);
            this.ultCompTLabel.TabIndex = 4;
            this.ultCompTLabel.Text = "Última compra";
            // 
            // planesContratadosComboBox
            // 
            this.planesContratadosComboBox.FormattingEnabled = true;
            this.planesContratadosComboBox.Location = new System.Drawing.Point(343, 185);
            this.planesContratadosComboBox.Name = "planesContratadosComboBox";
            this.planesContratadosComboBox.Size = new System.Drawing.Size(446, 21);
            this.planesContratadosComboBox.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 828);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // lineaDiviPanel
            // 
            this.lineaDiviPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.lineaDiviPanel.Location = new System.Drawing.Point(424, 212);
            this.lineaDiviPanel.Name = "lineaDiviPanel";
            this.lineaDiviPanel.Size = new System.Drawing.Size(290, 3);
            this.lineaDiviPanel.TabIndex = 7;
            // 
            // vencimientoTLabel
            // 
            this.vencimientoTLabel.AutoSize = true;
            this.vencimientoTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientoTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.vencimientoTLabel.Location = new System.Drawing.Point(446, 220);
            this.vencimientoTLabel.Name = "vencimientoTLabel";
            this.vencimientoTLabel.Size = new System.Drawing.Size(150, 18);
            this.vencimientoTLabel.TabIndex = 8;
            this.vencimientoTLabel.Text = "Tu recarga vencerá el";
            // 
            // fechaVenRecargaLabel
            // 
            this.fechaVenRecargaLabel.AutoSize = true;
            this.fechaVenRecargaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVenRecargaLabel.ForeColor = System.Drawing.Color.Black;
            this.fechaVenRecargaLabel.Location = new System.Drawing.Point(590, 221);
            this.fechaVenRecargaLabel.Name = "fechaVenRecargaLabel";
            this.fechaVenRecargaLabel.Size = new System.Drawing.Size(81, 16);
            this.fechaVenRecargaLabel.TabIndex = 9;
            this.fechaVenRecargaLabel.Text = "13/05/2024";
            // 
            // misConsumosTLabel
            // 
            this.misConsumosTLabel.AutoSize = true;
            this.misConsumosTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misConsumosTLabel.ForeColor = System.Drawing.Color.Black;
            this.misConsumosTLabel.Location = new System.Drawing.Point(509, 249);
            this.misConsumosTLabel.Name = "misConsumosTLabel";
            this.misConsumosTLabel.Size = new System.Drawing.Size(105, 16);
            this.misConsumosTLabel.TabIndex = 10;
            this.misConsumosTLabel.Text = "Mis consumos";
            // 
            // gbsTotalesPanel
            // 
            this.gbsTotalesPanel.BackColor = System.Drawing.Color.White;
            this.gbsTotalesPanel.Controls.Add(this.gbsTLabel);
            this.gbsTotalesPanel.Controls.Add(this.gbsNumLabel);
            this.gbsTotalesPanel.Location = new System.Drawing.Point(249, 272);
            this.gbsTotalesPanel.Name = "gbsTotalesPanel";
            this.gbsTotalesPanel.Size = new System.Drawing.Size(133, 88);
            this.gbsTotalesPanel.TabIndex = 11;
            // 
            // gbsTLabel
            // 
            this.gbsTLabel.AutoSize = true;
            this.gbsTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.gbsTLabel.Location = new System.Drawing.Point(25, 51);
            this.gbsTLabel.Name = "gbsTLabel";
            this.gbsTLabel.Size = new System.Drawing.Size(83, 15);
            this.gbsTLabel.TabIndex = 1;
            this.gbsTLabel.Text = "Gbs Totales";
            // 
            // gbsNumLabel
            // 
            this.gbsNumLabel.AutoSize = true;
            this.gbsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.gbsNumLabel.Location = new System.Drawing.Point(46, 21);
            this.gbsNumLabel.Name = "gbsNumLabel";
            this.gbsNumLabel.Size = new System.Drawing.Size(43, 15);
            this.gbsNumLabel.TabIndex = 0;
            this.gbsNumLabel.Text = "29.30";
            // 
            // gbsUtilizadosPanel
            // 
            this.gbsUtilizadosPanel.BackColor = System.Drawing.Color.White;
            this.gbsUtilizadosPanel.Controls.Add(this.gbsUTLabel);
            this.gbsUtilizadosPanel.Controls.Add(this.gbsNumULabel);
            this.gbsUtilizadosPanel.Location = new System.Drawing.Point(403, 272);
            this.gbsUtilizadosPanel.Name = "gbsUtilizadosPanel";
            this.gbsUtilizadosPanel.Size = new System.Drawing.Size(133, 88);
            this.gbsUtilizadosPanel.TabIndex = 12;
            // 
            // gbsUTLabel
            // 
            this.gbsUTLabel.AutoSize = true;
            this.gbsUTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsUTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.gbsUTLabel.Location = new System.Drawing.Point(18, 49);
            this.gbsUTLabel.Name = "gbsUTLabel";
            this.gbsUTLabel.Size = new System.Drawing.Size(100, 15);
            this.gbsUTLabel.TabIndex = 1;
            this.gbsUTLabel.Text = "Gbs Utilizados";
            // 
            // gbsNumULabel
            // 
            this.gbsNumULabel.AutoSize = true;
            this.gbsNumULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsNumULabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.gbsNumULabel.Location = new System.Drawing.Point(51, 18);
            this.gbsNumULabel.Name = "gbsNumULabel";
            this.gbsNumULabel.Size = new System.Drawing.Size(35, 15);
            this.gbsNumULabel.TabIndex = 0;
            this.gbsNumULabel.Text = "7.08";
            // 
            // diasRestantesPanel
            // 
            this.diasRestantesPanel.BackColor = System.Drawing.Color.White;
            this.diasRestantesPanel.Controls.Add(this.diasRestantesTLabel);
            this.diasRestantesPanel.Controls.Add(this.diasRestNumLabel);
            this.diasRestantesPanel.Location = new System.Drawing.Point(760, 272);
            this.diasRestantesPanel.Name = "diasRestantesPanel";
            this.diasRestantesPanel.Size = new System.Drawing.Size(133, 88);
            this.diasRestantesPanel.TabIndex = 14;
            // 
            // diasRestantesTLabel
            // 
            this.diasRestantesTLabel.AutoSize = true;
            this.diasRestantesTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasRestantesTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.diasRestantesTLabel.Location = new System.Drawing.Point(18, 49);
            this.diasRestantesTLabel.Name = "diasRestantesTLabel";
            this.diasRestantesTLabel.Size = new System.Drawing.Size(99, 15);
            this.diasRestantesTLabel.TabIndex = 1;
            this.diasRestantesTLabel.Text = "Días restantes";
            // 
            // diasRestNumLabel
            // 
            this.diasRestNumLabel.AutoSize = true;
            this.diasRestNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasRestNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.diasRestNumLabel.Location = new System.Drawing.Point(57, 21);
            this.diasRestNumLabel.Name = "diasRestNumLabel";
            this.diasRestNumLabel.Size = new System.Drawing.Size(23, 15);
            this.diasRestNumLabel.TabIndex = 0;
            this.diasRestNumLabel.Text = "26";
            // 
            // redesSocialesPanel
            // 
            this.redesSocialesPanel.BackColor = System.Drawing.Color.White;
            this.redesSocialesPanel.Controls.Add(this.gbsRedesSTLabel);
            this.redesSocialesPanel.Controls.Add(this.gbsNumRedesSocialesLabel);
            this.redesSocialesPanel.Location = new System.Drawing.Point(556, 272);
            this.redesSocialesPanel.Name = "redesSocialesPanel";
            this.redesSocialesPanel.Size = new System.Drawing.Size(185, 88);
            this.redesSocialesPanel.TabIndex = 13;
            // 
            // gbsRedesSTLabel
            // 
            this.gbsRedesSTLabel.AutoSize = true;
            this.gbsRedesSTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsRedesSTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.gbsRedesSTLabel.Location = new System.Drawing.Point(7, 50);
            this.gbsRedesSTLabel.Name = "gbsRedesSTLabel";
            this.gbsRedesSTLabel.Size = new System.Drawing.Size(175, 15);
            this.gbsRedesSTLabel.TabIndex = 1;
            this.gbsRedesSTLabel.Text = "Redes Sociales Utilizadas";
            // 
            // gbsNumRedesSocialesLabel
            // 
            this.gbsNumRedesSocialesLabel.AutoSize = true;
            this.gbsNumRedesSocialesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsNumRedesSocialesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.gbsNumRedesSocialesLabel.Location = new System.Drawing.Point(62, 21);
            this.gbsNumRedesSocialesLabel.Name = "gbsNumRedesSocialesLabel";
            this.gbsNumRedesSocialesLabel.Size = new System.Drawing.Size(64, 15);
            this.gbsNumRedesSocialesLabel.TabIndex = 0;
            this.gbsNumRedesSocialesLabel.Text = "0.08 Gbs";
            // 
            // miRecargaPanel
            // 
            this.miRecargaPanel.BackColor = System.Drawing.Color.White;
            this.miRecargaPanel.Controls.Add(this.separadorPanel1);
            this.miRecargaPanel.Controls.Add(this.comprarOfertPrepButton);
            this.miRecargaPanel.Controls.Add(this.fechaVenLabel);
            this.miRecargaPanel.Controls.Add(this.ofertaApliLabel);
            this.miRecargaPanel.Controls.Add(this.fechaVenciTLabel);
            this.miRecargaPanel.Controls.Add(this.ofertaTLabel);
            this.miRecargaPanel.Controls.Add(this.informativeLabel);
            this.miRecargaPanel.Controls.Add(this.informativeIconpictureBox);
            this.miRecargaPanel.Controls.Add(this.miRecargaTLabel);
            this.miRecargaPanel.Location = new System.Drawing.Point(249, 429);
            this.miRecargaPanel.Name = "miRecargaPanel";
            this.miRecargaPanel.Size = new System.Drawing.Size(653, 171);
            this.miRecargaPanel.TabIndex = 15;
            // 
            // separadorPanel1
            // 
            this.separadorPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.separadorPanel1.Location = new System.Drawing.Point(-5, 85);
            this.separadorPanel1.Name = "separadorPanel1";
            this.separadorPanel1.Size = new System.Drawing.Size(660, 3);
            this.separadorPanel1.TabIndex = 8;
            // 
            // comprarOfertPrepButton
            // 
            this.comprarOfertPrepButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.comprarOfertPrepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprarOfertPrepButton.ForeColor = System.Drawing.Color.White;
            this.comprarOfertPrepButton.Location = new System.Drawing.Point(200, 123);
            this.comprarOfertPrepButton.Name = "comprarOfertPrepButton";
            this.comprarOfertPrepButton.Size = new System.Drawing.Size(238, 31);
            this.comprarOfertPrepButton.TabIndex = 17;
            this.comprarOfertPrepButton.Text = "Comprar oferta prepago";
            this.comprarOfertPrepButton.UseVisualStyleBackColor = false;
            // 
            // fechaVenLabel
            // 
            this.fechaVenLabel.AutoSize = true;
            this.fechaVenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.fechaVenLabel.Location = new System.Drawing.Point(341, 93);
            this.fechaVenLabel.Name = "fechaVenLabel";
            this.fechaVenLabel.Size = new System.Drawing.Size(75, 13);
            this.fechaVenLabel.TabIndex = 22;
            this.fechaVenLabel.Text = "13/05/2024";
            // 
            // ofertaApliLabel
            // 
            this.ofertaApliLabel.AutoSize = true;
            this.ofertaApliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofertaApliLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.ofertaApliLabel.Location = new System.Drawing.Point(341, 67);
            this.ofertaApliLabel.Name = "ofertaApliLabel";
            this.ofertaApliLabel.Size = new System.Drawing.Size(74, 13);
            this.ofertaApliLabel.TabIndex = 21;
            this.ofertaApliLabel.Text = "PLAN 30GB";
            // 
            // fechaVenciTLabel
            // 
            this.fechaVenciTLabel.AutoSize = true;
            this.fechaVenciTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVenciTLabel.Location = new System.Drawing.Point(179, 93);
            this.fechaVenciTLabel.Name = "fechaVenciTLabel";
            this.fechaVenciTLabel.Size = new System.Drawing.Size(136, 13);
            this.fechaVenciTLabel.TabIndex = 20;
            this.fechaVenciTLabel.Text = "Fecha de vencimiento:";
            // 
            // ofertaTLabel
            // 
            this.ofertaTLabel.AutoSize = true;
            this.ofertaTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofertaTLabel.Location = new System.Drawing.Point(269, 67);
            this.ofertaTLabel.Name = "ofertaTLabel";
            this.ofertaTLabel.Size = new System.Drawing.Size(46, 13);
            this.ofertaTLabel.TabIndex = 19;
            this.ofertaTLabel.Text = "Oferta:";
            // 
            // informativeLabel
            // 
            this.informativeLabel.AutoSize = true;
            this.informativeLabel.BackColor = System.Drawing.Color.Transparent;
            this.informativeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.informativeLabel.Location = new System.Drawing.Point(248, 41);
            this.informativeLabel.Name = "informativeLabel";
            this.informativeLabel.Size = new System.Drawing.Size(160, 13);
            this.informativeLabel.TabIndex = 18;
            this.informativeLabel.Text = "Información de tu recarga actual";
            // 
            // informativeIconpictureBox
            // 
            this.informativeIconpictureBox.BackColor = System.Drawing.Color.White;
            this.informativeIconpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("informativeIconpictureBox.Image")));
            this.informativeIconpictureBox.Location = new System.Drawing.Point(232, 40);
            this.informativeIconpictureBox.Name = "informativeIconpictureBox";
            this.informativeIconpictureBox.Size = new System.Drawing.Size(14, 15);
            this.informativeIconpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.informativeIconpictureBox.TabIndex = 7;
            this.informativeIconpictureBox.TabStop = false;
            // 
            // miRecargaTLabel
            // 
            this.miRecargaTLabel.AutoSize = true;
            this.miRecargaTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miRecargaTLabel.Location = new System.Drawing.Point(267, 7);
            this.miRecargaTLabel.Name = "miRecargaTLabel";
            this.miRecargaTLabel.Size = new System.Drawing.Size(114, 25);
            this.miRecargaTLabel.TabIndex = 17;
            this.miRecargaTLabel.Text = "Mi recarga";
            // 
            // masIformacionButton
            // 
            this.masIformacionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.masIformacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masIformacionButton.ForeColor = System.Drawing.Color.White;
            this.masIformacionButton.Location = new System.Drawing.Point(433, 366);
            this.masIformacionButton.Name = "masIformacionButton";
            this.masIformacionButton.Size = new System.Drawing.Size(238, 31);
            this.masIformacionButton.TabIndex = 16;
            this.masIformacionButton.Text = "Más información";
            this.masIformacionButton.UseVisualStyleBackColor = false;
            // 
            // separadorPanel2
            // 
            this.separadorPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.separadorPanel2.Location = new System.Drawing.Point(249, 540);
            this.separadorPanel2.Name = "separadorPanel2";
            this.separadorPanel2.Size = new System.Drawing.Size(653, 3);
            this.separadorPanel2.TabIndex = 9;
            // 
            // separadorPanel3
            // 
            this.separadorPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.separadorPanel3.Location = new System.Drawing.Point(249, 727);
            this.separadorPanel3.Name = "separadorPanel3";
            this.separadorPanel3.Size = new System.Drawing.Size(651, 3);
            this.separadorPanel3.TabIndex = 16;
            // 
            // detallesFacturaPanel
            // 
            this.detallesFacturaPanel.BackColor = System.Drawing.Color.White;
            this.detallesFacturaPanel.Controls.Add(this.activarFacturacionCheckBox);
            this.detallesFacturaPanel.Controls.Add(this.editarDatosButton);
            this.detallesFacturaPanel.Controls.Add(this.facturaTLlabel);
            this.detallesFacturaPanel.Controls.Add(this.factTLabel);
            this.detallesFacturaPanel.Controls.Add(this.iconInfopictureBox);
            this.detallesFacturaPanel.Controls.Add(this.facturacionTiLabel);
            this.detallesFacturaPanel.Location = new System.Drawing.Point(249, 626);
            this.detallesFacturaPanel.Name = "detallesFacturaPanel";
            this.detallesFacturaPanel.Size = new System.Drawing.Size(653, 153);
            this.detallesFacturaPanel.TabIndex = 17;
            // 
            // activarFacturacionCheckBox
            // 
            this.activarFacturacionCheckBox.AutoSize = true;
            this.activarFacturacionCheckBox.Location = new System.Drawing.Point(372, 77);
            this.activarFacturacionCheckBox.Name = "activarFacturacionCheckBox";
            this.activarFacturacionCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activarFacturacionCheckBox.TabIndex = 21;
            this.activarFacturacionCheckBox.UseVisualStyleBackColor = true;
            // 
            // editarDatosButton
            // 
            this.editarDatosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.editarDatosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarDatosButton.ForeColor = System.Drawing.Color.White;
            this.editarDatosButton.Location = new System.Drawing.Point(249, 110);
            this.editarDatosButton.Name = "editarDatosButton";
            this.editarDatosButton.Size = new System.Drawing.Size(152, 31);
            this.editarDatosButton.TabIndex = 17;
            this.editarDatosButton.Text = "Editar datos";
            this.editarDatosButton.UseVisualStyleBackColor = false;
            // 
            // facturaTLlabel
            // 
            this.facturaTLlabel.AutoSize = true;
            this.facturaTLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaTLlabel.Location = new System.Drawing.Point(236, 77);
            this.facturaTLlabel.Name = "facturaTLlabel";
            this.facturaTLlabel.Size = new System.Drawing.Size(131, 13);
            this.facturaTLlabel.TabIndex = 20;
            this.facturaTLlabel.Text = "Facturación activada:";
            // 
            // factTLabel
            // 
            this.factTLabel.AutoSize = true;
            this.factTLabel.BackColor = System.Drawing.Color.Transparent;
            this.factTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(146)))));
            this.factTLabel.Location = new System.Drawing.Point(183, 44);
            this.factTLabel.Name = "factTLabel";
            this.factTLabel.Size = new System.Drawing.Size(345, 13);
            this.factTLabel.TabIndex = 18;
            this.factTLabel.Text = "Puedes desactivar o editar tus datos de facturación desde esta sección";
            // 
            // iconInfopictureBox
            // 
            this.iconInfopictureBox.BackColor = System.Drawing.Color.White;
            this.iconInfopictureBox.Location = new System.Drawing.Point(167, 43);
            this.iconInfopictureBox.Name = "iconInfopictureBox";
            this.iconInfopictureBox.Size = new System.Drawing.Size(14, 15);
            this.iconInfopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconInfopictureBox.TabIndex = 7;
            this.iconInfopictureBox.TabStop = false;
            // 
            // facturacionTiLabel
            // 
            this.facturacionTiLabel.AutoSize = true;
            this.facturacionTiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacionTiLabel.Location = new System.Drawing.Point(265, 9);
            this.facturacionTiLabel.Name = "facturacionTiLabel";
            this.facturacionTiLabel.Size = new System.Drawing.Size(125, 25);
            this.facturacionTiLabel.TabIndex = 17;
            this.facturacionTiLabel.Text = "Facturación";
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 828);
            this.Controls.Add(this.separadorPanel3);
            this.Controls.Add(this.separadorPanel2);
            this.Controls.Add(this.detallesFacturaPanel);
            this.Controls.Add(this.masIformacionButton);
            this.Controls.Add(this.miRecargaPanel);
            this.Controls.Add(this.diasRestantesPanel);
            this.Controls.Add(this.redesSocialesPanel);
            this.Controls.Add(this.gbsUtilizadosPanel);
            this.Controls.Add(this.gbsTotalesPanel);
            this.Controls.Add(this.misConsumosTLabel);
            this.Controls.Add(this.fechaVenRecargaLabel);
            this.Controls.Add(this.vencimientoTLabel);
            this.Controls.Add(this.lineaDiviPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.planesContratadosComboBox);
            this.Controls.Add(this.ultCompTLabel);
            this.Controls.Add(this.planTLabel);
            this.Controls.Add(this.dataUsuarioPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario principal";
            this.Load += new System.EventHandler(this.principalForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaPictureBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarSesionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billeteraIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wifiIconPictureBox)).EndInit();
            this.miCuentaPanel.ResumeLayout(false);
            this.miCuentaPanel.PerformLayout();
            this.ServiciosPanel.ResumeLayout(false);
            this.ServiciosPanel.PerformLayout();
            this.dataUsuarioPanel.ResumeLayout(false);
            this.dataUsuarioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).EndInit();
            this.gbsTotalesPanel.ResumeLayout(false);
            this.gbsTotalesPanel.PerformLayout();
            this.gbsUtilizadosPanel.ResumeLayout(false);
            this.gbsUtilizadosPanel.PerformLayout();
            this.diasRestantesPanel.ResumeLayout(false);
            this.diasRestantesPanel.PerformLayout();
            this.redesSocialesPanel.ResumeLayout(false);
            this.redesSocialesPanel.PerformLayout();
            this.miRecargaPanel.ResumeLayout(false);
            this.miRecargaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informativeIconpictureBox)).EndInit();
            this.detallesFacturaPanel.ResumeLayout(false);
            this.detallesFacturaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInfopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox marcaPictureBox;
        private System.Windows.Forms.Panel dataUsuarioPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox userIconPictureBox;
        private System.Windows.Forms.Panel ServiciosPanel;
        private System.Windows.Forms.Panel miCuentaPanel;
        private System.Windows.Forms.Label userPhoneLabel;
        private System.Windows.Forms.PictureBox billeteraIconPictureBox;
        private System.Windows.Forms.PictureBox wifiIconPictureBox;
        private System.Windows.Forms.Label miCuentaTLabel;
        private System.Windows.Forms.Label servicioTLabel;
        private System.Windows.Forms.LinkLabel servicioLinkLabel;
        private System.Windows.Forms.LinkLabel pagosLinkLabel;
        private System.Windows.Forms.Label planTLabel;
        private System.Windows.Forms.Label ultCompTLabel;
        private System.Windows.Forms.ComboBox planesContratadosComboBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel lineaDiviPanel;
        private System.Windows.Forms.Label vencimientoTLabel;
        private System.Windows.Forms.Label fechaVenRecargaLabel;
        private System.Windows.Forms.Label misConsumosTLabel;
        private System.Windows.Forms.Panel gbsTotalesPanel;
        private System.Windows.Forms.Label gbsTLabel;
        private System.Windows.Forms.Label gbsNumLabel;
        private System.Windows.Forms.Panel gbsUtilizadosPanel;
        private System.Windows.Forms.Label gbsUTLabel;
        private System.Windows.Forms.Label gbsNumULabel;
        private System.Windows.Forms.Panel diasRestantesPanel;
        private System.Windows.Forms.Label diasRestantesTLabel;
        private System.Windows.Forms.Label diasRestNumLabel;
        private System.Windows.Forms.Panel redesSocialesPanel;
        private System.Windows.Forms.Label gbsRedesSTLabel;
        private System.Windows.Forms.Label gbsNumRedesSocialesLabel;
        private System.Windows.Forms.Panel miRecargaPanel;
        private System.Windows.Forms.Button masIformacionButton;
        private System.Windows.Forms.Label miRecargaTLabel;
        private System.Windows.Forms.PictureBox informativeIconpictureBox;
        private System.Windows.Forms.Panel separadorPanel1;
        private System.Windows.Forms.Button comprarOfertPrepButton;
        private System.Windows.Forms.Label fechaVenLabel;
        private System.Windows.Forms.Label ofertaApliLabel;
        private System.Windows.Forms.Label fechaVenciTLabel;
        private System.Windows.Forms.Label ofertaTLabel;
        private System.Windows.Forms.Label informativeLabel;
        private System.Windows.Forms.Panel separadorPanel2;
        private System.Windows.Forms.Panel separadorPanel3;
        private System.Windows.Forms.Panel detallesFacturaPanel;
        private System.Windows.Forms.Button editarDatosButton;
        private System.Windows.Forms.Label facturaTLlabel;
        private System.Windows.Forms.Label factTLabel;
        private System.Windows.Forms.PictureBox iconInfopictureBox;
        private System.Windows.Forms.Label facturacionTiLabel;
        private System.Windows.Forms.CheckBox activarFacturacionCheckBox;
        private System.Windows.Forms.PictureBox iconUser;
        private System.Windows.Forms.Label userNameTLabel;
        private System.Windows.Forms.LinkLabel cerrarSesionLinkLabel;
        private System.Windows.Forms.PictureBox cerrarSesionPictureBox;
    }
}

