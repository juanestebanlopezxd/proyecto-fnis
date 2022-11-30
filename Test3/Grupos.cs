using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Datos;
using Logiica;

namespace Test3
{
    public partial class Grupos : Form
    {
        private Datos_Grupos datos_gp = new Datos_Grupos();
        private Datos_Docentes datos_doc = new Datos_Docentes();
        private Datos_Materias datos_mat = new Datos_Materias();
        private Datos_Salones datos_sal = new Datos_Salones();
        private Lista_Docentes lst_doc;
        private Lista_Materias lst_mat;
        private Lista_Salones lst_salones;

        private Service_docente logicdoc = new Service_docente();
        private Service_materia logicmat = new Service_materia();
        private Service_salon logicsal = new Service_salon();



        public Grupos()
        {
            InitializeComponent();
        }
        string id_doc, id_sal, id_mat;
        private void Grupos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncreargp_Click(object sender, EventArgs e)
        {
            lst_doc = datos_doc.leer_docentes();
            lst_mat = datos_mat.leer_materias();
            lst_salones = datos_sal.leer_salones();
            var lst_doc_sql = datos_doc.ConsultarDocenteSQL();
            var lst_sal_sql = datos_sal.ConsultarSalonSQL();
            var lst_mat_sql = datos_mat.ConsultarMateriaSQL();
            Grupo gp = new Grupo();


            if (datos_doc.leer_docentes() == null)
            {

                return;
            }
            foreach (Docente docente in lst_doc_sql)
            {

                if (logicdoc.Validar_Id(docente, textBoxiddocgp.Text) != null)
                {
                    id_doc = docente.Id;
                }
                
            }
            if (datos_sal.leer_salones() == null)
            {

                return;
            }
            foreach (Salon salon in lst_sal_sql)
            {
                if (logicsal.Validar_Id(salon, textBoxidsalongp.Text) != null)
                {
                    id_sal = salon.Id;
                }
                
            }
            if (datos_mat.leer_materias() == null)
            {

                return;
            }
            foreach (Materia materia in lst_mat_sql)
            {
                if (logicmat.Validar_Id(materia, textBoxidmateriagp.Text) != null)
                {
                    id_mat = materia.Id;
                }
                
            }



            if (id_sal != null & id_mat != null & id_doc != null)
            {
                string linea;
                linea = textBoxidmatgp.Text + ";" + textBoxiddocgp.Text + ";" + textBoxidsalongp.Text + ";" + textBoxidmateriagp.Text + ";" + comboBoxdiasem.Text + ";" + comboBoxhora.Text + ";" + textBoxnumgp.Text;
                gp.Id = textBoxidmatgp.Text;
                gp.Nombre = textBoxnumgp.Text;
                gp.Horario = comboBoxhora.Text;
                gp.Dsemana = comboBoxdiasem.Text;
                Salon salon = new Salon();
                salon.Id = textBoxidsalongp.Text;
                gp.Salon = salon;
                Docente docente = new Docente();
                docente.Id = textBoxiddocgp.Text;
                gp.Docente = docente;
                Materia materia = new Materia();
                materia.Id = textBoxidmateriagp.Text;
                gp.Materia = materia;
                datos_gp.GuardarGrupoSQL(gp);
                datos_gp.GuardarGrupo(linea);
                MessageBox.Show("se guardo el gp correctamente");
            }
            //string linea;
            //linea = textBoxidmatgp.Text + ";" + textBoxiddocgp.Text + ";" + textBoxidsalongp.Text + ";" + textBoxidmateriagp.Text + ";" + comboBoxdiasem.Text + ";" + comboBoxhora.Text + ";" + textBoxnumgp.Text;

            //if (datos_gp.GuardarGrupo(linea) == true)
            //{
            //    MessageBox.Show("Se guardo el grupo correctamente");
            //}
            //else
            //{
            //    MessageBox.Show("error al guardar el grupo");
            //}


        }
    }
}