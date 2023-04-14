namespace AppCitasMedicas.Registro
{
    partial class Tercero
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
            txtNombre = new TextBox();
            cbEstados = new ComboBox();
            txtCodigo = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnGuardar = new Button();
            groupBox2 = new GroupBox();
            dataGrid = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 31);
            txtNombre.TabIndex = 14;
            // 
            // cbEstados
            // 
            cbEstados.FormattingEnabled = true;
            cbEstados.Location = new Point(536, 79);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(280, 33);
            cbEstados.TabIndex = 13;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(199, 139);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 31);
            txtCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(327, 38);
            label1.Name = "label1";
            label1.Size = new Size(373, 48);
            label1.TabIndex = 11;
            label1.Text = "Administrar Terceros";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(178, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbEstados);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnGuardar);
            groupBox1.Location = new Point(72, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 199);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 30);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 17;
            label6.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(536, 33);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(274, 31);
            txtCorreo.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, -73);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 15;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 87);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 10;
            label4.Text = "Tipo de Tercero";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 33);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 10;
            label2.Text = "Codigo";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(536, 154);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(112, 34);
            BtnGuardar.TabIndex = 0;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGrid);
            groupBox2.Location = new Point(72, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(847, 229);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista";
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(14, 30);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(808, 181);
            dataGrid.TabIndex = 7;
            // 
            // Tercero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 580);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Tercero";
            Text = "Tercero";
            Load += Tercero_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private ComboBox cbEstados;
        private TextBox txtCodigo;
        private Label label1;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtCorreo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BtnGuardar;
        private GroupBox groupBox2;
        private DataGridView dataGrid;
    }
}