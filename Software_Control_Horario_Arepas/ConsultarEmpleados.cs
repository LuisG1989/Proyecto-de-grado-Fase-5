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
    public partial class ConsultarEmpleados : Form
    {
        List<Empleado> emplList = new List<Empleado>();
        string documentoLogin = string.Empty;
        public ConsultarEmpleados(List<Empleado> empleados, string docEmpleado)
        {
            InitializeComponent();
            this.emplList = empleados;
            this.documentoLogin = docEmpleado;
        }

        private void ConsultarEmpleados_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Login.ChangeOpacity(this.BackgroundImage, 0.2F);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void consultar_Click(object sender, EventArgs e)
        {
            Empleado empleado = this.emplList?.FirstOrDefault(e => e.documentoEmpleado == documento.Text.Trim());
            if(empleado != null)
            {
                nombreEmpleado.Text = empleado.nombreEmpleado;
                fechaIngreso.Text = empleado.fechaIngreso;
                cargoEmpleado.Text = empleado.tipoEmpleado;
                if(empleado.registroIngresoSalidas == null || empleado.registroIngresoSalidas.Count == 0)
                {
                    dgEntradasSalidas.DataSource = null;
                    MessageBox.Show("El empleado no ha registrado entradas y/o salidas", "Consultar Empleado", MessageBoxButtons.OK);
                }
                else
                {
                    dgEntradasSalidas.DataSource = empleado.registroIngresoSalidas;
                }
            }
            else
            {
                MessageBox.Show("El empleado no ha sido registrado", "Consultar Empleado", MessageBoxButtons.OK);
            }
        }

        private void limpiarDatos_Click(object sender, EventArgs e)
        {
            documento.Text = "";
            nombreEmpleado.Text = "";
            fechaIngreso.Text = "";
            cargoEmpleado.Text = "";
            dgEntradasSalidas.DataSource = null;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(documentoLogin, ref emplList);
            menu.Show();
            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
