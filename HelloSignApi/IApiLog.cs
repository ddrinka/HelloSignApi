﻿using HelloSignApi.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloSignApi
{
    /// <summary>
    /// Provides opportunity to catch various things during API calls.
    /// </summary>
    public interface IApiLog
    {
        /// <summary>
        /// Called when the API response content has been read and before
        /// deserialization occurs. This does not apply to direct file downloads.
        /// </summary>
        /// <param name="content"></param>
        /// <typeparam name="TResp">The expected response type.</typeparam>
        void ResponseRead<TResp>(string content) where TResp : ApiResponse;
    }
}
