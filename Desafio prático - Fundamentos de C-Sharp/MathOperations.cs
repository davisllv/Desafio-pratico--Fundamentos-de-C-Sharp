namespace Desafio_prático___Fundamentos_de_C_Sharp;

public class MathOperations
{
    public static double MathOperation(double valor1, double valor2, OperationTypeEnum type)
    {
        double returnValue = type switch
        {
            OperationTypeEnum.ADD => valor1 + valor2,
            OperationTypeEnum.SUBTRACT => valor1 - valor2,
            OperationTypeEnum.MULTIPLICATION => valor1 * valor2,
            OperationTypeEnum.DIVISION => valor2 == 0 ? valor1 / 1 : valor1 / valor2,
            OperationTypeEnum.AVERAGE => (new List<double>() { valor1, valor2 }).Average(),
            _ => 0
        };

        return Math.Round(returnValue, 3);
    }
}
