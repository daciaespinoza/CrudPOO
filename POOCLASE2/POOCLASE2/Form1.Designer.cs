namespace POOCLASE2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TbDNI = new TextBox();
            TbNombre = new TextBox();
            TbApellido = new TextBox();
            TbEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnGuardar = new Button();
            DgvPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // TbDNI
            // 
            TbDNI.Location = new Point(150, 41);
            TbDNI.Name = "TbDNI";
            TbDNI.Size = new Size(125, 27);
            TbDNI.TabIndex = 0;
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(150, 103);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(125, 27);
            TbNombre.TabIndex = 1;
            // 
            // TbApellido
            // 
            TbApellido.Location = new Point(150, 161);
            TbApellido.Name = "TbApellido";
            TbApellido.Size = new Size(125, 27);
            TbApellido.TabIndex = 2;
            // 
            // TbEdad
            // 
            TbEdad.Location = new Point(150, 216);
            TbEdad.Name = "TbEdad";
            TbEdad.Size = new Size(125, 27);
            TbEdad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 48);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 161);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 219);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 7;
            label4.Text = "Edad";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(181, 274);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(94, 29);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // DgvPersonas
            // 
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Location = new Point(308, 42);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.RowHeadersWidth = 51;
            DgvPersonas.RowTemplate.Height = 29;
            DgvPersonas.Size = new Size(611, 181);
            DgvPersonas.TabIndex = 9;
            DgvPersonas.CellContentClick += DgvPersonas_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 482);
            Controls.Add(DgvPersonas);
            Controls.Add(BtnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbEdad);
            Controls.Add(TbApellido);
            Controls.Add(TbNombre);
            Controls.Add(TbDNI);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbDNI;
        private TextBox TbNombre;
        private TextBox TbApellido;
        private TextBox TbEdad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnGuardar;
        private DataGridView DgvPersonas;
    }
}