﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models;

namespace Stock_Management_Dev
{
    public partial class ProductsForm : Form
    {
        AppDBContext context;
        
        public ProductsForm()
        {
            InitializeComponent();

            AddProductBtn.BackColor = Color.MediumSeaGreen;
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.ForeColor = Color.White;
            


        }

        private void LoadProducts()
        {
            var productData = context.Products.Include(p => p.Supplier).Select(p => new
            {
                p.ProductID,
                p.Name,
                p.Description,
                p.QuantityInStock,
                p.UnitPrice,
                p.SupplierID,
                Supplier = p.Supplier.Name,
            }).ToList();

            ProductsTable.DataSource = null; // clear binding first (good practice)
            ProductsTable.DataSource = productData;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

            context = new AppDBContext();
            LoadProducts();
            #region datagrid delete buttons
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Text = "حذف";
            deleteButton.Name = "حذف المنتج";
            deleteButton.UseColumnTextForButtonValue = true;
            ProductsTable.Columns.Add(deleteButton);
            #endregion

            #region datagrid update buttons
            DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
            updateButton.Text = "تعديل";
            updateButton.Name = "تعديل بيانات المنتج";
            updateButton.UseColumnTextForButtonValue = true;
            ProductsTable.Columns.Add(updateButton);
            #endregion
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts();
        }


        private void ProductsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Prevent header or invalid row clicks
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;


            // For delete buttons
            if (ProductsTable.Columns[e.ColumnIndex].Name == "حذف المنتج")
            {
                int selectedID = Convert.ToInt32(ProductsTable.Rows[e.RowIndex].Cells[0].Value);
                var warningMessage = MessageBox.Show("هل تريد ازالة هذا المنتج ؟", "Confirm Delete", MessageBoxButtons.YesNo);
                if (warningMessage == DialogResult.Yes)
                {
                    var product = context.Products.Find(selectedID);
                    context.Products.Remove(product);
                    context.SaveChanges();
                    LoadProducts();
                }
            }

            //For update buttons
            if (ProductsTable.Columns[e.ColumnIndex].Name == "تعديل بيانات المنتج")
            {
                int IDForUpdate = Convert.ToInt32(ProductsTable.Rows[e.RowIndex].Cells[0].Value);

                var ProductToUpdate = context.Products.Find(IDForUpdate);
                UpdateProductForm updateProductForm = new UpdateProductForm() { 
                    ProductID = ProductToUpdate.ProductID,
                    ProductName= ProductToUpdate.Name,
                    ProductQuantity = ProductToUpdate.QuantityInStock,
                    ProductDescription= ProductToUpdate.Description,
                    ProductPrice = ProductToUpdate.UnitPrice,
                    SupplierID = ProductToUpdate.SupplierID,
                };
                updateProductForm.ShowDialog();
                LoadProducts();
            }

        }
    }
}
