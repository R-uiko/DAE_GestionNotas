using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FResponsable : Form
    {
        public FResponsable()
        {
            InitializeComponent();
        }

        private void FResponsable_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet9.Responsable' Puede moverla o quitarla según sea necesario.
            this.responsableTableAdapter.Fill(this.dbGestionNotasDataSet9.Responsable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
