using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Windows.Forms;

namespace Test3
{
    public partial class Estudiantes : Form
    {
        private Datos_Estudiante datos = new Datos_Estudiante();
        private Lista_Estudiantes lista_estudiantes;
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void butonsave_Click(object sender, EventArgs e)
        {

            Estudiante est = new Estudiante();
            string linea;
            linea = textBoxId.Text + ";" + textBoxnom.Text + ";" + textBoxTel.Text;
            est.Id = textBoxId.Text;
            est.Nombre = textBoxnom.Text;
            est.Telefono = textBoxTel.Text;


            if (datos.GuardarEstudiante(linea) == true)
            {
                datos.GuardarEstudianteSQL(est);
                MessageBox.Show("Se guardo el estudiante correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar el Estudiante");
            }
        }

        private void btnestudiagg_Click(object sender, EventArgs e)
        {
            GPsaveestudi.Visible = true;
            GPModiestudiantes.Visible = false;
            GPdisposestu.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnestudidispose_Click(object sender, EventArgs e)
        {
            GPsaveestudi.Visible = false;
            GPModiestudiantes.Visible = false;
            GPdisposestu.Visible = true;
        }

        private void btnestudimodi_Click(object sender, EventArgs e)
        {
            GPsaveestudi.Visible = false;
            GPModiestudiantes.Visible = true;
            GPdisposestu.Visible = false;
        }
    }
}
