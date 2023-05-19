using Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration.Base;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration
{
    public class dxColumnChooser : BaseConfiguration
    {
        public bool allowSearch { get; set; }
        public string emptyPanelText { get; set; }
        public bool enabled { get; set; }
        public string height { get; set; }
        public string mode { get; set; }
        public string sortOrder { get; set; } // asc, desc
        public string title { get; set; }
        public int width { get; set; }

        public dxColumnChooser() : base()
        {
            allowSearch = false;
            emptyPanelText = "Drag a column here to hide it";
            enabled = false;
            height = "auto";
            mode = "dragAndDrop";
            title = "Column Chooser";
            width = 250;
        }

        public dxColumnChooser(bool allowSearch, string emptyPanelText, bool enabled, string height, string mode, string sortOrder, string title, int width) : this()
        {
            this.allowSearch = allowSearch;
            this.emptyPanelText = emptyPanelText;
            this.enabled = enabled;
            this.height = height;
            this.mode = mode;
            this.sortOrder = sortOrder;
            this.title = title;
            this.width = width;
        }
    }
}
