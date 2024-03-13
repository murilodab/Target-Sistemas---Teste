namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 05 - Inverta uma string\n\n");
            Console.WriteLine("Escreva a palavra ou frase para ser invertida: ");

            string input = Console.ReadLine();

            string invertida = invertString(input);
            Console.WriteLine(invertida);
            Console.ReadLine();
        }

        public static string invertString(string input)
        {



            char[] invertida = input.ToCharArray();
            Array.Reverse(invertida);

            return new string(invertida);

        }
    }
}
