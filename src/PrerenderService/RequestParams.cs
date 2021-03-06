﻿using System;

namespace PrerenderService
{
    public class RequestParams
    {
        /// <summary>
        ///     Client request URI
        /// </summary>
        public Uri RequestUri { get; set; }


        /// <summary>
        ///     User agent of the client
        /// </summary>
        public string UserAgent { get; set; }
    }
}