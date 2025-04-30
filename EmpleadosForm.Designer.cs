namespace Sistema_de_Nomina
{
    partial class EmpleadosForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aggEmpleado = new System.Windows.Forms.TabPage();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.comboBoxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consEmpleado = new System.Windows.Forms.TabPage();
            this.txtDepartamento = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.actEmpleado = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCedulaActualizar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombreActualizar = new System.Windows.Forms.TextBox();
            this.dgvActualizar = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.elimEmpleado = new System.Windows.Forms.TabPage();
            this.btnConsultarEliminar = new System.Windows.Forms.Button();
            this.txtDepartamentoEliminar = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtIdEmpleadoEliminar = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dataSetORA = new Sistema_de_Nomina.DataSetORA();
            this.dataSetORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUESTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUESTOSTableAdapter = new Sistema_de_Nomina.DataSetORATableAdapters.PUESTOSTableAdapter();
            this.tabControl1.SuspendLayout();
            this.aggEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.consEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.actEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).BeginInit();
            this.elimEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetORA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetORABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUESTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.aggEmpleado);
            this.tabControl1.Controls.Add(this.consEmpleado);
            this.tabControl1.Controls.Add(this.actEmpleado);
            this.tabControl1.Controls.Add(this.elimEmpleado);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // aggEmpleado
            // 
            this.aggEmpleado.Controls.Add(this.txtApellido);
            this.aggEmpleado.Controls.Add(this.label29);
            this.aggEmpleado.Controls.Add(this.btnAgregarEmpleado);
            this.aggEmpleado.Controls.Add(this.txtSalario);
            this.aggEmpleado.Controls.Add(this.txtCargo);
            this.aggEmpleado.Controls.Add(this.txtTelefono);
            this.aggEmpleado.Controls.Add(this.txtDireccion);
            this.aggEmpleado.Controls.Add(this.txtNombre);
            this.aggEmpleado.Controls.Add(this.dgvAgregar);
            this.aggEmpleado.Controls.Add(this.comboBoxDepartamentos);
            this.aggEmpleado.Controls.Add(this.label9);
            this.aggEmpleado.Controls.Add(this.label8);
            this.aggEmpleado.Controls.Add(this.label7);
            this.aggEmpleado.Controls.Add(this.label6);
            this.aggEmpleado.Controls.Add(this.label5);
            this.aggEmpleado.Controls.Add(this.txtCedula);
            this.aggEmpleado.Controls.Add(this.label3);
            this.aggEmpleado.Controls.Add(this.label2);
            this.aggEmpleado.Controls.Add(this.label1);
            this.aggEmpleado.Location = new System.Drawing.Point(4, 25);
            this.aggEmpleado.Name = "aggEmpleado";
            this.aggEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.aggEmpleado.Size = new System.Drawing.Size(590, 418);
            this.aggEmpleado.TabIndex = 0;
            this.aggEmpleado.Text = "Agregar Empleado";
            this.aggEmpleado.UseVisualStyleBackColor = true;
            this.aggEmpleado.SizeChanged += new System.EventHandler(this.aggEmpleado_SizeChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtApellido.Location = new System.Drawing.Point(80, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(117, 20);
            this.txtApellido.TabIndex = 46;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(15, 114);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 12);
            this.label29.TabIndex = 45;
            this.label29.Text = "Apellido";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(237)))));
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(487, 163);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(88, 71);
            this.btnAgregarEmpleado.TabIndex = 44;
            this.btnAgregarEmpleado.Text = "Agregar empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSalario.Location = new System.Drawing.Point(353, 211);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(117, 20);
            this.txtSalario.TabIndex = 43;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCargo.Location = new System.Drawing.Point(353, 163);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(117, 20);
            this.txtCargo.TabIndex = 42;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTelefono.Location = new System.Drawing.Point(353, 66);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(117, 20);
            this.txtTelefono.TabIndex = 41;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDireccion.Location = new System.Drawing.Point(80, 215);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 20);
            this.txtDireccion.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombre.Location = new System.Drawing.Point(79, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(33, 273);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.Size = new System.Drawing.Size(522, 128);
            this.dgvAgregar.TabIndex = 38;
            // 
            // comboBoxDepartamentos
            // 
            this.comboBoxDepartamentos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartamentos.FormattingEnabled = true;
            this.comboBoxDepartamentos.Location = new System.Drawing.Point(353, 110);
            this.comboBoxDepartamentos.Name = "comboBoxDepartamentos";
            this.comboBoxDepartamentos.Size = new System.Drawing.Size(117, 21);
            this.comboBoxDepartamentos.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "Teléfono";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCedula.Location = new System.Drawing.Point(79, 158);
            this.txtCedula.MaxLength = 13;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(117, 20);
            this.txtCedula.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Agregar Empleado";
            // 
            // consEmpleado
            // 
            this.consEmpleado.Controls.Add(this.txtDepartamento);
            this.consEmpleado.Controls.Add(this.label14);
            this.consEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.consEmpleado.Controls.Add(this.label13);
            this.consEmpleado.Controls.Add(this.txtIdEmpleado);
            this.consEmpleado.Controls.Add(this.label12);
            this.consEmpleado.Controls.Add(this.btnConsulta);
            this.consEmpleado.Controls.Add(this.dgvConsulta);
            this.consEmpleado.Controls.Add(this.label11);
            this.consEmpleado.Controls.Add(this.label10);
            this.consEmpleado.Location = new System.Drawing.Point(4, 25);
            this.consEmpleado.Name = "consEmpleado";
            this.consEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.consEmpleado.Size = new System.Drawing.Size(590, 418);
            this.consEmpleado.TabIndex = 1;
            this.consEmpleado.Text = "Consultar empleado";
            this.consEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDepartamento.FormattingEnabled = true;
            this.txtDepartamento.Location = new System.Drawing.Point(176, 203);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(117, 21);
            this.txtDepartamento.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(64, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 19);
            this.label14.TabIndex = 41;
            this.label14.Text = "Departamento";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(176, 151);
            this.txtNombreEmpleado.Multiline = true;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(117, 23);
            this.txtNombreEmpleado.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(87, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Nombre ";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtIdEmpleado.Location = new System.Drawing.Point(176, 105);
            this.txtIdEmpleado.Multiline = true;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(117, 23);
            this.txtIdEmpleado.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(101, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Cedula";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(237)))));
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(364, 105);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(113, 131);
            this.btnConsulta.TabIndex = 36;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(25, 275);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(540, 134);
            this.dgvConsulta.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(227, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Consultar por:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 26);
            this.label10.TabIndex = 33;
            this.label10.Text = "Consultar Empleado";
            // 
            // actEmpleado
            // 
            this.actEmpleado.Controls.Add(this.label16);
            this.actEmpleado.Controls.Add(this.txtCedulaActualizar);
            this.actEmpleado.Controls.Add(this.label4);
            this.actEmpleado.Controls.Add(this.btnActualizar);
            this.actEmpleado.Controls.Add(this.txtNombreActualizar);
            this.actEmpleado.Controls.Add(this.dgvActualizar);
            this.actEmpleado.Controls.Add(this.label23);
            this.actEmpleado.Controls.Add(this.label24);
            this.actEmpleado.Location = new System.Drawing.Point(4, 25);
            this.actEmpleado.Name = "actEmpleado";
            this.actEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.actEmpleado.Size = new System.Drawing.Size(590, 418);
            this.actEmpleado.TabIndex = 2;
            this.actEmpleado.Text = "Actualizar Empleado";
            this.actEmpleado.UseVisualStyleBackColor = true;
            this.actEmpleado.Click += new System.EventHandler(this.actEmpleado_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(478, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 19);
            this.label16.TabIndex = 67;
            this.label16.Text = "edite los datos";
            // 
            // txtCedulaActualizar
            // 
            this.txtCedulaActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCedulaActualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCedulaActualizar.Location = new System.Drawing.Point(344, 75);
            this.txtCedulaActualizar.Multiline = true;
            this.txtCedulaActualizar.Name = "txtCedulaActualizar";
            this.txtCedulaActualizar.Size = new System.Drawing.Size(208, 23);
            this.txtCedulaActualizar.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "Cedula";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(237)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(439, 34);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(113, 25);
            this.btnActualizar.TabIndex = 63;
            this.btnActualizar.Text = "buscar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombreActualizar
            // 
            this.txtNombreActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreActualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombreActualizar.Location = new System.Drawing.Point(73, 75);
            this.txtNombreActualizar.Multiline = true;
            this.txtNombreActualizar.Name = "txtNombreActualizar";
            this.txtNombreActualizar.Size = new System.Drawing.Size(208, 23);
            this.txtNombreActualizar.TabIndex = 58;
            this.txtNombreActualizar.TextChanged += new System.EventHandler(this.txtNombreActualizar_TextChanged);
            // 
            // dgvActualizar
            // 
            this.dgvActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizar.Location = new System.Drawing.Point(8, 136);
            this.dgvActualizar.Name = "dgvActualizar";
            this.dgvActualizar.Size = new System.Drawing.Size(574, 267);
            this.dgvActualizar.TabIndex = 57;
            this.dgvActualizar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizar_CellValueChanged);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(41, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 12);
            this.label23.TabIndex = 46;
            this.label23.Text = "Nombre";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(26, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(210, 26);
            this.label24.TabIndex = 45;
            this.label24.Text = "Actualizar Empleado";
            // 
            // elimEmpleado
            // 
            this.elimEmpleado.Controls.Add(this.btnConsultarEliminar);
            this.elimEmpleado.Controls.Add(this.txtDepartamentoEliminar);
            this.elimEmpleado.Controls.Add(this.label15);
            this.elimEmpleado.Controls.Add(this.txtNombreEliminar);
            this.elimEmpleado.Controls.Add(this.label25);
            this.elimEmpleado.Controls.Add(this.txtIdEmpleadoEliminar);
            this.elimEmpleado.Controls.Add(this.label26);
            this.elimEmpleado.Controls.Add(this.btnEliminar);
            this.elimEmpleado.Controls.Add(this.dgvEliminar);
            this.elimEmpleado.Controls.Add(this.label27);
            this.elimEmpleado.Controls.Add(this.label28);
            this.elimEmpleado.Location = new System.Drawing.Point(4, 25);
            this.elimEmpleado.Name = "elimEmpleado";
            this.elimEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.elimEmpleado.Size = new System.Drawing.Size(590, 418);
            this.elimEmpleado.TabIndex = 3;
            this.elimEmpleado.Text = "Eliminar Empleado";
            this.elimEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEliminar
            // 
            this.btnConsultarEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(237)))));
            this.btnConsultarEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEliminar.Location = new System.Drawing.Point(328, 105);
            this.btnConsultarEliminar.Name = "btnConsultarEliminar";
            this.btnConsultarEliminar.Size = new System.Drawing.Size(113, 131);
            this.btnConsultarEliminar.TabIndex = 53;
            this.btnConsultarEliminar.Text = "Buscar";
            this.btnConsultarEliminar.UseVisualStyleBackColor = false;
            this.btnConsultarEliminar.Click += new System.EventHandler(this.btnConsultarEliminar_Click);
            // 
            // txtDepartamentoEliminar
            // 
            this.txtDepartamentoEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartamentoEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDepartamentoEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDepartamentoEliminar.FormattingEnabled = true;
            this.txtDepartamentoEliminar.Location = new System.Drawing.Point(176, 215);
            this.txtDepartamentoEliminar.Name = "txtDepartamentoEliminar";
            this.txtDepartamentoEliminar.Size = new System.Drawing.Size(117, 21);
            this.txtDepartamentoEliminar.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 19);
            this.label15.TabIndex = 51;
            this.label15.Text = "Departamento";
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombreEliminar.Location = new System.Drawing.Point(176, 105);
            this.txtNombreEliminar.Multiline = true;
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(117, 23);
            this.txtNombreEliminar.TabIndex = 50;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(50, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 19);
            this.label25.TabIndex = 49;
            this.label25.Text = "Nombre ";
            // 
            // txtIdEmpleadoEliminar
            // 
            this.txtIdEmpleadoEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdEmpleadoEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtIdEmpleadoEliminar.Location = new System.Drawing.Point(176, 162);
            this.txtIdEmpleadoEliminar.Multiline = true;
            this.txtIdEmpleadoEliminar.Name = "txtIdEmpleadoEliminar";
            this.txtIdEmpleadoEliminar.Size = new System.Drawing.Size(117, 23);
            this.txtIdEmpleadoEliminar.TabIndex = 48;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(50, 166);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 19);
            this.label26.TabIndex = 47;
            this.label26.Text = "Cedula";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(115)))), ((int)(((byte)(237)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(447, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 131);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(20, 269);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.Size = new System.Drawing.Size(540, 134);
            this.dgvEliminar.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(124, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(279, 19);
            this.label27.TabIndex = 44;
            this.label27.Text = "Seleccione la fila que desea eliminar";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(188, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(193, 26);
            this.label28.TabIndex = 43;
            this.label28.Text = "Eliminar Empleado";
            // 
            // dataSetORA
            // 
            this.dataSetORA.DataSetName = "DataSetORA";
            this.dataSetORA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetORABindingSource
            // 
            this.dataSetORABindingSource.DataSource = this.dataSetORA;
            this.dataSetORABindingSource.Position = 0;
            // 
            // pUESTOSBindingSource
            // 
            this.pUESTOSBindingSource.DataMember = "PUESTOS";
            this.pUESTOSBindingSource.DataSource = this.dataSetORABindingSource;
            // 
            // pUESTOSTableAdapter
            // 
            this.pUESTOSTableAdapter.ClearBeforeFill = true;
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(598, 447);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadosForm";
            this.Text = "EmpleadosForm";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.aggEmpleado.ResumeLayout(false);
            this.aggEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.consEmpleado.ResumeLayout(false);
            this.consEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.actEmpleado.ResumeLayout(false);
            this.actEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).EndInit();
            this.elimEmpleado.ResumeLayout(false);
            this.elimEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetORA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetORABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUESTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aggEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.ComboBox comboBoxDepartamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage consEmpleado;
        private System.Windows.Forms.ComboBox txtDepartamento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage actEmpleado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvActualizar;
        private System.Windows.Forms.TabPage elimEmpleado;
        private System.Windows.Forms.ComboBox txtDepartamentoEliminar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtIdEmpleadoEliminar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnConsultarEliminar;
        private System.Windows.Forms.BindingSource dataSetORABindingSource;
        private DataSetORA dataSetORA;
        private System.Windows.Forms.BindingSource pUESTOSBindingSource;
        private DataSetORATableAdapters.PUESTOSTableAdapter pUESTOSTableAdapter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCedulaActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreActualizar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}