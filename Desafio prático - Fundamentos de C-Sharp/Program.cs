using Desafio_prático___Fundamentos_de_C_Sharp;
using System.Text;
using System.Xml.Linq;

class Program
{
    public static string ValidateSchemaNameSurname(string? nameOrSurname, bool isString)
    {
        string? nameOrSurnameValidate = nameOrSurname;
        double val = 0;

        while (string.IsNullOrEmpty(nameOrSurnameValidate) || (!string.IsNullOrEmpty(nameOrSurnameValidate) && nameOrSurnameValidate.Trim().Length == 0) || (!isString && !double.TryParse(nameOrSurnameValidate, out val)))
        {
            Console.WriteLine("Diga-me, novamente pois houve algum erro");
            nameOrSurnameValidate = Console.ReadLine();
        }

        return isString ? nameOrSurnameValidate.Trim() : val.ToString();
    }
    public static void Desafio1()
    {
        Console.WriteLine("Diga-me o seu nome, para que possamos criar uma mensagem modificável");
        string name = ValidateSchemaNameSurname(Console.ReadLine(), true);

        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");
        Console.WriteLine(string.Format("Ola {0}! Seja muito bem-vindo!", name));
        Console.WriteLine("Ola " + name + "! Seja muito bem-vindo!");
        StringBuilder sb = new StringBuilder("Olá ");
        sb.Append(name);
        sb.Append("! Seja muito bem-vindo!");
        Console.WriteLine(sb.ToString());
    }

    public static void Desafio2()
    {
        Console.WriteLine("Diga-me o seu nome, para que possamos criar uma mensagem modificável");
        string name = ValidateSchemaNameSurname(Console.ReadLine(), true);

        Console.WriteLine("Agora, diga-me o seu sobrenome");
        string? surname = ValidateSchemaNameSurname(Console.ReadLine(), true);

        Console.WriteLine($"Olá {name} {surname}! Seja muito bem-vindo!");
        Console.WriteLine(string.Format("Ola {0} {1}! Seja muito bem-vindo!", name, surname));
        Console.WriteLine("Ola " + name + " " + surname + "! Seja muito bem-vindo!");
    }

    public static void Desafio3()
    {
        Double valor1 = 12.2;
        Double valor2 = 3.5;

        Console.WriteLine("Soma " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.ADD));
        Console.WriteLine("Subtração " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.SUBTRACT));
        Console.WriteLine("Multiplicação " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.MULTIPLICATION));
        Console.WriteLine("Divisão " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.DIVISION));
        Console.WriteLine("Média " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.AVERAGE));

        Console.WriteLine("Digite dois valores para ser feito o cálculos matemáticos");

        valor1 = double.Parse(ValidateSchemaNameSurname(Console.ReadLine(), false));
        valor2 = double.Parse(ValidateSchemaNameSurname(Console.ReadLine(), false));

        Console.WriteLine("Soma " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.ADD));
        Console.WriteLine("Subtração " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.SUBTRACT));
        Console.WriteLine("Multiplicação " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.MULTIPLICATION));
        Console.WriteLine("Divisão " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.DIVISION));
        Console.WriteLine("Média " + MathOperations.MathOperation(valor1, valor2, OperationTypeEnum.AVERAGE));
    }

    public static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras para que seja retornado a quantidade de caracteres");

        string text = ValidateSchemaNameSurname(Console.ReadLine(), true);

        text = text.Replace(" ", "");


        Console.WriteLine($"O texto, sem contar os espaços, possui um total de: {text.Count()} caracteres");
    }
}