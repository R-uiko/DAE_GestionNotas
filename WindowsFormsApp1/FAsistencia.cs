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
    public partial class FAsistencia : Form
    {
        public FAsistencia()
        {
            InitializeComponent();
        }

        private void FAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet2.Asistencia' Puede moverla o quitarla según sea necesario.
            this.asistenciaTableAdapter.Fill(this.dbGestionNotasDataSet2.Asistencia);

        }
    }
}
