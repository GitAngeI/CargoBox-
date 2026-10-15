using System.Threading.Tasks;

namespace CargoBox.Domain
{
    public interface IPaqueteRepository
    {
        Task<Paquete> ObtenerPorGuiaAsync(string guiaUnica);
        Task GuardarAsync(Paquete paquete);
    }
}

// El dominio define los contratos (Interfaces), pero no depende de bases de datos.