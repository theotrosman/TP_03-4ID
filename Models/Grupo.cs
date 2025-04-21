class Grupo
{
    public static Dictionary<int, Integrante> Integrantes { get; private set; } = InicializarGrupo();

    /*
    public int DNI { get; private set; }
    public DatoPersonal DatosPersonales { get; private set; }
    public List<DatoFamiliar> DatosFamiliares { get; private set; }
    public DatoInteres DatosIntereses { get; private set; }

    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public DateTime FechaNacimiento { get; private set; }
    public string Foto { get; private set; }

    this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Parentesco = Parentesco;
        this.Descripción = Descripción;

    this.Hobbies = Hobbies;
        this.SeriesFavoritas = SeriesFavoritas;
        this.Amigos = Amigos;
        this.GustosEscolares = GustosEscolares;
    */




    public static Dictionary<int, Integrante> InicializarGrupo()
    {
        DatoPersonal datosTrosmanPersonales = new DatoPersonal("Theo", "Trosman", new DateTime(2008, 11, 12), "trosman.png");
        List<DatoFamiliar> datosTrosmanFamiliar = new List<DatoFamiliar>();
        datosTrosmanFamiliar.Add(new DatoFamiliar("Brisa", "Melano", "Prima", "Es la prima de Trosman y es genial"));
        datosTrosmanFamiliar.Add(new DatoFamiliar("Julia", "Melano", "Tia", "Es la tia de Trosman y es genial"));
        datosTrosmanFamiliar.Add(new DatoFamiliar("Mario", "Chantos", "Tio", "Es un tipo muy interesante"));
        DatoInteres interesTrosman = new DatoInteres("Programar", "Black Mirror", "Carlitos, Santiago y Lior", "Química");
        Integrante trosman = new Integrante(49092919, datosTrosmanPersonales, datosTrosmanFamiliar, interesTrosman);

        DatoPersonal datosDobroPersonales = new DatoPersonal("Santiago", "Dobro", new DateTime(2009, 01, 29), "foden.png");
        List<DatoFamiliar> datosDobroFamiliar = new List<DatoFamiliar>();
        datosDobroFamiliar.Add(new DatoFamiliar("Sabrina", "Garcia", "Tia", "Morocha, alta y fria"));
        datosDobroFamiliar.Add(new DatoFamiliar("Matias", "Perez", "Papá", "Es un tipo muy paciente"));
        datosDobroFamiliar.Add(new DatoFamiliar("Marco", "Garcia", "Abuelo", "5 letras, crack"));
        DatoInteres interesDobro = new DatoInteres("Cocinar, Netflix", "La casa de papel", "Carlitos, Trosman y Lior", "Física");
        Integrante Dobro = new Integrante(49317356, datosDobroPersonales, datosDobroFamiliar, interesDobro);

        DatoPersonal datosLiorPersonales = new DatoPersonal("Lior", "Tanel", new DateTime(2009, 6, 1), "Lior.png");
        List<DatoFamiliar> datosLiorFamiliar = new List<DatoFamiliar>();
        datosLiorFamiliar.Add(new DatoFamiliar("Bruno", "Zuculini", "Tio", "Rubio y futbolista de elite"));
        datosLiorFamiliar.Add(new DatoFamiliar("Emilia", "Mernes", "Prima", "Morocha y cantante"));
        datosLiorFamiliar.Add(new DatoFamiliar("Marco", "Martinez", "abuelo", "Leal y paciente"));
        DatoInteres interesLior = new DatoInteres("Futbol, Series", "Prison Break", "Carlitos, Trosman y Dobro", "Matemática y geografía");
        Integrante Lior = new Integrante(49123993, datosLiorPersonales, datosLiorFamiliar, interesLior);

        Dictionary<int, Integrante> grupo = new Dictionary<int, Integrante>();
        grupo.Add(trosman.DNI, trosman);
        grupo.Add(Dobro.DNI, Dobro);
        grupo.Add(Lior.DNI, Lior);
        return grupo;
    }
    public static Integrante DevolverIntegranteDni(int dni)
    {
        Integrante integrantedni = null;
        if (Integrantes.ContainsKey(dni))
        {
            integrantedni = Integrantes[dni];
        }

        return integrantedni;
    }


}