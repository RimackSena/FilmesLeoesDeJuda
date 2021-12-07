
using FIlmesLeoesDeJuda.BL.Services.Interfaces;
using FIlmesLeoesDeJuda.DAL.Entities;
using FIlmesLeoesDeJuda.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Usuario>> ObterTodos()
        {
            return await _usuarioRepository.ObterTodos();
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
            await _usuarioRepository.Adicionar(usuario);
        }

        public async Task<Usuario> ObterUsuarioPorId(Guid usuarioId)
        {
            return await _usuarioRepository.ObterPorId(usuarioId);
        }

        public async Task<Usuario> ObterUsuarioPorEmail(string email)
        {
            return await _usuarioRepository.ObterPorEmail(email);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
        }

        public void RemoverUsuario(Guid usuarioId)
        {
            _usuarioRepository.Remover(usuarioId);
        }
    }
}
