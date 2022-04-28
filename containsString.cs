
namespace Arrays
{
    internal class containString
    {
        static void Main(string[] args)
        {
            string checkHello = "hello";
            string[] messages = { "hello", "world", "kamusta", "mundo" };

            // matching string using LINQ method efficiently

            if (messages.Contains(checkHello))
            {
                Console.WriteLine("hello message is determined!");

            }
            else
            {
                Console.WriteLine("hello message is not determine!");
            }

            // matching string using LINQ method 

            // if (messages.Any(checkHello.Contains))
            // {
            //     Console.WriteLine("hello message is determined!");
            // }
            // else
            // {
            //     Console.WriteLine("hello message is not determine!");
            // }


            // matching string using foreach loop
            /*            foreach (string check in messages)
                       {

                           if (messages.Contains("hello"))
                           {
                               Console.WriteLine("hello message is determined!");
                           }
                           else
                           {
                               Console.WriteLine("hello message is not determine!");
                           }

                       } */



        }
    }
}