using Bibliotec_MVC_DEV.Models;

namespace Bibliotec_MVC_DEV
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> BuscarReservasComDetalhes();
        Task<IEnumerable<Reserva>> BuscarReservaPorUsuarioId(int usuarioId);
    }
}