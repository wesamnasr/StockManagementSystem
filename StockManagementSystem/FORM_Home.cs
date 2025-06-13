using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class FORM_Home : Form
    {
        public FORM_Home()
        {
            InitializeComponent();

            #region Initializing
            AppDBContext context = new AppDBContext();
            TileControl tileControl = new TileControl();
            tileControl.Size = new Size(1000, 1000);
            tileControl.Location = new Point(10, 10);
            TileGroup group = new TileGroup();
            #endregion

            #region generating data
            var tileData = new (string Title, int Count)[]
           {
                ("العملاء", context.Customers.Count()),
                ("فواتير العملاء", context.CustomerBills.Count()),
                ("الموردين", context.Suppliers.Count()),
                ("المنتجات", context.Products.Count()),
                ("فواتير الموردين", context.SupplierBills.Count())
           };
            #endregion


            foreach (var (title, count) in tileData)
            {
                TileItem item = new TileItem();

                item.AppearanceItem.Normal.BackColor = Color.DarkGray;
                item.AppearanceItem.Normal.ForeColor = Color.White;

                item.AppearanceItem.Normal.BorderColor = Color.Black;
                item.AppearanceItem.Normal.Options.UseBorderColor = true;

                item.ItemSize = TileItemSize.Large;

                item.Elements.Clear();
                
                item.Elements.Add(new TileItemElement()
                {
                    Text = $"{title}\n{count}",
                    TextAlignment = TileItemContentAlignment.MiddleCenter,
                    ImageAlignment = TileItemContentAlignment.MiddleCenter,
                    Appearance = {
                        Normal = {
                            Font = new Font("LBC", 20, FontStyle.Bold),
                            TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center, VAlignment = DevExpress.Utils.VertAlignment.Center },
                        
                        }
                    }
                });
                group.Items.Add(item);
            }
            tileControl.Groups.Add(group);

            pn_stats.Controls.Add(tileControl);

            this.Controls.Add(pn_stats);


            tileControl.Dock = DockStyle.Fill;
            pn_stats.Dock = DockStyle.Fill;

        }


    }
}
