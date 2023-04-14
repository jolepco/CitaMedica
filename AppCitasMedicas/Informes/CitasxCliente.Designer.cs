namespace AppCitasMedicas.Informes
{
    partial class CitasxCliente
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
            cbCliente = new ComboBox();
            label1 = new Label();
            dataGrid = new DataGridView();
            btnLimpiar = new Button();
            btnConsultar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(186, 79);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(182, 33);
            cbCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar Cliente";
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(22, 127);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(497, 225);
            dataGrid.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(256, 358);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(385, 358);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(51, 17);
            label2.Name = "label2";
            label2.Size = new Size(446, 48);
            label2.TabIndex = 13;
            label2.Text = "Citas Medicas por Cliente";
            // 
            // CitasxCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 406);
            Controls.Add(label2);
            Controls.Add(btnConsultar);
            Controls.Add(btnLimpiar);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Controls.Add(cbCliente);
            Name = "CitasxCliente";
            Text = "CitasxCliente";
            Load += CitasxCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCliente;
        private Label label1;
        private DataGridView dataGrid;
        private Button btnLimpiar;
        private Button btnConsultar;
        private Label label2;
    }
}