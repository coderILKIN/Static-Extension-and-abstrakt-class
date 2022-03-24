using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class MessageSender
    {


        public virtual void SendMessage(int section)
        { 
                Console.WriteLine("Send MessageSender");
        }

    }
}
