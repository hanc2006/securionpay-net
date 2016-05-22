﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SecurionPay.Converters;
using SecurionPay.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurionPay.Request.CrossSaleOffer
{
    public class CrossSaleOfferUpdateRequest
    {
        [JsonIgnore]
        public string CrossSaleOfferId { get; set; }

        [JsonProperty("charge")]
        public CrossSaleOfferRequestCharge Charge { get; set; }

        [JsonProperty("subscription")]
        public CrossSaleOfferRequestSubscription Subscription { get; set; }

        [JsonProperty("template")]
        [JsonConverter(typeof(SafeEnumConverter))]
        public CrossSaleOfferTemplate Template { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageData")]
        public string ImageData { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyLocation")]
        public string CompanyLocation { get; set; }

        [JsonProperty("termsAndConditionsUrl")]
        public string TermsAndConditionsUrl { get; set; }

        [JsonProperty("visibleForAllPartners")]
        public bool VisibleForAllPartners { get; set; }

        [JsonProperty("visibleForPartnerIds")]
        public List<string> VisibleForPartnerIds { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> Other;
    }
}
