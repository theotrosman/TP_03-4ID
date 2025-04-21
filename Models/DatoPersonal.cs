 class DatoPersonal
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public DateTime FechaNacimiento { get; private set; }
    public string Foto { get; private set; }
public DatoPersonal(string Nombre, string Apellido, DateTime FechaNacimiento, string Foto){
    this.Nombre = Nombre;
    this.Apellido = Apellido;
    this.FechaNacimiento = FechaNacimiento;
    this.Foto = Foto;
}
static int ObtenerEdad(DateTime FechaNacimiento)
{
    DateTime DiaActual = DateTime.Today;
    int Edad = (DiaActual.Year-FechaNacimiento.Year);
    return Edad;
}
}