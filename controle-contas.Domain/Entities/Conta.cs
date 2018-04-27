using controle_contas.Helpers;
using System;

namespace controle_contas.Domain.Entities
{
    public class Conta
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public string PessoaTipo { get; set; }
        public string Ancestry { get; set; }
        public int IdPessoa { get; set; }
        public DateTime? DtCadastro { get; set; }


        public Conta(string nome, string status,int idPessoa)
        {
            SetNome(nome);
            SetStatus(status);
            SetIdPessoa(idPessoa);
        }

        public Conta()
        {

        }

        public void SetNome(string nome)
        {
            Guard.ForNullOrEmptyDefaultMessage(nome, "Nome");
            Nome = nome;
        }

        public void SetStatus(string status)
        {
            Guard.ForNullOrEmptyDefaultMessage(status, "Status");
            Status = status;
        }

        public void SetIdPessoa(int idPessoa)
        {
            Guard.ForNegative(idPessoa, "PessoaId");
            IdPessoa = idPessoa;
        }

    }
}
