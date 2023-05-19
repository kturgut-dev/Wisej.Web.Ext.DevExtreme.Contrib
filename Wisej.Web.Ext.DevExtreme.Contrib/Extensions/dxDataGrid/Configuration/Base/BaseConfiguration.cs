using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration.Base
{
    public abstract class BaseConfiguration : IConfiguration
    {
        public object visible { get; set; }

        public BaseConfiguration()
        {
            visible = true;
        }

        public BaseConfiguration(bool _visible) : base()
        {
            visible = _visible;
        }
    }
}
