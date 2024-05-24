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
    public partial class ConsultarPedidos : Form
    {
        List<Pedido> pedidos = new List<Pedido>();
        List<Empleado> emplList = new List<Empleado>();
        Empleado empleado1 = new Empleado();
        string nombreEmpleado;
        string docEmpleado;
        public ConsultarPedidos(string empleado, ref List<Pedido> pedidosList, List<Empleado> empleados)
        {
            InitializeComponent();
            this.pedidos = pedidosList;
            this.emplList = empleados;
            this.nombreEmpleado = empleado;
            empleado1 = empleados.FirstOrDefault(e => e.nombreEmpleado == empleado);
            this.docEmpleado = empleado1.documentoEmpleado;
            CargarPedidos();
        }

        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Login.ChangeOpacity(this.BackgroundImage, 0.2F);
        }
        public void CargarPedidos()
        {
            FileStream pedidosFile = new FileStream("Pedidos.txt", FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(pedidosFile))
            {
                string linea = reader.ReadLine();
                while (linea != null && !string.IsNullOrEmpty(linea))
                {
                    string datos = linea;

                    var datosEmpl = datos.Split(',');
                    Pedido pedido = new Pedido();
                    pedido.empresa = datosEmpl[0].ToString();
                    pedido.fechaPedido =datosEmpl[1];
                    pedido.domiciliario = datosEmpl[2].ToString();

                    this.pedidos.Add(pedido);
                    linea = reader.ReadLine();
                }

            }
            pedidosFile.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void consultar_Click(object sender, EventArgs e)
        {
            if (empleado1.tipoEmpleado == "Supervisor")
            {
                this.dgPedidos.DataSource = pedidos;
            }
            else
            {
                var pedidoSource = pedidos.Where(p => p.domiciliario == nombreEmpleado).ToList();
                this.dgPedidos.DataSource = pedidoSource;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(docEmpleado, ref emplList);
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
