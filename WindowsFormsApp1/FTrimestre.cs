using ClassLibraryModel;
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
    public partial class FTrimestre : Form
    {
        private List<Asistencia> asistencias = new List<Asistencia>();
        public FTrimestre()
        {
            InitializeComponent();

            asistencias = new List<Asistencia>();
        }

        private void FTrimestre_Load(object sender, EventArgs e)
        {


            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet8.Trimestre' Puede moverla o quitarla según sea necesario.
            this.trimestreTableAdapter.Fill(this.dbGestionNotasDataSet8.Trimestre);

        }

        private void txtPeriodoAsistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
