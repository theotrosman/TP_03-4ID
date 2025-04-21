class DatoFamiliar
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Parentesco { get; private set; }
    public string Descripción { get; private set; }

    public DatoFamiliar(string Nombre, string Apellido, string Parentesco, string Descripción)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Parentesco = Parentesco;
        this.Descripción = Descripción;
    }
    

}