using System.Globalization;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercise 1>");
            Car bmw = new Car("BMW", 2023, 30000);
            bmw.displayCarInfo();

            Console.WriteLine("\nExercise 2>");
            BankAccount suyog = new BankAccount("22016093");
            suyog.Deposit(1000);
            suyog.Withdraw(500);
            suyog.DisplayBalance();

            Console.WriteLine("\nExercise 3>");
            Rectangle r1 = new Rectangle(4.5f, 3.2f);
            Console.WriteLine($"The area of rectangle is: {r1.CalculateArea()}");

            Console.WriteLine("\nExercise 4>");
            Circle shape = new Circle(5);
            Console.WriteLine($"The area of circle is : {shape.CalculateArea()}");

            Console.WriteLine("\nExercise 5>");
            Student s1 = new Student("Suyog Shakya", 21, "BIT");
            s1.Introduce();

            Console.WriteLine("\nExercise 6>");
            Stack<int> st1 = new Stack<int>();
            
            st1.Push(1);
            Console.WriteLine("The stack after pushing 1st item:");
            st1.DisplayStack();
            st1.Push(2);
            st1.Push(3);
            st1.Push(4);
            st1.Push(5);
            st1.Push(6);
            Console.WriteLine("The stack after pushing few items:");
            st1.DisplayStack();

            int poppedItem = st1.Pop();
            Console.WriteLine($"The item popped is : {poppedItem}");
            Console.WriteLine("The updated stack is:");
            st1.DisplayStack();

            Console.WriteLine("\nExercise 7>");
            Calendar calendar = new Calendar();
            calendar.PrintWeekdays();
        }
    }


}