namespace Wardon.Contracts
{
    public interface IEmailService
    {
        /// <summary>
        /// Send email based on resolved email sender type
        /// </summary>
        /// <param name="from">Email serder name</param>
        /// <param name="to">The direct receipient list</param>
        /// <param name="bcc">The blind copy receipient list</param>
        /// <param name="cc">The copy receipient list</param>
        /// <param name="content">The email content</param>
        /// <returns></returns>
        bool Send(string from, string[] to, string[] bcc, string[] cc, string content);
    }
}
