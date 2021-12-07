using FIlmesLeoesDeJuda.DAL.Entities;
using FIlmesLeoesDeJuda.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.DAL.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FilmesLeoesDeJudaContext ctx) : base(ctx) { }

        public async Task<Usuario> ObterPorEmail(string email)
        {
            return await _ctx.Usuarios.FirstOrDefaultAsync(p => p.Email == email);
        }
    }
}
