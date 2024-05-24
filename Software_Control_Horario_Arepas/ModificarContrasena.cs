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
    public partial class ModificarContrasena : Form
    {
        List<Empleado> empleadosList = new List<Empleado>();
        readonly string docEmpleado = string.Empty;
        public ModificarContrasena(string docEmpleado, ref List<Empleado> empleados)
        {
            InitializeComponent();
            this.docEmpleado = docEmpleado;
            empleadosList = empleados;

            LimpiarDatos();
        }
        private void LimpiarDatos()
        {
            this.oldPassword.Text = "";
            this.newPassword.Text = "";
            this.confPassword.Text = "";


        }
        private void ModificarContrasena_Load(object sender, EventArgs e)
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

        private void modificarPass_Click(object sender, EventArgs e)
        {
            StreamReader lectura;
            StreamWriter escritura;
            string cadena;
            try
            {
                lectura = File.OpenText("Empleados.txt");
                escritura = File.CreateText("EmplTemp.txt");

                cadena = lectura.ReadLine();
                while(cadena != null)
                {
                    var datos = cadena.Split(",");
                    if (datos[0].Trim().Equals(docEmpleado.ToString()))
                    {
                        if(this.oldPassword.Text.Trim() != datos[4].Trim())
                        {
                            MessageBox.Show("Su contraseña actual no coincide", "Contraseña", MessageBoxButtons.OK);
                        }
                        if(this.newPassword.Text.Trim() == this.confPassword.Text.Trim())
                        {
                            escritura.WriteLine($"{datos[0] + "," + datos[1] + "," + datos[2] + "," + datos[3] + "," + this.newPassword.Text.Trim()}");
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden", "Contraseña", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        escritura.WriteLine(cadena);
                    }
                    cadena = lectura.ReadLine();
                }
                lectura.Close();
                escritura.Close();

                File.Replace("EmplTemp.txt", "Empleados.txt", null);
                MessageBox.Show("Contraseña modificada", "Contraseña", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar modificar su contraseña", "Contraseña", MessageBoxButtons.OK);
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
