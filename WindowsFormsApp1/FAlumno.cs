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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FAlumno : Form
    {
        byte[] imagenByte;

        Alumno objAlumno = new Alumno();
        private string objtAlumno;

        public FAlumno()
        {
            InitializeComponent();
        }
        private void llenarDatosAlumnoyMostrar()
        {
            objAlumno.idAlumno = int.Parse(txtIdAlumno.Text);
            objAlumno.nombreAlumnos = txtNombreAlumno.Text;
            objAlumno.grado = txtGrado.Text;
            objAlumno.idSeccion = int.Parse(txtIdSeccion.Text);
            //objAlumno.sexoAlumno = rbSexoAlumno.Text;
            objAlumno.FechaNacimiento = dtpFechaNacimiento.Value;


            //objAlumno.FechaActual = dateFechaActual.ToString();
            objAlumno.idResponsable = int.Parse(txtIdResponsable.Text);
            objAlumno.nombreResponsable = txtNombreResponsable.Text;

            if (rMasculino.Checked)
            {
                objAlumno.sexoAlumno = "MAsculino";
            }
            else if (rFemenino.Checked)
            {
                objAlumno.sexoAlumno = "Femenino";
            }
            MessageBox.Show("Detalle de información de Alumno" + objtAlumno);
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            llenarDatosAlumnoyMostrar();
        }
        private void FAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet1.Alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.dbGestionNotasDataSet1.Alumno);
            // TODO: esta línea de código carga datos en la tabla 'dbGestionNotasDataSet.Seccion' Puede moverla o quitarla según sea necesario.
            this.seccionTableAdapter.Fill(this.dbGestionNotasDataSet.Seccion);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog selectorImagen = new OpenFileDialog();
                selectorImagen.Title = "Selecionar Imagen";
                if (selectorImagen.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAlumno.Image = Image.FromStream(selectorImagen.OpenFile());
                    MemoryStream memoria = new MemoryStream();
                    pictureBoxAlumno.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                    imagenByte = memoria.ToArray();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreResponsable_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdResponsable_TextChanged(object sender, EventArgs e)
        {

        }

        private void rMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbIdSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxAlumno_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
