using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Shared.Settings.Configurations
{
    public class Configuration
    {
        public string DBProvider { get; set; } //  like SQL DB database
        public string ConnectionString { get; set; }
    }
}
