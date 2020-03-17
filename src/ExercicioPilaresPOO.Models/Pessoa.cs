using System;

namespace ExercicioPilaresPOO.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set;}

        public long Cpf { get; set;}

        public string Sexo { get; set; }

        public abstract double Bonificacao();
        
    }
}
