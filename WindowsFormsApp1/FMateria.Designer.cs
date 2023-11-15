namespace WindowsFormsApp1
{
    partial class FMateria
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
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet7 = new WindowsFormsApp1.dbGestionNotasDataSet7();
            this.materiaTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet7TableAdapters.MateriaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateriaDataGridViewTextBoxColumn,
            this.idDocenteDataGridViewTextBoxColumn,
            this.nombreMateriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materiaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(38, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(433, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMateriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDocenteDataGridViewTextBoxColumn
            // 
            this.idDocenteDataGridViewTextBoxColumn.DataPropertyName = "idDocente";
            this.idDocenteDataGridViewTextBoxColumn.HeaderText = "idDocente";
            this.idDocenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDocenteDataGridViewTextBoxColumn.Name = "idDocenteDataGridViewTextBoxColumn";
            this.idDocenteDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreMateriaDataGridViewTextBoxColumn
            // 
            this.nombreMateriaDataGridViewTextBoxColumn.DataPropertyName = "nombreMateria";
            this.nombreMateriaDataGridViewTextBoxColumn.HeaderText = "nombreMateria";
            this.nombreMateriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMateriaDataGridViewTextBoxColumn.Name = "nombreMateriaDataGridViewTextBoxColumn";
            this.nombreMateriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.dbGestionNotasDataSet7;
            // 
            // dbGestionNotasDataSet7
            // 
            this.dbGestionNotasDataSet7.DataSetName = "dbGestionNotasDataSet7";
            this.dbGestionNotasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MATERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Materia";
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Location = new System.Drawing.Point(46, 37);
            this.txtIdMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.ReadOnly = true;
            this.txtIdMateria.Size = new System.Drawing.Size(76, 20);
            this.txtIdMateria.TabIndex = 5;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(46, 96);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(76, 20);
            this.txtNombreMateria.TabIndex = 6;
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.Location = new System.Drawing.Point(302, 37);
            this.txtIdDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.Size = new System.Drawing.Size(76, 20);
            this.txtIdDocente.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(50, 139);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "+Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Docente";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(175, 139);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(306, 139);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Registrar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtIdMateria);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreMateria);
            this.panel1.Controls.Add(this.txtIdDocente);
            this.panel1.Location = new System.Drawing.Point(38, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 174);
            this.panel1.TabIndex = 13;
            // 
            // FMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMateria";
            this.Load += new System.EventHandler(this.FMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet7 dbGestionNotasDataSet7;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private dbGestionNotasDataSet7TableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtIdDocente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}