using System.Threading.Tasks;
using CargoBox.Domain;

namespace CargoBox.Application
{
    public class EntregaAppService
    {
        private readonly IPaqueteRepository _repository;

        public EntregaAppService(IPaqueteRepository repository)
        {
            _repository = repository;
        }

        public async Task FinalizarEntrega(string guia, object evidenciaDTO)
        {
            // 1. Recuperar el objeto de la base de datos
            var paquete = await _repository.ObtenerPorGuiaAsync(guia);

            // 2. Ejecutar la regla de negocio en el Dominio
            paquete.FinalizarEntrega(evidenciaDTO);

            // 3. Guardar los cambios (Persistencia / Unit of Work)
            await _repository.GuardarAsync(paquete);
        }
    }
}

// La Service Layer coordina, pero le pasa la responsabilidad al paquete.