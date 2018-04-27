

using controle_contas.Domain.Entities;
using controle_contas.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace controle_contas.Domain.Tests.Entities
{
    [TestClass]
    public class PessoalFisicaTests
    {
        private string Nome { get; set; }
        private Cpf Cpf { get; set; }
        private PessoaFisica PessoaFisica { get; set; }

        public PessoalFisicaTests()
        {
            Nome = "Paulo Firmino";
            Cpf = new Cpf("36788116806");
            PessoaFisica = new PessoaFisica(Nome, Cpf);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PessoaFisica_New_Nome_Obrigatorio()
        {
            new PessoaFisica(null, Cpf);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PessoaFisica_New_Cpf_Obrigatorio()
        {
            new PessoaFisica(Nome, null);
        }

        [TestMethod]
        public void PessoaFisica_New_Nome()
        {
            Assert.AreEqual(Nome, PessoaFisica.Nome);
        }

        [TestMethod]
        public void PessoaFisica_New_Cpf()
        {
            Assert.AreEqual(Cpf, PessoaFisica.Cpf);
        }
    }
}
