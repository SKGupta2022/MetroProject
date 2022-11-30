using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Framework
{
    public interface IAppSettings
    {
        string DbConnection { get; }
    }
}
