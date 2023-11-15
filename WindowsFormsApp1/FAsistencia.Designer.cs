namespace WindowsFormsApp1
{
    partial class FAsistencia
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
            this.idAsistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoAsistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet2 = new WindowsFormsApp1.dbGestionNotasDataSet2();
            this.asistenciaTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet2TableAdapters.AsistenciaTableAdapter();
            this.txtIdAsistencia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPeriodoAsis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsistenciaDataGridViewTextBoxColumn,
            this.idAlumnoDataGridViewTextBoxColumn,
            this.idDocenteDataGridViewTextBoxColumn,
            this.periodoAsistenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asistenciaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAsistenciaDataGridViewTextBoxColumn
            // 
            this.idAsistenciaDataGridViewTextBoxColumn.DataPropertyName = "idAsistencia";
            this.idAsistenciaDataGridViewTextBoxColumn.HeaderText = "idAsistencia";
            this.idAsistenciaDataGridViewTextBoxColumn.Name = "idAsistenciaDataGridViewTextBoxColumn";
            this.idAsistenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "idAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            // 
            // idDocenteDataGridViewTextBoxColumn
            // 
            this.idDocenteDataGridViewTextBoxColumn.DataPropertyName = "idDocente";
            this.idDocenteDataGridViewTextBoxColumn.HeaderText = "idDocente";
            this.idDocenteDataGridViewTextBoxColumn.Name = "idDocenteDataGridViewTextBoxColumn";
            // 
            // periodoAsistenciaDataGridViewTextBoxColumn
            // 
            this.periodoAsistenciaDataGridViewTextBoxColumn.DataPropertyName = "periodoAsistencia";
            this.periodoAsistenciaDataGridViewTextBoxColumn.HeaderText = "periodoAsistencia";
            this.periodoAsistenciaDataGridViewTextBoxColumn.Name = "periodoAsistenciaDataGridViewTextBoxColumn";
            // 
            // asistenciaBindingSource
            // 
            this.asistenciaBindingSource.DataMember = "Asistencia";
            this.asistenciaBindingSource.DataSource = this.dbGestionNotasDataSet2;
            // 
            // dbGestionNotasDataSet2
            // 
            this.dbGestionNotasDataSet2.DataSetName = "dbGestionNotasDataSet2";
            this.dbGestionNotasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistenciaTableAdapter
            // 
            this.asistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdAsistencia
            // 
            this.txtIdAsistencia.Location = new System.Drawing.Point(56, 30);
            this.txtIdAsistencia.Name = "txtIdAsistencia";
            this.txtIdAsistencia.ReadOnly = true;
            this.txtIdAsistencia.Size = new System.Drawing.Size(100, 20);
            this.txtIdAsistencia.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.cmbPeriodoAsis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIdDocente);
            this.panel1.Controls.Add(this.txtIdAlumno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtIdAsistencia);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 165);
            this.panel1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(76, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(188, 138);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(293, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Asistencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Alumno";
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(312, 30);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.ReadOnly = true;
            this.txtIdAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtIdAlumno.TabIndex = 7;
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.Location = new System.Drawing.Point(56, 94);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.ReadOnly = true;
            this.txtIdDocente.Size = new System.Drawing.Size(100, 20);
            this.txtIdDocente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Periodo Asistencia";
            // 
            // cmbPeriodoAsis
            // 
            this.cmbPeriodoAsis.FormattingEnabled = true;
            this.cmbPeriodoAsis.Location = new System.Drawing.Point(312, 94);
            this.cmbPeriodoAsis.Name = "cmbPeriodoAsis";
            this.cmbPeriodoAsis.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodoAsis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "ASISTENCIA";
            // 
            // FAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FAsistencia";
            this.Text = "FAsistencia";
            this.Load += new System.EventHandler(this.FAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet2 dbGestionNotasDataSet2;
        private System.Windows.Forms.BindingSource asistenciaBindingSource;
        private dbGestionNotasDataSet2TableAdapters.AsistenciaTableAdapter asistenciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoAsistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIdAsistencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdDocente;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPeriodoAsis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}