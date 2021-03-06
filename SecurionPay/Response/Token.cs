using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SecurionPay.Converters;
using System;
using System.Collections.Generic;
namespace SecurionPay.Response
{
    public class Token
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("first6")]
        public String First6 { get; set; }

        [JsonProperty("last4")]
        public String Last4 { get; set; }

        [JsonProperty("expMonth")]
        public String ExpMonth { get; set; }

        [JsonProperty("expYear")]
        public String ExpYear { get; set; }

        [JsonProperty("cardholderName")]
        public String CardholderName { get; set; }

        [JsonProperty("used")]
        public Boolean Used { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("addressLine1")]
        public String AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public String AddressLine2 { get; set; }

        [JsonProperty("addressCity")]
        public String AddressCity { get; set; }

        [JsonProperty("AddressState")]
        public String AddressState { get; set; }

        [JsonProperty("addressZip")]
        public String AddressZip { get; set; }

        [JsonProperty("addressCountry")]
        public String AddressCountry { get; set; }

        [JsonProperty("fraudCheckData")]
        public FraudCheckData FraudCheckData { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> Other;

        [JsonProperty("fingerprint")]
        public String Fingerprint { get; set; }

    }
}