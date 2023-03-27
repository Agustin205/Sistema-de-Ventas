
namespace Login_v1._1
{
    partial class BackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUp));
            this.label3 = new System.Windows.Forms.Label();
            this.Restaurar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelRBD = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.labelHB = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(17, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ubicacion:";
            // 
            // Restaurar
            // 
            this.Restaurar.BackColor = System.Drawing.Color.Navy;
            this.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restaurar.ForeColor = System.Drawing.Color.White;
            this.Restaurar.Location = new System.Drawing.Point(523, 158);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(122, 23);
            this.Restaurar.TabIndex = 18;
            this.Restaurar.Text = "Realizar Restauracion";
            this.Restaurar.UseVisualStyleBackColor = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 20);
            this.textBox2.TabIndex = 16;
            // 
            // labelRBD
            // 
            this.labelRBD.AutoSize = true;
            this.labelRBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelRBD.ForeColor = System.Drawing.Color.Navy;
            this.labelRBD.Location = new System.Drawing.Point(99, 114);
            this.labelRBD.Name = "labelRBD";
            this.labelRBD.Size = new System.Drawing.Size(296, 29);
            this.labelRBD.TabIndex = 15;
            this.labelRBD.Text = "Restaurar Base de Datos";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Navy;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(104, 72);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "Realizar BackUp";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // labelHB
            // 
            this.labelHB.AutoSize = true;
            this.labelHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelHB.ForeColor = System.Drawing.Color.Navy;
            this.labelHB.Location = new System.Drawing.Point(99, 19);
            this.labelHB.Name = "labelHB";
            this.labelHB.Size = new System.Drawing.Size(176, 29);
            this.labelHB.TabIndex = 10;
            this.labelHB.Text = "Hacer BackUp";
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
            this.dataGridView1.Location = new System.Drawing.Point(95, 206);
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
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Restaurar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelRBD);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelHB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackUp";
            this.ShowIcon = false;
            this.Text = "BackUp";
            this.Load += new System.EventHandler(this.BackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Restaurar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelRBD;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label labelHB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}