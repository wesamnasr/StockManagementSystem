﻿namespace StockManagementSystem
{
    partial class BillsClientView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pn_cont = new System.Windows.Forms.Panel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ColCustomerBillID = new DevExpress.XtraGrid.Columns.GridColumn();
            ColSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            ColBilldate = new DevExpress.XtraGrid.Columns.GridColumn();
            ColTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ColPaidAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            customerBillBindingSource = new System.Windows.Forms.BindingSource(components);
            pn_cont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBillBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pn_cont
            // 
            pn_cont.Controls.Add(gridControl1);
            pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_cont.Location = new System.Drawing.Point(0, 0);
            pn_cont.Name = "pn_cont";
            pn_cont.Size = new System.Drawing.Size(952, 443);
            pn_cont.TabIndex = 1;
            // 
            // gridControl1
            // 
            gridControl1.DataSource = customerBillBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(952, 443);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.DetailTip.Options.UseFont = true;
            gridView1.Appearance.Empty.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.Empty.Options.UseFont = true;
            gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.EvenRow.Options.UseFont = true;
            gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.FilterPanel.Options.UseFont = true;
            gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.FixedLine.Options.UseFont = true;
            gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.FocusedCell.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.FooterPanel.Options.UseFont = true;
            gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.GroupButton.Options.UseFont = true;
            gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.GroupFooter.Options.UseFont = true;
            gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.GroupRow.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.HorzLine.Options.UseFont = true;
            gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView1.Appearance.NoSearchResults.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.NoSearchResults.Options.UseFont = true;
            gridView1.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.OddRow.Options.UseFont = true;
            gridView1.Appearance.Preview.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.Preview.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.RowSeparator.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.VertLine.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ColCustomerBillID, ColSupplierName, ColBilldate, ColTotalAmount, ColPaidAmount });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.EnableAppearanceEvenRow = true;
            gridView1.OptionsView.EnableAppearanceOddRow = true;
            gridView1.PaintStyleName = "Skin";
            gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(ColCustomerBillID, DevExpress.Data.ColumnSortOrder.Descending) });
            gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // ColCustomerBillID
            // 
            ColCustomerBillID.Caption = "رقم الفاتورة";
            ColCustomerBillID.FieldName = "CustomerBillID";
            ColCustomerBillID.MinWidth = 25;
            ColCustomerBillID.Name = "ColCustomerBillID";
            ColCustomerBillID.OptionsColumn.AllowEdit = false;
            ColCustomerBillID.Visible = true;
            ColCustomerBillID.VisibleIndex = 0;
            ColCustomerBillID.Width = 139;
            // 
            // ColSupplierName
            // 
            ColSupplierName.Caption = "اسم العميل";
            ColSupplierName.FieldName = "Customer.Name";
            ColSupplierName.MinWidth = 25;
            ColSupplierName.Name = "ColSupplierName";
            ColSupplierName.Visible = true;
            ColSupplierName.VisibleIndex = 1;
            ColSupplierName.Width = 164;
            // 
            // ColBilldate
            // 
            ColBilldate.Caption = "تاريخ الفاتورة";
            ColBilldate.FieldName = "BillDate";
            ColBilldate.MinWidth = 25;
            ColBilldate.Name = "ColBilldate";
            ColBilldate.Visible = true;
            ColBilldate.VisibleIndex = 2;
            ColBilldate.Width = 164;
            // 
            // ColTotalAmount
            // 
            ColTotalAmount.Caption = "الإجمالي";
            ColTotalAmount.FieldName = "TotalAmount";
            ColTotalAmount.MinWidth = 25;
            ColTotalAmount.Name = "ColTotalAmount";
            ColTotalAmount.Visible = true;
            ColTotalAmount.VisibleIndex = 3;
            ColTotalAmount.Width = 164;
            // 
            // ColPaidAmount
            // 
            ColPaidAmount.Caption = "عدد العناصر";
            ColPaidAmount.FieldName = "Items.Count";
            ColPaidAmount.MinWidth = 25;
            ColPaidAmount.Name = "ColPaidAmount";
            ColPaidAmount.Visible = true;
            ColPaidAmount.VisibleIndex = 4;
            ColPaidAmount.Width = 171;
            // 
            // customerBillBindingSource
            // 
            customerBillBindingSource.DataSource = typeof(Models.CustomerBill);
            // 
            // BillsClientView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(952, 443);
            Controls.Add(pn_cont);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "BillsClientView";
            Text = "BillsClientView";
            pn_cont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBillBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel pn_cont;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColCustomerBillID;
        private DevExpress.XtraGrid.Columns.GridColumn ColSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn ColBilldate;
        private DevExpress.XtraGrid.Columns.GridColumn ColTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn ColPaidAmount;
        private System.Windows.Forms.BindingSource customerBillBindingSource;
    }
}