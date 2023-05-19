namespace Wisej.Web.Ext.DevExtreme.Contrib.Test
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dxDataGridContrib1 = new Wisej.Web.Ext.DevExtreme.Contrib.Extensions.dxDataGrid.dxDataGridContrib();
            this.SuspendLayout();
            // 
            // dxDataGridContrib1
            // 
            this.dxDataGridContrib1.AccessKey = "test";
            this.dxDataGridContrib1.Dock = Wisej.Web.DockStyle.Fill;
            this.dxDataGridContrib1.Name = "dxDataGridContrib1";
            this.dxDataGridContrib1.Size = new System.Drawing.Size(991, 567);
            this.dxDataGridContrib1.TabIndex = 0;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 568);
            this.Controls.Add(this.dxDataGridContrib1);
            this.Name = "Window1";
            this.Text = "Window1";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Extensions.dxDataGrid.dxDataGridContrib dxDataGridContrib1;
    }
}

