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
    public partial class FDocente : Form
    {
        public FDocente()
        {
            InitializeComponent();
        }

        private void FDocente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet4.Docente' Puede moverla o quitarla según sea necesario.
            this.docenteTableAdapter.Fill(this.dbGestionNotasDataSet4.Docente);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
