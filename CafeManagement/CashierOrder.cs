using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace CafeManagementSystem
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MV98GJ7M;Initial Catalog=Cafe;Integrated Security=True;Encrypt=False");

        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvailableProducts();
        }

        public void displayAllAvailableProducts()
        {
            CashierOrderFormProductData allprds = new CashierOrderFormProductData();

            List<CashierOrderFormProductData> listdat = allprds.availProductsData();

            cashierOrderForm_menuTable.DataSource = listdat;
        }

        private void cashierOrderForm_addbtn_Click(object sender, EventArgs e)
        {
        }

        private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrderForm_productID.Items.Clear();

            string selectedValue = cashierOrderForm_type.SelectedItem as string;

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    if (selectedValue != null)
                    {
                        try
                        {
                            string selectData = $"SELECT * FROM [Cafe].[dbo].[products] WHERE [prod_type] = '{selectedValue}'";
                            using (SqlCommand cmd = new SqlCommand(selectData, con))
                            {
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string value = reader["prod_id"].ToString();
                                        cashierOrderForm_productID.Items.Add(value);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.Message);
                        }
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show("Failed Connection" + ex.Message);
                }  
                finally
                {
                    con.Close();
                }
            }
        }

        private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
