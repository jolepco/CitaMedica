namespace AppCitasMedicas.Informes
{
    partial class ConsultarCitasxrangodefechas
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
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerInit = new DateTimePicker();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            dataGrid = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(422, 122);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(155, 31);
            dateTimePickerEnd.TabIndex = 26;
            // 
            // dateTimePickerInit
            // 
            dateTimePickerInit.Location = new Point(113, 122);
            dateTimePickerInit.Name = "dateTimePickerInit";
            dateTimePickerInit.Size = new Size(155, 31);
            dateTimePickerInit.TabIndex = 27;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(457, 422);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 24;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(328, 422);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(94, 191);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(497, 225);
            dataGrid.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 94);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 21;
            label4.Text = "Fecha Final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 94);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 22;
            label3.Text = "Fecha Inicial";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(184, 28);
            label2.Name = "label2";
            label2.Size = new Size(302, 48);
            label2.TabIndex = 28;
            label2.Text = "Rangos de Fecha";
            // 
            // ConsultarCitasxrangodefechas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 473);
            Controls.Add(label2);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerInit);
            Controls.Add(btnConsultar);
            Controls.Add(btnLimpiar);
            Controls.Add(dataGrid);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "ConsultarCitasxrangodefechas";
            Text = "ConsultarCitasxrangodefechas";
            Load += ConsultarCitasxrangodefechas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerInit;
        private Button btnConsultar;
        private Button btnLimpiar;
        private DataGridView dataGrid;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}