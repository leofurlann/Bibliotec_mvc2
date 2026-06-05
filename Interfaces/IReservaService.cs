using Bibliotec_MVC_DEV.Models;

namespace Bibliotec_MVC_DEV
{
    public interface IReservaService
    {
        Task<IEnumerable<Reserva>> BuscarReservaAsync();
        Task<IEnumerable<Reserva>> BuscarReservasPorUsuarioAsync(int alunoId);
    }
}