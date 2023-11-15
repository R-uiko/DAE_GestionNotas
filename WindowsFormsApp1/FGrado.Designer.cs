namespace WindowsFormsApp1
{
    partial class FGrado
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
            this.idGradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet6 = new WindowsFormsApp1.dbGestionNotasDataSet6();
            this.gradoTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet6TableAdapters.GradoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeAnioCur = new System.Windows.Forms.DateTimePicker();
            this.txtIdGrado = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGradoDataGridViewTextBoxColumn,
            this.idSeccionDataGridViewTextBoxColumn,
            this.anioCursoDataGridViewTextBoxColumn,
            this.aulaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(21, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // idGradoDataGridViewTextBoxColumn
            // 
            this.idGradoDataGridViewTextBoxColumn.DataPropertyName = "idGrado";
            this.idGradoDataGridViewTextBoxColumn.HeaderText = "idGrado";
            this.idGradoDataGridViewTextBoxColumn.Name = "idGradoDataGridViewTextBoxColumn";
            this.idGradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSeccionDataGridViewTextBoxColumn
            // 
            this.idSeccionDataGridViewTextBoxColumn.DataPropertyName = "idSeccion";
            this.idSeccionDataGridViewTextBoxColumn.HeaderText = "idSeccion";
            this.idSeccionDataGridViewTextBoxColumn.Name = "idSeccionDataGridViewTextBoxColumn";
            // 
            // anioCursoDataGridViewTextBoxColumn
            // 
            this.anioCursoDataGridViewTextBoxColumn.DataPropertyName = "anioCurso";
            this.anioCursoDataGridViewTextBoxColumn.HeaderText = "anioCurso";
            this.anioCursoDataGridViewTextBoxColumn.Name = "anioCursoDataGridViewTextBoxColumn";
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            this.aulaDataGridViewTextBoxColumn.DataPropertyName = "aula";
            this.aulaDataGridViewTextBoxColumn.HeaderText = "aula";
            this.aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            // 
            // gradoBindingSource
            // 
            this.gradoBindingSource.DataMember = "Grado";
            this.gradoBindingSource.DataSource = this.dbGestionNotasDataSet6;
            // 
            // dbGestionNotasDataSet6
            // 
            this.dbGestionNotasDataSet6.DataSetName = "dbGestionNotasDataSet6";
            this.dbGestionNotasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradoTableAdapter
            // 
            this.gradoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtIdSeccion);
            this.panel1.Controls.Add(this.txtAula);
            this.panel1.Controls.Add(this.txtIdGrado);
            this.panel1.Controls.Add(this.dateTimeAnioCur);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 173);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año que Cursa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Seccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Grado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Aula";
            // 
            // dateTimeAnioCur
            // 
            this.dateTimeAnioCur.Location = new System.Drawing.Point(16, 104);
            this.dateTimeAnioCur.Name = "dateTimeAnioCur";
            this.dateTimeAnioCur.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAnioCur.TabIndex = 7;
            // 
            // txtIdGrado
            // 
            this.txtIdGrado.Location = new System.Drawing.Point(16, 33);
            this.txtIdGrado.Name = "txtIdGrado";
            this.txtIdGrado.Size = new System.Drawing.Size(100, 20);
            this.txtIdGrado.TabIndex = 8;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(256, 104);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 9;
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(256, 33);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.Size = new System.Drawing.Size(100, 20);
            this.txtIdSeccion.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(63, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "+Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(174, 141);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(281, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(482, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FGrado";
            this.Text = "FGrado";
            this.Load += new System.EventHandler(this.FGrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet6 dbGestionNotasDataSet6;
        private System.Windows.Forms.BindingSource gradoBindingSource;
        private dbGestionNotasDataSet6TableAdapters.GradoTableAdapter gradoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdSeccion;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtIdGrado;
        private System.Windows.Forms.DateTimePicker dateTimeAnioCur;
    }
}