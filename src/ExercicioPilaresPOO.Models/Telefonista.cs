using System;

namespace ExercicioPilaresPOO.Models
{
    public class Telefonista : Funcionario
    {
        public int Ramal { get; set; }

        public override double Bonificacao(){
            return Salario * 0.15;
        }
        
    }
}
