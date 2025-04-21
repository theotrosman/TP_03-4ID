 class Integrante
{
    public int DNI { get; private set; }
    public DatoPersonal DatosPersonales { get; private set; }
    public List<DatoFamiliar> DatosFamiliares { get; private set; }
    public DatoInteres DatosIntereses { get; private set; }
    
    public Integrante(int DNI, DatoPersonal DatosPersonales, List<DatoFamiliar> DatosFamiliares, DatoInteres DatosIntereses)
    {
        this.DNI = DNI;
        this.DatosPersonales = DatosPersonales;
        this.DatosFamiliares = DatosFamiliares;
        this.DatosIntereses = DatosIntereses;
    }
}