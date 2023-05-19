using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration
{
    [DisplayName("DatGrrid Column")]
    [ToolboxItem(true)]
    [DesignTimeVisible(false)]
    [ApiCategory("Lists & Grids/DataGridView")]
    //[ToolboxItemFilter("Wisej.Web.DataGridColumn")]
    //[Designer("Wisej.Design.DataGridViewColumnDesigner, Wisej.Framework.Design, Version=3.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
    public class dxColumn
    {
        //Accepted Values: undefined | 'center' | 'left' | 'right'
        public string alignment { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowEditing { get; set; } = true;

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowExporting { get; set; } = true;

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowFiltering { get; set; } = true;

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowFixing { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowGrouping { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowHeaderFiltering { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowHiding { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowReordering { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowResizing { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowSearch { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool allowSorting { get; set; }

        //[DefaultValue(true)]
        [Category("Allow Customize")]
        public bool autoExpandGroup { get; set; }

        public string calculateCellValue { get; set; } // string function name
        public string caption { get; set; } // null
        public dxColumn[] columns { get; set; }
        public string cssClass { get; set; }
        public string dataField { get; set; }
        public string dataType { get; set; }
        public object editorOptions { get; set; }
        public bool encodeHtml { get; set; }

        [DefaultValue("false")]
        public string falseText { get; set; }
        public string[] filterOperations { get; set; }
        public string filterType { get; set; }
        public object filterValue { get; set; }
        public object[] filterValues { get; set; }

        public bool @fixed { get; set; }
        public bool fixedPosition { get; set; }

        [DefaultValue("")]
        public string format { get; set; }
        public object formItem { get; set; }
        public int? groupIndex { get; set; }

        public dxColumn()
        {
            //allowEditing = true;
            //allowExporting = true;
            //allowFiltering = true;
            //allowFixing = true;
            //allowGrouping = true;
            //allowHeaderFiltering = true;
            //allowHiding = true;
            //allowReordering = true;
            //allowResizing = true;
            //allowSearch = true;
            //allowSorting = true;
            //autoExpandGroup = true;
            //encodeHtml = true;
            //falseText = "false";
        }
    }
}
