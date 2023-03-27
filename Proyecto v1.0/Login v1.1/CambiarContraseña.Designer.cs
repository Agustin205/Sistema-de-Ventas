namespace Login_v1._1
{
    partial class CambiarContraseña
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
            this.labelEm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRC = new System.Windows.Forms.Label();
            this.labelCN = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCN2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEm
            // 
            this.labelEm.AutoSize = true;
            this.labelEm.ForeColor = System.Drawing.Color.Navy;
            this.labelEm.Location = new System.Drawing.Point(34, 82);
            this.labelEm.Name = "labelEm";
            this.labelEm.Size = new System.Drawing.Size(32, 13);
            this.labelEm.TabIndex = 6;
            this.labelEm.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelRC
            // 
            this.labelRC.AutoSize = true;
            this.labelRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRC.ForeColor = System.Drawing.Color.Navy;
            this.labelRC.Location = new System.Drawing.Point(147, 21);
            this.labelRC.Name = "labelRC";
            this.labelRC.Size = new System.Drawing.Size(256, 25);
            this.labelRC.TabIndex = 7;
            this.labelRC.Text = "Reestablecer Contraseña";
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.ForeColor = System.Drawing.Color.Navy;
            this.labelCN.Location = new System.Drawing.Point(34, 104);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(96, 13);
            this.labelCN.TabIndex = 9;
            this.labelCN.Text = "Contraseña Nueva";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 8;
            // 
            // labelCN2
            // 
            this.labelCN2.AutoSize = true;
            this.labelCN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCN2.ForeColor = System.Drawing.Color.Navy;
            this.labelCN2.Location = new System.Drawing.Point(34, 133);
            this.labelCN2.Name = "labelCN2";
            this.labelCN2.Size = new System.Drawing.Size(96, 13);
            this.labelCN2.TabIndex = 11;
            this.labelCN2.Text = "Contraseña Nueva";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 20);
            this.textBox3.TabIndex = 10;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.Navy;
            this.btnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.ForeColor = System.Drawing.Color.White;
            this.btnRestablecer.Location = new System.Drawing.Point(137, 172);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(266, 23);
            this.btnRestablecer.TabIndex = 12;
            this.btnRestablecer.Text = "Restablecer Contraseña";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Navy;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.ForeColor = System.Drawing.Color.White;
            this.cerrar.Location = new System.Drawing.Point(21, 172);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 13;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(505, 207);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.labelCN2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelCN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelRC);
            this.Controls.Add(this.labelEm);
            this.Controls.Add(this.textBox1);
            this.Name = "CambiarContraseña";
            this.Text = "CambiarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEm;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRC;
        private System.Windows.Forms.Label labelCN;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCN2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button cerrar;
    }
}