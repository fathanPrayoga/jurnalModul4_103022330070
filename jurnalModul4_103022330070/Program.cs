using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class kodeProduk
{
    private static Dictionary<string, string> produk = new Dictionary<string, string>
    {
        { "laptop", "E100" },
        { "Smartphone", "E101" },
        { "Tablet", "E102" },
        { "Headset", "E103" },
        { "Keyboard", "E104" }, 
        { "Mouse", "E1O5" },
        { "Printer", "E106" },
        { "Monitor", "E107" },
        { "Smartwatch", "E108" },
        { "Kamera", "E109" },
    };
    public static string getKodeElektronik(string kodeElektronik)
    {
        return produk.ContainsKey(kodeElektronik) ? produk [kodeElektronik] : "kode tidak ditemukan!";
        
    }


    
}

public enum Fanstate
{
    Quiet,
    Turbo,
    Balanced,
    performance
}
public enum Trigger
{
    ModeDown,
    ModeUp,
    TurboShortcut
}

public class FanLaptop
{
    private Fanstate _state = Fanstate.Quiet;

    public class Transisi
    {
        Fanstate Awal;
        Fanstate Akhir;
        Fanstate Trigger;

        public Transisi(Fanstate awal, Fanstate akhir, Fanstate trigger)
        {
            Awal = awal;
            Akhir = akhir;
            Trigger = trigger;
        }
    }
    public FanLaptop()
    {
        _state = Fanstate.Quiet;
        Console.WriteLine("Quite mode");
    }

    public void TurboShortcut()
    {
        if (_state == Fanstate.Quiet)
        {

        }
    }
    public void BalancedShortcut()
    {

    }
    public void performanceShortcut() { 
    
    }
    public void TriggerShortcut() { 
    
    }
    
}

class Program {
    public static void Main(String[] args)
    {

        Console.WriteLine(kodeProduk.getKodeElektronik("laptop"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Smartphone"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Tablet"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Headset"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Keyboard"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Mouse"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Printer"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Monitor"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Smartwatch"));
        Console.WriteLine(kodeProduk.getKodeElektronik("Kamera"));



    }
}