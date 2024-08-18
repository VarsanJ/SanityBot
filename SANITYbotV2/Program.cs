using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityBot
{


    internal class Program
    {

        public static void Main(string[] args)
        {
            Introduction();
            information();
            operation();
            Console.ReadKey();

        }

        public static string Determination(string analyzeMessage)
        {
            analyzeMessage = analyzeMessage.Trim();
            analyzeMessage = analyzeMessage.ToLower();

            if (analyzeMessage.Contains("distress") || analyzeMessage.Contains("crisis") || analyzeMessage.Contains("help") || analyzeMessage.Contains("911") || analyzeMessage.Contains("988") || analyzeMessage.Contains("emergency") || analyzeMessage.Contains("resource") || analyzeMessage.Contains("number"))
            {
                return @"
Help is available! Here are a few resources you can use.
Need Emergency Help: Call 911 Immediately
Thinking of Suicide?: Call 988,
CAMH: https://cmha.ca/find-help/
Kids Help Phone: Call 1-800-668-6868
Ontario Resources: https://www.ontario.ca/page/find-mental-health-support
Health Connect Ontario: Call 811

You are not ALONE. Help is AVAILABLE!!!
";
            }

            if (analyzeMessage.Contains("quote"))
            {
                //Gives a positive quote
                Random random = new Random();
                if (random.Next(0, 2) == 0) 
                {
                    return "\"Keep your face to the sunshine and you cannot see a shadow.\" - Helen Keller";
                }
                else
                {
                    return "\"If you’re going through hell, keep going.\" — Winston Churchill";
                }
            }


            int numSuicide = 0;
            string[] suicide = { "kms", "want to die", "kill myself", "suicide", "death", "suicidal", "jump off", "end", "die", "quit" };
            foreach (string check in suicide)
            {
                if (analyzeMessage.Contains(check))
                {
                    numSuicide++;
                }
            }

            int numDepression = 0;
            string[] depression = { "sad", "depressed", "upset", "emotional", "unstable", "no one loves me", "depression", "emo", "unstable" };
            foreach (string check in depression)
            {
                if (analyzeMessage.Contains(check))
                {
                    numDepression++;
                }
            }

            int numAnxiety = 0;
            string[] anxiety = { "anxi", "anxiety", "anxious", "worry", "concerned", "fearful", "nervous", "worried", "stagefright", "I dont know", "will i succeed" };
            foreach (string check in anxiety)
            {
                if (analyzeMessage.Contains(check))
                {
                    numAnxiety++;
                }
            }


            int numLoneliness = 0;
            string[] loneliness = { "lonely", "no one", "alone", "isolate", "solitude", "private", "seclude", "lonesome", "lone"};
            foreach (string check in loneliness)
            {
                if (analyzeMessage.Contains(check))
                {
                    numLoneliness++;
                }
            }

            int numLossLife = 0; //lost a relative, a friend (ADD MORE CATEGORIES U CAN THINK OF, like 1 or 2  or 3)
            string[] losslife = { "relative died", "family died", "died", "sibling died", "brother died", "sister died", "mom died", "dad died", "cousin died", "aunt died", "dog died", "uncle died", "pet died" };
            foreach (string check in losslife)
            {
                if (analyzeMessage.Contains(check))
                {
                    numLossLife++;
                }
            }


            int numPositiveMessage = 0;
            string[] positivemessage = { "positive", "motivate", "driven", "advice", "therapy", "assistance" };
            foreach (string check in positivemessage)
            {
                if (analyzeMessage.Contains(check))
                {
                    numPositiveMessage++;
                }
            }

            int numStressed = 0;
            string[] stressed = { "tension", "stress", "burnt out", "burned out", "overwork", "burn", "work", "stressed" };
            foreach (string check in stressed)
            {
                if (analyzeMessage.Contains(check))
                {
                    numStressed++;
                }
            }

            int numEatingDisorder = 0;
            string[] eatingdisorder = { "ED", "eating disorder", "never eating", "barely eat", "never eat", "scared to eat", "skinny" };
            foreach (string check in eatingdisorder)
            {
                if (analyzeMessage.Contains(check))
                {
                    numEatingDisorder++;
                }
            }

            int numPTSD = 0;
            string[] PTSD = { "scarred", "forever hurt", "damaged", "ptsd"};
            foreach (string check in PTSD)
            {
                if (analyzeMessage.Contains(check))
                {
                    numPTSD++;
                }
            }

            // This SECTION is to compare each numbers to determine which one is the highest
            int[] compare = {numAnxiety, numDepression, numEatingDisorder, numLoneliness, numLossLife, numPositiveMessage, numPTSD, numStressed, numSuicide};
            int maxvalue = compare.Max();
            int maxlocation = compare.ToList().IndexOf(maxvalue);
            if (numAnxiety + numDepression + numEatingDisorder + numLoneliness + numLossLife + numPositiveMessage + numPTSD + numStressed + numSuicide == 0)
            {
                return "unknown";
            }
            else if (maxlocation == 0)
            {
                return "anxiety";
            }
            else if (maxlocation == 1)
            {
                return "depression";
            }
            else if (maxlocation == 2)
            {
                return "eatingdisorder";
            }
            else if (maxlocation == 3)
            {
                return "loneliness";
            }
            else if (maxlocation == 4)
            {
                return "losslife";
            }
            else if (maxlocation == 5)
            {
                return "positive";
            }
            else if (maxlocation == 6)
            {
                return "ptsd";
            }
            else if (maxlocation == 7)
            {
                return "stressed";
            }
            else if (maxlocation == 8)
            {
                return "suicide";
            }
            return "unknown";


        } 


        public static void Introduction()
        {
            // Purpose: Introduce users to the ChatBot
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
________________________________________________________________
Welcome  to  SanityBot  -  Your Personal Mental Health Chatbot !
         Your mental health is important to us all.
This program was developed by Varsan Jeyakkumar and Ishraq Alam.
                  Press any KEY to PROCEED!
________________________________________________________________
            ");
            Console.ReadKey();
            Console.Clear();

            // Purpose: Agree to the terms of service
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
By Proceeding (entering any key) or using this program, you agree to the following Terms of Service:
(1) You are not to exploit any vulnerabilities, glitches or bugs in the program
(2) You are not to use the program in any way which is illegal, hurtful, discriminatory, hateful or dangerous
(3) This program may not always be 100% Accurate, please report any issues to the developers
");
            Console.ReadKey();
            Console.Clear();
        }

        public static void information()
        {
            Console.WriteLine(@"
Welcome to this interactive ChatBot - powered by OpenAI's ChatGPT and topic related customization!
Enter simple requests and the chatbot will guide you on the right track!
Enter exit to terminate the program
");
        }

        public static void operation()
        {
            while (true)
            {
                //Input
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("USER: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string input = Console.ReadLine();
                if ((input.Length == 0)||input == null)
                {
                    while (true)
                    {
                        Console.WriteLine("Please enter a valid string!");
                        input = Console.ReadLine();
                        if (input.Length>0)
                        {
                            break;
                        }
                    }
                    
                }
                input = input.Trim();
                input = input.ToLower();

                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("SanityBot: "); 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank you for using SanityBot! Exiting the program once you press any key!");
                    break; //Termination Break
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("SanityBot: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string checking = Determination(input);
                if (checking == "unknown")
                {
                    Console.WriteLine("I am sorry, I was unable to understand. Please reword it or try to simplify your prompt!");
                }
                else if (checking == "suicide")
                {
                    Console.WriteLine("Nothing ever is worth taking your own life. You are a being with so much potential, and you must fulfill it. You are wonderful and a key component to the world. If you need help, dial 988!");
                }
                else if (checking == "anxiety")
                {
                    Console.WriteLine("Anxiety is natural when you try something new. In fact, it can be considered as the barrier between you and your potential. Don't be afraid to leap beyond your boundaries and limits!");
                }
                else if (checking == "depression")
                {
                    Console.WriteLine("I am sorry to hear that. It is important to remember that you are not alone and that there are people who care about you. You can reach out to a friend, family member, or a professional if you need help.");
                }
                else if (checking == "loneliness")
                {
                    Console.WriteLine("There are people all around you who care about you. Try to connect with family and friends, they also long to be with you. You can try joining clubs, sports, activities, and clubs to meet those who have similar interests to you.");
                }
                else if (checking == "losslife")
                {
                    Console.WriteLine("I am sorry to hear that. Human life is truly valuable. Everyone responds differently, so take your time to come to terms with the loss. It is important to remember that you are not alone and that there are people who care about you.");
                }
                else if (checking == "positive")
                {
                    Random random2 = new Random();
                    if (random2.Next(0, 2) == 1)
                        Console.WriteLine("Every day is a good day. It is true that sometimes there are moments which can be difficult and tough to handle. However, cherish the moments in life which bring you happiness and joy.");
                    else
                        Console.WriteLine("You are a wonderful person capable of so much good!");
                }
                else if (checking == "ptsd")
                {
                    Console.WriteLine("PTSD is caused by many reasons. You should seek professional guidance to resolve your PTSD. There is no shame in treating it, it can happen to anybody!");
                }
                else if (checking == "eatingdisorder")
                {
                    Console.WriteLine("Eating is a natural part of life. Sometimes you may feel like you're not hungry, but please make sure to eat enough! Try a variety of different foods to see what you like best.");
                }
                else if (checking == "stressed")
                {
                    Console.WriteLine("Take a breath and calm down. Do something which makes you happy and take a quick break. Make sure to focus on yourself. Sometimes, a simple break calms us down and enables us to tackle issues better!");
                }
                else
                {
                    Console.WriteLine(checking);
                }
            }
        }
    }
}
