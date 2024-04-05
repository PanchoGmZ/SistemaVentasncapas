namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVistas
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdPersona = new TextBox();
            txtNombreUser = new TextBox();
            txtContraseña = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 84);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 131);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 178);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 226);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "FECHA REGISTRO";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(145, 82);
            txtIdPersona.Margin = new Padding(3, 2, 3, 2);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(262, 23);
            txtIdPersona.TabIndex = 4;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(145, 128);
            txtNombreUser.Margin = new Padding(3, 2, 3, 2);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(262, 23);
            txtNombreUser.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(145, 175);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(262, 23);
            txtContraseña.TabIndex = 6;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(148, 262);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(97, 26);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(295, 262);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 26);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(424, 81);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(123, 26);
            button3.TabIndex = 10;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 220);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(114, 23);
            label5.Name = "label5";
            label5.Size = new Size(267, 29);
            label5.TabIndex = 12;
            label5.Text = "AGREGAR UN USUARIO";
            // 
            // UsuarioInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(565, 300);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUser);
            Controls.Add(txtIdPersona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuarioInsertarVistas";
            Text = "UsuarioInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdPersona;
        private TextBox txtNombreUser;
        private TextBox txtContraseña;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}