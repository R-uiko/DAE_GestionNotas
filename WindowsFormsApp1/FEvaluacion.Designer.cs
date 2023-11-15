namespace WindowsFormsApp1
{
    partial class FEvaluacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEvaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet5 = new WindowsFormsApp1.dbGestionNotasDataSet5();
            this.evaluacionTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet5TableAdapters.EvaluacionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTrimestre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorNota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdEvaluacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvaluacionDataGridViewTextBoxColumn,
            this.idMateriaDataGridViewTextBoxColumn,
            this.idTrimestreDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.idAlumnoDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn,
            this.promedioDataGridViewTextBoxColumn,
            this.valorNotaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evaluacionBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(42, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(717, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // idEvaluacionDataGridViewTextBoxColumn
            // 
            this.idEvaluacionDataGridViewTextBoxColumn.DataPropertyName = "idEvaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.HeaderText = "idEvaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEvaluacionDataGridViewTextBoxColumn.Name = "idEvaluacionDataGridViewTextBoxColumn";
            this.idEvaluacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEvaluacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTrimestreDataGridViewTextBoxColumn
            // 
            this.idTrimestreDataGridViewTextBoxColumn.DataPropertyName = "idTrimestre";
            this.idTrimestreDataGridViewTextBoxColumn.HeaderText = "idTrimestre";
            this.idTrimestreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTrimestreDataGridViewTextBoxColumn.Name = "idTrimestreDataGridViewTextBoxColumn";
            this.idTrimestreDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            this.idAlumnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "nota1";
            this.nota1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.Width = 125;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "nota2";
            this.nota2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.Width = 125;
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "nota3";
            this.nota3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            this.nota3DataGridViewTextBoxColumn.Width = 125;
            // 
            // promedioDataGridViewTextBoxColumn
            // 
            this.promedioDataGridViewTextBoxColumn.DataPropertyName = "promedio";
            this.promedioDataGridViewTextBoxColumn.HeaderText = "promedio";
            this.promedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.promedioDataGridViewTextBoxColumn.Name = "promedioDataGridViewTextBoxColumn";
            this.promedioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorNotaDataGridViewTextBoxColumn
            // 
            this.valorNotaDataGridViewTextBoxColumn.DataPropertyName = "valorNota";
            this.valorNotaDataGridViewTextBoxColumn.HeaderText = "valorNota";
            this.valorNotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorNotaDataGridViewTextBoxColumn.Name = "valorNotaDataGridViewTextBoxColumn";
            this.valorNotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // evaluacionBindingSource
            // 
            this.evaluacionBindingSource.DataMember = "Evaluacion";
            this.evaluacionBindingSource.DataSource = this.dbGestionNotasDataSet5;
            // 
            // dbGestionNotasDataSet5
            // 
            this.dbGestionNotasDataSet5.DataSetName = "dbGestionNotasDataSet5";
            this.dbGestionNotasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluacionTableAdapter
            // 
            this.evaluacionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "EVALUACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(313, 37);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(76, 20);
            this.txtMateria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Trimestre";
            // 
            // txtIdTrimestre
            // 
            this.txtIdTrimestre.Location = new System.Drawing.Point(600, 37);
            this.txtIdTrimestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdTrimestre.Name = "txtIdTrimestre";
            this.txtIdTrimestre.ReadOnly = true;
            this.txtIdTrimestre.Size = new System.Drawing.Size(76, 20);
            this.txtIdTrimestre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(16, 101);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtIdUsuario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Alumno";
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(313, 101);
            this.txtIdAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.ReadOnly = true;
            this.txtIdAlumno.Size = new System.Drawing.Size(76, 20);
            this.txtIdAlumno.TabIndex = 9;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(16, 164);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(76, 20);
            this.txtNota1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nota 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nota 2";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(313, 167);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(76, 20);
            this.txtNota2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(597, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nota 3";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(600, 166);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(76, 20);
            this.txtNota3.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Promedio";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(153, 217);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(310, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Valor Nota";
            // 
            // txtValorNota
            // 
            this.txtValorNota.Location = new System.Drawing.Point(313, 254);
            this.txtValorNota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorNota.Name = "txtValorNota";
            this.txtValorNota.Size = new System.Drawing.Size(76, 20);
            this.txtValorNota.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(457, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(460, 217);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(76, 20);
            this.txtEstado.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "ID Evaluación";
            // 
            // txtIdEvaluacion
            // 
            this.txtIdEvaluacion.Location = new System.Drawing.Point(16, 37);
            this.txtIdEvaluacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEvaluacion.Name = "txtIdEvaluacion";
            this.txtIdEvaluacion.ReadOnly = true;
            this.txtIdEvaluacion.Size = new System.Drawing.Size(76, 20);
            this.txtIdEvaluacion.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMateria);
            this.panel1.Controls.Add(this.txtValorNota);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtIdEvaluacion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtIdTrimestre);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIdUsuario);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNota3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIdAlumno);
            this.panel1.Controls.Add(this.txtNota2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNota1);
            this.panel1.Location = new System.Drawing.Point(42, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 316);
            this.panel1.TabIndex = 25;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(313, 284);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 30);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(472, 284);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 30);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(159, 284);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 29);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEvaluacion";
            this.Load += new System.EventHandler(this.FEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet5 dbGestionNotasDataSet5;
        private System.Windows.Forms.BindingSource evaluacionBindingSource;
        private dbGestionNotasDataSet5TableAdapters.EvaluacionTableAdapter evaluacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTrimestre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorNota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdEvaluacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
    }
}