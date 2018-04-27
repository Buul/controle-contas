using controle_contas.Api.ViewModels;
using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using controle_contas.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace controle_contas.Api.Controllers
{
    public class PessoaJuridicaController : ApiController
    {

        private readonly IPessoaJuridicaAppService _pessoaJuridicaApp;
 
        public PessoaJuridicaController(IPessoaJuridicaAppService pessoaJuridicaApp)
        {
            _pessoaJuridicaApp = pessoaJuridicaApp;
        }


        // GET: api/PessoaJuridica
        public IEnumerable<PessoaJuridica> Get()
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetAll();
            return pessoaJuridica;
        }

        // GET: api/PessoaJuridica/5
        public PessoaJuridica Get(int id)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(id);
            return pessoaJuridica;
        }

        // POST: api/PessoaJuridica
        public void Post(PessoaJuridicaViewModel pessoaJuridicaVM)
        {

            var pessoaJuridica = new PessoaJuridica
            {
                NomeFantasia = pessoaJuridicaVM.NomeFantasia,
                Cnpj = new Cnpj(pessoaJuridicaVM.Cnpj),
                RazaoSocial = pessoaJuridicaVM.RazaoSocial

            };
            _pessoaJuridicaApp.Add(pessoaJuridica);
        }

        // PUT: api/PessoaJuridica/5
        public void Put(PessoaJuridicaViewModel pessoaJuridicaVM)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(Convert.ToInt32(pessoaJuridicaVM.Id));
            pessoaJuridica.NomeFantasia = pessoaJuridicaVM.NomeFantasia;
            pessoaJuridica.Cnpj = new Cnpj(pessoaJuridicaVM.Cnpj);
            pessoaJuridica.RazaoSocial = pessoaJuridicaVM.RazaoSocial;
           _pessoaJuridicaApp.Update(pessoaJuridica);
        }

        // DELETE: api/PessoaJuridica/5
        public void Delete(int id)
        {
            var pessoaJuridica = _pessoaJuridicaApp.GetById(id);
            _pessoaJuridicaApp.Remove(pessoaJuridica);
        }
    }
}
