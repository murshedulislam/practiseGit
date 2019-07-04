using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Models;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp
{
    public partial class CategorySetup : Form
    {
        Category category = new Category();
        
        StockManager _stockManager = new StockManager();
        int rowIndex;
        int isExecuted;
        public CategorySetup()
        {
            
            InitializeComponent();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveButton.Text =="Save")
            {
                category.Name = categoryNameTextBox.Text;
                if (_stockManager.Duplicate(category) > 0)
                {
                    MessageBox.Show("This Category name already exists");
                    return;
                }
               isExecuted=_stockManager.InsertCategory(category);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
                categoryDisplayGridView.DataSource= _stockManager.DisplayGrid();
            }

            if (SaveButton.Text == "Update")
            {
                category.Name = categoryNameTextBox.Text;
                if (_stockManager.Duplicate(category) > 0)
                {
                    MessageBox.Show("This Category name already exists");
                    return;
                }
               isExecuted=_stockManager.UpdateCategory(category, rowIndex);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
                categoryDisplayGridView.DataSource = _stockManager.DisplayGrid();
                SaveButton.Text = "Save";
            }



        }

       

        private void ShowButton_Click(object sender, EventArgs e)
        {
            categoryDisplayGridView.DataSource= _stockManager.DisplayGrid();
        }

        private void categoryDisplayGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //districtComboBox.Text = "";
                rowIndex = e.RowIndex + 1;
                DataGridViewRow selectedRow = categoryDisplayGridView.Rows[e.RowIndex];

                categoryNameTextBox.Text = selectedRow.Cells[1].Value.ToString();


                SaveButton.Text = "Update";


            }
        }

        
    }
}
