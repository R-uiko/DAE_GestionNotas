namespace WindowsFormsApp1
{
    partial class FDetalleMateria
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
            this.idDetallemateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogoMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet3 = new WindowsFormsApp1.dbGestionNotasDataSet3();
            this.detalle_MateriaTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet3TableAdapters.Detalle_MateriaTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDDetalleMateria = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtIdEvaluacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.cmbCatalogoM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetallemateriaDataGridViewTextBoxColumn,
            this.idMateriaDataGridViewTextBoxColumn,
            this.idEvaluacionDataGridViewTextBoxColumn,
            this.idSeccionDataGridViewTextBoxColumn,
            this.catalogoMateriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detalleMateriaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(34, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDetallemateriaDataGridViewTextBoxColumn
            // 
            this.idDetallemateriaDataGridViewTextBoxColumn.DataPropertyName = "idDetalle_materia";
            this.idDetallemateriaDataGridViewTextBoxColumn.HeaderText = "idDetalle_materia";
            this.idDetallemateriaDataGridViewTextBoxColumn.Name = "idDetallemateriaDataGridViewTextBoxColumn";
            this.idDetallemateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            // 
            // idEvaluacionDataGridViewTextBoxColumn
            // 
            this.idEvaluacionDataGridViewTextBoxColumn.DataPropertyName = "idEvaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.HeaderText = "idEvaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.Name = "idEvaluacionDataGridViewTextBoxColumn";
            // 
            // idSeccionDataGridViewTextBoxColumn
            // 
            this.idSeccionDataGridViewTextBoxColumn.DataPropertyName = "idSeccion";
            this.idSeccionDataGridViewTextBoxColumn.HeaderText = "idSeccion";
            this.idSeccionDataGridViewTextBoxColumn.Name = "idSeccionDataGridViewTextBoxColumn";
            // 
            // catalogoMateriaDataGridViewTextBoxColumn
            // 
            this.catalogoMateriaDataGridViewTextBoxColumn.DataPropertyName = "catalogoMateria";
            this.catalogoMateriaDataGridViewTextBoxColumn.HeaderText = "catalogoMateria";
            this.catalogoMateriaDataGridViewTextBoxColumn.Name = "catalogoMateriaDataGridViewTextBoxColumn";
            // 
            // detalleMateriaBindingSource
            // 
            this.detalleMateriaBindingSource.DataMember = "Detalle_Materia";
            this.detalleMateriaBindingSource.DataSource = this.dbGestionNotasDataSet3;
            // 
            // dbGestionNotasDataSet3
            // 
            this.dbGestionNotasDataSet3.DataSetName = "dbGestionNotasDataSet3";
            this.dbGestionNotasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalle_MateriaTableAdapter
            // 
            this.detalle_MateriaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(54, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.cmbCatalogoM);
            this.panel1.Controls.Add(this.txtIdSeccion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtIdEvaluacion);
            this.panel1.Controls.Add(this.txtMateria);
            this.panel1.Controls.Add(this.txtIDDetalleMateria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(34, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 180);
            this.panel1.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(215, 154);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(370, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Detalle Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Evaluacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Seccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "DETALLE MATERIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Materia";
            // 
            // txtIDDetalleMateria
            // 
            this.txtIDDetalleMateria.Location = new System.Drawing.Point(44, 33);
            this.txtIDDetalleMateria.Name = "txtIDDetalleMateria";
            this.txtIDDetalleMateria.ReadOnly = true;
            this.txtIDDetalleMateria.Size = new System.Drawing.Size(100, 20);
            this.txtIDDetalleMateria.TabIndex = 9;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(215, 33);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 10;
            // 
            // txtIdEvaluacion
            // 
            this.txtIdEvaluacion.Location = new System.Drawing.Point(404, 33);
            this.txtIdEvaluacion.Name = "txtIdEvaluacion";
            this.txtIdEvaluacion.ReadOnly = true;
            this.txtIdEvaluacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdEvaluacion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Catalogo Materia";
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(44, 104);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.ReadOnly = true;
            this.txtIdSeccion.Size = new System.Drawing.Size(100, 20);
            this.txtIdSeccion.TabIndex = 13;
            // 
            // cmbCatalogoM
            // 
            this.cmbCatalogoM.FormattingEnabled = true;
            this.cmbCatalogoM.Location = new System.Drawing.Point(215, 104);
            this.cmbCatalogoM.Name = "cmbCatalogoM";
            this.cmbCatalogoM.Size = new System.Drawing.Size(121, 21);
            this.cmbCatalogoM.TabIndex = 14;
            // 
            // FDetalleMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Name = "FDetalleMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDetalleMateria";
            this.Load += new System.EventHandler(this.FDetalleMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet3 dbGestionNotasDataSet3;
        private System.Windows.Forms.BindingSource detalleMateriaBindingSource;
        private dbGestionNotasDataSet3TableAdapters.Detalle_MateriaTableAdapter detalle_MateriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetallemateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogoMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSeccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdEvaluacion;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtIDDetalleMateria;
        private System.Windows.Forms.ComboBox cmbCatalogoM;
    }
}