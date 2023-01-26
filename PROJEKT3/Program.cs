//program wyświetla dane o aucie 
//klasa
public class Pojazd
{
    public string rocznik;
    public string kolor;
    public void opis()
    {
        Console.WriteLine("Auto zostało wyprodukowane w {0}, kolor katalogowy: {1}.", rocznik, kolor);
    }
}
//klasa dziedzicząca
//program wyświetla dane o aucie przy pomocy dziedziczenia klas oraz inne dodatkowe
public class Auto : Pojazd
{
    public string Marka;
    public string model;
    public void dokladnyopis()
    {
        Console.WriteLine("Auto {0} {1} zostało wyprodukowane w {2}, kolor katalogowy: {3}.", Marka, model, rocznik, kolor);
    }
}
public class Program 
{
    public static void Main()
    {
        Auto samochod = new Auto();
        samochod.rocznik = "2011";
        samochod.kolor = "Czarny";
        samochod.Marka = "BMW";
        samochod.model = "E90";
        //wywolanie funkcji z klas
        samochod.opis();
        samochod.dokladnyopis();
    }
}