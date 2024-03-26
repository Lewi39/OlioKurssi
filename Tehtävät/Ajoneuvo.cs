using System
    
    class Ajoneuvo
{
    static void Main(string[] args)

    {
       
    public string nimi { get; set; }

    public int nopeus { get; set; }

    public string nimi { get; set; }

    public string renkaat { get; set; }

    public void tulostadata()

    {
        Console.WriteLine("Ajoneuvo: ");
        Console.WriteLine("-- nimi " + nimi);
        Console.WriteLine("-- nopeus " + nopeus);
        Console.WriteLine("-- Renkaat " + renkaat);
    }

    public string ToString()
    {
        string merkkijono = "Ájoneuvo nimi: " + nimi + " Nopeus: " + nopeus + "km/h. Renkaat: " + renkaat + "kpl";
        return merkkijono;




    }










}
}