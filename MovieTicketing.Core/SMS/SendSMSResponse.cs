using System.Collections.Generic;

namespace MovieTicketing.Core
{
    /// <summary>
    /// A response from a SendEmail call for any <see cref="ISMSSender"/> implementation
    /// </summary>
    public class SendSMSResponse
    {

        /// <summary>
        /// True if the message was sent successfully
        /// </summary>
        public bool Successful => !(Errors?.Count > 0);

        /// <summary>
        /// The error message if the sending failed
        /// </summary>
        public List<string> Errors { get; set; }
    }
}
