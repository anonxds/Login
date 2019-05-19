namespace InventarioLaboratorio
{
    partial class FrmReactivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReactivos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lstLaboratorio = new System.Windows.Forms.ComboBox();
            this.dgvReactivo = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.txtReacNom = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtReacNum = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.txtBscCad = new System.Windows.Forms.TextBox();
            this.txtReacObs = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtReacUni = new System.Windows.Forms.TextBox();
            this.txtReacCat = new System.Windows.Forms.TextBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblExixtencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(810, 34);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 45);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Reactivos";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(24, 189);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(179, 37);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Clasificación:";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(24, 117);
            this.lblLaboratorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(148, 37);
            this.lblLaboratorio.TabIndex = 12;
            this.lblLaboratorio.Text = "Ubicación:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.Location = new System.Drawing.Point(492, 112);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 54);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "Medio de cultivo",
            "Reactivo Congelador",
            "Reactivo Refrigerador"});
            this.lstTipo.Location = new System.Drawing.Point(213, 178);
            this.lstTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(268, 45);
            this.lstTipo.TabIndex = 14;
            // 
            // lstLaboratorio
            // 
            this.lstLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLaboratorio.FormattingEnabled = true;
            this.lstLaboratorio.Items.AddRange(new object[] {
            "Laboratorio 1",
            "Laboratorio 2",
            "Laboratorio 3",
            "Laboratorio 4"});
            this.lstLaboratorio.Location = new System.Drawing.Point(213, 112);
            this.lstLaboratorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLaboratorio.Name = "lstLaboratorio";
            this.lstLaboratorio.Size = new System.Drawing.Size(268, 45);
            this.lstLaboratorio.TabIndex = 15;
            // 
            // dgvReactivo
            // 
            this.dgvReactivo.AllowUserToAddRows = false;
            this.dgvReactivo.AllowUserToDeleteRows = false;
            this.dgvReactivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReactivo.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvReactivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReactivo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReactivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReactivo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReactivo.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReactivo.Location = new System.Drawing.Point(30, 369);
            this.dgvReactivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReactivo.Name = "dgvReactivo";
            this.dgvReactivo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReactivo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReactivo.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReactivo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReactivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReactivo.Size = new System.Drawing.Size(1725, 615);
            this.dgvReactivo.TabIndex = 17;
            this.dgvReactivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReactivo_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(1575, 171);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 54);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(1008, 172);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 54);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportar.Location = new System.Drawing.Point(1386, 172);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(180, 54);
            this.btnExportar.TabIndex = 40;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.Location = new System.Drawing.Point(1197, 172);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 54);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(1574, 45);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(182, 37);
            this.lblCerrarSesion.TabIndex = 44;
            this.lblCerrarSesion.Text = "Cerrar sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // txtReacNom
            // 
            this.txtReacNom.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacNom.Location = new System.Drawing.Point(30, 300);
            this.txtReacNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReacNom.Name = "txtReacNom";
            this.txtReacNom.Size = new System.Drawing.Size(268, 36);
            this.txtReacNom.TabIndex = 46;
            this.txtReacNom.Visible = false;
            this.txtReacNom.TextChanged += new System.EventHandler(this.txtReacNom_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(24, 263);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 30);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // txtReacNum
            // 
            this.txtReacNum.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacNum.Location = new System.Drawing.Point(309, 300);
            this.txtReacNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReacNum.Name = "txtReacNum";
            this.txtReacNum.Size = new System.Drawing.Size(268, 36);
            this.txtReacNum.TabIndex = 48;
            this.txtReacNum.Visible = false;
            this.txtReacNum.TextChanged += new System.EventHandler(this.txtReacNum_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(303, 263);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(106, 30);
            this.lblNumero.TabIndex = 47;
            this.lblNumero.Text = "Numero:";
            this.lblNumero.Visible = false;
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.ForeColor = System.Drawing.Color.White;
            this.lblCaducidad.Location = new System.Drawing.Point(588, 263);
            this.lblCaducidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(130, 30);
            this.lblCaducidad.TabIndex = 49;
            this.lblCaducidad.Text = "Caducidad:";
            this.lblCaducidad.Visible = false;
            // 
            // txtBscCad
            // 
            this.txtBscCad.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscCad.Location = new System.Drawing.Point(588, 300);
            this.txtBscCad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBscCad.Name = "txtBscCad";
            this.txtBscCad.Size = new System.Drawing.Size(268, 36);
            this.txtBscCad.TabIndex = 50;
            this.txtBscCad.Visible = false;
            this.txtBscCad.TextChanged += new System.EventHandler(this.txtBscCad_TextChanged);
            // 
            // txtReacObs
            // 
            this.txtReacObs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacObs.Location = new System.Drawing.Point(1425, 302);
            this.txtReacObs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReacObs.Name = "txtReacObs";
            this.txtReacObs.Size = new System.Drawing.Size(328, 38);
            this.txtReacObs.TabIndex = 56;
            this.txtReacObs.Visible = false;
            this.txtReacObs.TextChanged += new System.EventHandler(this.txtReacObs_TextChanged);
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.Color.White;
            this.lblObservacion.Location = new System.Drawing.Point(1419, 263);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(150, 30);
            this.lblObservacion.TabIndex = 55;
            this.lblObservacion.Text = "Observación:";
            this.lblObservacion.Visible = false;
            // 
            // txtReacUni
            // 
            this.txtReacUni.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacUni.Location = new System.Drawing.Point(1146, 300);
            this.txtReacUni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReacUni.Name = "txtReacUni";
            this.txtReacUni.Size = new System.Drawing.Size(268, 36);
            this.txtReacUni.TabIndex = 54;
            this.txtReacUni.Visible = false;
            this.txtReacUni.TextChanged += new System.EventHandler(this.txtReacUni_TextChanged);
            // 
            // txtReacCat
            // 
            this.txtReacCat.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReacCat.Location = new System.Drawing.Point(867, 300);
            this.txtReacCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReacCat.Name = "txtReacCat";
            this.txtReacCat.Size = new System.Drawing.Size(268, 36);
            this.txtReacCat.TabIndex = 53;
            this.txtReacCat.Visible = false;
            this.txtReacCat.TextChanged += new System.EventHandler(this.txtReacCat_TextChanged);
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.White;
            this.lblCatalogo.Location = new System.Drawing.Point(867, 263);
            this.lblCatalogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(113, 30);
            this.lblCatalogo.TabIndex = 52;
            this.lblCatalogo.Text = "Catálogo:";
            this.lblCatalogo.Visible = false;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.White;
            this.lblUnidad.Location = new System.Drawing.Point(1140, 263);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(94, 30);
            this.lblUnidad.TabIndex = 51;
            this.lblUnidad.Text = "Unidad:";
            this.lblUnidad.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(1575, 103);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(178, 44);
            this.txtEstado.TabIndex = 87;
            // 
            // lblExixtencia
            // 
            this.lblExixtencia.AutoSize = true;
            this.lblExixtencia.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExixtencia.ForeColor = System.Drawing.Color.White;
            this.lblExixtencia.Location = new System.Drawing.Point(1380, 108);
            this.lblExixtencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExixtencia.Name = "lblExixtencia";
            this.lblExixtencia.Size = new System.Drawing.Size(185, 37);
            this.lblExixtencia.TabIndex = 86;
            this.lblExixtencia.Text = "En existencia:";
            // 
            // FrmReactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1776, 1017);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblExixtencia);
            this.Controls.Add(this.txtReacObs);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.txtReacUni);
            this.Controls.Add(this.txtReacCat);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtBscCad);
            this.Controls.Add(this.lblCaducidad);
            this.Controls.Add(this.txtReacNum);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtReacNom);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvReactivo);
            this.Controls.Add(this.lstLaboratorio);
            this.Controls.Add(this.lstTipo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Activo Fijo";
            this.Load += new System.EventHandler(this.FrmReactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.ComboBox lstTipo;
        public System.Windows.Forms.ComboBox lstLaboratorio;
        public System.Windows.Forms.DataGridView dgvReactivo;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.TextBox txtReacNom;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtReacNum;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.TextBox txtBscCad;
        private System.Windows.Forms.TextBox txtReacObs;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtReacUni;
        private System.Windows.Forms.TextBox txtReacCat;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblExixtencia;
    }
}