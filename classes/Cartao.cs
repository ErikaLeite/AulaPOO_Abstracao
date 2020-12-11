using System;
namespace AulaPOO_Abstracao.classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira = "MasterCard";
        public string numero = "5255.4345.4744.8714";
        public string titular = "Rita Cruz";
        public string cvv = "595";
        public string validade = "05/21";
        public string cpfTitular = "83877319866";

        public string SalvarCartao()
        {
            return "";
        }
    }
}