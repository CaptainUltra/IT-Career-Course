﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Common
{
    public class CoreValidator
    {
        public static void ThrowIfNull(object obj, string name)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void ThrowIfNullOrEmpty(string text, string name)
        {
            if(string.IsNullOrEmpty(text))
            {
                throw new ArgumentException($"{name} cannot be null or empty.", name);
            }
        }
    }
}
