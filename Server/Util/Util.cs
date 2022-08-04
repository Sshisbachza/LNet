using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LNetServer.Util
{
    public class Util
    {
        private static string allowedChars = "1234567890";
        private static char SecretPrefix = '0';
        private static Random random = new Random();

        public static char GetChar()
        {
            return allowedChars[random.Next(0, allowedChars.Length)];
        }

        public static string GetID(bool hidden)
        {
            char[] id = new char[]
            {
                hidden ? SecretPrefix : GetChar(),
                GetChar(),
                GetChar(),
                GetChar(),
                GetChar(),
                GetChar(),
                GetChar(),
                GetChar(),
                GetChar(),
                GetChar()
            };

            return new string(id).ToUpperInvariant();
        }
    }
}
