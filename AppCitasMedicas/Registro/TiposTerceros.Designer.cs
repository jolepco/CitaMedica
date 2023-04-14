namespace AppCitasMedicas.Registro
{
    partial class TiposTerceros
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
            BtnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            cbEstados = new ComboBox();
            txtNombre = new TextBox();
            dataGrid = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(297, 185);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(112, 34);
            BtnGuardar.TabIndex = 0;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 288);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(493, 48);
            label1.TabIndex = 1;
            label1.Text = "Administrar tipo de terceros";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(139, 130);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(364, 31);
            txtCodigo.TabIndex = 2;
            // 
            // cbEstados
            // 
            cbEstados.FormattingEnabled = true;
            cbEstados.Location = new Point(135, 221);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(368, 33);
            cbEstados.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 176);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(364, 31);
            txtNombre.TabIndex = 6;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(10, 37);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(481, 153);
            dataGrid.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnGuardar);
            groupBox1.Location = new Point(12, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 229);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGrid);
            groupBox2.Location = new Point(38, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(501, 202);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 33);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 10;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 79);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 126);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 10;
            label4.Text = "Estado";
            // 
            // TiposTerceros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 550);
            Controls.Add(txtNombre);
            Controls.Add(cbEstados);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "TiposTerceros";
            Text = "TiposTerceros";
            Load += TiposTerceros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtCodigo;
        private ComboBox cbEstados;
        private TextBox txtNombre;
        private DataGridView dataGrid;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}