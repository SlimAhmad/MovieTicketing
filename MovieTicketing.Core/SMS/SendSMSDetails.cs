namespace MovieTicketing.Core
{
    /// <summary>
    /// The details about the message to send
    /// </summary>
    public class SendSMSDetails
    {



        /// <summary>
        /// The number of the sender
        /// </summary>
        public string FromNumber { get; set; }



        /// <summary>
        /// The number of the receiver
        /// </summary>
        public string ToNumber { get; set; }



        /// <summary>
        /// The message body content
        /// </summary>
        public string Content { get; set; }
    }
}
