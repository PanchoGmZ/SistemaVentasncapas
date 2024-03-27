namespace SistemaVentasVISTAS2.BienvenidosVISTAS
{
    partial class DashboardMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMenu));
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-5, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 450);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumSeaGreen;
            button5.BackgroundImage = Properties.Resources.objetivo;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(15, 346);
            button5.Name = "button5";
            button5.Size = new Size(129, 57);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSeaGreen;
            button4.BackgroundImage = Properties.Resources.repartidor;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(15, 262);
            button4.Name = "button4";
            button4.Size = new Size(129, 57);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.BackgroundImage = Properties.Resources.carrito_de_compras;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(15, 179);
            button3.Name = "button3";
            button3.Size = new Size(129, 57);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.BackgroundImage = Properties.Resources.proteccion;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(15, 95);
            button2.Name = "button2";
            button2.Size = new Size(129, 57);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(15, 18);
            button1.Name = "button1";
            button1.Size = new Size(129, 57);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(button6);
            panel2.Location = new Point(164, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 388);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Aquamarine;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(452, 297);
            button6.Name = "button6";
            button6.Size = new Size(129, 57);
            button6.TabIndex = 5;
            button6.Text = "Cerrar Sesion";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(412, 42);
            label1.TabIndex = 2;
            label1.Text = "Dashboard Principal";
            // 
            // DashboardMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(757, 431);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DashboardMenu";
            Text = "DashboardMenu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
    }
}