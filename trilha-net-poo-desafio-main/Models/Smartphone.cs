namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; }
        private string modelo { get; set;}
        private string imei { get; set;}
        private string memoria { get; set;}


        public Smartphone(string Numero ,string Modelo ,string Imei, string Memoria)
        {
            numero = Numero;
            modelo = Modelo;
            memoria = Memoria;
            imei = Imei;        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}