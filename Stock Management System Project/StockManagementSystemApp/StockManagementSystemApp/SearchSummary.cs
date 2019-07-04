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
    public partial class SearchSummary : Form
    {
        Company company = new Company();
        Category category = new Category();
        Item item = new Item();
        StockOUT stockOUT = new StockOUT();
        SearchManager _searchManager = new SearchManager();
        int com;


        List<string> categories = new List<string>();
        List<string> companies = new List<string>();
        List<string> items = new List<string>();
        public SearchSummary()
        {
            InitializeComponent();
            companies = _searchManager.LoadCompany();
            foreach (string comp in companies)
            {
                companyComboBox.Items.Add(comp);
            }

            categories = _searchManager.LoadCategory();
            foreach (string catg in categories)
            {
                categoryComboBox.Items.Add(catg);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(companyComboBox.Text) & String.IsNullOrEmpty(categoryComboBox.Text))
            {
                MessageBox.Show("U r empty");
            }

            if (!String.IsNullOrEmpty(companyComboBox.Text) & !String.IsNullOrEmpty(categoryComboBox.Text))
            {
                company.Name = companyComboBox.Text;
                category.Name = categoryComboBox.Text;
                if (_searchManager.DisplayGrid(company, category).Rows.Count > 0)
                {
                    

                    searchDataGridView.DataSource = _searchManager.DisplayGrid(company, category);
                }
                else
                {
                    MessageBox.Show("Did not find any matching item");
                }
            }

            if(String.IsNullOrEmpty(companyComboBox.Text) & !String.IsNullOrEmpty(categoryComboBox.Text))
            {
                // MessageBox.Show("Company Empty");
                category.Name = categoryComboBox.Text;
                searchDataGridView.DataSource = _searchManager.DisplayCategoryGrid(category);
            }

            if (!String.IsNullOrEmpty(companyComboBox.Text) & String.IsNullOrEmpty(categoryComboBox.Text))
            {
                company.Name = companyComboBox.Text;
                //MessageBox.Show("Category Empty");
                searchDataGridView.DataSource = _searchManager.DisplayCompanyGrid(company);
            }
        }

        private void searchDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            searchDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
