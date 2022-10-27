using System.Threading.Tasks;

namespace MovieTicketing.Core
{
    /// <summary>
    /// A service that handles sending emails on behalf of the caller
    /// </summary>

    public interface ISMSSender
    {
        /// <summary>
        /// Sends an sms message with the given information
        /// </summary>
        /// <param name="details">The details about the sms to send</param>
        /// <returns></returns>
        Task<SendSMSResponse> SendSMSAsync(SendSMSDetails details);
    }
}
