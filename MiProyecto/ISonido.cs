public interface ISonido
{
    string HacerSonido();
}

public class Perro : ISonido
{
    public string HacerSonido()
    {
        return "Guau";
    }
}

public class Gato : ISonido
{
    public string HacerSonido()
    {
        return "Miau";
    }
}

public class Vaca : ISonido
{
    public string HacerSonido()
    {
        return "Muuu";
    }
}
