
namespace Presentation
{
    partial class Form1_LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_LogIn));
            this.label1_LogIn = new System.Windows.Forms.Label();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.label1_NombreProyecto = new System.Windows.Forms.Label();
            this.linkLabel1_RecupPassw = new System.Windows.Forms.LinkLabel();
            this.pictureBox1_Cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2_Minimizar = new System.Windows.Forms.PictureBox();
            this.button1_Access = new System.Windows.Forms.Button();
            this.label1_MsjError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_LogIn
            // 
            this.label1_LogIn.AutoSize = true;
            this.label1_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.label1_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_LogIn.ForeColor = System.Drawing.Color.White;
            this.label1_LogIn.Location = new System.Drawing.Point(84, 59);
            this.label1_LogIn.Name = "label1_LogIn";
            this.label1_LogIn.Size = new System.Drawing.Size(125, 25);
            this.label1_LogIn.TabIndex = 1;
            this.label1_LogIn.Text = "Iniciar sesión";
            // 
            // textBox1Username
            // 
            this.textBox1Username.BackColor = System.Drawing.Color.Black;
            this.textBox1Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Username.ForeColor = System.Drawing.Color.White;
            this.textBox1Username.Location = new System.Drawing.Point(12, 139);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(254, 23);
            this.textBox1Username.TabIndex = 1;
            this.textBox1Username.Text = "Usuario";
            this.textBox1Username.Enter += new System.EventHandler(this.textBox1Username_Enter);
            this.textBox1Username.Leave += new System.EventHandler(this.textBox1Username_Leave);
            // 
            // textBox2Password
            // 
            this.textBox2Password.BackColor = System.Drawing.Color.Black;
            this.textBox2Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Password.ForeColor = System.Drawing.Color.White;
            this.textBox2Password.Location = new System.Drawing.Point(12, 185);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(254, 23);
            this.textBox2Password.TabIndex = 2;
            this.textBox2Password.Text = "Contraseña";
            this.textBox2Password.TextChanged += new System.EventHandler(this.textBox2Password_TextChanged);
            this.textBox2Password.Enter += new System.EventHandler(this.textBox2Password_Enter);
            this.textBox2Password.Leave += new System.EventHandler(this.textBox2Password_Leave);
            // 
            // label1_NombreProyecto
            // 
            this.label1_NombreProyecto.AutoSize = true;
            this.label1_NombreProyecto.BackColor = System.Drawing.Color.Transparent;
            this.label1_NombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_NombreProyecto.ForeColor = System.Drawing.Color.White;
            this.label1_NombreProyecto.Location = new System.Drawing.Point(12, 28);
            this.label1_NombreProyecto.Name = "label1_NombreProyecto";
            this.label1_NombreProyecto.Size = new System.Drawing.Size(269, 31);
            this.label1_NombreProyecto.TabIndex = 0;
            this.label1_NombreProyecto.Text = "SistemAutomecanica";
            this.label1_NombreProyecto.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1_RecupPassw
            // 
            this.linkLabel1_RecupPassw.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1_RecupPassw.AutoSize = true;
            this.linkLabel1_RecupPassw.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1_RecupPassw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1_RecupPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1_RecupPassw.LinkColor = System.Drawing.Color.White;
            this.linkLabel1_RecupPassw.Location = new System.Drawing.Point(9, 474);
            this.linkLabel1_RecupPassw.Name = "linkLabel1_RecupPassw";
            this.linkLabel1_RecupPassw.Size = new System.Drawing.Size(138, 17);
            this.linkLabel1_RecupPassw.TabIndex = 0;
            this.linkLabel1_RecupPassw.TabStop = true;
            this.linkLabel1_RecupPassw.Text = "Contraseña olvidada";
            // 
            // pictureBox1_Cerrar
            // 
            this.pictureBox1_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_Cerrar.Image")));
            this.pictureBox1_Cerrar.Location = new System.Drawing.Point(272, 9);
            this.pictureBox1_Cerrar.Name = "pictureBox1_Cerrar";
            this.pictureBox1_Cerrar.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1_Cerrar.TabIndex = 6;
            this.pictureBox1_Cerrar.TabStop = false;
            this.pictureBox1_Cerrar.Click += new System.EventHandler(this.pictureBox1_Cerrar_Click);
            // 
            // pictureBox2_Minimizar
            // 
            this.pictureBox2_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2_Minimizar.Image")));
            this.pictureBox2_Minimizar.Location = new System.Drawing.Point(250, 9);
            this.pictureBox2_Minimizar.Name = "pictureBox2_Minimizar";
            this.pictureBox2_Minimizar.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2_Minimizar.TabIndex = 7;
            this.pictureBox2_Minimizar.TabStop = false;
            this.pictureBox2_Minimizar.Click += new System.EventHandler(this.pictureBox2_Minimizar_Click);
            // 
            // button1_Access
            // 
            this.button1_Access.BackColor = System.Drawing.Color.Black;
            this.button1_Access.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Access.FlatAppearance.BorderSize = 0;
            this.button1_Access.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1_Access.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1_Access.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Access.ForeColor = System.Drawing.Color.White;
            this.button1_Access.Image = ((System.Drawing.Image)(resources.GetObject("button1_Access.Image")));
            this.button1_Access.Location = new System.Drawing.Point(12, 235);
            this.button1_Access.Name = "button1_Access";
            this.button1_Access.Size = new System.Drawing.Size(276, 40);
            this.button1_Access.TabIndex = 3;
            this.button1_Access.Text = "Entrar";
            this.button1_Access.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_Access.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1_Access.UseVisualStyleBackColor = false;
            this.button1_Access.Click += new System.EventHandler(this.button1_Access_Click);
            // 
            // label1_MsjError
            // 
            this.label1_MsjError.AutoSize = true;
            this.label1_MsjError.BackColor = System.Drawing.Color.Transparent;
            this.label1_MsjError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_MsjError.ForeColor = System.Drawing.Color.White;
            this.label1_MsjError.Image = ((System.Drawing.Image)(resources.GetObject("label1_MsjError.Image")));
            this.label1_MsjError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1_MsjError.Location = new System.Drawing.Point(15, 292);
            this.label1_MsjError.Name = "label1_MsjError";
            this.label1_MsjError.Size = new System.Drawing.Size(29, 13);
            this.label1_MsjError.TabIndex = 9;
            this.label1_MsjError.Text = "Error";
            this.label1_MsjError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1_MsjError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1_MsjError);
            this.Controls.Add(this.pictureBox2_Minimizar);
            this.Controls.Add(this.pictureBox1_Cerrar);
            this.Controls.Add(this.label1_NombreProyecto);
            this.Controls.Add(this.linkLabel1_RecupPassw);
            this.Controls.Add(this.button1_Access);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1Username);
            this.Controls.Add(this.label1_LogIn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1_LogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemAutomechanical ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_LogIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_LogIn;
        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Label label1_NombreProyecto;
        private System.Windows.Forms.LinkLabel linkLabel1_RecupPassw;
        private System.Windows.Forms.PictureBox pictureBox1_Cerrar;
        private System.Windows.Forms.PictureBox pictureBox2_Minimizar;
        private System.Windows.Forms.Button button1_Access;
        private System.Windows.Forms.Label label1_MsjError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

