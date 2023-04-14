namespace AppCitasMedicas;

partial class Menu
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
        menuPrincipal = new MenuStrip();
        registroToolStripMenuItem = new ToolStripMenuItem();
        tercerosToolStripMenuItem = new ToolStripMenuItem();
        citasToolStripMenuItem = new ToolStripMenuItem();
        tipoDeTercerosToolStripMenuItem = new ToolStripMenuItem();
        informesToolStripMenuItem = new ToolStripMenuItem();
        citasXClienteToolStripMenuItem = new ToolStripMenuItem();
        citasXDoctorRangoDeFechasToolStripMenuItem = new ToolStripMenuItem();
        rangoDeFechasToolStripMenuItem = new ToolStripMenuItem();
        menuPrincipal.SuspendLayout();
        SuspendLayout();
        // 
        // menuPrincipal
        // 
        menuPrincipal.ImageScalingSize = new Size(24, 24);
        menuPrincipal.Items.AddRange(new ToolStripItem[] { registroToolStripMenuItem, informesToolStripMenuItem });
        menuPrincipal.Location = new Point(0, 0);
        menuPrincipal.Name = "menuPrincipal";
        menuPrincipal.Size = new Size(800, 33);
        menuPrincipal.TabIndex = 0;
        menuPrincipal.Text = "menuStrip1";
        // 
        // registroToolStripMenuItem
        // 
        registroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tercerosToolStripMenuItem, citasToolStripMenuItem, tipoDeTercerosToolStripMenuItem });
        registroToolStripMenuItem.Name = "registroToolStripMenuItem";
        registroToolStripMenuItem.Size = new Size(93, 29);
        registroToolStripMenuItem.Text = "Registro";
        // 
        // tercerosToolStripMenuItem
        // 
        tercerosToolStripMenuItem.Name = "tercerosToolStripMenuItem";
        tercerosToolStripMenuItem.Size = new Size(243, 34);
        tercerosToolStripMenuItem.Text = "Terceros";
        tercerosToolStripMenuItem.Click += tercerosToolStripMenuItem_Click;
        // 
        // citasToolStripMenuItem
        // 
        citasToolStripMenuItem.Name = "citasToolStripMenuItem";
        citasToolStripMenuItem.Size = new Size(243, 34);
        citasToolStripMenuItem.Text = "Citas";
        citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
        // 
        // tipoDeTercerosToolStripMenuItem
        // 
        tipoDeTercerosToolStripMenuItem.Name = "tipoDeTercerosToolStripMenuItem";
        tipoDeTercerosToolStripMenuItem.Size = new Size(243, 34);
        tipoDeTercerosToolStripMenuItem.Text = "Tipo de Terceros";
        tipoDeTercerosToolStripMenuItem.Click += tipoDeTercerosToolStripMenuItem_Click;
        // 
        // informesToolStripMenuItem
        // 
        informesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { citasXClienteToolStripMenuItem, citasXDoctorRangoDeFechasToolStripMenuItem, rangoDeFechasToolStripMenuItem });
        informesToolStripMenuItem.Name = "informesToolStripMenuItem";
        informesToolStripMenuItem.Size = new Size(99, 29);
        informesToolStripMenuItem.Text = "Informes";
        // 
        // citasXClienteToolStripMenuItem
        // 
        citasXClienteToolStripMenuItem.Name = "citasXClienteToolStripMenuItem";
        citasXClienteToolStripMenuItem.Size = new Size(301, 34);
        citasXClienteToolStripMenuItem.Text = "Cliente";
        citasXClienteToolStripMenuItem.Click += citasXClienteToolStripMenuItem_Click;
        // 
        // citasXDoctorRangoDeFechasToolStripMenuItem
        // 
        citasXDoctorRangoDeFechasToolStripMenuItem.Name = "citasXDoctorRangoDeFechasToolStripMenuItem";
        citasXDoctorRangoDeFechasToolStripMenuItem.Size = new Size(301, 34);
        citasXDoctorRangoDeFechasToolStripMenuItem.Text = "Doctor rango de fechas";
        citasXDoctorRangoDeFechasToolStripMenuItem.Click += citasXDoctorRangoDeFechasToolStripMenuItem_Click;
        // 
        // rangoDeFechasToolStripMenuItem
        // 
        rangoDeFechasToolStripMenuItem.Name = "rangoDeFechasToolStripMenuItem";
        rangoDeFechasToolStripMenuItem.Size = new Size(301, 34);
        rangoDeFechasToolStripMenuItem.Text = "Rango de Fechas";
        rangoDeFechasToolStripMenuItem.Click += rangoDeFechasToolStripMenuItem_Click;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuPrincipal);
        IsMdiContainer = true;
        MainMenuStrip = menuPrincipal;
        Name = "Menu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Menu General";
        WindowState = FormWindowState.Maximized;
        Load += Menu_Load;
        menuPrincipal.ResumeLayout(false);
        menuPrincipal.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuPrincipal;
    private ToolStripMenuItem registroToolStripMenuItem;
    private ToolStripMenuItem tercerosToolStripMenuItem;
    private ToolStripMenuItem citasToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem;
    private ToolStripMenuItem tipoDeTercerosToolStripMenuItem;
    private ToolStripMenuItem citasXClienteToolStripMenuItem;
    private ToolStripMenuItem citasXDoctorRangoDeFechasToolStripMenuItem;
    private ToolStripMenuItem rangoDeFechasToolStripMenuItem;
}
