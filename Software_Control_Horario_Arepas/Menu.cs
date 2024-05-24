using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_Control_Horario_Arepas
{
    public partial class Menu : Form
    {
        Empleado empleado = new Empleado();
        List<Empleado> empleadosList = new List<Empleado>();
        List<Pedido> pedidosList = new List<Pedido>();
        string docEmpleado = string.Empty;
        public Menu(string documentoEmpleado,ref List<Empleado> empleados)
        {
            InitializeComponent();
            docEmpleado = documentoEmpleado;
            this.empleadosList = empleados;
            empleado = empleados.FirstOrDefault(u => u.documentoEmpleado == documentoEmpleado);
            switch (empleado.tipoEmpleado)
            {
                case "Operario":
                    registrarIngreso.Visible = true;
                    RegistrarSalida.Visible = true;
                    ConsultarEmpleados.Visible = false;
                    ConsutarPedido.Visible = false;
                    CrearEmpleado.Visible = false;
                    CrearPedido.Visible = false;
                    break;
                case "Domiciliario":
                    registrarIngreso.Visible = true;
                    ConsultarEmpleados.Visible = false;
                    ConsutarPedido.Visible = true;
                    CrearEmpleado.Visible = false;
                    CrearPedido.Visible = false;
                    break;
                case "Supervisor":
                    registrarIngreso.Visible = true;
                    RegistrarSalida.Visible = true;
                    ConsultarEmpleados.Visible = true;
                    ConsutarPedido.Visible = true;
                    CrearEmpleado.Visible = true;
                    CrearPedido.Visible = true;
                    break;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
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

        private void registrarIngreso_Click(object sender, EventArgs e)
        {
            string ingresoSalidaFile = "Entradas_Salidas.txt";
            var existInOut = empleado.registroIngresoSalidas?.Find(i => i.fechaIngreso.ToShortDateString() == DateTime.Now.ToShortDateString());
            if(existInOut != null)
            {
                MessageBox.Show("Usted ya ha registrado entrada el día de hoy", "Entrada", MessageBoxButtons.OK);
            }
            else
            {
                empleado.registroIngresoSalidas = new List<IngresoSalida>();
                empleado.registroIngresoSalidas.Add(new IngresoSalida { fechaIngreso = DateTime.Now });

                using (StreamWriter writer = new StreamWriter(ingresoSalidaFile,true))
                {
                     writer.WriteLine($"{empleado.documentoEmpleado+",Entrada,"+DateTime.Now}"); // Escribo en el archivo
                    writer.Close();
                }

                MessageBox.Show("Se ha registrado su entrada", "Entrada", MessageBoxButtons.OK);
            }
        }

        private void RegistrarSalida_Click(object sender, EventArgs e)
        {
            string ingresoSalidaFile = "Entradas_Salidas.txt";
            var existIn = empleado.registroIngresoSalidas?.Find(i => i.fechaIngreso.ToShortDateString() == DateTime.Now.ToShortDateString());
            var existOut = empleado.registroIngresoSalidas?.Find(i => i.fechaSalida.ToShortDateString() == DateTime.Now.ToShortDateString());
            if (existOut != null)
            {
                MessageBox.Show("Usted ya ha registrado salida el día de hoy", "Salida", MessageBoxButtons.OK);
            }
            else
            {
                if (existIn != null)
                {
                    existIn.fechaSalida = DateTime.Now;
                }
                else
                {
                    empleado.registroIngresoSalidas = new List<IngresoSalida>();
                    empleado.registroIngresoSalidas.Add(new IngresoSalida { fechaSalida = DateTime.Now });
                }

                using (StreamWriter writer = new StreamWriter(ingresoSalidaFile,true))
                {
                    writer.WriteLine($"{empleado.documentoEmpleado + ",Salida," + DateTime.Now}"); // Escribo en el archivo
                    writer.Close();
                }

                MessageBox.Show("Se ha registrado su salida", "Salida", MessageBoxButtons.OK);
            }
        }

        private void CrearPedido_Click(object sender, EventArgs e)
        {
            CrearPedidos crearPedido = new CrearPedidos(empleadosList, ref pedidosList, docEmpleado);
            crearPedido.Show();
            this.Hide();
        }

        private void ConsutarPedido_Click(object sender, EventArgs e)
        {
            ConsultarPedidos consultar = new ConsultarPedidos(empleado.nombreEmpleado, ref pedidosList, empleadosList);
            consultar.Show();
            this.Hide();
        }

        private void CrearEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado CrearEmpleado = new AgregarEmpleado(empleado.documentoEmpleado, ref empleadosList);
            CrearEmpleado.Show();
            this.Hide();
        }

        private void ConsultarEmpleados_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados consultar = new ConsultarEmpleados(empleadosList, docEmpleado);
            consultar.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Hide();
        }

        private void modifyPass_Click(object sender, EventArgs e)
        {
            ModificarContrasena modPass = new ModificarContrasena(docEmpleado, ref empleadosList);
            modPass.Show();
            this.Hide();
        }
    }
}
