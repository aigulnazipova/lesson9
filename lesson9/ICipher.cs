using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal interface ICipher
    {
        string Encode(string s);
        string Decode(string s);
    }
}
