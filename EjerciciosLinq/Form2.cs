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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void ejerciciosDel1Al6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir al formulario de los ejercicios1 al 6
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_MenoresMax_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            List<Persona> personas = Program.gestion.PersonasMenoresMax(out mensaje);
            if (mensaje.Equals(""))
            {
                dataGridView1.DataSource = personas;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btn_MenoresMax2_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            var menoresConTelefonos = Program.gestion.CantidadTelefonos(out mensaje);
            if (mensaje.Equals(""))
            {
                //System.Type tipo = menoresConTelefonos.GetType();
                //string nombre = (string)tipo.GetProperty("Nombre").GetValue(menoresConTelefonos);
                //int edad = (int)menoresConTelefonos.GetType().GetProperty("Edad").GetValue(menoresConTelefonos);
                //int numTelefonos = (int)menoresConTelefonos.GetType().GetProperty("numTelefonos").GetValue(menoresConTelefonos);
                dataGridView2.DataSource = menoresConTelefonos;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btn_perSinTelefono_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            List<Persona> personas = Program.gestion.personasSinTelefono(out mensaje);
            if (mensaje.Equals(""))
            {
                dataGridView3.DataSource = personas;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void ejercicios10Y11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir al formulario de los ejercicios 10 y 11
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
