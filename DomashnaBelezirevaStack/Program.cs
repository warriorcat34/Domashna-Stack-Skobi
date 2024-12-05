namespace DomashnaBelezirevaStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the brackets: ");
            string input = Console.ReadLine();
            char[] characters = input.ToArray();

            Stack<char> stack = new Stack<char>(characters);

            
            Print(stack);
            EvenOrOddBrackets(stack);

            
            
        }

        static void EvenOrOddBrackets(Stack<char> stack) 
        { 
            if (stack.Count % 2 == 0)
            {
                Console.WriteLine("The brackets are odd!");
            }
            else
            {
                Console.WriteLine("The brackets are even!");
            }
        }

        static void Print(Stack<char> stack) 
        {
            //Uhh prosto sled kato napishete skobite prosto cuknete pak enter, nz shto go pravi :)
            char[] brackets = Console.ReadLine().ToArray();
            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '(' || brackets[i] == ')')
                {
                    stack.Push(brackets[i]);
                }
            }

            while (stack.Count > 0) 
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
