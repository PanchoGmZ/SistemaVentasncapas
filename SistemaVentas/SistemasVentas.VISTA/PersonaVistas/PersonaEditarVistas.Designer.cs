namespace SistemasVentas.VISTA.PersonaVistas
{
    partial class PersonaEditarVistas
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
            button2 = new Button();
            button1 = new Button();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            txtCI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(337, 325);
            button2.Name = "button2";
            button2.Size = new Size(186, 35);
            button2.TabIndex = 23;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(79, 325);
            button1.Name = "button1";
            button1.Size = new Size(186, 35);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(178, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(345, 23);
            txtTelefono.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 144);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 20;
            label5.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(178, 242);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(345, 23);
            txtCorreo.TabIndex = 19;
            // 
            // txtCI
            // 
            txtCI.Location = new Point(178, 189);
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(345, 23);
            txtCI.TabIndex = 18;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(178, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(345, 23);
            txtApellido.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(178, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 23);
            txtNombre.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 240);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 15;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 187);
            label3.Name = "label3";
            label3.Size = new Size(24, 21);
            label3.TabIndex = 14;
            label3.Text = "CI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 13;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 44);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // PersonaEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 421);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(txtCI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonaEditarVistas";
            Text = "PersonaEditarVistas";
            Load += PersonaEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtCI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}