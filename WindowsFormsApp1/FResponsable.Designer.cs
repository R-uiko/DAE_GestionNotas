namespace WindowsFormsApp1
{
    partial class FResponsable
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
            this.idResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGestionNotasDataSet9 = new WindowsFormsApp1.dbGestionNotasDataSet9();
            this.responsableTableAdapter = new WindowsFormsApp1.dbGestionNotasDataSet9TableAdapters.ResponsableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdResponsable = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreResponsable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet9)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idResponsableDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.nombreResponsableDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.responsableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(44, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(538, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idResponsableDataGridViewTextBoxColumn
            // 
            this.idResponsableDataGridViewTextBoxColumn.DataPropertyName = "idResponsable";
            this.idResponsableDataGridViewTextBoxColumn.HeaderText = "idResponsable";
            this.idResponsableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idResponsableDataGridViewTextBoxColumn.Name = "idResponsableDataGridViewTextBoxColumn";
            this.idResponsableDataGridViewTextBoxColumn.ReadOnly = true;
            this.idResponsableDataGridViewTextBoxColumn.Width = 125;
            // 
            // dUIDataGridViewTextBoxColumn
            // 
            this.dUIDataGridViewTextBoxColumn.DataPropertyName = "DUI";
            this.dUIDataGridViewTextBoxColumn.HeaderText = "DUI";
            this.dUIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dUIDataGridViewTextBoxColumn.Name = "dUIDataGridViewTextBoxColumn";
            this.dUIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreResponsableDataGridViewTextBoxColumn
            // 
            this.nombreResponsableDataGridViewTextBoxColumn.DataPropertyName = "nombreResponsable";
            this.nombreResponsableDataGridViewTextBoxColumn.HeaderText = "nombreResponsable";
            this.nombreResponsableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreResponsableDataGridViewTextBoxColumn.Name = "nombreResponsableDataGridViewTextBoxColumn";
            this.nombreResponsableDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // responsableBindingSource
            // 
            this.responsableBindingSource.DataMember = "Responsable";
            this.responsableBindingSource.DataSource = this.dbGestionNotasDataSet9;
            // 
            // dbGestionNotasDataSet9
            // 
            this.dbGestionNotasDataSet9.DataSetName = "dbGestionNotasDataSet9";
            this.dbGestionNotasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsableTableAdapter
            // 
            this.responsableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESPONSABLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Responsable";
            // 
            // txtIdResponsable
            // 
            this.txtIdResponsable.Location = new System.Drawing.Point(19, 33);
            this.txtIdResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdResponsable.Name = "txtIdResponsable";
            this.txtIdResponsable.Size = new System.Drawing.Size(76, 20);
            this.txtIdResponsable.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 61);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 16);
            this.label.TabIndex = 4;
            this.label.Text = "DUI";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(19, 79);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(76, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre Responsable";
            // 
            // txtNombreResponsable
            // 
            this.txtNombreResponsable.Location = new System.Drawing.Point(19, 125);
            this.txtNombreResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreResponsable.Name = "txtNombreResponsable";
            this.txtNombreResponsable.Size = new System.Drawing.Size(76, 20);
            this.txtNombreResponsable.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(397, 33);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(76, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(397, 94);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(80, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(112, 157);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(227, 157);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 23);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(346, 157);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtIdResponsable);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.txtNombreResponsable);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.txtDUI);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Location = new System.Drawing.Point(44, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 182);
            this.panel1.TabIndex = 15;
            // 
            // FResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FResponsable";
            this.Load += new System.EventHandler(this.FResponsable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGestionNotasDataSet9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbGestionNotasDataSet9 dbGestionNotasDataSet9;
        private System.Windows.Forms.BindingSource responsableBindingSource;
        private dbGestionNotasDataSet9TableAdapters.ResponsableTableAdapter responsableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdResponsable;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreResponsable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}