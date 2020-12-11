using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data; //Para funcionar precisa utilizar o SYSTEM
        public DateTime Data
        {
            get {return DateTime.Now;}
            set {data = value;}
        }        
        protected float valor;


        public float Valor
        {
            get {return valor;}
            set {valor = value;}
        }

        public virtual string Cancelar()
        {
            return "";
        }

    }
}