
namespace Login_v1._1
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.Registrarse = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.linkOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.labelErr = new System.Windows.Forms.Label();
            this.BackUp = new System.Windows.Forms.Button();
            this.ActualizarDV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 1;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.Color.Navy;
            this.IniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.Color.White;
            this.IniciarSesion.Location = new System.Drawing.Point(415, 168);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(96, 41);
            this.IniciarSesion.TabIndex = 2;
            this.IniciarSesion.Text = "Iniciar Sesion";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // Registrarse
            // 
            this.Registrarse.BackColor = System.Drawing.Color.Navy;
            this.Registrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Registrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrarse.ForeColor = System.Drawing.Color.White;
            this.Registrarse.Location = new System.Drawing.Point(563, 168);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(90, 41);
            this.Registrarse.TabIndex = 3;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = false;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(338, 75);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Contraseña.Location = new System.Drawing.Point(338, 124);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 5;
            this.Contraseña.Text = "Contraseña";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTitulo.Location = new System.Drawing.Point(488, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(91, 25);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Acceder";
            // 
            // linkOlvideContraseña
            // 
            this.linkOlvideContraseña.AutoSize = true;
            this.linkOlvideContraseña.Location = new System.Drawing.Point(475, 224);
            this.linkOlvideContraseña.Name = "linkOlvideContraseña";
            this.linkOlvideContraseña.Size = new System.Drawing.Size(125, 13);
            this.linkOlvideContraseña.TabIndex = 8;
            this.linkOlvideContraseña.TabStop = true;
            this.linkOlvideContraseña.Text = "Olvidaste tu contraseña?";
            this.linkOlvideContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOlvideContraseña_LinkClicked);
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.ForeColor = System.Drawing.Color.Red;
            this.labelErr.Location = new System.Drawing.Point(281, 11);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(202, 13);
            this.labelErr.TabIndex = 17;
            this.labelErr.Text = "Error En DV. No se podrá usar el sistema.";
            this.labelErr.Visible = false;
            // 
            // BackUp
            // 
            this.BackUp.BackColor = System.Drawing.Color.Navy;
            this.BackUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BackUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackUp.ForeColor = System.Drawing.Color.White;
            this.BackUp.Location = new System.Drawing.Point(281, 39);
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(75, 23);
            this.BackUp.TabIndex = 18;
            this.BackUp.Text = "Back Up";
            this.BackUp.UseVisualStyleBackColor = false;
            this.BackUp.Visible = false;
            this.BackUp.Click += new System.EventHandler(this.BackUp_Click);
            // 
            // ActualizarDV
            // 
            this.ActualizarDV.BackColor = System.Drawing.Color.Navy;
            this.ActualizarDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ActualizarDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.ActualizarDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarDV.ForeColor = System.Drawing.Color.White;
            this.ActualizarDV.Location = new System.Drawing.Point(363, 39);
            this.ActualizarDV.Name = "ActualizarDV";
            this.ActualizarDV.Size = new System.Drawing.Size(78, 23);
            this.ActualizarDV.TabIndex = 19;
            this.ActualizarDV.Text = "ActualizarDV";
            this.ActualizarDV.UseVisualStyleBackColor = false;
            this.ActualizarDV.Visible = false;
            this.ActualizarDV.Click += new System.EventHandler(this.ActualizarDV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 256);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Navy;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(647, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(780, 254);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ActualizarDV);
            this.Controls.Add(this.BackUp);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.linkOlvideContraseña);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginUser";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label labelTitulo;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkOlvideContraseña;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.Button BackUp;
        private System.Windows.Forms.Button ActualizarDV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}