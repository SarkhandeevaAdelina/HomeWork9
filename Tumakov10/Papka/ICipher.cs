using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10.Papka
{
    public interface ICipher
    {
        void encode(string text);
        void decode(string detext);
    }
}
