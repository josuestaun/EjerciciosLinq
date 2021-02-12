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
using Gestion;

namespace EjerciciosLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BuscarPersona_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            String name = txt_name.Text;
            List<Persona> personas = Program.gestion.PersonasComienzanA(name, out mensaje);
            if (mensaje.Equals(""))
            {
                dataGrid.DataSource = personas;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btn_localidad_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            if (Program.gestion.ExistEnLocalidad(txt_localidad.Text))
            {
                mensaje = "Si hay personas en " + txt_localidad.Text;
            }
            else
            {
                mensaje = "No hay personas en " + txt_localidad.Text;
            }
            MessageBox.Show(mensaje);
        }

        private void btn_identificador_Click(object sender, EventArgs e)
        {
            Persona per = Program.gestion.personaPorIdentificador(txt_identificador.Text);
            if (per == null)
            {
                MessageBox.Show("No hay nadie");
            }
            else
            {
                MessageBox.Show("Nombre: " + per.Nombre + "\nLocalidad: " + per.Localidad + "\nEdad: " + per.Edad + "\nCantidad de telefonos: " + Program.gestion.CantidadTelefonos(per.Id));
            }
        }

        private void btn_identificadorMax_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            String identificador = txt_IdentificadorMax.Text;
            int id = int.Parse(identificador);
            List<Persona> personas = Program.gestion.PersonasHastaIdentificador(id, out mensaje);
            if (mensaje.Equals(""))
            {
                dataGrid2.DataSource = personas;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btn_Edad_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            int edad = int.Parse(txt_Edad.Text);
            List<Persona> personas = Program.gestion.PersonasMayorEdad(edad, out mensaje);
            if (mensaje.Equals(""))
            {
                dataGrid3.DataSource = personas;
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void ejercicios7Al10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir al formulario de los ejercicios 7 al 9
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ejercicio10Y11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir al formulario de los ejercicios 10 y 11
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
