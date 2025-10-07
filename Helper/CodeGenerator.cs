using System;
using System.Linq;

namespace POETWeb.Helpers
{
    public static class CodeGenerator
    {
        private static Random _rng = new Random();

        public static string GenerateAccountCode()
        {
            // Ví dụ: AB12CD34
            string letters = new string(Enumerable.Range(0, 4)
                .Select(_ => (char)('A' + _rng.Next(26))).ToArray());
            string digits = _rng.Next(0, 10000).ToString("D4");
            return letters + digits;
        }
    }
}
