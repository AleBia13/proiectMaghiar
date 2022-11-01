using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using NuGet.Protocol.Core.Types;
using Xunit;
using Xunit.Sdk;

namespace proiectMaghiar.Models
{
    public class Problem
    {

       
        public Problem()
        {

        }
        public Problem(string inputString)
        {
            this.inputString = inputString;
        }

        [Required]
        public string inputString { get; set; }


        //This functions finds if the string contains the character c
        
        public int lengthOfLongestSubstring(string s)
        {
            int i;
            string current=""; //local longest substring
            i = 0;
            int len = 0;
            int len_max;
            int ant = 0;
            bool ok = false;
            len_max = 0;

            while (i < s.Length)
            {

                if (current.Contains(s[i])==false)
                {
                    if (ok == true)  // checks if this is the first element of the current substring
                    {
                        ant = i;
                        ok = false;
                    }
                    current += s[i];
                    len++;
                    i++;
                }
                else
                {
                    if (current.Length > len_max)
                        len_max = current.Length;
                    i = ant + 1;
                    len = 1;
                    current = "";
                    ok = true;
                }

            } 
            // in case the longest substring is at the end
            if (current.Length > len_max)
                len_max = current.Length;
            return len_max;
        }

    }
}
