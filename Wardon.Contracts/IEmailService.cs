using System;

namespace Wardon.Contracts
{
    public interface IEmailService
    {
        bool Send(string from, string[] to, string[] bcc, string[] cc, string content);
    }
}
