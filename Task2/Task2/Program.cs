using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine("1. Send message by email");
                Console.WriteLine("2. Send message by sms");
                Console.WriteLine("0. Quit");

                selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 2)
                {
                    SmsSender smssender = new SmsSender();
                    smssender.SendMessage(2);

                }
                else if (selection==1)
                {
                    EmailSender emailsesender = new EmailSender();
                    emailsesender.SendMessage(1);
                }

            } while (selection != 0);


            


        }



    }
}
