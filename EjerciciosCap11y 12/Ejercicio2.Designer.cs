namespace EjerciciosCap11y_12
{
    partial class Ejercicio2
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.Abrirbutton = new System.Windows.Forms.Button();
            this.ArchivolistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Ruta";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(133, 21);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(150, 20);
            this.NombretextBox.TabIndex = 2;
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(133, 61);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(150, 20);
            this.RutatextBox.TabIndex = 3;
            // 
            // Abrirbutton
            // 
            this.Abrirbutton.Location = new System.Drawing.Point(304, 50);
            this.Abrirbutton.Name = "Abrirbutton";
            this.Abrirbutton.Size = new System.Drawing.Size(103, 34);
            this.Abrirbutton.TabIndex = 4;
            this.Abrirbutton.Text = "Abrir";
            this.Abrirbutton.UseVisualStyleBackColor = true;
            this.Abrirbutton.Click += new System.EventHandler(this.Abrirbutton_Click);
            // 
            // ArchivolistView
            // 
            this.ArchivolistView.Location = new System.Drawing.Point(25, 123);
            this.ArchivolistView.Name = "ArchivolistView";
            this.ArchivolistView.Size = new System.Drawing.Size(382, 97);
            this.ArchivolistView.TabIndex = 5;
            this.ArchivolistView.UseCompatibleStateImageBehavior = false;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.ArchivolistView);
            this.Controls.Add(this.Abrirbutton);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.Button Abrirbutton;
        private System.Windows.Forms.ListView ArchivolistView;
    }
}