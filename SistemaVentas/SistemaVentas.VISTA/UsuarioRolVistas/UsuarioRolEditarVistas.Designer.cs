namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolEditarVistas
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
            btnSelecMarca = new Button();
            btnSelecTiProd = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            txtIdRol = new TextBox();
            txtIdUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSelecMarca
            // 
            btnSelecMarca.BackColor = Color.Transparent;
            btnSelecMarca.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecMarca.Location = new Point(400, 120);
            btnSelecMarca.Margin = new Padding(3, 2, 3, 2);
            btnSelecMarca.Name = "btnSelecMarca";
            btnSelecMarca.Size = new Size(123, 27);
            btnSelecMarca.TabIndex = 27;
            btnSelecMarca.Text = "SELECCIONAR";
            btnSelecMarca.UseVisualStyleBackColor = false;
            btnSelecMarca.Click += btnSelecMarca_Click;
            // 
            // btnSelecTiProd
            // 
            btnSelecTiProd.BackColor = Color.Transparent;
            btnSelecTiProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecTiProd.Location = new Point(400, 78);
            btnSelecTiProd.Margin = new Padding(3, 2, 3, 2);
            btnSelecTiProd.Name = "btnSelecTiProd";
            btnSelecTiProd.Size = new Size(123, 30);
            btnSelecTiProd.TabIndex = 26;
            btnSelecTiProd.Text = "SELECCIONAR";
            btnSelecTiProd.UseVisualStyleBackColor = false;
            btnSelecTiProd.Click += btnSelecTiProd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(133, 171);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(285, 236);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 28);
            button2.TabIndex = 24;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(146, 236);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 28);
            button1.TabIndex = 23;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(133, 127);
            txtIdRol.Margin = new Padding(3, 2, 3, 2);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(262, 23);
            txtIdRol.TabIndex = 22;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(133, 85);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(262, 23);
            txtIdUsuario.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 171);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 20;
            label3.Text = "FECHA ASIGNA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 128);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 19;
            label2.Text = "IDROL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 86);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 18;
            label1.Text = "IDUSUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 25);
            label4.Name = "label4";
            label4.Size = new Size(272, 35);
            label4.TabIndex = 28;
            label4.Text = "EDITAR USUARIOROL";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(132, 208);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(262, 23);
            txtEstado.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(61, 209);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 29;
            label5.Text = "ESTADO";
            // 
            // UsuarioRolEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(537, 273);
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
            Name = "UsuarioRolEditarVistas";
            Text = "UsuarioRolEditarVistas";
            Load += UsuarioRolEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecMarca;
        private Button btnSelecTiProd;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox txtIdRol;
        private TextBox txtIdUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtEstado;
        private Label label5;
    }
}