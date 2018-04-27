

using controle_contas.Domain.ValueObject;
using controle_contas.Helpers;
using System;

namespace controle_contas.Domain.Entities
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public Cnpj Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        
        public PessoaJuridica(string razaoSocial, Cnpj cnpj)
        {
            SetRazaoSocial(razaoSocial);
            SetCnpj(cnpj);
        }

        public PessoaJuridica()
        {

        }

        public void SetRazaoSocial(string razaoSocial)
        {
            Guard.ForNullOrEmptyDefaultMessage(razaoSocial, "Razão Social");
            RazaoSocial = razaoSocial;
        }

        public void SetCnpj(Cnpj cnpj)
        {
            if (cnpj == null)
                throw new Exception("Cnpj Obrigatório");
            Cnpj = cnpj;
        }
    }
}
