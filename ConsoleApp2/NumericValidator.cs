using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NumericValidator : Validator
    {
        public override bool Validate(string data)
        {
            if (!int.TryParse(data, out _))
            {
                Console.WriteLine("Ошибка: Данные должны быть числом.");
                return false;
            }
            return NextValidator?.Validate(data) ?? true;
        }
    }
}
