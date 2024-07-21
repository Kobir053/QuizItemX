namespace QuizItemX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. enter question\n2. see questions");
            int res = Convert.ToInt32(Console.ReadLine());
            XService service = new XService("./QuizItem.xml");
            if (res == 1)
            {
                Console.WriteLine("enter your question");
                string q = Console.ReadLine();
                Console.WriteLine("enter answer");
                string ans = Console.ReadLine();
                service.AddItem(q, ans);
            }
            else
            {
                service.Show();
            }

        }
    }
}
