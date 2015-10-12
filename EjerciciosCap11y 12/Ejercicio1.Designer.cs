namespace EjerciciosCap11y_12
{
    partial class Ejercicio1
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
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.CadenalistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese cadena";
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(99, 45);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(100, 20);
            this.CadenatextBox.TabIndex = 1;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(215, 40);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 2;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // CadenalistView
            // 
            this.CadenalistView.Location = new System.Drawing.Point(15, 86);
            this.CadenalistView.Name = "CadenalistView";
            this.CadenalistView.Size = new System.Drawing.Size(275, 97);
            this.CadenalistView.TabIndex = 3;
            this.CadenalistView.UseCompatibleStateImageBehavior = false;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 262);
            this.Controls.Add(this.CadenalistView);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.CadenatextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.ListView CadenalistView;
    }
}