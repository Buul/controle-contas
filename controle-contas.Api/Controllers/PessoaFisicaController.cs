using controle_contas.Api.ViewModels;
using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using controle_contas.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Http;

namespace controle_contas.Api.Controllers
{
    public class PessoaFisicaController : ApiController
    {

        private readonly IPessoaFisicaAppService _pessoaFisicaApp;
 
        public PessoaFisicaController(IPessoaFisicaAppService pessoaFisicaApp)
        {
            _pessoaFisicaApp = pessoaFisicaApp;
        }


        // GET: api/PessoaFisica
        public IEnumerable<PessoaFisica> Get()
        {
            var pessoaFisica = _pessoaFisicaApp.GetAll();
            return pessoaFisica;
        }

        // GET: api/PessoaFisica/5
        public PessoaFisica Get(int id)
        {
            var pessoaFisica = _pessoaFisicaApp.GetById(id);
            return pessoaFisica;
        }

        // POST: api/PessoaFisica
        public void Post(PessoaFisicaViewModel pessoaFisicaVM)
        {            var date = DateTime.ParseExact(pessoaFisicaVM.DtNascimento,
                               "dd/MM/yyyy",
                               CultureInfo.InvariantCulture);

            var pessoaFisica = new PessoaFisica
            {
                Nome = pessoaFisicaVM.Nome,
                Cpf = new Cpf(pessoaFisicaVM.Cpf),
                DtNascimento = date

            };
            _pessoaFisicaApp.Add(pessoaFisica);
        }

        // PUT: api/PessoaFisica/5
        public void Put(PessoaFisicaViewModel pessoaFisicaVM)
        {
            var date = DateTime.ParseExact(pessoaFisicaVM.DtNascimento,
                             "dd/MM/yyyy",
                             CultureInfo.InvariantCulture);

            var pessoaFisica = _pessoaFisicaApp.GetById(Convert.ToInt32(pessoaFisicaVM.Id));
            pessoaFisica.Nome = pessoaFisicaVM.Nome;
            pessoaFisica.Cpf = new Cpf(pessoaFisicaVM.Cpf);
            pessoaFisica.DtNascimento = date;
            _pessoaFisicaApp.Update(pessoaFisica);
        }

        // DELETE: api/PessoaFisica/5
        public void Delete(int id)
        {
            var pessoaFisica = _pessoaFisicaApp.GetById(id);
            _pessoaFisicaApp.Remove(pessoaFisica);
        }
    }
}
