 class DatoInteres
{
    public string Hobbies { get; private set; }
    public string SeriesFavoritas { get; private set; }
    public string Amigos { get; private set; }
    public string GustosEscolares { get; private set; }

    public DatoInteres(string Hobbies, string SeriesFavoritas, string Amigos, string GustosEscolares)
    {
        this.Hobbies = Hobbies;
        this.SeriesFavoritas = SeriesFavoritas;
        this.Amigos = Amigos;
        this.GustosEscolares = GustosEscolares;
    }
}
