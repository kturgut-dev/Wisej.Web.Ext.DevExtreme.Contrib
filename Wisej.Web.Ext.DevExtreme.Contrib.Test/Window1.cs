
using System;
using Wisej.Web;
using Wisej.Web.Ext.DevExtreme.Contrib.Test.DataSource;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Test
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            dxDataGridContrib1.DataSource = CarDataSource.LoadDataSource();
        }
    }
}
