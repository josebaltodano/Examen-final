using AppCore.Services;
using Domanin;
using Domanin.Enums;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examenfinal
{
    public partial class Registro : Form
    {
        private EstudianteModel model { get; set; }

        public Registro()
        {
            InitializeComponent();
        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante= new Estudiante()
            {
                id = model.GetLastProductoId() + 1,
                Nombre = txtNombre.Text,
                Apellidos = txtapellido.Text,
                Carnet = txtcarnet.Text,
                Municipio = txtMicipio.Text,
                departamento = txtDepartamento.Text,
                clases =(Clases)comboBox1.SelectedIndex
            };
            model.create(estudiante); 
           
            Dispose();

         
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetValues(typeof(Clases)).Cast<object>().ToArray());
        }
    }
}
