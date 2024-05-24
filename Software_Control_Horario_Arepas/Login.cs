using Software_Control_Horario_Arepas.Models;
using System.Drawing.Imaging;

namespace Software_Control_Horario_Arepas
{
    public partial class Login : Form
    {
        string paswordOp = "Op123";
        string paswordSup = "Sup123";
        string paswordDom = "Dom123";
        List<Empleado> empleados = new List<Empleado>();
        public Login()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = ChangeOpacity(this.BackgroundImage, 0.2F);
        }



        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

            Empleado empleado = empleados.FirstOrDefault(u => u.documentoEmpleado.ToString() == user.Text);
            if (empleado == null)
            {
                MessageBox.Show("Usuario Incorrecto");
                user.Clear();
                user.Focus();
                return;
            }
            if (password.Text != empleado.contrasena)
            {
                MessageBox.Show("Contraseña Incorrecta");
                password.Clear();
                password.Focus();
                return;
            }
            Menu menu = new Menu(empleado.documentoEmpleado, ref empleados);
            this.Hide();
            menu.Show();
        }

        public void CargarUsuarios()
        {
            FileStream empleadosFile = new FileStream("Empleados.txt", FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(empleadosFile))
            {
                string linea = reader.ReadLine();
                while (linea != null && !string.IsNullOrEmpty(linea))
                {
                    // Reconstruyo el objeto a partir de los datos levantados del archivo
                    string datos = linea;

                    var datosEmpl = datos.Split(',');

                    Empleado empl = new Empleado();
                    empl.documentoEmpleado = datosEmpl[0];
                    empl.nombreEmpleado = datosEmpl[1].ToString();
                    empl.tipoEmpleado = datosEmpl[2].ToString();
                    empl.fechaIngreso = datosEmpl[3].ToString();
                    empl.contrasena = datosEmpl[4].ToString();

                    //Ingresos y Salidas

                    FileStream ingresosSalidasFile = new FileStream("Entradas_Salidas.txt", FileMode.OpenOrCreate, FileAccess.Read);
                    List<IngresoSalida> registroIngresoSalidas = new List<IngresoSalida>();
                    using (StreamReader readerIn = new StreamReader(ingresosSalidasFile))
                    {
                        string line = readerIn.ReadLine();
                        while (line != null)
                        {
                            // Reconstruyo el objeto a partir de los datos levantados del archivo
                            string registro = line;

                            var datosInOuts = registro.Split(',');
                            if (empl.documentoEmpleado == datosInOuts[0])
                            {
                                var existInOut = empl.registroIngresoSalidas?.Find(i => i.fechaIngreso.ToShortDateString() == DateTime.Parse(datosInOuts[2]).ToShortDateString());
                                IngresoSalida inOuts = existInOut != null ? existInOut : new IngresoSalida();
                                if (datosInOuts[1] == "Entrada")
                                {
                                    inOuts.fechaIngreso = DateTime.ParseExact(datosInOuts[2], "M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    inOuts.fechaSalida = DateTime.ParseExact(datosInOuts[2], "M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                                }

                                if(existInOut == null)
                                {
                                    registroIngresoSalidas.Add(inOuts);
                                }
                                empl.registroIngresoSalidas = registroIngresoSalidas;
                            }
                            line = readerIn.ReadLine();
                        }
                    }
                    ingresosSalidasFile.Close();

                    empleados.Add(empl);

                    linea = reader.ReadLine();
                }
            }
            empleadosFile.Close();

            

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