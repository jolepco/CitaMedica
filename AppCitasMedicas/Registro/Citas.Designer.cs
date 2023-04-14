namespace AppCitasMedicas.Registro
{
    partial class Citas
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            cbCliente = new ComboBox();
            cbDoctor = new ComboBox();
            label4 = new Label();
            btnCancelar = new Button();
            label3 = new Label();
            label2 = new Label();
            BtnGuardar = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Controls.Add(cbDoctor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnGuardar);
            groupBox1.Location = new Point(26, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 229);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(109, 79);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(368, 33);
            cbCliente.TabIndex = 11;
            // 
            // cbDoctor
            // 
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(109, 30);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(368, 33);
            cbDoctor.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 126);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 10;
            label4.Text = "Fecha";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(106, 185);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 79);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 10;
            label3.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 33);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 10;
            label2.Text = "Doctor";
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(172, 28);
            label1.Name = "label1";
            label1.Size = new Size(251, 48);
            label1.TabIndex = 12;
            label1.Text = "Citas Medicas";
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 353);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Citas";
            Text = "Citas";
            Load += Citas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BtnGuardar;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbCliente;
        private ComboBox cbDoctor;
        private Button btnCancelar;
        private Label label1;
    }
}