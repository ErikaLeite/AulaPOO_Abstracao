using System;
namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        /*
            REGRAS DE NEGÓGIO - BOLETO
            -- DESCONTO de 12%
        */
        private string codigoBarras = "34191.79001 01043.510047 91020.150008 7 84650026000";
        public string CodigoBarras
        {
            get {return codigoBarras;}
        }


        public void Registrar(float valor, DateTime dataEmissao, string codigoBarras)
        {
            System.Console.WriteLine($"O valor à ser pago é de R$ {valor * 0.88f} com 12% de desconto.");
            System.Console.WriteLine($"\nData de Emissão: {dataEmissao}");
            System.Console.WriteLine($"Data de Vencimento: {dataEmissao.AddDays(5)}");
            System.Console.WriteLine($"\nCódigo para Pagamento: {codigoBarras}");
        }
    }
            
}