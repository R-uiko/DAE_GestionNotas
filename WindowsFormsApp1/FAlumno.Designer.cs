namespace WindowsFormsApp1
{
    partial class FAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet = new WindowsFormsApp1.dbGestionNotasDataSet();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rFemenino = new System.Windows.Forms.RadioButton();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.txtIdResponsable = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.rMasculino = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet1 = new WindowsFormsApp1.dbGestionNotasDataSet1();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeFechaAct = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxAlumno = new System.Windows.Forms.PictureBox();
            this.seccionTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSetTableAdapters.SeccionTableAdapter();
            this.alumnoTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet1TableAdapters.AlumnoTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Alumno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.txtIdSeccion);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.rFemenino);
            this.panel1.Controls.Add(this.txtNombreResponsable);
            this.panel1.Controls.Add(this.txtIdResponsable);
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.txtNombreAlumno);
            this.panel1.Controls.Add(this.txtIdAlumno);
            this.panel1.Controls.Add(this.rMasculino);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(17, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 292);
            this.panel1.TabIndex = 6;
            // 
            // seccionBindingSource
            // 
            this.seccionBindingSource.DataMember = "Seccion";
            this.seccionBindingSource.DataSource = this.dbGestionNotasDataSet;
            // 
            // dbGestionNotasDataSet
            // 
            this.dbGestionNotasDataSet.DataSetName = "dbGestionNotasDataSet";
            this.dbGestionNotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(260, 88);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(145, 20);
            this.dtpFechaNacimiento.TabIndex = 23;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // rFemenino
            // 
            this.rFemenino.AutoSize = true;
            this.rFemenino.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFemenino.Location = new System.Drawing.Point(55, 106);
            this.rFemenino.Name = "rFemenino";
            this.rFemenino.Size = new System.Drawing.Size(31, 20);
            this.rFemenino.TabIndex = 22;
            this.rFemenino.TabStop = true;
            this.rFemenino.Text = "F";
            this.rFemenino.UseVisualStyleBackColor = true;
            this.rFemenino.CheckedChanged += new System.EventHandler(this.rFemenino_CheckedChanged);
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.Location = new System.Drawing.Point(165, 221);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(240, 20);
            this.txtNombreResponsable.TabIndex = 20;
            this.txtNombreResponsable.TextChanged += new System.EventHandler(this.txtNombreResponsable_TextChanged);
            // 
            // txtIdResponsable
            // 
            this.txtIdResponsable.Location = new System.Drawing.Point(104, 188);
            this.txtIdResponsable.Name = "txtIdResponsable";
            this.txtIdResponsable.ReadOnly = true;
            this.txtIdResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtIdResponsable.TabIndex = 19;
            this.txtIdResponsable.TextChanged += new System.EventHandler(this.txtIdResponsable_TextChanged);
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(67, 152);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(100, 20);
            this.txtGrado.TabIndex = 18;
            this.txtGrado.TextChanged += new System.EventHandler(this.txtGrado_TextChanged);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(78, 54);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(295, 20);
            this.txtNombreAlumno.TabIndex = 17;
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(78, 16);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.ReadOnly = true;
            this.txtIdAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtIdAlumno.TabIndex = 16;
            // 
            // rMasculino
            // 
            this.rMasculino.AutoSize = true;
            this.rMasculino.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMasculino.Location = new System.Drawing.Point(12, 106);
            this.rMasculino.Name = "rMasculino";
            this.rMasculino.Size = new System.Drawing.Size(34, 20);
            this.rMasculino.TabIndex = 14;
            this.rMasculino.TabStop = true;
            this.rMasculino.Text = "M";
            this.rMasculino.UseVisualStyleBackColor = true;
            this.rMasculino.CheckedChanged += new System.EventHandler(this.rMasculino_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "ID Sección";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre Responsable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID Responsable";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AutoGenerateColumns = false;
            this.dgvAlumno.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.nombreAlumnosDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.gradoDataGridViewTextBoxColumn,
            this.idResponsableDataGridViewTextBoxColumn,
            this.nombreResponsableDataGridViewTextBoxColumn,
            this.idSeccionDataGridViewTextBoxColumn,
            this.sexoAlumnoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.fechaActualDataGridViewTextBoxColumn});
            this.dgvAlumno.DataSource = this.alumnoBindingSource;
            this.dgvAlumno.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvAlumno.Location = new System.Drawing.Point(18, 349);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.Size = new System.Drawing.Size(671, 173);
            this.dgvAlumno.TabIndex = 11;
            this.dgvAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumno_CellContentClick);
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            this.idAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreAlumnosDataGridViewTextBoxColumn
            // 
            this.nombreAlumnosDataGridViewTextBoxColumn.DataPropertyName = "nombreAlumnos";
            this.nombreAlumnosDataGridViewTextBoxColumn.HeaderText = "nombreAlumnos";
            this.nombreAlumnosDataGridViewTextBoxColumn.Name = "nombreAlumnosDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            // 
            // idResponsableDataGridViewTextBoxColumn
            // 
            this.idResponsableDataGridViewTextBoxColumn.DataPropertyName = "idResponsable";
            this.idResponsableDataGridViewTextBoxColumn.HeaderText = "idResponsable";
            this.idResponsableDataGridViewTextBoxColumn.Name = "idResponsableDataGridViewTextBoxColumn";
            // 
            // nombreResponsableDataGridViewTextBoxColumn
            // 
            this.nombreResponsableDataGridViewTextBoxColumn.DataPropertyName = "nombreResponsable";
            this.nombreResponsableDataGridViewTextBoxColumn.HeaderText = "nombreResponsable";
            this.nombreResponsableDataGridViewTextBoxColumn.Name = "nombreResponsableDataGridViewTextBoxColumn";
            // 
            // idSeccionDataGridViewTextBoxColumn
            // 
            this.idSeccionDataGridViewTextBoxColumn.DataPropertyName = "idSeccion";
            this.idSeccionDataGridViewTextBoxColumn.HeaderText = "idSeccion";
            this.idSeccionDataGridViewTextBoxColumn.Name = "idSeccionDataGridViewTextBoxColumn";
            // 
            // sexoAlumnoDataGridViewTextBoxColumn
            // 
            this.sexoAlumnoDataGridViewTextBoxColumn.DataPropertyName = "sexoAlumno";
            this.sexoAlumnoDataGridViewTextBoxColumn.HeaderText = "sexoAlumno";
            this.sexoAlumnoDataGridViewTextBoxColumn.Name = "sexoAlumnoDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // fechaActualDataGridViewTextBoxColumn
            // 
            this.fechaActualDataGridViewTextBoxColumn.DataPropertyName = "FechaActual";
            this.fechaActualDataGridViewTextBoxColumn.HeaderText = "FechaActual";
            this.fechaActualDataGridViewTextBoxColumn.Name = "fechaActualDataGridViewTextBoxColumn";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.dbGestionNotasDataSet1;
            // 
            // dbGestionNotasDataSet1
            // 
            this.dbGestionNotasDataSet1.DataSetName = "dbGestionNotasDataSet1";
            this.dbGestionNotasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFoto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFoto.Location = new System.Drawing.Point(500, 210);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(128, 23);
            this.btnFoto.TabIndex = 13;
            this.btnFoto.Text = "+ Elegir Archivo";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(28, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Fecha Actual";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 14);
            this.label12.TabIndex = 16;
            this.label12.Text = "Datos ";
            // 
            // dateTimeFechaAct
            // 
            this.dateTimeFechaAct.Location = new System.Drawing.Point(526, 269);
            this.dateTimeFechaAct.Name = "dateTimeFechaAct";
            this.dateTimeFechaAct.Size = new System.Drawing.Size(151, 20);
            this.dateTimeFechaAct.TabIndex = 17;
            // 
            // pictureBoxAlumno
            // 
            this.pictureBoxAlumno.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlumno.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.foto1;
            this.pictureBoxAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlumno.Image = global::WindowsFormsApp1.Properties.Resources.foto;
            this.pictureBoxAlumno.Location = new System.Drawing.Point(500, 51);
            this.pictureBoxAlumno.Name = "pictureBoxAlumno";
            this.pictureBoxAlumno.Size = new System.Drawing.Size(143, 145);
            this.pictureBoxAlumno.TabIndex = 12;
            this.pictureBoxAlumno.TabStop = false;
            this.pictureBoxAlumno.Click += new System.EventHandler(this.pictureBoxAlumno_Click);
            // 
            // seccionTableAdapter
            // 
            this.seccionTableAdapter.ClearBeforeFill = true;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(164, 259);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(305, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(260, 125);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.ReadOnly = true;
            this.txtIdSeccion.Size = new System.Drawing.Size(100, 20);
            this.txtIdSeccion.TabIndex = 24;
            // 
            // FAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(700, 534);
            this.Controls.Add(this.dateTimeFechaAct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pictureBoxAlumno);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAlumno";
            this.Load += new System.EventHandler(this.FAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.PictureBox pictureBoxAlumno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rMasculino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.TextBox txtIdResponsable;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.RadioButton rFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimeFechaAct;
        private dbGestionNotasDataSet dbGestionNotasDataSet;
        private System.Windows.Forms.BindingSource seccionBindingSource;
        private dbGestionNotasDataSetTableAdapters.SeccionTableAdapter seccionTableAdapter;
        private dbGestionNotasDataSet1 dbGestionNotasDataSet1;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private dbGestionNotasDataSet1TableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdSeccion;
    }
}