namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a partir do número: {Numero}, com o celular modelo {Modelo}, de Imei: {IMEI} que possuí {Memoria} gb de memória");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação de {Numero} com o celular modelo {Modelo}, de Imei: {IMEI} que possuí {Memoria} gb de memória");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}