namespace EjerciciosCap11y_12
{
    partial class Ejercicio4
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
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(344, 82);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(92, 31);
            this.Eliminarbutton.TabIndex = 0;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese ruta y nombre";
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(145, 88);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(180, 20);
            this.RutatextBox.TabIndex = 2;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 222);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminarbutton);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutatextBox;
    }
}