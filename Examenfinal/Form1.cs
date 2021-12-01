using AppCore.Interface;
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
    public partial class Form1 : Form
    {
        private Iestudianteservices iestudianteservice;
        public Form1(Iestudianteservices iestudianteservices )
        {
            this.iestudianteservice = iestudianteservices;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }
    }
}
