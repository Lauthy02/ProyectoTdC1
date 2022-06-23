using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//Referencio a la capa de dominio
using Domain;

/*
//https://rjcodeadvance.com/cap-1-disenar-login-moderno-efecto-placeholder-y-transparencia-c-y-winform/
*/

namespace Presentation
{
    public partial class Form1_LogIn : Form
    {
        public Form1_LogIn()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #region Boton Acceder
        private void button1_Access_Click(object sender, EventArgs e)
        {
            if (textBox1Username.Text != "Usuario")  
            {
                if (textBox2Password.Text != "Contraseña")
                {
                    //Creo una clase tipo UserModel de nombre Nuser
                    UserModel Nuser = new UserModel();
                    bool ValidarLogin = Nuser.LoginUser(textBox1Username.Text,textBox2Password.Text);
                    if (ValidarLogin == true)
                    {
                        Form2_Principal Menu = new Form2_Principal();
                        Menu.Show();
                        this.Hide();
                    }
                    else //NO ANDA ESTE ELSE
                    {
                        label1_MsjError.Visible = true;
                        MsjError("Usuario o contraseña incorrecta.");
                        textBox1Username.Clear();
                        textBox2Password.Clear();
                        textBox1Username.Focus();
                    }
                }
                else
                {
                    MsjError("Por favor, ponga la contraseña");
                }
            }
            else 
            {
                MsjError("Por favor, ponga el usuario");
            }
        }

        private void MsjError(string msg)
        {
            label1_MsjError.Text = "     " + msg;
            label1_MsjError.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Cuadro de texto Username

        //Evento enter: Cuando el cursor está dentro de la caja de texto
        private void textBox1Username_Enter(object sender, EventArgs e)
        {
            label1_MsjError.Visible = false;
            if (textBox1Username.Text=="Usuario")
            {
                textBox1Username.Text = "";
            }
        }

        //Evento leave: Cuando el cursor está fuera de la caja de texto
        private void textBox1Username_Leave(object sender, EventArgs e)
        {
            if (textBox1Username.Text == "")
            {
                textBox1Username.Text = "Usuario";
            }
        }

        #endregion

        #region Cuadro de texto Password

        //Evento enter: Cuando el cursor está dentro de la caja de texto
        private void textBox2Password_Enter(object sender, EventArgs e)
        {
            label1_MsjError.Visible = false;
            if (textBox2Password.Text == "Contraseña")
            {
                textBox2Password.Text = "";
                textBox2Password.UseSystemPasswordChar = true;
            }
        }

        //Evento leave: Cuando el cursor está fuera de la caja de texto
        private void textBox2Password_Leave(object sender, EventArgs e)
        {
            if (textBox2Password.Text == "")
            {
                textBox2Password.Text = "Contraseña";
                textBox2Password.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            textBox2Password.UseSystemPasswordChar = false;
        }

        #endregion



        #region Cerrar y minimizar
        private void pictureBox1_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion




        #region Sin uso
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2VerContraseña_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
