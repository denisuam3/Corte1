using Corte1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        Registro registro = new Registro();
        Person persona = new Person();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            persona.Nombres = tbname.Text;
            persona.Apellidos = tbapellidos.Text;
            persona.FechaNacimiento = dtpfechanacimiento.Value;
            persona.Ciudad = cmbciudad.SelectedItem.ToString();

            registro.AgregarPersona(persona, index);
            index++;
            MessageBox.Show("Persona agregada " );
        }

        private void btnMayorEdad_Click(object sender, EventArgs e)
        {
            int edad = persona.CalcularEdad();
            Operacion operacion = new Operacion(edad);
            string mensaje = operacion.MayorEdad();
            MessageBox.Show($"{persona.Nombres} tienes {edad} años, y {mensaje}", 
                "Mayor o menor de Edad", MessageBoxButtons.OK, MessageBoxIcon.Information );

        }
    }
}
