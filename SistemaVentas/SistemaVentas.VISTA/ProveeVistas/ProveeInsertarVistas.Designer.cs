namespace SistemaVentas.VISTA.ProveeVistas
{
    partial class ProveeInsertarVistas
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
            label5 = new Label();
            txtIdProducto = new TextBox();
            txtProveedor = new TextBox();
            txtPrecio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnSelecProvee = new Button();
            btnSelecProd = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 82);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "IDPRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 114);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "IDPROVEEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 213);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 148);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 3;
            label4.Text = "FECHA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 179);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 4;
            label5.Text = "PRECIO";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(157, 82);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(316, 27);
            txtIdProducto.TabIndex = 5;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(157, 114);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(316, 27);
            txtProveedor.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(157, 178);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(316, 27);
            txtPrecio.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(190, 228);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 9;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(341, 228);
            button2.Name = "button2";
            button2.Size = new Size(115, 31);
            button2.TabIndex = 10;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(157, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // btnSelecProvee
            // 
            btnSelecProvee.BackColor = Color.FromArgb(0, 192, 192);
            btnSelecProvee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecProvee.Location = new Point(479, 109);
            btnSelecProvee.Name = "btnSelecProvee";
            btnSelecProvee.Size = new Size(142, 33);
            btnSelecProvee.TabIndex = 17;
            btnSelecProvee.Text = "SELECCIONAR";
            btnSelecProvee.UseVisualStyleBackColor = false;
            btnSelecProvee.Click += btnSelecProvee_Click;
            // 
            // btnSelecProd
            // 
            btnSelecProd.BackColor = Color.FromArgb(0, 192, 192);
            btnSelecProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecProd.Location = new Point(479, 72);
            btnSelecProd.Name = "btnSelecProd";
            btnSelecProd.Size = new Size(142, 33);
            btnSelecProd.TabIndex = 16;
            btnSelecProd.Text = "SELECCIONAR";
            btnSelecProd.UseVisualStyleBackColor = false;
            btnSelecProd.Click += btnSelecProd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(190, 21);
            label6.Name = "label6";
            label6.Size = new Size(273, 37);
            label6.TabIndex = 18;
            label6.Text = "AGREGAR PROVEE";
            // 
            // ProveeInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(642, 282);
            Controls.Add(label6);
            Controls.Add(btnSelecProvee);
            Controls.Add(btnSelecProd);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(txtProveedor);
            Controls.Add(txtIdProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProveeInsertarVistas";
            Text = "ProveeInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdProducto;
        private TextBox txtProveedor;
        private TextBox txtPrecio;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button btnSelecProvee;
        private Button btnSelecProd;
        private Label label6;
    }
}