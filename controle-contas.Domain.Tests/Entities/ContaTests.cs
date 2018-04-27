

using controle_contas.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace controle_contas.Domain.Tests.Entities
{
    [TestClass]
    public class ContaTests
    {
        private string Nome { get; set; }
        private string Status { get; set; }
        private int IdPessoa { get; set; }
        private Conta Conta { get; set; }


        public ContaTests()
        {
            Nome = "Paulo Conta";
            Status = "ATIVO";
            IdPessoa = 1;
            Conta = new Conta(Nome, Status, IdPessoa);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Conta_New_Nome_Obrigatorio()
        {
            new Conta(null, Status, IdPessoa);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Conta_New_Status_Obrigatorio()
        {
            new Conta(Nome, null, IdPessoa);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Conta_New_Status_IdPessoa()
        {
            new Conta(Nome, Status, -1);
        }

        [TestMethod]
        public void Conta_New_Nome()
        {
            Assert.AreEqual(Nome, Conta.Nome);
        }

        [TestMethod]
        public void Conta_New_Status()
        {
            Assert.AreEqual(Status, Conta.Status);
        }

        [TestMethod]
        public void Conta_New_IdPessoa()
        {
            Assert.AreEqual(IdPessoa, Conta.IdPessoa);
        }
    }
}
