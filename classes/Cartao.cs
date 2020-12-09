namespace AulaPOO_Abstracao.classes
{
    public abstract class Cartao : Pagamento
    {
        public string badeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarXartao()
        {
            return "";
        }
    }
}