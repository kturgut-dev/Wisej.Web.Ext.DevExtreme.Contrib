using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Core;
using Wisej.Design;
using Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.Configuration;
using static System.Windows.Forms.AxHost;

namespace Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid
{
    [Serializable]
    public partial class dxDataGridContrib : DevExtreme.dxDataGrid
    {
        #region Configurations

        /// <summary>
        /// https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#accessKey
        /// Type: String
        /// Default Value: undefined
        /// The value of this property will be passed to the accesskey attribute of the HTML element that underlies the UI component.
        /// </summary>
        public string AccessKey
        {
            //get { return this.Options.accessKey; }
            //set { this.Options.accessKey = value; } 
            get { return (string)GetOptionProperty("accessKey"); }
            set { SetOptionProperty("accessKey", value); }
        }

        /// <summary>
        /// https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#activeStateEnabled
        /// Type: Boolean
        /// Default Value: false
        /// The UI component switches to the active state when users press down the primary mouse button. When this property is set to true, 
        /// the CSS rules for the active state apply. You can change these rules to customize the component.
        /// Use this property when you display the component on a platform whose guidelines include the active state change for UI components
        /// </summary>
        [DesignerActionList]
        [MergableProperty(false)]
        [WisejSerializerOptions(WisejSerializerOptions.None)]
        public bool ActiveStateEnabled
        {
            get { return this.Options.activeStateEnabled; }
            set { this.Options.activeStateEnabled = value; }
        }

        //https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#allowColumnReordering
        //Type: Boolean
        //Default Value: false
        public bool AllowColumnReordering
        {
            get { return this.Options.allowColumnReordering; }
            set { this.Options.allowColumnReordering = value; }
        }

        //https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#allowColumnResizing
        //Type: Boolean
        //Default Value: false

        public bool AllowColumnResizing
        {
            get { return this.Options.allowColumnResizing; }
            set { this.Options.allowColumnResizing = value; }
        }

        /// <summary>
        /// https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#autoNavigateToFocusedRow
        /// Type: Boolean
        /// Default Value: true
        /// Note: You must specify the component's height to ensure that the autoNavigateToFocusedRow property works properly.
        /// </summary>
        public bool AutoNavigateToFocusedRow
        {
            get { return this.Options.autoNavigateToFocusedRow; }
            set { this.Options.autoNavigateToFocusedRow = value; }
        }

        /// <summary>
        /// https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#cacheEnabled
        /// Type: Boolean
        /// Default Value: true
        /// When this property is set to true, data loaded once is saved in cache. 
        /// Then, the UI component takes data from this cache when performing such operations as sorting, grouping, paging, etc. 
        /// Caching is helpful when the data source takes significant time to load. But, consider disabling it for frequently changing data sources.
        ///To update data in cache, call the refresh() method of the UI component or the reload() method of the DataSource:
        /// </summary>
        public bool CacheEnabled
        {
            get { return this.Options.cacheEnabled; }
            set { this.Options.cacheEnabled = value; }
        }

        /// <summary>
        /// https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#cellHintEnabled
        /// Type: Boolean
        /// Default Value: true
        /// Enables a hint that appears when a user hovers the mouse pointer over a cell with truncated content.
        /// </summary>
        public bool CellHintEnabled
        {
            get { return this.Options.cellHintEnabled; }
            set { this.Options.cellHintEnabled = value; }
        }

        /// <summary>
        /// https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/#columnAutoWidth
        /// Type: Boolean
        /// Default Value: false
        /// Specifies whether columns should adjust their widths to the content.
        /// </summary>
        public bool ColumnAutoWidth
        {
            get { return this.Options.columnAutoWidth; }
            set { this.Options.columnAutoWidth = value; }
        }

        public dxColumnChooser ColumnChooser
        {
            get { return this.Options.columnChooser; }
            set { this.Options.columnChooser = value; }
        }

        #endregion

        private void SetOptionProperty(string name, object val)
        {
            this.Options[name] = val;
        }

        private object GetOptionProperty(string name)
        {
            return this.Options[name];
        }

        public string KeyExpr
        {
            get { return this.Options.keyExpr; }
            set { this.Options.keyExpr = value; }
        }

        public object DataSource
        {
            get { return this.Options.dataSource; }
            set { this.Options.dataSource = value; }
        }

        public IEnumerable<object> Columns
        {
            get { return this.Options.columns; }
            set { this.Options.columns = value; }
        }

        public dxGroupPanel GroupPanel
        {
            get { return this.Options.groupPanel; }
            set { this.Options.groupPanel = value; }
        }

        public dxDataGridContrib()
        {
            InitializeComponent();
        }

        private void dxDataGridContrib_Load(object sender, EventArgs e)
        {

        }
    }
}

