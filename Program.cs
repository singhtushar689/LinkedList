namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList program");
            Linkedlist ln = new Linkedlist();
            ln.Add(56);
            ln.Add(30);
            ln.Add(70);
            ln.RemoveFirstNode();
            Console.WriteLine("After removing , Now LinkedList is : ");

            ln.Display();
        }
    }
}