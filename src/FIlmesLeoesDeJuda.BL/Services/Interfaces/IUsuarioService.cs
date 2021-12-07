
using FIlmesLeoesDeJuda.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.BL.Services.Interfaces
{
    public interface IUsuarioService 
    {
        Task CadastrarUsuario(Usuario usuario);
        Task<Usuario> ObterUsuarioPorId(Guid usuarioId);
        void AtualizarUsuario(Usuario usuario);

        void RemoverUsuario(Guid usuarioId);

        Task<IEnumerable<Usuario>> ObterTodos();

        Task<Usuario> ObterUsuarioPorEmail(string email);
    }
}
