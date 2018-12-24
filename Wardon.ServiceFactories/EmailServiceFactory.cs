using System;
using Wardon.Contracts;
using Wardon.Contracts.Factories;
using Wardon.Services;
using Wardon.Support;

namespace Wardon.ServiceFactories
{
    public class EmailServiceFactory : IEmailServiceFactory
    {
        public IEmailService ResolveEmailService(EmailSenderType emailSenderType = EmailSenderType.Gmail)
        {
            switch (emailSenderType)
            {
                case EmailSenderType.Gmail:
                    return new GmailEmailService();
                case EmailSenderType.SendGrid:
                    return new SendGridEmailService();
                default:
                    throw new NotImplementedException("Requested Email Service has not been implemented.");
            }
        }
    }
}
