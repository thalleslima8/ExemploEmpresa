using ExemploEmpresa.Entities;
using System;
using System.Collections.Generic;

namespace ExemploEmpresa {
    class Program {
        static void Main(string[] args) {

            List<Employee> Empregados = new List<Employee> { };

            Console.WriteLine("Qual a qtd de funcionários?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Entre com o Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Entre com a qtd de horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da hora trabalhada? ");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("É Terceirizado (s/n)?");
                char t = char.Parse(Console.ReadLine());
                if (t == 's' || t == 'S') {
                    Console.WriteLine("Digite Adicional: ");
                    double additional = double.Parse(Console.ReadLine());
                    Empregados.Add(new OutsourcedEmployee(name, hours, value, additional));
                    Console.WriteLine("Empregado adicionado");
                } else {
                    Empregados.Add(new Employee(name, hours, value));
                    Console.WriteLine("Empregado adicionado");
                }
            }

            

            foreach(Employee emp in Empregados) {

                Console.WriteLine(emp);
                Console.WriteLine("Pagamento: R$ " + emp.Payment().ToString("F2"));
                
            }
        }
    }
}
