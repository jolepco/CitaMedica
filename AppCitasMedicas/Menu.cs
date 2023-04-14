namespace AppCitasMedicas;

public partial class Menu : Form
{
    public Menu()
    {
        InitializeComponent();
    }
    public static Boolean FormIsOpen(String FormABuscar)
    {

        Boolean lEncontrado = false;

        foreach (Form form in Application.OpenForms)
        {

            if (form.Name == FormABuscar)
            {
                form.WindowState = FormWindowState.Normal;
                form.Activate();
                lEncontrado = true;
                break;
            }

        }
        return lEncontrado;
    }

    private void tercerosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (FormIsOpen("Terceros"))
            {
                return;
            }
            Registro.Tercero
            MdiChild = new Registro.Tercero();
            MdiChild.MdiParent = this;
            MdiChild.WindowState = FormWindowState.Normal;
            MdiChild.StartPosition = FormStartPosition.CenterScreen;
            MdiChild.Show();
        }
        catch (Exception)
        {


        }
    }

    private void tipoDeTercerosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (FormIsOpen("TiposTerceros"))
            {
                return;
            }
            Registro.TiposTerceros
            MdiChild = new Registro.TiposTerceros();
            MdiChild.MdiParent = this;
            MdiChild.WindowState = FormWindowState.Normal;
            MdiChild.StartPosition = FormStartPosition.CenterScreen;
            MdiChild.Show();
        }
        catch (Exception)
        {


        }
    }

    private void citasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (FormIsOpen("Citas"))
            {
                return;
            }
            Registro.Citas
            MdiChild = new Registro.Citas();
            MdiChild.MdiParent = this;
            MdiChild.WindowState = FormWindowState.Normal;
            MdiChild.StartPosition = FormStartPosition.CenterScreen;
            MdiChild.Show();
        }
        catch (Exception)
        {


        }
    }

    private void citasXClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (FormIsOpen("CitasxCliente"))
            {
                return;
            }
            Informes.CitasxCliente
            MdiChild = new Informes.CitasxCliente();
            MdiChild.MdiParent = this;
            MdiChild.WindowState = FormWindowState.Normal;
            MdiChild.StartPosition = FormStartPosition.CenterScreen;
            MdiChild.Show();
        }
        catch (Exception)
        {


        }
    }

    private void citasXDoctorRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (FormIsOpen("CitasxDoctosyrangodefechas"))
            {
                return;
            }
            Informes.CitasxDoctosyrangodefechas
            MdiChild = new Informes.CitasxDoctosyrangodefechas();
            MdiChild.MdiParent = this;
            MdiChild.WindowState = FormWindowState.Normal;
            MdiChild.StartPosition = FormStartPosition.CenterScreen;
            MdiChild.Show();
        }
        catch (Exception)
        {


        }
    }

    private void rangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (FormIsOpen("ConsultarCitasxrangodefechas"))
            {
                return;
            }
            Informes.ConsultarCitasxrangodefechas
            MdiChild = new Informes.ConsultarCitasxrangodefechas();
            MdiChild.MdiParent = this;
            MdiChild.WindowState = FormWindowState.Normal;
            MdiChild.StartPosition = FormStartPosition.CenterScreen;
            MdiChild.Show();
        }
        catch (Exception)
        {


        }
    }

    private void Menu_Load(object sender, EventArgs e)
    {

    }
}
