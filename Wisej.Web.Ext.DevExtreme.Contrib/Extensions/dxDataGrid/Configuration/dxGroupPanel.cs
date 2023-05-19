using Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration.Base;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration
{
    public class dxGroupPanel : BaseConfiguration
    {
        public bool allowColumnDragging { get; set; }
        public string emptyPanelText { get; set; }

        public dxGroupPanel() : base()
        {
            allowColumnDragging = true;
            emptyPanelText = "Bu sütuna göre gruplamak için bir sütun başlığını buraya sürükleyin";
            visible = false;
        }

        public dxGroupPanel(bool _allowColumnDragging, string _emptyPanelText, bool _visible) : this()
        {
            allowColumnDragging = _allowColumnDragging;
            emptyPanelText = _emptyPanelText;
            visible = _visible;
        }

        internal string ToJSON()
        {
            return "{ " +
                "allowColumnDragging: " + allowColumnDragging.ToString().ToLower() + ", " +
                "emptyPanelText: '" + emptyPanelText + "', " +
                "visible: " + visible.ToString().ToLower() +
                " }";
        }
    }
}
