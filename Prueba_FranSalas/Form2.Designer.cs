namespace Prueba_FranSalas
{
    partial class Form2
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
            this.cmdLeer = new System.Windows.Forms.Button();
            this.cmdEscribri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLeer
            // 
            this.cmdLeer.Location = new System.Drawing.Point(27, 31);
            this.cmdLeer.Name = "cmdLeer";
            this.cmdLeer.Size = new System.Drawing.Size(75, 23);
            this.cmdLeer.TabIndex = 0;
            this.cmdLeer.Text = "Leer";
            this.cmdLeer.UseVisualStyleBackColor = true;
            this.cmdLeer.Click += new System.EventHandler(this.cmdLeer_Click);
            // 
            // cmdEscribri
            // 
            this.cmdEscribri.Location = new System.Drawing.Point(133, 31);
            this.cmdEscribri.Name = "cmdEscribri";
            this.cmdEscribri.Size = new System.Drawing.Size(75, 23);
            this.cmdEscribri.TabIndex = 1;
            this.cmdEscribri.Text = "Escribir";
            this.cmdEscribri.UseVisualStyleBackColor = true;
            this.cmdEscribri.Click += new System.EventHandler(this.cmdEscribri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 68);
            this.Controls.Add(this.cmdEscribri);
            this.Controls.Add(this.cmdLeer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLeer;
        private System.Windows.Forms.Button cmdEscribri;
    }
}