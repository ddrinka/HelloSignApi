﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloSignApi.Requests
{
    /// <summary>
    /// Field object for new signature requests.
    /// </summary>
    public class RequestFormField : FormField
    {
        /// <summary>
        /// page in the document where the field should be placed (requires documents be PDF files).
        /// When the page number parameter is supplied, the API will use the new coordinate system. 
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// Signer index identified by the offset 
        /// in the signers parameter, indicating which signer 
        /// should fill out the field.
        /// </summary>
        public int Signer { get; set; }

        /// <summary>
        /// Optional validation for text type fields.
        /// See <see cref="DataValidationTypes"/>.
        /// </summary>
        [JsonProperty("validation_type", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationType { get; set; }
    }


}
