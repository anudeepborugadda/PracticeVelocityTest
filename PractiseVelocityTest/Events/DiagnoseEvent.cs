using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity
{
    class DiagnoseEvent : IEvent

    {
        public string GenerateMultiples()
        {
         return String.Join(
        Environment.NewLine,
        Enumerable.Range(1, (100 - 1) + 1)
          .Select(n => n % 14 == 0 ? "Diagnose Patient"
                     : n % 2 == 0 ? "Diagnose"
                     : n % 7 == 0 ? "Patient"
                     : n.ToString()));
        }
      }
    }
