using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploEmpresa.Entities {
    class Employee {
        public string Name { get;private set; }
        public int Hours { get; set; }
        public double ValuePerHour { get;private set; }

        public Employee() {

        }

        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() {
            double payment = Hours * ValuePerHour;
            return payment;
        }

        public override string ToString() {
            return "Nome: " + Name
                + "\nValor por hora: R$ " + ValuePerHour
                + "\nQuantidade de horas Trabalhadas: " + Hours;
        }
    }
}
