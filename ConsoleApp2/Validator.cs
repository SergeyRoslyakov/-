using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Validator
    {
        protected Validator NextValidator;

        public Validator SetNext(Validator next)
        {
            NextValidator = next;
            return next;
        }

        public abstract bool Validate(string data);
    }
}
