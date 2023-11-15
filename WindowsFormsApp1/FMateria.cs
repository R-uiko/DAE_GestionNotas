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
    public partial class FMateria : Form
    {
        public FMateria()
        {
            InitializeComponent();
        }

        private void FMateria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet7.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.dbGestionNotasDataSet7.Materia);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
