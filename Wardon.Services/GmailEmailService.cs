using System;
using System.Collections.Generic;
using System.Text;
using Wardon.Contracts;

namespace Wardon.Services
{
    public class GmailEmailService : IEmailService
    {
        public bool Send(string from, string[] to, string[] bcc, string[] cc, string content)
        {
            throw new NotImplementedException();
        }
    }
}
