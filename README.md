Instalação do Projeto
Configurações
Foram utilizados: .Net Framework e banco de dados SQLServer.
Desenvolvido utilizando DDD com Code First.

Após o download do projeto, abra o visual studio verifique e altere String de conexão(pacote controle-contas.Api) 
que esta no arquivo Web.config.

Abra o Package Manager Console do Visual Studio.
  -Selecione como o Default Project = 4-Infra\controle-contas.Infra.Data
  -execute o comando  update-database

Uma vez que o Banco de dados foi criado, basta executar a aplicação.

Descrição das funcionalidades
Recursos disponíveis
Para o consumo da API estão disponíbilizadas os seguintes recursos:

Recurso Pessoa Física
Pontos de acesso
Métodos                URI
GET                    api/PessoaFisica
POST                   api/PessoaFisica
GET                    api/PessoaFisica/:id
DELETE                 api/PessoaFisica/:id
PUT                    api/PessoaFisica
JSON Válido
   {
        "Id": "1",
        "Nome": "Nome Pessoa Físia",
        "Cpf": "36788116806",
        "DtNascimento": "28/07/1988"
    }

Recurso Pessoa Jurídica
Pontos de acesso
Métodos                URI
GET                    api/PessoaJuridica
POST                   api/PessoaJuridica
GET                    api/PessoaJuridica/:id
DELETE                 api/PessoaJuridica/:id
PUT                    api/PessoaJuridica
JSON Válido
   {
        "Id": "1",
        "NomeFantasa": "Nome Fantasia da pf",
        "Cnpj": "93066466000170",
        "RazaoSocial": "Razão Social da pf"
    }

Recurso Conta
Pontos de acesso
Métodos                URI
GET                    api/Conta
POST                   api/Conta
GET                    api/Conta/:id
DELETE                 api/Conta/:id
PUT                    api/Conta
JSON Válido
   {
        "Id": "1",
        "Nome": "Nome conta",
        "Status": "ATIVA BLOQUEDA OU CANCELADA",
        "PessoaTipo": "J ou P"
        "Ancestry": "id conta ancestry"
        "IdPessoa": "1"
        "DtCadastro": "28/03/2018"
           
    }
Recurso Transação
Pontos de acesso
Métodos                URI
GET                    api/Transacao
POST                   api/Transacao
GET                    api/Transacao/:id
JSON Válido
   {
        "Id": "1",
        "Valor": "300",
        "IdContaOrigem": "2",
        "IdContaDestino": "3"
        "Estorno": false
        "CodigoTransacaoEstorno": "1eee3"         
    }
