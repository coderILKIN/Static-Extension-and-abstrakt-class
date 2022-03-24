using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class SmsSender:MessageSender
    {
        public override void SendMessage(int section)
        {
           
                Console.WriteLine("Sms ile mesaj gonerildi");
            

        }
    }
}
