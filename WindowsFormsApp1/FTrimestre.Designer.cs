namespace WindowsFormsApp1
{
    partial class FTrimestre
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
            this.idTrimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTrimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet8 = new WindowsFormsApp1.dbGestionNotasDataSet8();
            this.trimestreTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet8TableAdapters.TrimestreTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrimestre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNTrimestre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAñoTrimestre = new System.Windows.Forms.TextBox();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrimestreDataGridViewTextBoxColumn,
            this.nTrimestreDataGridViewTextBoxColumn,
            this.anioTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trimestreBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(26, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(430, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // idTrimestreDataGridViewTextBoxColumn
            // 
            this.idTrimestreDataGridViewTextBoxColumn.DataPropertyName = "idTrimestre";
            this.idTrimestreDataGridViewTextBoxColumn.HeaderText = "idTrimestre";
            this.idTrimestreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTrimestreDataGridViewTextBoxColumn.Name = "idTrimestreDataGridViewTextBoxColumn";
            this.idTrimestreDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrimestreDataGridViewTextBoxColumn.Width = 125;
            // 
            // nTrimestreDataGridViewTextBoxColumn
            // 
            this.nTrimestreDataGridViewTextBoxColumn.DataPropertyName = "nTrimestre";
            this.nTrimestreDataGridViewTextBoxColumn.HeaderText = "nTrimestre";
            this.nTrimestreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nTrimestreDataGridViewTextBoxColumn.Name = "nTrimestreDataGridViewTextBoxColumn";
            this.nTrimestreDataGridViewTextBoxColumn.Width = 125;
            // 
            // anioTDataGridViewTextBoxColumn
            // 
            this.anioTDataGridViewTextBoxColumn.DataPropertyName = "anioT";
            this.anioTDataGridViewTextBoxColumn.HeaderText = "anioT";
            this.anioTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anioTDataGridViewTextBoxColumn.Name = "anioTDataGridViewTextBoxColumn";
            this.anioTDataGridViewTextBoxColumn.Width = 125;
            // 
            // trimestreBindingSource
            // 
            this.trimestreBindingSource.DataMember = "Trimestre";
            this.trimestreBindingSource.DataSource = this.dbGestionNotasDataSet8;
            // 
            // dbGestionNotasDataSet8
            // 
            this.dbGestionNotasDataSet8.DataSetName = "dbGestionNotasDataSet8";
            this.dbGestionNotasDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trimestreTableAdapter
            // 
            this.trimestreTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRIMESTRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Trimestre";
            // 
            // txtTrimestre
            // 
            this.txtTrimestre.Location = new System.Drawing.Point(33, 46);
            this.txtTrimestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrimestre.Name = "txtTrimestre";
            this.txtTrimestre.Size = new System.Drawing.Size(76, 20);
            this.txtTrimestre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "N Trimestre";
            // 
            // txtNTrimestre
            // 
            this.txtNTrimestre.Location = new System.Drawing.Point(33, 96);
            this.txtNTrimestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNTrimestre.Name = "txtNTrimestre";
            this.txtNTrimestre.Size = new System.Drawing.Size(76, 20);
            this.txtNTrimestre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año Trimestre";
            // 
            // txtAñoTrimestre
            // 
            this.txtAñoTrimestre.Location = new System.Drawing.Point(317, 46);
            this.txtAñoTrimestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAñoTrimestre.Name = "txtAñoTrimestre";
            this.txtAñoTrimestre.Size = new System.Drawing.Size(76, 20);
            this.txtAñoTrimestre.TabIndex = 7;
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(67, 147);
            this.btnRegistrarAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(74, 26);
            this.btnRegistrarAsistencia.TabIndex = 10;
            this.btnRegistrarAsistencia.Text = "Registrar";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = false;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegistrarAsistencia);
            this.panel1.Controls.Add(this.txtTrimestre);
            this.panel1.Controls.Add(this.txtAñoTrimestre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNTrimestre);
            this.panel1.Location = new System.Drawing.Point(26, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 175);
            this.panel1.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(189, 147);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(74, 26);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actuallizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(319, 147);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 26);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FTrimestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTrimestre";
            this.Load += new System.EventHandler(this.FTrimestre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet8 dbGestionNotasDataSet8;
        private System.Windows.Forms.BindingSource trimestreBindingSource;
        private dbGestionNotasDataSet8TableAdapters.TrimestreTableAdapter trimestreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTrimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrimestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNTrimestre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAñoTrimestre;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
    }
}