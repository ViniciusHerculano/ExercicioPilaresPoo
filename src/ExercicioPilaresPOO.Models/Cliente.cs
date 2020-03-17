using System;

namespace ExercicioPilaresPOO.Models
{
    public class Cliente : Pessoa
    {
        public string FormaPgmento { get; set; }
        public double Limite { get; set; }

        public override double Bonificacao(){
            return Limite * 0.02;
        }
    }
}
