namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthValidator = new LengthValidator();
            var numericValidator = new NumericValidator();
            var rangeValidator = new RangeValidator(1, 100);

            lengthValidator.SetNext(numericValidator).SetNext(rangeValidator);

            Console.WriteLine("Введите данные для валидации:");
            string inputData = Console.ReadLine();

            bool isValid = lengthValidator.Validate(inputData);

            if (isValid)
            {
                Console.WriteLine("Данные валидны.");
            }
        }
    }
}
