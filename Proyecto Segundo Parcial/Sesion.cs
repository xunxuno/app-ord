using System;

namespace ProyectoSegundoParcial
{
    public static class Sesion
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static string NombreUsuario { get; set; } = "";
        public static string NumeroTelefono { get; set; } = "";
        public static PlanUsuario PlanActual { get; set; } = new PlanUsuario();
    }

    public class PlanUsuario
    {
        public string NombrePlan { get; set; } = "";
        public string NumeroTelefono { get; set; } = "";
        public DateTime FechaVencimiento { get; set; }
        public int DiasTotales { get; set; }
        public int DiasRestantes { get; set; }
        public int GbTotales { get; set; }
        public int GbUtilizados { get; set; }
        public int GbUtilizadosRedes { get; set; }
    }
}
