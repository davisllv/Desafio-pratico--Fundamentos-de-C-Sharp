using System.Text;
using System.Xml.Linq;

class Program
{
    public static string ValidateSchemaNameSurname(string? nameOrSurname)
    {
        string? nameOrSurnameValidate = nameOrSurname;
        while (nameOrSurnameValidate is not string || string.IsNullOrEmpty(nameOrSurnameValidate) || (!string.IsNullOrEmpty(nameOrSurnameValidate) && nameOrSurnameValidate.Trim().Length == 0))
        {
            Console.WriteLine("Diga-me, novamente pois houve algum erro");
            nameOrSurnameValidate = Console.ReadLine();
        }

        return nameOrSurnameValidate.Trim();
    }
    public static void Desafio1()
    {
        Console.WriteLine("Diga-me o seu nome, para que possamos criar uma mensagem modificável");
        string name = ValidateSchemaNameSurname(Console.ReadLine());

        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");
        Console.WriteLine(string.Format("Ola {0}! Seja muito bem-vindo!", name));
        Console.WriteLine("Ola " + name + "! Seja muito bem-vindo!");
        StringBuilder sb = new StringBuilder("Olá ");
        sb.Append(name);
        sb.Append("! Seja muito bem-vindo!");
        Console.WriteLine(sb.ToString());
    }

    public static void Main()
    {
        Console.WriteLine("Diga-me o seu nome, para que possamos criar uma mensagem modificável");
        string name = ValidateSchemaNameSurname(Console.ReadLine());

        Console.WriteLine("Agora, diga-me o seu sobrenome");
        string? surname = ValidateSchemaNameSurname(Console.ReadLine());

        Console.WriteLine($"Olá {name} {surname}! Seja muito bem-vindo!");
        Console.WriteLine(string.Format("Ola {0} {1}! Seja muito bem-vindo!", name, surname));
        Console.WriteLine("Ola " + name + " " + surname + "! Seja muito bem-vindo!");
    }
}