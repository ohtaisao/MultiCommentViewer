﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeLiveSitePlugin.Test2
{
    [Serializable]
    public class FatalException : Exception
    {
        public FatalException() { }
        public FatalException(string message, Exception innterException) : base(message, innterException) { }
    }
    [Serializable]
    public class ReloadException : Exception
    {
        public ReloadException() { }
    }
    [Serializable]
    public class ContinuationContentsNullException : Exception
    {
        public ContinuationContentsNullException() { }
    }

    [Serializable]
    public class ParseException : Exception
    {
        public string Raw { get; }
        public ParseException() { }
        public ParseException(string raw)
        {
            Raw = raw;
        }
        public ParseException(string raw, Exception inner) : base("", inner) { }
    }

    [Serializable]
    public class ContinuationNotExistsException : Exception
    {
        public ContinuationNotExistsException() { }
    }

    [Serializable]
    public class ChatUnavailableException : Exception
    {
        public ChatUnavailableException() { }
    }
}
