namespace EjerciciosCap11y_12
{
    partial class Ejercicio5
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Ruta = new System.Windows.Forms.Label();
            this.NuevoNtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(123, 42);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(197, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(123, 88);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(197, 20);
            this.RutatextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Renombrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(36, 45);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // Ruta
            // 
            this.Ruta.AutoSize = true;
            this.Ruta.Location = new System.Drawing.Point(36, 91);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(30, 13);
            this.Ruta.TabIndex = 4;
            this.Ruta.Text = "Ruta";
            // 
            // NuevoNtextBox
            // 
            this.NuevoNtextBox.Location = new System.Drawing.Point(123, 134);
            this.NuevoNtextBox.Name = "NuevoNtextBox";
            this.NuevoNtextBox.Size = new System.Drawing.Size(197, 20);
            this.NuevoNtextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nuevo nombre";
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NuevoNtextBox);
            this.Controls.Add(this.Ruta);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Ruta;
        private System.Windows.Forms.TextBox NuevoNtextBox;
        private System.Windows.Forms.Label label3;
    }
}