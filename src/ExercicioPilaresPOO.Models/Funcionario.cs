using System;

namespace ExercicioPilaresPOO.Models
{
    public abstract class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public string Funcao { get; set; }
        public DateTime DataAdmissao { get; set; }

    }
}
