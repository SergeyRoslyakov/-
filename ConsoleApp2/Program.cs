namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nonEmptyValidator = new NewValidator();
            var lengthValidator = new LengthValidator();
            var numericValidator = new NumericValidator();
            var rangeValidator = new RangeValidator(1, 100);

            nonEmptyValidator.SetNext(lengthValidator).SetNext(numericValidator).SetNext(rangeValidator);

            Console.WriteLine("Введите данные для валидации:");
            string inputData = Console.ReadLine();

            bool isValid = nonEmptyValidator.Validate(inputData);

            if (isValid)
            {
                Console.WriteLine("Данные валидны.");
            }
        }
    }
}

