
using controle_contas.Helpers;
using System;

namespace controle_contas.Domain.ValueObject
{

    public class Cnpj
    {
        public Int64 Codigo { get; private set; }

        protected Cnpj()
        {

        }

        public Cnpj(string cnpj)
        {
            try
            {
                cnpj = CnpjLimpo(cnpj);
                if (!IsCnpj(cnpj))
                    throw new Exception();

                Codigo = Convert.ToInt64(cnpj);
            }
            catch (Exception)
            {
                throw new Exception("Cnpj inválido: " + cnpj);
            }
        }

        public static string CnpjLimpo(string cnpj)
        {
            cnpj = TextoHelper.GetNumeros(cnpj);

            if (string.IsNullOrEmpty(cnpj))
                return "";

            while (cnpj.StartsWith("0"))
                cnpj = cnpj.Substring(1);

            return cnpj;
        }


        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);

        }
    }
}
