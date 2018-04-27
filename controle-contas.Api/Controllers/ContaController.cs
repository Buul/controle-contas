using controle_contas.Api.ViewModels;
using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace controle_contas.Api.Controllers
{
    public class ContaController : ApiController
    {

        private readonly IContaAppService _contaApp;
 
        public ContaController(IContaAppService contaApp)
        {
            _contaApp = contaApp;
        }

        // GET: api/Conta
        public IEnumerable<Conta> Get()
        {
            var Conta = _contaApp.GetAll();
            return Conta;
        }

        // GET: api/Conta/5
        public Conta Get(int id)
        {
            var Conta = _contaApp.GetById(id);
            return Conta;
        }

        // POST: api/Conta
        public void Post(ContaViewModel contaVM)
        {
            var Conta = new Conta
            {
                Nome = contaVM.Nome,
                Status = contaVM.Status,
                PessoaTipo = contaVM.PessoaTipo,
                Ancestry = contaVM.Ancestry,
                IdPessoa = Convert.ToInt32(contaVM.IdPessoa),
                DtCadastro = DateTime.Now

            };
            _contaApp.Add(Conta);
        }

        // PUT: api/Conta/5
        public void Put(ContaViewModel contaVM)
        {

            var conta = _contaApp.GetById(Convert.ToInt32(contaVM.Id));
            conta.Nome = contaVM.Nome;
            conta.Status = contaVM.Status;
            conta.PessoaTipo = contaVM.PessoaTipo;
            conta.Ancestry = contaVM.Ancestry;
            conta.IdPessoa = Convert.ToInt32(contaVM.IdPessoa);
            _contaApp.Update(conta);
        }

        // DELETE: api/Conta/5
        public void Delete(int id)
        {
            var Conta = _contaApp.GetById(id);
            _contaApp.Remove(Conta);
        }
    }
}
