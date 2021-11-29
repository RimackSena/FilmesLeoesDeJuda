using FIlmesLeoesDeJuda.DAL.Entities;
using FIlmesLeoesDeJuda.DAL.Repositories.Interfaces;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.DAL.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly FilmesLeoesDeJudaContext _filmesLeoesDeJudaContext;

        public UsuarioRepository(FilmesLeoesDeJudaContext filmesLeoesDeJudaContext)
        {
            _filmesLeoesDeJudaContext = filmesLeoesDeJudaContext;
        }

        public async Task Adicionar(Usuario usuario)
        {
            _filmesLeoesDeJudaContext.Add(usuario);
            await _filmesLeoesDeJudaContext.SaveChangesAsync();
        }
    }
}
