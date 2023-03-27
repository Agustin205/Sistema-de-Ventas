
namespace Login_v1._1
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alta = new System.Windows.Forms.Button();
            this.labelP = new System.Windows.Forms.Label();
            this.Baja = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.BajaTemporal = new System.Windows.Forms.Button();
            this.Venta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPor2 = new System.Windows.Forms.Label();
            this.labelPor1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(58)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(92, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(797, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.Navy;
            this.Alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alta.ForeColor = System.Drawing.Color.White;
            this.Alta.Location = new System.Drawing.Point(105, 298);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(106, 37);
            this.Alta.TabIndex = 2;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = false;
            this.Alta.Click += new System.EventHandler(this.Ver_Click);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.ForeColor = System.Drawing.Color.Navy;
            this.labelP.Location = new System.Drawing.Point(470, 27);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(127, 29);
            this.labelP.TabIndex = 3;
            this.labelP.Text = "Productos";
            // 
            // Baja
            // 
            this.Baja.BackColor = System.Drawing.Color.Navy;
            this.Baja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Baja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baja.ForeColor = System.Drawing.Color.White;
            this.Baja.Location = new System.Drawing.Point(294, 298);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(139, 37);
            this.Baja.TabIndex = 4;
            this.Baja.Text = "Baja Total";
            this.Baja.UseVisualStyleBackColor = false;
            this.Baja.Click += new System.EventHandler(this.Baja_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.Navy;
            this.Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.White;
            this.Modificar.Location = new System.Drawing.Point(725, 298);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(130, 37);
            this.Modificar.TabIndex = 5;
            this.Modificar.Text = "Modificacion";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BajaTemporal
            // 
            this.BajaTemporal.BackColor = System.Drawing.Color.Navy;
            this.BajaTemporal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BajaTemporal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BajaTemporal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BajaTemporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaTemporal.ForeColor = System.Drawing.Color.White;
            this.BajaTemporal.Location = new System.Drawing.Point(509, 298);
            this.BajaTemporal.Name = "BajaTemporal";
            this.BajaTemporal.Size = new System.Drawing.Size(149, 37);
            this.BajaTemporal.TabIndex = 6;
            this.BajaTemporal.Text = "Baja Temporal";
            this.BajaTemporal.UseVisualStyleBackColor = false;
            this.BajaTemporal.Click += new System.EventHandler(this.BajaTemporal_Click);
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.Color.Navy;
            this.Venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta.ForeColor = System.Drawing.Color.White;
            this.Venta.Location = new System.Drawing.Point(783, 39);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(106, 37);
            this.Venta.TabIndex = 7;
            this.Venta.Text = "Venta";
            this.Venta.UseVisualStyleBackColor = false;
            this.Venta.Visible = false;
            this.Venta.Click += new System.EventHandler(this.Venta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(102, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "La cantidad actual en comparacion a la optima es %";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(102, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "La cantidad actual en comparacion a la minima es %";
            this.label3.Visible = false;
            // 
            // labelPor2
            // 
            this.labelPor2.AutoSize = true;
            this.labelPor2.ForeColor = System.Drawing.Color.Navy;
            this.labelPor2.Location = new System.Drawing.Point(353, 43);
            this.labelPor2.Name = "labelPor2";
            this.labelPor2.Size = new System.Drawing.Size(10, 13);
            this.labelPor2.TabIndex = 10;
            this.labelPor2.Text = ".";
            this.labelPor2.Visible = false;
            // 
            // labelPor1
            // 
            this.labelPor1.AutoSize = true;
            this.labelPor1.ForeColor = System.Drawing.Color.Navy;
            this.labelPor1.Location = new System.Drawing.Point(353, 63);
            this.labelPor1.Name = "labelPor1";
            this.labelPor1.Size = new System.Drawing.Size(10, 13);
            this.labelPor1.TabIndex = 11;
            this.labelPor1.Text = ".";
            this.labelPor1.Visible = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.labelPor1);
            this.Controls.Add(this.labelPor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.BajaTemporal);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PropuestasReparador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Button Baja;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button BajaTemporal;
        private System.Windows.Forms.Button Venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPor2;
        private System.Windows.Forms.Label labelPor1;
    }
}