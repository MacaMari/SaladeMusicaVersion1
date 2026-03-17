namespace MercedesVersion1.Forms
{
    partial class FormIngresar
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
            this.Button4Docente = new System.Windows.Forms.Button();
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button4Docente
            // 
            this.Button4Docente.Location = new System.Drawing.Point(88, 65);
            this.Button4Docente.Name = "Button4Docente";
            this.Button4Docente.Size = new System.Drawing.Size(92, 23);
            this.Button4Docente.TabIndex = 0;
            this.Button4Docente.Text = "DOCENTE";
            this.Button4Docente.UseVisualStyleBackColor = true;
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.Location = new System.Drawing.Point(88, 114);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Size = new System.Drawing.Size(92, 23);
            this.buttonEstudiante.TabIndex = 1;
            this.buttonEstudiante.Text = "ESTUDIANTE";
            this.buttonEstudiante.UseVisualStyleBackColor = true;
            // 
            // FormIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 262);
            this.Controls.Add(this.buttonEstudiante);
            this.Controls.Add(this.Button4Docente);
            this.IsMdiContainer = true;
            this.Name = "FormIngresar";
            this.Text = "FormIngresar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button4Docente;
        private System.Windows.Forms.Button buttonEstudiante;
    }
}