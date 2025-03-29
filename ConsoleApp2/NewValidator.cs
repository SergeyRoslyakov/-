using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NewValidator : Validator
    {
        public override bool Validate(string data)
        {
            if (data == null || data.Trim() == "")
            {
                Console.WriteLine("Ошибка: Данные не могут быть пустыми.");
                return false;
            }
            return NextValidator?.Validate(data) ?? true;
        }
    }
}
