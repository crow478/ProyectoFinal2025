namespace proyecto_final_1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carbohidratos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idproducto = new System.Windows.Forms.TextBox();
            this.proteinas = new System.Windows.Forms.TextBox();
            this.grasas = new System.Windows.Forms.TextBox();
            this.energias = new System.Windows.Forms.TextBox();
            this.calorias = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbalimento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ALIMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 81);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO ALIEMNTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CARBOHIDRATOS  (g)";
            // 
            // carbohidratos
            // 
            this.carbohidratos.Location = new System.Drawing.Point(26, 180);
            this.carbohidratos.Name = "carbohidratos";
            this.carbohidratos.Size = new System.Drawing.Size(100, 22);
            this.carbohidratos.TabIndex = 10;
            this.carbohidratos.TextChanged += new System.EventHandler(this.carbohidratos_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "PROTEINAS (g)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "GRASAS (g)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "ENERGIAS (kcal)";
            // 
            // idproducto
            // 
            this.idproducto.Location = new System.Drawing.Point(26, 109);
            this.idproducto.Name = "idproducto";
            this.idproducto.Size = new System.Drawing.Size(100, 22);
            this.idproducto.TabIndex = 15;
            // 
            // proteinas
            // 
            this.proteinas.Location = new System.Drawing.Point(197, 180);
            this.proteinas.Name = "proteinas";
            this.proteinas.Size = new System.Drawing.Size(100, 22);
            this.proteinas.TabIndex = 18;
            // 
            // grasas
            // 
            this.grasas.Location = new System.Drawing.Point(398, 180);
            this.grasas.Name = "grasas";
            this.grasas.Size = new System.Drawing.Size(100, 22);
            this.grasas.TabIndex = 19;
            // 
            // energias
            // 
            this.energias.Location = new System.Drawing.Point(26, 272);
            this.energias.Name = "energias";
            this.energias.Size = new System.Drawing.Size(100, 22);
            this.energias.TabIndex = 20;
            // 
            // calorias
            // 
            this.calorias.Location = new System.Drawing.Point(197, 272);
            this.calorias.Name = "calorias";
            this.calorias.Size = new System.Drawing.Size(100, 22);
            this.calorias.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "SIGUIENTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(197, 100);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(153, 24);
            this.cmbproducto.TabIndex = 24;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "CALORIAS (kcal)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbalimento
            // 
            this.cmbalimento.FormattingEnabled = true;
            this.cmbalimento.Location = new System.Drawing.Point(398, 100);
            this.cmbalimento.Name = "cmbalimento";
            this.cmbalimento.Size = new System.Drawing.Size(153, 24);
            this.cmbalimento.TabIndex = 26;
            this.cmbalimento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 374);
            this.Controls.Add(this.cmbalimento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbproducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calorias);
            this.Controls.Add(this.energias);
            this.Controls.Add(this.grasas);
            this.Controls.Add(this.proteinas);
            this.Controls.Add(this.idproducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.carbohidratos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox carbohidratos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idproducto;
        private System.Windows.Forms.TextBox proteinas;
        private System.Windows.Forms.TextBox grasas;
        private System.Windows.Forms.TextBox energias;
        private System.Windows.Forms.TextBox calorias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbalimento;
    }
}