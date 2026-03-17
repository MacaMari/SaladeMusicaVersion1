namespace MercedesVersion1.Forms
{
    partial class FormQuienesSomos
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
            this.button3Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somos una academia dedicada a la enseñanza de musica";
            // 
            // button3Volver
            // 
            this.button3Volver.Location = new System.Drawing.Point(134, 117);
            this.button3Volver.Name = "button3Volver";
            this.button3Volver.Size = new System.Drawing.Size(75, 23);
            this.button3Volver.TabIndex = 1;
            this.button3Volver.Text = "Volver";
            this.button3Volver.UseVisualStyleBackColor = true;
            // 
            // FormQuienesSomos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 187);
            this.Controls.Add(this.button3Volver);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "FormQuienesSomos";
            this.Text = "FormQuienesSomos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3Volver;
    }
}