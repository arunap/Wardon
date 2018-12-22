using System;
using Wardon.Contracts;

namespace Wardon.Services
{
    public class EmailService : IEmailService
    {
        public bool Send(string from, string[] to, string[] bcc, string[] cc, string content)
        {
            throw new NotImplementedException();
        }
    }
}
