using System;

namespace ExercicioPilaresPOO.Models
{
    public class Gerente : Funcionario
    {
        public int FuncionariosGerenciados { get; set; }

        public int Senha { get; set; }

        public override double Bonificacao()
        {
            return Salario * 0.30;
        }

    }

}

