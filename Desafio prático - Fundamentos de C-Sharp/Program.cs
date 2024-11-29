using Desafio_prático___Fundamentos_de_C_Sharp;
using Desafio_prático___Fundamentos_de_C_Sharp.Enum;
using System.Text;
using System.Text.RegularExpressions;
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
    public static bool ValidateLicensePlate(string? value)
    {
        string? valueValidate = value;

        if (string.IsNullOrEmpty(valueValidate) || (!string.IsNullOrEmpty(valueValidate) && valueValidate.Trim().Length == 0) || valueValidate.Count() != 7 || !Regex.IsMatch(valueValidate.Substring(0, 3), @"^[a-zA-Z]+$") || !int.TryParse(valueValidate.Substring(3), out int num))
            return false;

        return true;
    }
    public static string ReturnDateFormated(DateTime date, TypeDateEnum type)
    {
        if (type == TypeDateEnum.COMPLET)
        {
            string formatoCompleto = date.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
            return formatoCompleto;
        }else if(type == TypeDateEnum.ONLY_DATE)
        {
            string formatoCompleto = date.ToString("dd/MM/yyyy");
            return formatoCompleto;
        }else if(type == TypeDateEnum.ONLY_HOUR)
        {
            string formatoCompleto = date.ToString("HH:mm");
            return formatoCompleto;
        }
        else if(type == TypeDateEnum.DATE_COMPLETE_MONTH)
        {
            string formatoCompleto = date.ToString("dd 'de' MMMM 'de' yyyy");
            return formatoCompleto;
        }


        return "Formato Incorreto";
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

    public static void Desafio4()
    {
        Console.WriteLine("Digite uma ou mais palavras para que seja retornado a quantidade de caracteres");

        string text = ValidateSchemaNameSurname(Console.ReadLine(), true);

        text = text.Replace(" ", "");

        Console.WriteLine($"O texto, sem contar os espaços, possui um total de: {text.Count()} caracteres");
    }

    public static void Desafio5()
    {
        Console.WriteLine("Diga-me a placa do seu carro, para que possamos fazer um cadastro");
        bool isValid = ValidateLicensePlate(Console.ReadLine());

        if (!isValid)
        {
            Console.WriteLine("Diga-me, novamente pois houve algum erro, o padrão precisa ser ABC1234");
            return;
        }

        Console.WriteLine("A Placa foi inserida da forma correta, isto é, um formato válido");
    }

    public static void Main()
    {
        Console.WriteLine("Selecione quatro formatados de datas, para serem formatadas. Coloque somente os números \n1- Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)\n2- Apenas a data no formato 01/03/2024\n3- Apenas a hora no formato de 24 horas.\n4- A data com o mês por extenso.");

        string? typeDate = Console.ReadLine();
        int value;
        while(!int.TryParse(typeDate, out value))
        {
            Console.WriteLine("Selecione valores apenas de 1 a 4");
            typeDate = Console.ReadLine();
        }

        string dateFormated = ReturnDateFormated(DateTime.Now, (TypeDateEnum)value);

        Console.WriteLine(dateFormated);
    }
}