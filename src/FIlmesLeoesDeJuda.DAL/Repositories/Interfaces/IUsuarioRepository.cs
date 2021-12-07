using FIlmesLeoesDeJuda.DAL.Entities;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.DAL.Repositories.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> ObterPorEmail(string email);
    }
}
