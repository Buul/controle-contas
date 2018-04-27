

using controle_contas.Domain.Entities;
using controle_contas.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace controle_contas.Domain.Tests.Entities
{
    [TestClass]
    public class PessoalJuridicaTests
    {
        private string RazaoSocial { get; set; }
        private Cnpj Cnpj { get; set; }
        private PessoaJuridica PessoaJuridica { get; set; }

        public PessoalJuridicaTests()
        {
            RazaoSocial = "Paulo Firmino ME";
            Cnpj = new Cnpj("93066466000170");
            PessoaJuridica = new PessoaJuridica(RazaoSocial, Cnpj);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PessoaJuridica_New_RazaoSocial_Obrigatorio()
        {
            new PessoaJuridica(null, Cnpj);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PessoaJuridica_New_Cnpj_Obrigatorio()
        {
            new PessoaJuridica(RazaoSocial, null);
        }

        [TestMethod]
        public void PessoaJuridica_New_RazaoSocial()
        {
            Assert.AreEqual(RazaoSocial, PessoaJuridica.RazaoSocial);
        }

        [TestMethod]
        public void PessoaJuridica_New_Cnpj()
        {
            Assert.AreEqual(Cnpj, PessoaJuridica.Cnpj);
        }  
    }
}
