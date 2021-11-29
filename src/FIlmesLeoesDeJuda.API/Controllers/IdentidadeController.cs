using FIlmesLeoesDeJuda.API.ViewModels;
using FIlmesLeoesDeJuda.BL.Services.Interfaces;
using FIlmesLeoesDeJuda.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(UsuarioVM usuarioVM)
        {
            var usuario = new Usuario(usuarioVM.Nome, usuarioVM.Email, usuarioVM.Senha);
            await _usuarioService.CadastrarUsuario(usuario);
            return Ok();
        }
    }
}
