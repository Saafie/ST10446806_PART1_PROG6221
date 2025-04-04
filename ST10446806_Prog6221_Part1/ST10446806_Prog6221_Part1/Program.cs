using System;
using System.Speech.Synthesis;
using System.Media;
using System.Linq;



class Chatbot
{
    public string Name { get; set; }
    public string userName { get; set; }

    public Chatbot(string name)
    {
        Name = name;
        
    }

    public void GreetUser()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hello! Welcome to " + Name + ". Your friendly Cybersecurity Awarenesss chatbot! Here to keep you safe online");
        Console.ResetColor();

    }

    public void Sound()
    {//Sound Path for voice
        string filePath = @"C:\Users\Insaaf Behardien\Documents\ST10446806_Prog6221_Part1\ST10446806_Prog6221_Part1\ProgAudio.wav;
        try
        {
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                player.PlaySync();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error playing sound: " + ex.Message);
            Console.ResetColor();
        }





    }

    public void DisplayASCIIArt()
    {// ASCIIART
        Thread.Sleep(500);
        Task.Run(() => Sound());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
 Thread.Sleep(500);

        Console.WriteLine(@"

                         ██████╗ ██╗     ██╗   ██╗██████╗  ██████╗ ████████╗");
        Thread.Sleep(500);
        Console.WriteLine(@"                         ██╔══██╗██║     ██║   ██║██╔══██╗██╔═══██╗╚══██╔══╝"); Thread.Sleep(500);
        Console.WriteLine(@"                         ██████╔╝██║     ██║   ██║██████╔╝██║   ██║   ██║   "); Thread.Sleep(200);
        Console.WriteLine(@"                         ██║  ██╗██║     ██║   ██║██╔══██╗██║   ██║   ██║   "); Thread.Sleep(200);
        Console.WriteLine(@"                         ██████╔╝███████╗╚██████╔╝██████╔╝╚██████╔╝   ██║  "); Thread.Sleep(200);
        Console.WriteLine(@"                         ╚═════╝ ╚══════╝ ╚═════╝ ╚═════╝  ╚═════╝    ╚═╝  "); Thread.Sleep(200);
        Console.WriteLine(@"                                                                          
                         ███████╗███████╗ ██████╗██╗   ██╗██████╗ ███████╗ "); Thread.Sleep(500);
        Console.WriteLine(@"                         ██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗██╔════╝"); Thread.Sleep(200);
        Console.WriteLine(@"                         ███████╗█████╗  ██║     ██║   ██║██████╔╝█████╗ "); Thread.Sleep(200);
        Console.WriteLine(@"                         ╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗██╔══╝"); Thread.Sleep(200);
        Console.WriteLine(@"                         ███████║███████╗╚██████╗╚██████╔╝██║  ██║███████╗  "); Thread.Sleep(200);
        Console.WriteLine(@"                         ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝ "); Thread.Sleep(200);
        Console.WriteLine(@"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ForegroundColor = ConsoleColor.Cyan; //Changes font color
        Console.WriteLine(@"
| Password Safety...
| Phishing...
| Data Secured...
| Threat Detection...");

        Console.ResetColor();
        Thread.Sleep(4000);
        Console.Clear();
    }



    public void Chat()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        //Heading
        Console.WriteLine("BluBoT Secure");
        Console.WriteLine("===============================================================================================");

        //Chatbot ask your name
        Console.WriteLine("What is your name? ");
        Console.ResetColor();

        string userName;
        while (true)
        {
            userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName) || userName.Length <= 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Username must be more than 2 letters. Please try again."); // Flags invalid answer
                Console.ResetColor();
            }
            else
            {
                break;
            }
        }

        while (true) // Main interaction loop
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nNice to meet you, " + userName);
            Console.WriteLine("***************************************************");
            Console.WriteLine("Things you can ask me:");
            Console.WriteLine("- How are you doing?"); // Ask the bot how its doing
            Console.WriteLine("- What can I ask you?");// What questions can be asked
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            string feelings = Console.ReadLine().ToLower();

            if (feelings.Contains("exit"))
        {
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nGoodbye " + userName + "! Stay safe online.");
            Console.ResetColor();
            Environment.Exit(0); // Exit immediately if "exit" is typed
        }

            // must contain these words
            if (feelings.Contains("how") || feelings.Contains("are")|| feelings.Contains("doing"))
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nI am doing well. How are you doing, " + userName + "?");
                    Console.ResetColor();
                    string userfeel = Console.ReadLine().ToLower();

                    string[] keywords = { "i'm", "i", "am", "im", "good", "well", "happy", "amazing", "great", "splendid", "doing" };
                    string[] badkeywords = { "i'm", "i", "am", "im", "doing", "bad", "awful", "sad" };
                    bool containsKeywordG = keywords.Any(word => userfeel.Contains(word));
                    bool containsKeywordB = badkeywords.Any(word => userfeel.Contains(word));

                    if (containsKeywordG)
                    {// if you doing well
                        Thread.Sleep(200);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nI'm happy to hear that!");
                        Console.ResetColor();
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(200);
                        Console.WriteLine("\nFeel free to ask me anything about Cyber Security.");
                        Console.ResetColor();
                        Chatquestions();
                        break;
                    }
                    // if you not doing well
                    else if (containsKeywordB)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nI'm sorry to hear that.");
                        Console.ResetColor();
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                        Thread.Sleep(200);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nFeel free to ask me anything about Cyber Security.");
                        Console.ResetColor();
                        Chatquestions(); // This stays in place
                        break;
                    }
                    else
                    {//if a valid answer was not given
                        Thread.Sleep(200);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nI'm sorry, I didn't quite get that. Can you rephrase your answer?");
                        Console.ResetColor();
                    }
                } break;
            }
            else if (feelings.Contains("ask")) // if asked what questions
            {
                Chatquestions();
                break;
            }
            else if (string.IsNullOrEmpty(feelings)) // if left empty
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nPlease enter a valid answer.");
                Console.ResetColor();
            }
            else
            {
                invalid();
            }
        }
    }


    public void Chatquestions()
    //method to get questions
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nYou can ask anything about cybersecurity. Some examples are:");
        Console.WriteLine("- What's your purpose?");
        Console.WriteLine("- Password safety");
        Console.WriteLine("- What is phishing?");
        Console.WriteLine("- Safe browsing");
        Console.ResetColor();
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        securityQ();
    }


    public void securityQ() // Method for answers
    {
        while (true)
        {
            string answer = quit();

            //questions about purpose
            if (answer.Contains("purpose"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMy purpose is to provide knowledge on cybersecurity and its practices among users, such as employees, students, and organizations. I inform users of online threats and how to avoid these common risks, by sending notifications about potential threats and alerting users to risky activities.");
                Console.WriteLine("If you would like to know more in-depth, don't be afraid to ask more questions.");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: to Quit");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            // Respond to questions about password safety
            else if (answer.Contains("password safety"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPassword safety helps protect your data and account from any intruders or attackers, and limits the possiblity of you account getting hacked");
                Console.WriteLine("- Other Questions asked:");
                Console.WriteLine("- Types of password practices");
                Console.WriteLine("- What makes a Strong password");
                Console.WriteLine("- Reusing Passwords");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: to Quit");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                passwordQ();
            }

            // Respond to questions about phishing
            else if (answer.Contains("phishing"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPhishing is a cyber attack, It is used by impersonating as an orginiazation,services or individuals to decieve users and gain sensitive information");
                Console.WriteLine("examples are:");
                Console.WriteLine("Email - Links or downloads are sent via email, with the attacker disguised as a legitemate company");
                Console.WriteLine("pressing on these links can cause you to be redirected to risky websites or have malicious malware installed on ur device");
                Console.WriteLine("Smishing - SMS phishing where malisious links and websites are sent via text messages");
                Console.WriteLine("Exit: to Quit"); 
                Console.WriteLine("Return: Return to previous questions");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            // Respond to questions about safe browsing
            else if (answer.Contains("safe browsing"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nSafe browsing is the practices you follow to away from the risks of malicious websites, threats, viruses, identity theft and scams when browsing online");
               
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.ResetColor(); 
                SafeBrowsing();
            }
            else
            {
                invalid();
            }
        }
    }

    public void passwordQ() // method to passwords extra questions
    {
        Console.ResetColor();


        while (true)
        {
            string answer = quit();

            //gives practices for passwords
            if (answer.Contains("practices"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPassword Practices");

                Console.WriteLine("Biometric Passwords: It uses Biological features to create passwords on your device, using biometric scanner that scans your unique features, to calculate the match percentage of your biometric password");
                Console.WriteLine(" Multi-Factor Authentication (MFA), is an authentication process that uses two ways to grant acess to personal information and accounts. An OTP and a Password, an otp is a one time code sent to the verified email or cell number.");
                Console.WriteLine("Strong passwords can be used to keep anyone from accessing ur sensitive information, because stronger passwords are harder to crack");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: to Quit");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                quit();
            }

            //Gives you strong passwords
            else if (answer.Contains("strong"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nYou can create a Strong password by:");
                Console.WriteLine("Including special characters or numbers e.g. @,!,?");
                Console.WriteLine("Using more Characters to create longer passwords");
                Console.WriteLine("Do not use personal information: Birthdays, Names, phone numbers");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: to Quit");
                Console.ResetColor();
            
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                quit();
            }

            //gives you why you cant reuse passwords
            else if (answer.Contains("reusing") || answer.Contains("re-using"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nIt increases the risks of syberattacks, if a hacker steals a password from one website it has access to your other accounts and your password can be spread and bought over the dark web");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: to Quit");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                quit();
            }
        }
    }



    //safe Browsing method
    public void SafeBrowsing()
    {
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nFuther Questions asked: ");
        Console.WriteLine("- How to Practice Safe Browsing");
        Console.WriteLine("- What is a VPN?");
        Console.WriteLine("Return: Return to previous questions");
        Console.WriteLine("Exit: to Quit");
        Console.ResetColor();
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");


        while (true)
        {// allows you to quit the console
            string answer = quit();


            // Phrases to match exactly
            string[] phrases =
            {
            "how to practice safe browsing",
            "practice safe browsing",
            "safe browsing practices"
        };

            // Keywords to check if any are present
            string[] keywords = { "how", "to", "practice", "safe", "browsing" };

            // Check if input contains an exact phrase OR at least one keyword
            bool containsPhrase = phrases.Any(phrase => answer.Contains(phrase));
            bool containsKeyword = keywords.Any(word => answer.Contains(word));

            if (containsPhrase || containsKeyword)
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("3 Ways to Practice Safe Browsing:");

                Console.WriteLine("\nInstall an Ad Blocker: Ad blockers prevent unwanted ads, some of which contain malicious redirects to unsafe websites.");
                Console.WriteLine("Use an Antivirus: An antivirus program protects you from malicious websites in real-time, detecting and blocking harmful files and browsers.");
                Console.WriteLine("Avoid Public Wi-Fi for Sensitive Transactions: Public Wi-Fi is usually not secure, making it easier for hackers to access your sensitive information.");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: To Quit");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                answer = Console.ReadLine().ToLower();

                if (answer == "exit")
                {
                    Environment.Exit(0); // If "exit", quit the program
                }
                else if (answer == "return")
                {
                    Chatquestions(); // If "return", go back to the previous questions
                    break; // Stop the current loop and go back to previous questions
                }
                else
                {
                    invalid(); // If the answer is anything else, call invalid() method
                }
            }
            else if (answer.Contains("vpn"))
            {
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nA VPN creates a secure and encrypted connection to the internet using a private network.");
                Console.WriteLine("Return: Return to previous questions");
                Console.WriteLine("Exit: To Quit");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                answer = Console.ReadLine().ToLower();

                if (answer == "exit")
                {
                    Environment.Exit(0); // If "exit", quit the program
                }
                else if (answer == "return")
                {
                    Chatquestions(); // If "return", go back to the previous questions
                    break; // Stop the current loop and go back to previous questions
                }
                else
                {
                    invalid(); // If the answer is anything else, call invalid() method
                }
            }
        }
    }


    public void invalid() //Displays invalid error method
    {
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nI'm not sure how to answer that. Could you try rephrasing? Or type 'exit' to quit.");
                Console.ResetColor();
    }

    public string quit() // Quiting console method
    {
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nEnter your question:");
        Console.ResetColor();

        string answer = Console.ReadLine().ToLower().Trim();

        // Exit the loop if the user types 'exit'
        if (answer.Contains("exit"))
        {
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nGoodbye " + userName + "! Stay safe online.");
            Console.ResetColor();

            // Exit the application
            Environment.Exit(0); // This terminates the application.
        }
        else if (string.IsNullOrEmpty(answer))
        {// Error handling when answer is null
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nBot: Please enter a valid question.");
            Console.ResetColor();
            return answer;
        }
        else if (answer.Contains("return"))
        {//Return to previous questions
            Chatquestions();
            securityQ();
        }

        return answer; // Return the answer to use it later
    }


    class Program
    {
        static void Main()
        {  

            Chatbot bot = new Chatbot("BluBot Secure");
            bot.GreetUser();
            bot.DisplayASCIIArt();
            bot.Chat();
            

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
