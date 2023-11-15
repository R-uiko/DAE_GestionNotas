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
    public partial class FPrincipal : Form
    { private RTipoUsuario modeloTipoUsuario = new RTipoUsuario();
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLogin frm = new FLogin();

            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             FTrimestre frm = new FTrimestre();

            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FMateria frm = new FMateria();

            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FEvaluacion frm = new FEvaluacion();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FDocente frm = new FDocente();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FAlumno frm = new FAlumno();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FResponsable frm = new FResponsable();

            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FDetalleMateria frm = new FDetalleMateria();

            frm.Show();
        }
    }
}
