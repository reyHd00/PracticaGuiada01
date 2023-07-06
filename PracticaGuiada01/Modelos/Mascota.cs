using Microsoft.AspNetCore.SignalR;

namespace PracticaGuiada01.Modelos
{
    // Clase padre
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Color { get; set; }

        public void Comer()
        {
            Console.WriteLine("La mascota está comiendo.");
        }
    }

    // Clase hija
    public class Gato : Mascota
    {
        public void Maullar()
        {
            Console.WriteLine("El gato está maullando.");
        }
    }

}
