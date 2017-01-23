using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PrettyHair.Interfaces
{
    interface IKeyGenerator
    {
        string NextKey();
    }
}
