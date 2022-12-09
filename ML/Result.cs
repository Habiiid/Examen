using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {
        public Boolean Correct { get; set; }
        public string Message { get; set; }
        public Exception ex { get; set; }
        public Object Object { get; set; }
        public List<object> Objetcs { get; set; }


    }
}
