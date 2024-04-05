namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioEditarVistas
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
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtContraseña = new TextBox();
            txtNombreUser = new TextBox();
            txtIdPersona = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(183, 9);
            label5.Name = "label5";
            label5.Size = new Size(262, 37);
            label5.TabIndex = 24;
            label5.Text = "EDITAR USUARIO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button3.Location = new Point(483, 79);
            button3.Name = "button3";
            button3.Size = new Size(144, 34);
            button3.TabIndex = 22;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button2.Location = new Point(338, 322);
            button2.Name = "button2";
            button2.Size = new Size(117, 34);
            button2.TabIndex = 21;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button1.Location = new Point(170, 322);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 20;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(166, 209);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(299, 27);
            txtContraseña.TabIndex = 19;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(166, 147);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(299, 27);
            txtNombreUser.TabIndex = 18;
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(166, 85);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(299, 27);
            txtIdPersona.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 277);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 16;
            label4.Text = "FECHA REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 214);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 15;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 151);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 14;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 88);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 13;
            label1.Text = "IDPERSONA";
            // 
            // UsuarioEditarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(645, 372);
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
            Name = "UsuarioEditarVistas";
            Text = "UsuarioEditarVistas";
            Load += UsuarioEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtContraseña;
        private TextBox txtNombreUser;
        private TextBox txtIdPersona;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}