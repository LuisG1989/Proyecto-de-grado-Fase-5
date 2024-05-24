using Software_Control_Horario_Arepas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Control_Horario_Arepas
{
    public partial class AgregarEmpleado : Form
    {
        List<Empleado> empleadosList = new List<Empleado>();
        readonly string docEmpleado = string.Empty;
        public AgregarEmpleado(string docEmpleado, ref List<Empleado> empleados)
        {
            InitializeComponent();
            this.docEmpleado = docEmpleado;
            empleadosList = empleados;

            LimpiarDatos();
        }
        private void LimpiarDatos()
        {
            this.tipoEmpleado.Text = "";
            this.nombreEmpleado.Text = "";
            this.documento.Text = "";
            this.fechaIngreso.Text = DateTime.Now.ToShortDateString();

            this.tipoEmpleado.Items.Add("Operario");
            this.tipoEmpleado.Items.Add("Domiciliario");
            this.tipoEmpleado.Items.Add("Supervisor");

        }
        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Login.ChangeOpacity(this.BackgroundImage, 0.2F);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private string GenerateOneTimePassword()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            string password = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }

        private void crearEmpleado_Click(object sender, EventArgs e)
        {
            string empleadosFile = "Empleados.txt";
            bool empleadoExist = empleadosList.Any(e => e.documentoEmpleado == documento.Text);
            Empleado empleado = new Empleado();
            empleado.nombreEmpleado = nombreEmpleado.Text;
            empleado.documentoEmpleado =  documento.Text;
            empleado.fechaIngreso = fechaIngreso.Text;
            empleado.tipoEmpleado = tipoEmpleado.Text.Trim();
            empleado.contrasena = GenerateOneTimePassword();
            if (!empleadoExist)
            {
                empleadosList.Add(empleado);
                using (StreamWriter writer = new StreamWriter(empleadosFile, true))
                {
                    writer.WriteLine($"{empleado.documentoEmpleado + "," + empleado.nombreEmpleado + "," + empleado.tipoEmpleado + "," + empleado.fechaIngreso + "," + empleado.contrasena}"); // Escribo en el archivo

                    writer.Close();
                }
                MessageBox.Show("Empleado registrado correctamente", "Registro", MessageBoxButtons.OK);
                LimpiarDatos();
            }
            else
            {
                MessageBox.Show("Ya existe un empleado con el documento ingresado registrado", "Registro", MessageBoxButtons.OK);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado, ref empleadosList);
            menu.Show();
            this.Hide();
        }
    }
}
