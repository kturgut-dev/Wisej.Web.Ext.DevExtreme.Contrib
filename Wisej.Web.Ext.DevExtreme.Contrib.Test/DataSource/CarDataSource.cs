using System.Collections.Generic;
using Wisej.Web.Ext.DevExtreme.Contrib.Test.Model;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Test.DataSource
{
    public static class CarDataSource
    {
        public static List<Car> LoadDataSource(int count = 250)
        {
            List<Car> ds = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                ds.Add(new Car()
                {
                    Name = "Car " + i.ToString(),
                    Model = "Model " + i.ToString(),
                    Color = "Color " + i.ToString(),
                    Year = 2000 + i
                });
            }

            return ds;
        }
    }
}
