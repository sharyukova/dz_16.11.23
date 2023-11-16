using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov_9
{
    public interface ICipher
    {
        string Encode(string str);
        string Decode (string str);
    }
   
}
