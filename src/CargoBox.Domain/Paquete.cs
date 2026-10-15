using System;

namespace CargoBox.Domain
{
    public class Paquete
    {
        public string GuiaUnica { get; private set; }
        public string Estado { get; private set; }

        public Paquete(string guiaUnica)
        {
            GuiaUnica = guiaUnica;
            Estado = "Recibido";
        }

        // Método de dominio: Protege la regla BR012
        public void FinalizarEntrega(object evidenciaRecepcion)
        {
            if (evidenciaRecepcion == null)
            {
                throw new Exception("Error: No se puede cambiar a Entregado sin evidencia de recepción.");
            }
            
            Estado = "Entregado";
            // Aquí iría la lógica para emitir el Domain Event
        }
    }
}