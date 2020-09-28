namespace dotnet_core_email_sender.EmailModel
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}