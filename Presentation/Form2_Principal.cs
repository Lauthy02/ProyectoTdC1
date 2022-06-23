using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
https://rjcodeadvance.com/interfaz-grafico-de-usuario-modernista-multi-window-con-c-version-completa/
*/

namespace Presentation
{
    public partial class Form2_Principal : Form
    {
        public Form2_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void button1_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3_Clientes>();
            button1_Usuarios.BackColor = Color.FromArgb(192, 192, 0);
        }

        private void button2_HistorialDelCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form5_HistClien>();
            button2_HistorialDelCliente.BackColor = Color.FromArgb(192, 192, 0);
        }

        private void button3_Calendario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4_Calendario>();
            button3_Calendario.BackColor = Color.FromArgb(192, 192, 0);
        }

        #endregion


        #region Funcionalidades del form


        //Método para arrastrar el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Cerrar, minimizar, maximizar y achicar
        private void pictureBox1_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //tengo que capturar los valores del fom antes de maximizar para despues poder achicarlo
        int lx, ly, sw, sh;
        private void pictureBox3_Maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            pictureBox3_Maximizar.Visible = false;
            pictureBox4_Achicar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pictureBox4_Achicar_Click(object sender, EventArgs e)
        {
            pictureBox3_Maximizar.Visible = true;
            pictureBox4_Achicar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location= new Point(lx, ly);
        }
        #endregion
        #endregion

        #region Método para abrir formularios en el panel3
    
        private void AbrirFormulario<MiFormulario>()where MiFormulario : Form, new() 
        {
            Form Formulario;
            //Busca en la colección el formulario 
            Formulario = panel3_Formularios.Controls.OfType<MiFormulario>().FirstOrDefault();
            //Si el formulario inestancia no exixte
            if (Formulario==null )
            {
                //Creamos una nueva instancia del formulario
                Formulario = new MiFormulario();
                //Le decimos q no es un form de lvl superior
                Formulario.TopLevel = false;
                //Le saco el borde al formulario
                Formulario.FormBorderStyle = FormBorderStyle.None;
                //Para que se acople al panel
                Formulario.Dock = DockStyle.Fill;
                //Agregamos el formulario a la colección de controles del panel
                panel3_Formularios.Controls.Add(Formulario);
                //especificamos la propiedad tag
                panel3_Formularios.Tag = Formulario;
                //Lo mostramos
                Formulario.Show();
                //Para que se abra adelante
                Formulario.BringToFront();
                Formulario.FormClosed += new FormClosedEventHandler(CerrarFormulario);
            }
            else //Si el fomr instancia existe
            {
                //Solo lo traemos al frente con BringToFront
                Formulario.BringToFront();
            }
        }
        #endregion  

        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form3_Clientes"] == null) 
            {
                button1_Usuarios.BackColor = Color.FromArgb(15, 15, 15);
            }
            if (Application.OpenForms["Form4_Calendario"] == null)
            {
                button3_Calendario.BackColor = Color.FromArgb(15, 15, 15);
            }
            if (Application.OpenForms["Form5_HistClien"] == null)
            {
                button2_HistorialDelCliente.BackColor = Color.FromArgb(15, 15, 15);
            }
        }
    }
}
