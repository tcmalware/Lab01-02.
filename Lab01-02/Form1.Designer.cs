namespace Lab01_02
{
    partial class formulario
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.textname = new System.Windows.Forms.TextBox();
            this.textapellido = new System.Windows.Forms.TextBox();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.LinkLabel();
            this.lbldni = new System.Windows.Forms.Label();
            this.textdni = new System.Windows.Forms.TextBox();
            this.cbactivo = new System.Windows.Forms.CheckBox();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.comboxdepa = new System.Windows.Forms.ComboBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.comboboxcargo = new System.Windows.Forms.ComboBox();
            this.lblfoto = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmantenimiento = new System.Windows.Forms.Label();
            this.gbdatos.SuspendLayout();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.cbactivo);
            this.gbdatos.Controls.Add(this.textdni);
            this.gbdatos.Controls.Add(this.lbldni);
            this.gbdatos.Controls.Add(this.txtcodigo);
            this.gbdatos.Controls.Add(this.textemail);
            this.gbdatos.Controls.Add(this.texttelefono);
            this.gbdatos.Controls.Add(this.textdireccion);
            this.gbdatos.Controls.Add(this.textapellido);
            this.gbdatos.Controls.Add(this.textname);
            this.gbdatos.Controls.Add(this.dtpfecha);
            this.gbdatos.Controls.Add(this.lblfecha);
            this.gbdatos.Controls.Add(this.lblemail);
            this.gbdatos.Controls.Add(this.lbltelefono);
            this.gbdatos.Controls.Add(this.lbldireccion);
            this.gbdatos.Controls.Add(this.lblapellido);
            this.gbdatos.Controls.Add(this.lblname);
            this.gbdatos.Controls.Add(this.lblcodigo);
            this.gbdatos.Location = new System.Drawing.Point(21, 59);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(568, 212);
            this.gbdatos.TabIndex = 0;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos Personales";
            this.gbdatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbinfo
            // 
            this.gbinfo.Controls.Add(this.imagen);
            this.gbinfo.Controls.Add(this.lblfoto);
            this.gbinfo.Controls.Add(this.comboboxcargo);
            this.gbinfo.Controls.Add(this.lblcargo);
            this.gbinfo.Controls.Add(this.comboxdepa);
            this.gbinfo.Controls.Add(this.lbldepartamento);
            this.gbinfo.Location = new System.Drawing.Point(621, 59);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(319, 212);
            this.gbinfo.TabIndex = 1;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "Información adicional";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(31, 23);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(27, 45);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Nombre:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(27, 72);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(47, 13);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(19, 99);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(55, 13);
            this.lbldireccion.TabIndex = 3;
            this.lbldireccion.Text = "Dirección:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(22, 124);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(52, 13);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "Teléfono:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(39, 150);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(11, 175);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(63, 13);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "Fecha Nac:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(80, 172);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 7;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(80, 43);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(200, 20);
            this.textname.TabIndex = 8;
            // 
            // textapellido
            // 
            this.textapellido.Location = new System.Drawing.Point(80, 69);
            this.textapellido.Name = "textapellido";
            this.textapellido.Size = new System.Drawing.Size(361, 20);
            this.textapellido.TabIndex = 9;
            // 
            // textdireccion
            // 
            this.textdireccion.Location = new System.Drawing.Point(80, 95);
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(361, 20);
            this.textdireccion.TabIndex = 10;
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(80, 121);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(100, 20);
            this.texttelefono.TabIndex = 11;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(80, 147);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(361, 20);
            this.textemail.TabIndex = 12;
            // 
            // txtcodigo
            // 
            this.txtcodigo.AutoSize = true;
            this.txtcodigo.Location = new System.Drawing.Point(80, 23);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(45, 13);
            this.txtcodigo.TabIndex = 13;
            this.txtcodigo.TabStop = true;
            this.txtcodigo.Text = "U10023";
            this.txtcodigo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(307, 47);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(29, 13);
            this.lbldni.TabIndex = 14;
            this.lbldni.Text = "DNI:";
            this.lbldni.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textdni
            // 
            this.textdni.Location = new System.Drawing.Point(340, 43);
            this.textdni.Name = "textdni";
            this.textdni.Size = new System.Drawing.Size(101, 20);
            this.textdni.TabIndex = 15;
            // 
            // cbactivo
            // 
            this.cbactivo.AutoSize = true;
            this.cbactivo.Location = new System.Drawing.Point(375, 172);
            this.cbactivo.Name = "cbactivo";
            this.cbactivo.Size = new System.Drawing.Size(56, 17);
            this.cbactivo.TabIndex = 16;
            this.cbactivo.Text = "Activo";
            this.cbactivo.UseVisualStyleBackColor = true;
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Location = new System.Drawing.Point(60, 45);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(77, 13);
            this.lbldepartamento.TabIndex = 0;
            this.lbldepartamento.Text = "Departamento:";
            // 
            // comboxdepa
            // 
            this.comboxdepa.FormattingEnabled = true;
            this.comboxdepa.Location = new System.Drawing.Point(151, 43);
            this.comboxdepa.Name = "comboxdepa";
            this.comboxdepa.Size = new System.Drawing.Size(121, 21);
            this.comboxdepa.TabIndex = 1;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(99, 74);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(38, 13);
            this.lblcargo.TabIndex = 2;
            this.lblcargo.Text = "Cargo:";
            // 
            // comboboxcargo
            // 
            this.comboboxcargo.FormattingEnabled = true;
            this.comboboxcargo.Location = new System.Drawing.Point(151, 70);
            this.comboboxcargo.Name = "comboboxcargo";
            this.comboboxcargo.Size = new System.Drawing.Size(121, 21);
            this.comboboxcargo.TabIndex = 3;
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(78, 100);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(59, 13);
            this.lblfoto.TabIndex = 4;
            this.lblfoto.Text = "Fotografía:";
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(171, 100);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(98, 92);
            this.imagen.TabIndex = 5;
            this.imagen.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnagregar.Location = new System.Drawing.Point(462, 277);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(572, 277);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(684, 277);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(792, 276);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.DNI,
            this.Nombre,
            this.Apellidos,
            this.Dirección,
            this.Teléfono,
            this.Email,
            this.FecNac,
            this.Departamento});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 320);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(949, 178);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // FecNac
            // 
            this.FecNac.HeaderText = "FecNac";
            this.FecNac.Name = "FecNac";
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // lblmantenimiento
            // 
            this.lblmantenimiento.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblmantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmantenimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmantenimiento.Location = new System.Drawing.Point(0, 0);
            this.lblmantenimiento.Name = "lblmantenimiento";
            this.lblmantenimiento.Padding = new System.Windows.Forms.Padding(7);
            this.lblmantenimiento.Size = new System.Drawing.Size(972, 46);
            this.lblmantenimiento.TabIndex = 7;
            this.lblmantenimiento.Text = "Mantenimiento de Usuarios";
            this.lblmantenimiento.Click += new System.EventHandler(this.lblmantenimiento_Click);
            // 
            // formulario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(973, 533);
            this.Controls.Add(this.lblmantenimiento);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.gbinfo);
            this.Controls.Add(this.gbdatos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.LinkLabel txtcodigo;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.TextBox textapellido;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.CheckBox cbactivo;
        private System.Windows.Forms.TextBox textdni;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.ComboBox comboxdepa;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.ComboBox comboboxcargo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.Label lblmantenimiento;
    }
}

