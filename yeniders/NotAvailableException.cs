using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yeniders
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException() : base("Otaq rezervasiya ucun uygun deyil.")
        {

        }
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}