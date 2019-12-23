using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploEmpresa.Enums {
    class OutsourcedEmployee : Employee {

        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            double payment = ValuePerHour * Hours;
            payment += AdditionalCharge * 1.1;
            return payment;
        }

        public override string ToString() {
            return base.ToString() + "\nValor adicional: " + AdditionalCharge;
        }
    }
}
