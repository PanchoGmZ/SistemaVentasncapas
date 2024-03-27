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
            label1 = new Label();
            txtNombreRol = new TextBox();
            GuardarBtn = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 117);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(121, 119);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(282, 23);
            txtNombreRol.TabIndex = 1;
            txtNombreRol.TextChanged += txtNombreRol_TextChanged_1;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(183, 178);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(110, 39);
            GuardarBtn.TabIndex = 2;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 50);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 3;
            label2.Text = "Rol";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(293, 50);
            button1.Name = "button1";
            button1.Size = new Size(110, 25);
            button1.TabIndex = 5;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RolInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 288);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(GuardarBtn);
            Controls.Add(txtNombreRol);
            Controls.Add(label1);
            Name = "RolInsertarVista";
            Text = "RolInsertarVista";
            Load += RolInsertarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreRol;
        private Button GuardarBtn;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}