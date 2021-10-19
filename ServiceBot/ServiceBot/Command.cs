using System;
using System.Collections.Generic;

namespace ServiceBot
{
    class Command
    {
        Chat ch = new Chat();

        public List<string> keyWords = new List<string>()
        {
            "What time is it now?",
            "What is your name?",
            "How are you?",
            "How long do you work?",
            "Show our correspondence",
            "Clean the screen",
            "Help"
        };

        public void Answer()
        {
            int orderOfCurrentInput = 0;
            DateTime starttime = DateTime.Now;

            while (true)
            {
                Console.Write("Write command: ");
                ch.Messages.Add(Console.ReadLine());

                if (ch.Messages[orderOfCurrentInput] == keyWords[0])
                {
                    Console.WriteLine(DateTime.Now.ToString("HH:mm"));
                    ch.Messages.Add(DateTime.Now.ToString("HH:mm"));
                }
                else if (ch.Messages[orderOfCurrentInput] == keyWords[1])
                {
                    Console.WriteLine("My name is Mef");
                    ch.Messages.Add("My name is Mef");
                }
                else if (ch.Messages[orderOfCurrentInput] == keyWords[2])
                {
                    Console.WriteLine("I am fine");
                    ch.Messages.Add("I am fine");
                }
                else if (ch.Messages[orderOfCurrentInput] == keyWords[3])
                {
                    DateTime endtime = DateTime.Now;
                    var workingHours = endtime - starttime;
                    Console.WriteLine(workingHours);
                    ch.Messages.Add(System.Convert.ToString(workingHours));
                }
                else if (ch.Messages[orderOfCurrentInput] == keyWords[4])
                {
                    foreach (var item in ch.Messages)
                    {
                        Console.WriteLine(item);
                    }
                    orderOfCurrentInput--;
                }
                else if (ch.Messages[orderOfCurrentInput] == keyWords[5])
                {
                    System.Console.Clear();
                    orderOfCurrentInput--;
                }
                else if (ch.Messages[orderOfCurrentInput] == keyWords[6])
                {
                    foreach (var item in keyWords)
                    {
                        Console.WriteLine(item);
                    }
                    orderOfCurrentInput--;
                }
                else
                {
                    Console.WriteLine("Sorry, idk this command....");
                    orderOfCurrentInput--;
                }
                orderOfCurrentInput += 2;
            }
        }
    }
}
