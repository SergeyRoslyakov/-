using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LengthValidator : Validator
    {
        public override bool Validate(string data)
        {
            if (data.Length < 5)
            {
                Console.WriteLine("Ошибка: Длина данных должна быть не менее 5 символов.");
                return false;
            }
            return NextValidator?.Validate(data) ?? true;
        }
    }
}
