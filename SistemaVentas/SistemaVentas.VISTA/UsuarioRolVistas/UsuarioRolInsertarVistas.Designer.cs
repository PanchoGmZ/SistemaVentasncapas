namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolInsertarVistas
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
            txtIdUsuario = new TextBox();
            txtIdRol = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnSelecMarca = new Button();
            btnSelecTiProd = new Button();
            label4 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 88);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "IDUSUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 130);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 1;
            label2.Text = "IDROL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 174);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 2;
            label3.Text = "FECHA ASIGNA";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(136, 88);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(262, 23);
            txtIdUsuario.TabIndex = 3;
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(136, 130);
            txtIdRol.Margin = new Padding(3, 2, 3, 2);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(262, 23);
            txtIdRol.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(144, 240);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(284, 240);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(99, 30);
            button2.TabIndex = 7;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 174);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnSelecMarca
            // 
            btnSelecMarca.BackColor = Color.Transparent;
            btnSelecMarca.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecMarca.Location = new Point(403, 124);
            btnSelecMarca.Margin = new Padding(3, 2, 3, 2);
            btnSelecMarca.Name = "btnSelecMarca";
            btnSelecMarca.Size = new Size(124, 27);
            btnSelecMarca.TabIndex = 17;
            btnSelecMarca.Text = "SELECCIONAR";
            btnSelecMarca.UseVisualStyleBackColor = false;

            // 
            // btnSelecTiProd
            // 
            btnSelecTiProd.BackColor = Color.Transparent;
            btnSelecTiProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecTiProd.Location = new Point(403, 82);
            btnSelecTiProd.Margin = new Padding(3, 2, 3, 2);
            btnSelecTiProd.Name = "btnSelecTiProd";
            btnSelecTiProd.Size = new Size(124, 28);
            btnSelecTiProd.TabIndex = 16;
            btnSelecTiProd.Text = "SELECCIONAR";
            btnSelecTiProd.UseVisualStyleBackColor = false;
            btnSelecTiProd.Click += btnSelecTiProd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 21);
            label4.Name = "label4";
            label4.Size = new Size(416, 35);
            label4.TabIndex = 18;
            label4.Text = "AGREGA UN NUEVO USUARIOROL";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(136, 215);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(262, 23);
            txtEstado.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(66, 216);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 19;
            label5.Text = "ESTADO";
            // 
            // UsuarioRolInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(550, 294);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSelecMarca);
            Controls.Add(btnSelecTiProd);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdRol);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuarioRolInsertarVistas";
            Text = "UsuarioRolInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdUsuario;
        private TextBox txtIdRol;
        private TextBox txtFechaAsigna;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button btnSelecMarca;
        private Button btnSelecTiProd;
        private Label label4;
        private TextBox txtEstado;
        private Label label5;
    }
}