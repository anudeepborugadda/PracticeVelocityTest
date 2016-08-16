using System;
using System.Linq;

namespace PracticeVelocity
{
    public class RegisterEvent : IEvent

    {
        public string GenerateMultiples()
        {
            return String.Join(
           Environment.NewLine,
           Enumerable.Range(1, (100 - 1) + 1)
             .Select(n => (n % 3 == 0 && n % 5 == 0) ? "Register Patient"    /// Or we can directly use  n % 15 == 0
                        : n % 3 == 0 ? "Register"
                        : n % 5 == 0 ? "Patient"
                        : n.ToString()));
        }
       
    }
}
