using Sistema_de_Nomina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_nomina
{
    public partial class FormMainMenu : Form
    {

        //dlls pa bolde redondeado
        // Codigo de esquinas bordeadas
        private Point lastPoint;
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
        //eto son dlls para estilos y blablabla, no se mueven
        [DllImport("gdi32")]
        private static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
        [DllImport("dwmapi")]
        private static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, ref DwmBlurbehind pBlurBehind);
        public struct DwmBlurbehind
        {
            public int DwFlags;
            public bool FEnable;
            public IntPtr HRgnBlur;
            public bool FTransitionOnMaximized;
        }

        //to lo q tu vea en ingles e pq tomé una plantilla y la adapté y quité cosas que iban de más por eso este codigo lo voy a limpiar luego y quitar lo que no sirva
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
           InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            BordesRedondeados();
            if (this.WindowState == FormWindowState.Normal ) 
            { 
                bordesRedondos = true;
               
            } else 
            { 
                bordesRedondos = false; 
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
   
        //Methods
       public bool bordesRedondos = true;
        public void BordesRedondeados()
        {


            if (bordesRedondos) 
            {
                GraphicsPath path = new GraphicsPath();

                // Configurar el radio de los bordes del botón (bordes redondeados)
                int borderRadius = 10; // Ajusta según lo deseado
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(button1.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(button1.Width - borderRadius, button1.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, button1.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                button1.Region = new Region(path);
                //estilos del form
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }else if(!bordesRedondos) 
            {
                GraphicsPath path = new GraphicsPath();

                // Configurar el radio de los bordes del botón (bordes redondeados)
                path.Reset();
                //path.AddArc(button1.Width - borderRadius, 0, borderRadius, borderRadius, -270, -90);
                //path.AddArc(button1.Width - borderRadius, button1.Height - borderRadius, borderRadius, borderRadius, 0, -90);
                //path.AddArc(0, button1.Height - borderRadius, borderRadius, borderRadius, -90, -90);
                //button1.Region = new Region(path);
                ////estilos del form
                //this.FormBorderStyle = FormBorderStyle.None;
                //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, -20, -20));
            }
        }

        //barra de carga y timer
       
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;  
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDeBoton(button4);
            ColorVuelate(button4);
            ColorDeBoton(button4);
            ColorVuelate(button4);
        }
        private void OpenChildForm(Type formType, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            // Activar el botón asociado al formulario secundario
            if (btnSender != null && btnSender is Button)
            {
                ActivateButton((Button)btnSender);
            }

            // Crear una nueva instancia del formulario especificado
            Form childForm = (Form)Activator.CreateInstance(formType);

            // Configurar el formulario secundario
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Agregar el formulario secundario al panel de contenido principal
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;

            // Asegurar que el formulario secundario esté al frente
            childForm.BringToFront();

            // Mostrar el formulario secundario
            childForm.Show();
        }
        //mas etilos y mieldas
        private void ColorDeBoton(Button btn)
        {
            btn.BackColor = Color.FromArgb(96, 100, 206);
        }
        private void ColorVuelate(Button btn)
        {
            btn.BackColor = Color.FromArgb(112, 115, 237); 
        }
        private void Reset()
        {
            
           currentButton = null;
           
        }
        
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            if (WindowState == FormWindowState.Maximized)
            {

            }
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ColorDeBoton(btnInicio);
            ColorVuelate(btnInicio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDeBoton(button2);
            ColorVuelate(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDeBoton(button3);
            ColorVuelate(button3);
        }

        

        GraphicsPath path = new GraphicsPath();

        //el panel 1 es el panel que abarca toda la parte blanca del form, basicamente se crea un formulario hijo y cuando se le de a X boton el panel va a cambiar a ese formulario hijo
        //el codigo para que los botones abran el formulario hijo en el panel es "OpenChildForm(new Forms.FormQTuUsa(), sender);"
        
        //los rjbutton son botones con bordes redondeados que vienen de otra clase lajsdkjas
      private void rjButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para minimizar el formulario EmpleadosForm que se muestra en un panel
        public void MinimizarEmpleadosForm()
        {
            // Crear una instancia del formulario EmpleadosForm si no está creado
            EmpleadosForm empleadosForm = panelDesktopPane.Controls.OfType<EmpleadosForm>().FirstOrDefault();

            if (empleadosForm != null)
            {
                // Minimizar el formulario EmpleadosForm
                empleadosForm.WindowState = FormWindowState.Normal;
            }
        }
        public void btnMinimizar_Click(object sender, EventArgs e)
        {
            EmpleadosForm empleadosFormulario = new EmpleadosForm();
            EmpleadosForm empleadosForm = panelDesktopPane.Controls.OfType<EmpleadosForm>().FirstOrDefault();
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Enabled = false;
            btnMinimizar.Visible = false;
            btnMaximizar.Enabled = true;
            btnMaximizar.Visible = true;


            if (this.WindowState == FormWindowState.Normal)
            {
                
                // Configurar el radio de los bordes del botón (bordes redondeados)
                int borderRadius = 10;
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(button1.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(button1.Width - borderRadius, button1.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, button1.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                button1.Region = new Region(path);

                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }

       public void btnMaximizar_Click(object sender, EventArgs e)
       {
            this.WindowState = FormWindowState.Maximized;
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMinimizar.Enabled = true;
                btnMinimizar.Visible = true;
                btnMaximizar.Enabled = false;
                btnMaximizar.Visible = false;
            }

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
       }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(typeof(EmpleadosForm), sender);
            EmpleadosForm empleadosForm = new EmpleadosForm();
            panelHeader.BackColor = Color.Transparent;
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        //movimiento del form
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void FormMainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = Point.Empty;
            }
        }

        private void FormMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormInicio), sender);
            panelHeader.BackColor = Color.FromArgb(96, 100, 206);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormNomina), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}