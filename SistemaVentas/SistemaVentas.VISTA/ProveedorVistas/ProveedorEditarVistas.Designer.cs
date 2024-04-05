namespace SistemaVentas.VISTA.ProveedorVistas
{
    partial class ProveedorEditarVistas
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
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(268, 211);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 28);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(130, 211);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(99, 28);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(110, 148);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(294, 23);
            txtDireccion.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(110, 106);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(294, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 63);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 23);
            txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 149);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 10;
            label3.Text = "DIRECCION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 106);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 9;
            label2.Text = "TELEFONO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 64);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 8;
            label1.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(77, 15);
            label4.Name = "label4";
            label4.Size = new Size(325, 32);
            label4.TabIndex = 16;
            label4.Text = "EDITAR PROVEEDOR";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(110, 186);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(267, 23);
            txtEstado.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 187);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 25;
            label6.Text = "ESTADO";
            // 
            // ProveedorEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(428, 248);
            Controls.Add(txtEstado);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProveedorEditarVistas";
            Text = "ProveedorEditarVistas";
            Load += ProveedorEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtEstado;
        private Label label6;
    }
}