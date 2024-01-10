using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; private set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        // Construtor da classe Smartphone
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // Método para ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
