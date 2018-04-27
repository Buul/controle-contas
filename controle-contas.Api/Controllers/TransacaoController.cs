using controle_contas.Api.ViewModels;
using controle_contas.Application.Interfaces;
using controle_contas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace controle_contas.Api.Controllers
{
    public class TransacaoController : ApiController
    {

        private readonly ITransacaoAppService _transacaoApp;
 
        public TransacaoController(ITransacaoAppService transacaoApp)
        {
            _transacaoApp = transacaoApp;
        }

        // GET: api/Transacao
        public IEnumerable<Transacao> Get()
        {
            var transacao = _transacaoApp.GetAll();
            return transacao;
        }

        // GET: api/Transacao/5
        public Transacao Get(int id)
        {
            var transacao = _transacaoApp.GetById(id);
            return transacao;
        }

        // POST: api/Transacao
        public void Post(TransacaoViewModel transacaoVW)
        {
            var transacao = new Transacao
            {
                Valor = Convert.ToDecimal(transacaoVW.Valor),
                IdContaOrigem = Convert.ToInt32(transacaoVW.IdContaOrigem),
                IdContaDestino = Convert.ToInt32(transacaoVW.IdContaDestino),
                ValorContaOrigem = Convert.ToDecimal(transacaoVW.ValorContaOrigem),
                ValorContaDestino = Convert.ToDecimal(transacaoVW.ValorContaDestino),
                Estorno = transacaoVW.Estorno,
                CodigoTransacaoEstorno = transacaoVW.CodigoTransacaoEstorno

            };
            _transacaoApp.Add(transacao);
        }

        // PUT: api/Transacao/5
        public void Put(TransacaoViewModel transacaoVW)
        {
            var conta = _transacaoApp.GetById(Convert.ToInt32(transacaoVW.Id));
            conta.Valor = Convert.ToDecimal(transacaoVW.Valor);
            conta.IdContaOrigem = Convert.ToInt32(transacaoVW.IdContaOrigem);
            conta.IdContaDestino = Convert.ToInt32(transacaoVW.IdContaDestino);
            conta.ValorContaOrigem = Convert.ToDecimal(transacaoVW.ValorContaOrigem);
            conta.ValorContaDestino = Convert.ToDecimal(transacaoVW.ValorContaDestino);
            conta.Estorno = transacaoVW.Estorno;
            conta.CodigoTransacaoEstorno = transacaoVW.CodigoTransacaoEstorno;
            _transacaoApp.Update(conta);
        }

        // DELETE: api/Transacao/5
        public void Delete(int id)
        {
            var Transacao = _transacaoApp.GetById(id);
            _transacaoApp.Remove(Transacao);
        }
    }
}
