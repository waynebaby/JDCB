using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OAuthLib
{
    /// <summary>
    /// Represents the OAuth requst token.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("Token:{Token},Secret:{Secret}")]
    public class OAuthRequestToken
    {
        /// <summary>
        /// Gets or sets the token field.
        /// </summary>
        [DataMember]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the token secret field.
        /// </summary>
        [DataMember]
        public string Secret { get; set; }
    }

    /// <summary>
    /// Represents the OAuth access token.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("UserID:{UserID}")]
    public class OAuthAccessToken : OAuthRequestToken
    {
        /// <summary>
        /// Gets or sets the user id field.
        /// </summary>
        [DataMember]
        public string UserID { get; set; }
        [DataMember]
        public int ExpiresIn { get; set; }
    }
}
