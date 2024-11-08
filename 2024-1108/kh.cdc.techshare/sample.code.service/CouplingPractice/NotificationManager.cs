namespace sample.code.service.CouplingPractice
{
    public class NotificationManager
    {
        public void Notify(string messageType, string message)
        {
            if (messageType.Equals("Email"))
            {
                EmailNotificationService emailService = new EmailNotificationService();
                emailService.Send(message);
            }
            else
            {
                SMSNotificationService smsService = new SMSNotificationService();
                smsService.Send(message);
            }
           
         
        }
    }
}
