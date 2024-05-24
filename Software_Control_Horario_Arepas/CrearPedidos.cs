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
    public partial class CrearPedidos : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Pedido> pedidos = new List<Pedido>();
        string docEmpleado=string.Empty;
        public CrearPedidos(List<Empleado> empleadosList, ref List<Pedido> pedidosList, string docEmpl)
        {
            InitializeComponent();
            this.empleados = empleadosList;
            this.pedidos = pedidosList;
            this.docEmpleado = docEmpl;
            LimpiarDatos();
        }

        public void LimpiarDatos()
        {
            this.Empresas.Text = "";
            this.Domiciliarios.Text = "";
            this.fechaPedido.Text = DateTime.Now.ToShortDateString();

            this.Empresas.Items.Add("Éxito");
            this.Empresas.Items.Add("Surtimax");
            this.Empresas.Items.Add("Olímpica");
            this.Empresas.Items.Add("Carulla");
            this.Empresas.Items.Add("Placita de Capri");

            foreach(Empleado empl in empleados.Where(e=>e.tipoEmpleado == "Domiciliario"))
            {
                this.Domiciliarios.Items.Add(empl.nombreEmpleado);
            }


        }

        private void CrearPedidos_Load(object sender, EventArgs e)
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

        private void crearPedido_Click(object sender, EventArgs e)
        {
            string pedidosFile = "Pedidos.txt";
            Pedido pedido = new Pedido();
            pedido.fechaPedido = fechaPedido.Text;
            pedido.domiciliario = Domiciliarios.Text;
            pedido.empresa = Empresas.Text;
            bool pedidoExist = pedidos.Any(p => p.fechaPedido == fechaPedido.Text && p.empresa == Empresas.Text);
            if (!pedidoExist)
            {
                pedidos.Add(pedido);
                using (StreamWriter writer = new StreamWriter(pedidosFile, true))
                {
                    writer.WriteLine($"{pedido.empresa + "," + pedido.fechaPedido + "," + pedido.domiciliario }"); // Escribo en el archivo

                    writer.Close();
                }
                MessageBox.Show("Pedido creado correctamente", "Registro Pedido", MessageBoxButtons.OK);
                LimpiarDatos();
            }
            else
            {
                MessageBox.Show("Ya existe un pedido para esta empresa en la misma fecha", "Registro Pedido", MessageBoxButtons.OK);
            }
            

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado,ref empleados);
            menu.Show();
            this.Hide();
        }
    }
}
