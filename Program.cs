namespace lab06;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        double peso, altura, imc;
        // Interação com o usuário
        Console.WriteLine("Insira o seu peso em kg: ");
        peso = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira sua altura em metros: ");
        altura = double.Parse(Console.ReadLine()!);
        // Processamento
        imc = peso / Math.Pow(altura, 2);

        switch (imc)
        {
            case > 34:
                Console.WriteLine("Situação: Muito obeso");
                break;
            case >= 30:
                Console.WriteLine("Situação: Obeso");
                break;
            case >= 25:
                Console.WriteLine("Situação: Acima do peso");
                break;
            case >= 20:
                Console.WriteLine("Situação: Peso normal");
                break;
            default:
                Console.WriteLine("Situação: Abaixo do peso");
                break;
        }
    }
}
