using System.Threading.Tasks;

namespace MovieTicketing.Core
{
    public interface ISMSTemplateSender
    {
        /// <summary>
        /// Sends an sms with the given details using the General template
        /// </summary>
        /// <param name="details">The sms message details. Note the Content property is ignored and replaced with the template</param>
        /// <returns></returns>
        Task<SendSMSResponse> SendGeneralSMSAsync(SendSMSDetails details, string firstName, string lastName, string token);
    }
}
