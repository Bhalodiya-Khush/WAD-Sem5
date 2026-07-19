using System;
namespace Program4
{
    public class  BrowserHistory
    {
        static void DisplayMenu()
        {
            Console.WriteLine("\n========== Browser History ==========");
            Console.WriteLine("1. Visit New Webpage");
            Console.WriteLine("2. Go Back");
            Console.WriteLine("3. View Current Page");
            Console.WriteLine("4. Display Browsing History");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }

        static void Main(String[] args)
        {
            Stack<string> stack = new Stack<string>();
            while(true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                int input;
                if (!int.TryParse(choice, out input))
                {
                    Console.WriteLine("Invalid input! Please enter numbers only.");
                    continue;
                }
                switch (input)
                {
                    case 1:
                        Console.Write("Enter the URL of the webpage: ");
                        string url = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(url))
                        {
                            Console.WriteLine("URL cannot be empty.");
                            break;
                        }
                        stack.Push(url);
                        Console.WriteLine($"Visited: {url}");
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            string lastVisited = stack.Pop();
                            Console.WriteLine($"Went back from: {lastVisited}");
                        }
                        else
                        {
                            Console.WriteLine("No pages to go back to.");
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine($"Current Page: {stack.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("No current page. Please visit a webpage first.");
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine("Browsing History:");
                            foreach (string page in stack)
                            {
                                Console.WriteLine(page);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No browsing history available.");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }
}