namespace SistemaVentasVISTAS2.BienvenidosVISTAS
{
    partial class SeleccionarClienteDVistas
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
            panel2 = new Panel();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 42);
            label1.TabIndex = 9;
            label1.Text = "Clientes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(10, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 396);
            panel2.TabIndex = 8;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleTurquoise;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(13, 339);
            button7.Name = "button7";
            button7.Size = new Size(176, 30);
            button7.TabIndex = 9;
            button7.Text = "Seleccionar";
            button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(568, 301);
            dataGridView1.TabIndex = 8;
            // 
            // SeleccionarClienteDVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 456);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "SeleccionarClienteDVistas";
            Text = "SeleccionarClienteDVistas";
            Load += SeleccionarClienteDVistas_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button button7;
        private DataGridView dataGridView1;
    }
}