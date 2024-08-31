namespace CRUD_Parcial
{
    partial class Inicio
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
            this.bntGestion = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntGestion
            // 
            this.bntGestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntGestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGestion.Location = new System.Drawing.Point(199, 272);
            this.bntGestion.Name = "bntGestion";
            this.bntGestion.Size = new System.Drawing.Size(111, 48);
            this.bntGestion.TabIndex = 1;
            this.bntGestion.Text = "Gestion";
            this.bntGestion.UseVisualStyleBackColor = false;
            this.bntGestion.Click += new System.EventHandler(this.bntGestion_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListado.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnListado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListado.Location = new System.Drawing.Point(510, 272);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(111, 48);
            this.btnListado.TabIndex = 2;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 65.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(126, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "⁓Northwind⁓";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 466);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.bntGestion);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntGestion;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Label label1;
    }
}