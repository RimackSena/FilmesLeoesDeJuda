using FIlmesLeoesDeJuda.API.ViewModels;
using FIlmesLeoesDeJuda.BL.Services.Interfaces;
using FIlmesLeoesDeJuda.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;

namespace FIlmesLeoesDeJuda.API.Controllers
{
    [Route("api/identidades")]
    [ApiController]
    public class IdentidadeController : ControllerBase
    {

        private readonly IUsuarioService _usuarioService;

        public IdentidadeController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> ObterUsuarios()
        {
            return Ok(await _usuarioService.ObterTodos());
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CadatraUsuarioVM usuarioVM)
        {
            var usuario = new Usuario(usuarioVM.Nome, usuarioVM.Email, Crypto.HashPassword(usuarioVM.Senha));
            await _usuarioService.CadastrarUsuario(usuario);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarUsuario(AtualizaUsuarioVM usuarioVM)
        {
            var usuario = await _usuarioService.ObterUsuarioPorId(usuarioVM.UsuarioId);

            usuario.Atualizar(usuarioVM.Nome);

            _usuarioService.AtualizarUsuario(usuario);

            return Ok();
        }

        [HttpDelete("{usuarioId:guid}")]
        public IActionResult RemoverUsuario([FromRoute] Guid usuarioId)
        {
            _usuarioService.RemoverUsuario(usuarioId);

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var usuario = await _usuarioService.ObterUsuarioPorEmail(loginVM.Email);

            if (!Crypto.VerifyHashedPassword(usuario.Senha, loginVM.Senha))
            {
                throw new Exception("Usuario ou senha inválidos");
            }

            return Ok();
        }

        [HttpPut("senha")]
        public async Task<IActionResult> AtualizarSenha(AtualizaSenhaVM atualizaSenhaVM)
        {
            return Ok();
        }
    }
}
