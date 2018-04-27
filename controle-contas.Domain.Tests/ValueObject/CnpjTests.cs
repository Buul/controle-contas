

using controle_contas.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace controle_contas.Domain.Test.ValueObject
{
    [TestClass]
    public class CnpjTests
    {
        [TestMethod]
        public void Cnpj_New_Cnpj_Valido_46860116000100()
        {
            var cnpj = new Cnpj("46.860.116/0001-00");
            Assert.AreEqual(46860116000100, cnpj.Codigo);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cpf_New_Cpf_Invalido_0d89502b3454e()
        {
            var cpf = new Cpf("0d89502b3454e");
        }
    }
}

