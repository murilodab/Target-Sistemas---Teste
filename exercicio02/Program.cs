namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: \n");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            List<int> fibonacci = generateFibonacci(num);

            foreach(int n in fibonacci)
            {
                Console.Write(n);
            }

            if (fibonacci.Contains(num))
            {
                Console.WriteLine("\n\nO seu número está no Fibonacci.");
            }else
            {
                Console.WriteLine("\n\nO seu número não está no Fibonacci.");
            }

            Console.ReadLine();
        }

        public static List<int> generateFibonacci(int num) {

            List<int> fibonacci = new List<int>
            {
                0,1
            };

            int i = 0;

            while (fibonacci[i+1] < num)
            {
                fibonacci.Add(fibonacci[i] + fibonacci[i+1]);
                i++;
            }

            return fibonacci;


        }

    }
}
