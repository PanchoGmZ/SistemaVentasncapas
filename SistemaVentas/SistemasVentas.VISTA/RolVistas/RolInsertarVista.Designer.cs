namespace SistemasVentas.VISTA.RolVistas
{
    partial class RolInsertarVista
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
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(122, 79);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(282, 23);
            this.txtNombreRol.TabIndex = 1;
            this.txtNombreRol.TextChanged += new System.EventHandler(this.txtNombreRol_TextChanged_1);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(161, 133);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(110, 39);
            this.GuardarBtn.TabIndex = 2;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // RolInsertarVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 288);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label1);
            this.Name = "RolInsertarVista";
            this.Text = "RolInsertarVista";
            this.Load += new System.EventHandler(this.RolInsertarVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombreRol;
        private Button GuardarBtn;
    }
}