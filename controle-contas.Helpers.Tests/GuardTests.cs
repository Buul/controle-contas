
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace controle_contas.Helpers.Test
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpt_Error_empty()
        {
            Guard.ForNullOrEmpty("", "valor não pode ser vazio");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpt_Error_null()
        {
            Guard.ForNullOrEmpty(null, "valor não pode ser nulo");
        }

    }
}
