﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubXamarin.Core.Utility
{
    /// <summary>
    /// A Utility which converts strings seperated with commas to a string array
    /// </summary>
    public class StringToStringArrayConverter
    {
        public static string[] Convert(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            var stringArray = new List<string>();
            str = str.Trim();
            var i = 0;
            while (str.Contains(","))
            {
                var index = str.IndexOf(',');
                stringArray.Add(str.Substring(0, index));
                str = str.Remove(0, index+1);
                str = str.Trim();
                i++;
            }
            if (str.Length > 0)
            {
                stringArray.Add(str.Trim());
            }
            return stringArray.ToArray();
        }
    }
}