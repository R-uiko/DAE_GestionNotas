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
    public partial class FDetalleMateria : Form
    {
        public FDetalleMateria()
        {
            InitializeComponent();
        }

        private void FDetalleMateria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet3.Detalle_Materia' Puede moverla o quitarla según sea necesario.
            this.detalle_MateriaTableAdapter.Fill(this.dbGestionNotasDataSet3.Detalle_Materia);

        }
    }
}
