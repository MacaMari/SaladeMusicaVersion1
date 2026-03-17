namespace MercedesVersion1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1QuienSom = new System.Windows.Forms.Button();
            this.button2Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACADEMIA DE MUSICA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "MERCEDES SOSA";
            // 
            // button1QuienSom
            // 
            this.button1QuienSom.Location = new System.Drawing.Point(116, 155);
            this.button1QuienSom.Name = "button1QuienSom";
            this.button1QuienSom.Size = new System.Drawing.Size(91, 23);
            this.button1QuienSom.TabIndex = 2;
            this.button1QuienSom.Text = "Quienes Somos";
            this.button1QuienSom.UseVisualStyleBackColor = true;
            this.button1QuienSom.Click += new System.EventHandler(this.button1QuienSom_Click);
            // 
            // button2Ingresar
            // 
            this.button2Ingresar.Location = new System.Drawing.Point(116, 198);
            this.button2Ingresar.Name = "button2Ingresar";
            this.button2Ingresar.Size = new System.Drawing.Size(91, 23);
            this.button2Ingresar.TabIndex = 3;
            this.button2Ingresar.Text = "Ingresar";
            this.button2Ingresar.UseVisualStyleBackColor = true;
            this.button2Ingresar.Click += new System.EventHandler(this.button2Ingresar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 294);
            this.Controls.Add(this.button2Ingresar);
            this.Controls.Add(this.button1QuienSom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1QuienSom;
        private System.Windows.Forms.Button button2Ingresar;
    }
}

