using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStep255
{
    public class Employee<T> : Person
    {
        public List<T> Things { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

    }
}
