namespace AppCitasMedicas.Modelos
{
    internal class Tercero
    {
        private int id;
        private string Codigo;
        private string Nombre;
        private string Correo;
        private int IdCargo;

        public void setId(int id) { this.id = id; }
        public int getId() { return id; }

        public void setCodigo(string Codigo) { this.Codigo = Codigo; }
        public string getCodigo() { return Codigo; }

        public void setNombre(string Nombre) { this.Nombre = Nombre; }
        public string getNombre() { return Nombre; }

        public void setCorreo(string Correo) { this.Correo = Correo; }
        public string getCorreo() { return Correo; }

        public void setIdCargo(int IdCargo) { this.IdCargo = IdCargo; }
        public int getIdCargo() { return IdCargo; }

    }
}
