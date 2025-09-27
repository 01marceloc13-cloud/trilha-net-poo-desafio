namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método abstrato da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia...");
        }
    }
}