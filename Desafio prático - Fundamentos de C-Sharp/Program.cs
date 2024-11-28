using System.Text;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Diga-me o seu nome, para que possamos criar uma mensagem modificável");
        string? name = Console.ReadLine();

        while(name is not string || string.IsNullOrEmpty(name) || (!string.IsNullOrEmpty(name) && name.Trim().Length == 0))
        {
            Console.WriteLine("Diga-me, novamente, o seu nome, pois houve algum erro");
            name = Console.ReadLine();
        }

        name = name.Trim();

        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");
        Console.WriteLine(string.Format("Ola {0}! Seja muito bem-vindo!", name));
        Console.WriteLine("Ola " + name + "! Seja muito bem-vindo!");
        StringBuilder sb = new StringBuilder("Olá ");
        sb.Append(name);
        sb.Append("! Seja muito bem-vindo!");
        Console.WriteLine(sb.ToString());
    }
}