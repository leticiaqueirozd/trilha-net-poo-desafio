using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe Nokia
            Console.WriteLine("NOKIA")
            Nokia nokia = new Nokia("123456789", "Nokia 8", "IMEI123", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n")

            // Testando a classe iPhone
            Console.WriteLine("IPHONE")
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine(); // Para manter a janela do console aberta
        }
    }
}
