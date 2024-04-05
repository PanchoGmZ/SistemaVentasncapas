namespace SistemaVentas.VISTA.MarcaVistas
{
    partial class MarcaInsertarVistas
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
            txtNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 65);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 71);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 23);
            txtNombre.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(66, 128);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 27);
            button1.TabIndex = 2;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(186, 128);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 27);
            button2.TabIndex = 3;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 18);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 14;
            label2.Text = "AGREGAR MARCA";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(85, 96);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(228, 23);
            txtEstado.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 90);
            label5.Name = "label5";
            label5.Size = new Size(68, 18);
            label5.TabIndex = 21;
            label5.Text = "ESTADO";
            // 
            // MarcaInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(338, 170);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MarcaInsertarVistas";
            Text = "MarcaInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtEstado;
        private Label label5;
    }
}