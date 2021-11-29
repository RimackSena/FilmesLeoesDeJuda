
using FIlmesLeoesDeJuda.BL.Services.Interfaces;
using FIlmesLeoesDeJuda.DAL.Entities;
using FIlmesLeoesDeJuda.DAL.Repositories.Interfaces;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.BL.Services
{
   
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
            await _usuarioRepository.Adicionar(usuario);
        }
    }
}
