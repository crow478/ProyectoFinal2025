namespace proyecto_final_1
{
    partial class Form8
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
            this.comboBoxIdUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxIdUsuario
            // 
            this.comboBoxIdUsuario.FormattingEnabled = true;
            this.comboBoxIdUsuario.Location = new System.Drawing.Point(33, 77);
            this.comboBoxIdUsuario.Name = "comboBoxIdUsuario";
            this.comboBoxIdUsuario.Size = new System.Drawing.Size(227, 24);
            this.comboBoxIdUsuario.TabIndex = 0;
            this.comboBoxIdUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxIdUsuario);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdUsuario;
    }
}