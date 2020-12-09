namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        /*
        REGRAS DE NEGÓCIO CARTÃO DE CRÉDITO
            -- JUROS: 5% em até 6 parcelas
                      8% de 7 à 12 parcelas
            -- NÃO ACEITAR MAIS QUE 12 PARCELAS        
        */

        private float limite = 3000;

        public void Pagar(float valor)
        {

        }
    }
}