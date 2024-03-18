namespace SistemasVentas.Vista.PersonaVistas
{
    partial class PersonaListarVista
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
            dataGridView1 = new DataGridView();
            btn_Seleccionar = new Button();
            Agregar_btn = new Button();
            editar_btn = new Button();
            eliminar_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(529, 331);
            dataGridView1.TabIndex = 0;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.Location = new Point(431, 359);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(110, 29);
            btn_Seleccionar.TabIndex = 1;
            btn_Seleccionar.Text = "Seleccionar";
            btn_Seleccionar.UseVisualStyleBackColor = true;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // Agregar_btn
            // 
            Agregar_btn.Location = new Point(29, 359);
            Agregar_btn.Name = "Agregar_btn";
            Agregar_btn.Size = new Size(114, 29);
            Agregar_btn.TabIndex = 2;
            Agregar_btn.Text = "Agregar";
            Agregar_btn.UseVisualStyleBackColor = true;
            Agregar_btn.Click += Agregar_btn_Click;
            // 
            // editar_btn
            // 
            editar_btn.Location = new Point(162, 359);
            editar_btn.Name = "editar_btn";
            editar_btn.Size = new Size(114, 29);
            editar_btn.TabIndex = 3;
            editar_btn.Text = "Editar";
            editar_btn.UseVisualStyleBackColor = true;
            editar_btn.Click += editar_btn_Click;
            // 
            // eliminar_btn
            // 
            eliminar_btn.Location = new Point(295, 359);
            eliminar_btn.Name = "eliminar_btn";
            eliminar_btn.Size = new Size(114, 29);
            eliminar_btn.TabIndex = 4;
            eliminar_btn.Text = "Eliminar";
            eliminar_btn.UseVisualStyleBackColor = true;
            eliminar_btn.Click += eliminar_btn_Click;
            // 
            // PersonaListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 400);
            Controls.Add(eliminar_btn);
            Controls.Add(editar_btn);
            Controls.Add(Agregar_btn);
            Controls.Add(btn_Seleccionar);
            Controls.Add(dataGridView1);
            Name = "PersonaListarVista";
            Text = "PersonaListarVista";
            Load += PersonaListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Seleccionar;
        private Button Agregar_btn;
        private Button editar_btn;
        private Button eliminar_btn;
    }
}