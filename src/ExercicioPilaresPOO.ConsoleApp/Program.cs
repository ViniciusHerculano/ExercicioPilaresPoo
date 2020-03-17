using System;
using  ExercicioPilaresPOO.Models;

namespace ExercicioPilaresPOO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bonificacao Cliente

            var cliente = new Cliente();
            cliente.Nome = "Vinicius Cliente";
            cliente.Cpf = 11111111111;
            cliente.Sexo = "Masculino";
            cliente.FormaPgmento = "À vista, crediário e Cartão de Crédito";
            cliente.Limite = 500.00;
            
            Console.WriteLine("--------------------- INFORMAÇÕES DO CLIENTE ---------------------");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Cpf: {cliente.Cpf}");
            Console.WriteLine($"Sexo: {cliente.Sexo}");
            Console.WriteLine($"Formas de pagamentos aceitas: {cliente.FormaPgmento}");
            Console.WriteLine($"Limite para compras no Cred.: {cliente.Limite}");
            Console.WriteLine($"Bonificação para desconto: R${cliente.Bonificacao()}");
            Console.WriteLine("------------------------------------------------------------------");

            #endregion
            
            #region Bonificação Telefonista

            var telefonista = new Telefonista();
            telefonista.Nome = "Telefonista";
            telefonista.Cpf = 22222222222;
            telefonista.Sexo = "Feminino";
            telefonista.Salario = 1350.00;
            telefonista.Ramal = 1;

            Console.WriteLine("------------------- INFORMAÇÕES DO FUNCIONÁRIO -------------------");
            Console.WriteLine($"Nome: {telefonista.Nome}");
            Console.WriteLine($"Cpf: {telefonista.Cpf}");
            Console.WriteLine($"Sexo: {telefonista.Sexo}");
            Console.WriteLine($"Ramal: {telefonista.Ramal}");
            Console.WriteLine($"Salário: {telefonista.Salario}");
            Console.WriteLine($"Bonificação salarial: R${telefonista.Bonificacao()}");
            Console.WriteLine("------------------------------------------------------------------");

            #endregion

            #region Bonificação Gerente

            var gerente = new Gerente();
            gerente.Nome = "Gerente";
            gerente.Cpf = 33333333333;
            gerente.Sexo = "Masculino";
            gerente.Salario = 2600.00;
            gerente.FuncionariosGerenciados = 50;
            gerente.Senha = 1234;

            Console.WriteLine("------------------- INFORMAÇÕES DO FUNCIONÁRIO -------------------");
            Console.WriteLine($"Nome: {gerente.Nome}");
            Console.WriteLine($"Cpf: {gerente.Cpf}");
            Console.WriteLine($"Sexo: {gerente.Sexo}");
            Console.WriteLine($"Funcionários gerenciados: {gerente.FuncionariosGerenciados}");
            Console.WriteLine($"Senha: {gerente.Senha}");
            Console.WriteLine($"Salário: {gerente.Salario}");
            Console.WriteLine($"Bonificação salarial: R${gerente.Bonificacao()}");
            Console.WriteLine("------------------------------------------------------------------");

            #endregion


        }
    }
}
