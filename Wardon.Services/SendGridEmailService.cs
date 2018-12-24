using System;
using Wardon.Contracts;

namespace Wardon.Services
{
    public class SendGridEmailService : IEmailService
    {
        public bool Send(string from, string[] to, string[] bcc, string[] cc, string content)
        {
            throw new NotImplementedException();
        }
    }
}
