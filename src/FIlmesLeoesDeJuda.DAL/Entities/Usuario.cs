using System;

namespace FIlmesLeoesDeJuda.DAL.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        protected Usuario() {}
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public void Atualizar(string nome)
        {
            Nome = nome;
        }
    }
}
