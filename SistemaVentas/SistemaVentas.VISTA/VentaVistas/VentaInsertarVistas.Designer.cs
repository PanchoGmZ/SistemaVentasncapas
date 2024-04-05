namespace SistemaVentas.VISTA.VentaVistas
{
    partial class VentaInsertarVistas
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
            txtIdCliente = new TextBox();
            txtIdVendedor = new TextBox();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnSelecliente = new Button();
            btnSelecVendedor = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtEstado = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 66);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "IDCLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 99);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 1;
            label2.Text = "IDVENDEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 2;
            label3.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(68, 167);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 3;
            label4.Text = "TOTAL";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(130, 63);
            txtIdCliente.Margin = new Padding(3, 2, 3, 2);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(259, 23);
            txtIdCliente.TabIndex = 4;
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(130, 97);
            txtIdVendedor.Margin = new Padding(3, 2, 3, 2);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(259, 23);
            txtIdVendedor.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(130, 164);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(259, 23);
            txtTotal.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(138, 232);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 25);
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
            button2.Location = new Point(270, 232);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 25);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSelecliente
            // 
            btnSelecliente.BackColor = Color.Transparent;
            btnSelecliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecliente.Location = new Point(412, 57);
            btnSelecliente.Margin = new Padding(3, 2, 3, 2);
            btnSelecliente.Name = "btnSelecliente";
            btnSelecliente.Size = new Size(123, 26);
            btnSelecliente.TabIndex = 10;
            btnSelecliente.Text = "SELECCIONAR";
            btnSelecliente.UseVisualStyleBackColor = false;
            btnSelecliente.Click += btnSelecliente_Click;
            // 
            // btnSelecVendedor
            // 
            btnSelecVendedor.BackColor = Color.Transparent;
            btnSelecVendedor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecVendedor.Location = new Point(412, 96);
            btnSelecVendedor.Margin = new Padding(3, 2, 3, 2);
            btnSelecVendedor.Name = "btnSelecVendedor";
            btnSelecVendedor.Size = new Size(123, 25);
            btnSelecVendedor.TabIndex = 11;
            btnSelecVendedor.Text = "SELECCIONAR";
            btnSelecVendedor.UseVisualStyleBackColor = false;
            btnSelecVendedor.Click += btnSelecVendedor_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 129);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(130, 196);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(259, 23);
            txtEstado.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 200);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 13;
            label5.Text = "ESTADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(146, 15);
            label6.Name = "label6";
            label6.Size = new Size(200, 30);
            label6.TabIndex = 17;
            label6.Text = "AGREGAR VENTA";
            // 
            // VentaInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(556, 270);
            Controls.Add(label6);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSelecVendedor);
            Controls.Add(btnSelecliente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(txtIdVendedor);
            Controls.Add(txtIdCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentaInsertarVistas";
            Text = "VentaInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdCliente;
        private TextBox txtIdVendedor;
        private TextBox txtFecha;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private Button btnSelecliente;
        private Button btnSelecVendedor;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEstado;
        private Label label5;
        private Label label6;
    }
}