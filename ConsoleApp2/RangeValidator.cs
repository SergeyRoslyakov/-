using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RangeValidator : Validator
    {
        private readonly int _min;
        private readonly int _max;

        public RangeValidator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool Validate(string data)
        {
            int number = int.Parse(data);
            if (number < _min || number > _max)
            {
                Console.WriteLine($"Ошибка: Данные должны быть в диапазоне от до {_max}.");
                return false;
            }
            return NextValidator?.Validate(data) ?? true;
        }
    }
}
