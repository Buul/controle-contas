

using controle_contas.Domain.ValueObject;
using controle_contas.Helpers;
using System;

namespace controle_contas.Domain.Entities
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime? DtNascimento { get; set; }
        
        public PessoaFisica(string nome, Cpf cpf)
        {
            SetNome(nome);
            SetCpf(cpf);
        }

        public PessoaFisica()
        {

        }

        public void SetNome(string nome)
        {
            Guard.ForNullOrEmptyDefaultMessage(nome, "Nome");
            Nome = nome;
        }

        public void SetCpf(Cpf cpf)
        {
            if (cpf == null)
                throw new Exception("Cpf Obrigatório");
            Cpf = cpf;
        }
    }
}
