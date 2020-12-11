using System;
namespace AulaPOO_Abstracao.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public void Pagar(float valor)
        {
            if(valor <= saldo){
                System.Console.WriteLine("Compra Aprovada!");
            }else{
                System.Console.WriteLine("Compra Não aprovada! Entre em contato com sua administradora.");
            }
        }
        public override string Cancelar()
        {
            return "Compra cancelada!";
        }
    }
}