using Microsoft.AspNetCore.SignalR;

namespace PracticaGuiada01.Modelos
{
    // Clase padre
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Color { get; set; }

    }

    // Clase hijo
    public class Gato : Mascota
    {
        public string Raza { get; set; }
        public string ColorPelaje { get; set; }

        
    }

}
