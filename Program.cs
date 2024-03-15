namespace FIcha1_Exer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor_1;
            double valor_2;

            Console.WriteLine("Por favor indroduza 2 valores: \n\t");
            valor_1 = Convert.ToDouble(Console.ReadLine());
            valor_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Os resultados das operações aritméticas são:\n");
            Console.WriteLine($"Soma é: {valor_1 + valor_2}");
            Console.WriteLine($"Subtração é: {valor_1 - valor_2}");
            Console.WriteLine($"Multiplicação é: {valor_1 * valor_2}");
            Console.WriteLine($"Divisão é :{valor_1 / valor_2}");
        }
    }
}
