namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList program");
            Linkedlist ln = new Linkedlist();
            ln.Add(30);
            ln.Add(56);
            ln.Add(40);
            ln.Add(70);
            int search = ln.Search(50);

            ln.InsertAtParticularPosition(3, 50);
            ln.Display();
            ln.DeleteNodeAtParticularPosition(3);
        }
    }
}