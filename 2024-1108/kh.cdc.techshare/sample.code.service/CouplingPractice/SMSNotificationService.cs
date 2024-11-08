using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.code.service.CouplingPractice
{
    internal class SMSNotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending sms: {message}");
        }
    }
}
