namespace DesafioPOO.Models


{
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método abstrato da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone...");
        }
    }
}