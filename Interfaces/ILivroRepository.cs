using Bibliotec_MVC_DEV.Models;

namespace Bibliotec_MVC_DEV.Interfaces
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> BuscarLivrosAsync();

        Task<IEnumerable<Categoria>> ListarCategoriaAsync();

        Task CadastrarLivro(Livro l);

        Task CadastrarCatLivroAsync(LivroCategoria lc);

        Task DeletarLivroAsync(Livro l);

        Task DeletarCatLivroAsync(int idLivro);

        Task <Livro?> BuscarLivroPorIdAsync(int id);
    }
}