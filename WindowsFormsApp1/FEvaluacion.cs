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
    public partial class FEvaluacion : Form
    {
        public FEvaluacion()
        {
            InitializeComponent();
        }

        private void FEvaluacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet5.Evaluacion' Puede moverla o quitarla según sea necesario.
            this.evaluacionTableAdapter.Fill(this.dbGestionNotasDataSet5.Evaluacion);

        }
    }
}
