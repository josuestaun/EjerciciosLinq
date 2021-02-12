using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLinq
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ejercicios7Al9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir al formulario de los ejercicios 7 al 9
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ejercicio1Al7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir al formulario de los ejercicios 1 al 6
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_TelDigitos_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            List<Persona> personas = Program.gestion.personasTelefonoDigitos(out mensaje);
            if (mensaje.Equals(""))
            {
                dataGridView1.DataSource = personas;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
