namespace AppCitasMedicas.Informes
{
    partial class CitasxDoctosyrangodefechas
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
            label2 = new Label();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            dataGrid = new DataGridView();
            label1 = new Label();
            cbDoctor = new ComboBox();
            dateTimePickerInit = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(54, 21);
            label2.Name = "label2";
            label2.Size = new Size(441, 48);
            label2.TabIndex = 19;
            label2.Text = "Citas Medicas por Doctor";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(388, 462);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 17;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(259, 462);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(25, 231);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(497, 225);
            dataGrid.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 86);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 15;
            label1.Text = "Seleccionar Doctor";
            // 
            // cbDoctor
            // 
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(189, 83);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(182, 33);
            cbDoctor.TabIndex = 14;
            // 
            // dateTimePickerInit
            // 
            dateTimePickerInit.Location = new Point(44, 162);
            dateTimePickerInit.Name = "dateTimePickerInit";
            dateTimePickerInit.Size = new Size(155, 31);
            dateTimePickerInit.TabIndex = 20;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(353, 162);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(155, 31);
            dateTimePickerEnd.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 134);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 15;
            label3.Text = "Fecha Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 134);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 15;
            label4.Text = "Fecha Final";
            // 
            // CitasxDoctosyrangodefechas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 528);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerInit);
            Controls.Add(label2);
            Controls.Add(btnConsultar);
            Controls.Add(btnLimpiar);
            Controls.Add(dataGrid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbDoctor);
            Name = "CitasxDoctosyrangodefechas";
            Text = "CitasxDoctosyrangodefechas";
            Load += CitasxDoctosyrangodefechas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnConsultar;
        private Button btnLimpiar;
        private DataGridView dataGrid;
        private Label label1;
        private ComboBox cbDoctor;
        private DateTimePicker dateTimePickerInit;
        private DateTimePicker dateTimePickerEnd;
        private Label label3;
        private Label label4;
    }
}