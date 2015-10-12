namespace EjerciciosCap11y_12
{
    partial class Ejercicio3
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
            this.Copiarbutton = new System.Windows.Forms.Button();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.NuevaRutatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Copiarbutton
            // 
            this.Copiarbutton.Location = new System.Drawing.Point(374, 132);
            this.Copiarbutton.Name = "Copiarbutton";
            this.Copiarbutton.Size = new System.Drawing.Size(88, 31);
            this.Copiarbutton.TabIndex = 0;
            this.Copiarbutton.Text = "Copiar";
            this.Copiarbutton.UseVisualStyleBackColor = true;
            this.Copiarbutton.Click += new System.EventHandler(this.Copiarbutton_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(135, 53);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(213, 20);
            this.NombretextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta del archivo";
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(135, 96);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(213, 20);
            this.RutatextBox.TabIndex = 4;
            this.RutatextBox.TextChanged += new System.EventHandler(this.RutatextBox_TextChanged);
            // 
            // NuevaRutatextBox
            // 
            this.NuevaRutatextBox.Location = new System.Drawing.Point(135, 138);
            this.NuevaRutatextBox.Name = "NuevaRutatextBox";
            this.NuevaRutatextBox.Size = new System.Drawing.Size(213, 20);
            this.NuevaRutatextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva ruta";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NuevaRutatextBox);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Copiarbutton);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Copiarbutton;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.TextBox NuevaRutatextBox;
        private System.Windows.Forms.Label label3;
    }
}