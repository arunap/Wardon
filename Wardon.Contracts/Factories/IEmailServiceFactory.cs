using Wardon.Support;

namespace Wardon.Contracts.Factories
{
    /// <summary>
    /// Email Service factory to resolve the email service instance in the run time
    /// </summary>
    public interface IEmailServiceFactory
    {
        /// <summary>
        /// Resolving the email service in the run time to give the flexibility to resolve the email sender type
        /// based on system settings
        /// </summary>
        /// <param name="emailSenderType">Accepts Gmail/SendGrid..</param>
        /// <returns>Instance of a EmailSender</returns>
        IEmailService ResolveEmailService(EmailSenderType emailSenderType = EmailSenderType.Gmail);
    }
}
