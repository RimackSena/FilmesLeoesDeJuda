
using FIlmesLeoesDeJuda.DAL.Entities;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.BL.Services.Interfaces
{
    public interface IUsuarioService 
    {
        Task CadastrarUsuario(Usuario usuario);
    }
}
