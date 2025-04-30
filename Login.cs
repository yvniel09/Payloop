using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using System.Net.Mail;
using Sistema_de_nomina;


namespace Sistema_de_Nomina
{
    public partial class Login : Form
    {
        private string cadenaConexion = "Data Source=localhost:1521/xe;User Id=NominaUser;Password=Yuniel1120;";


        // Codigo de esquinas bordeadas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse
        );
        public Login()
        {
            
            InitializeComponent();
            //estilos del form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            // Configurar la apariencia del botón
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.FlatAppearance.BorderSize = 0; // Sin bordes
            btnEnviar.BackColor = Color.FromArgb(200, 200, 200); // Color de fondo grisáceo
            btnEnviar.ForeColor = Color.Black; // Color del texto legible
            btnEnviar.Font = new Font(btnEnviar.Font, FontStyle.Regular); // Fuente en negrita
            // Configurar el radio de los bordes del botón (bordes redondeados)
            int borderRadius = 10; // Ajusta según lo deseado
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(btnEnviar.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(btnEnviar.Width - borderRadius, btnEnviar.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, btnEnviar.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            btnEnviar.Region = new Region(path);
            textBoxContraseña.Text = "";
            MostrarContraseña(false);
            MostrarCandadoBloqueado();
            CargarDepartamentos();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MostrarContraseña(bool mostrar)
        {
            textBoxContraseña.UseSystemPasswordChar = !mostrar;
        }
        private void CargarDepartamentos()
        {
            try
            {
                // Crea una conexión a la base de datos
                using (OracleConnection connection = new OracleConnection(cadenaConexion))
                {
                    // Abre la conexión
                    connection.Open();

                    // Crea un comando SQL para ejecutar la consulta
                    string query = "SELECT nombre FROM departamentos";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // Ejecuta la consulta y obtén los resultados
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // Limpia los elementos existentes en el ComboBox
                            comboBox2.Items.Clear();

                            // Agrega cada nombre de departamento al ComboBox
                            while (reader.Read())
                            {
                                string nombreDepartamento = reader.GetString(0);
                                comboBox2.Items.Add(nombreDepartamento);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier error que pueda ocurrir
                MessageBox.Show("Error al cargar departamentos: " + ex.Message);
            }
        }

        bool candadoBloqueado;
        private void MostrarCandadoBloqueado()
        {
            pcCandado.Image = Properties.Resources.candadoBloqueado;
            candadoBloqueado = true;
        }

        

       
       
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;
            string cargo = comboBox2.Text;
            // Consulta SQL para verificar las credenciales en la tabla de usuarios
            string consulta = "SELECT COUNT(*) FROM usuarios WHERE usuario = :usuario AND contrasena = :contraseña AND cargo = :cargo";

            using (OracleConnection conexion = new OracleConnection(cadenaConexion))
            using (OracleCommand comando = new OracleCommand(consulta, conexion))
            {
                // Agregar parámetros
                comando.Parameters.Add(new OracleParameter("usuario", OracleDbType.Varchar2)).Value = usuario;
                comando.Parameters.Add(new OracleParameter("contraseña", OracleDbType.Varchar2)).Value = contraseña;
                comando.Parameters.Add(new OracleParameter("cargo", OracleDbType.Varchar2)).Value = cargo;
                try
                {
                    conexion.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        // Si las credenciales son válidas, mostrar el siguiente formulario
                        FormMainMenu formMainMenu = new FormMainMenu();
                        formMainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al autenticar: " + ex.Message);
                }
            }

        }
        private void pcCandado_Click(object sender, EventArgs e)
        {
            candadoBloqueado = !candadoBloqueado;
            pcCandado.Image = candadoBloqueado ? Properties.Resources.candadoBloqueado : Properties.Resources.candadoDesbloqueado;
            MostrarContraseña(!candadoBloqueado);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
