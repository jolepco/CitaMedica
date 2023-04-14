namespace AppCitasMedicas.Modelos
{
    internal class Cita
    {
        private int id;
        private int idDoctor;
        private int IdCliente;
        private string fechaCita;

        public void setId(int id) { this.id = id; }
        public int getId() { return id; }

        public void setidDoctor(int idDoctor) { this.idDoctor = idDoctor; }
        public int getidDoctor() { return idDoctor; }

        public void setIdCliente(int IdCliente) { this.IdCliente = IdCliente; }
        public int getIdCliente() { return IdCliente; }

        public void setfechaCita(string fechaCita) { this.fechaCita = fechaCita; }
        public string getfechaCita() { return fechaCita; }

    }

    internal class citasnombres : Cita
    {
        private string NombreDoctor;
        private string NombreCliente;
        public void setNombreDoctor(string NombreDoctor) { this.NombreDoctor = NombreDoctor; }
        public string getNombreDoctor() { return NombreDoctor; }

        public void setNombreCliente(string NombreCliente) { this.NombreCliente = NombreCliente; }
        public string getNombreCliente() { return NombreCliente; }
    }
}
