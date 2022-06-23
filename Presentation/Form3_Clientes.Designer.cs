
namespace Presentation
{
    partial class Form3_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_Clientes));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1_Cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // pictureBox1_Cerrar
            // 
            this.pictureBox1_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_Cerrar.Image")));
            this.pictureBox1_Cerrar.Location = new System.Drawing.Point(602, 12);
            this.pictureBox1_Cerrar.Name = "pictureBox1_Cerrar";
            this.pictureBox1_Cerrar.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1_Cerrar.TabIndex = 1;
            this.pictureBox1_Cerrar.TabStop = false;
            this.pictureBox1_Cerrar.Click += new System.EventHandler(this.pictureBox1_Cerrar_Click);
            // 
            // Form3_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 377);
            this.Controls.Add(this.pictureBox1_Cerrar);
            this.Controls.Add(this.label1);
            this.Name = "Form3_Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1_Cerrar;
    }
}