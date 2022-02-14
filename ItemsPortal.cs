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

namespace Cst150Project
{
    public partial class ItemsPortal : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevre\OneDrive\Documents\GymAppDB.V1.mdf;Integrated Security=True;Connect Timeout=30");



        public ItemsPortal()
        {
            InitializeComponent();
        }
        private void ItemsPortal_Load(object sender, EventArgs e)
        {
            fillCombo();
            populate();
            //SearchItem();
           
        }


        private void SearchItem()
        {

            
                
        }




        private void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter ItemSDA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ItemSDA);
            var ds = new DataSet();
            ItemSDA.Fill(ds);
            ItemDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ItemsExit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemsPortalLogout_btn_Click(object sender, EventArgs e)
        {
            new LogInForm().Show(); 
            this.Hide();
        }

        private void ItemsClear_lbl_Click(object sender, EventArgs e)
        {
            ItemId_txt.Clear();
            ItemName_txt.Clear();
            ItemQuantity_txt.Clear();
            ItemPrice_txt.Clear();
            ItemId_txt.Focus();
        }

        //Returns to admin window
        private void Back2Admin_btn_Click(object sender, EventArgs e)
        {
            new AdminPortal().Show();
            this.Hide();
        }


       // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevre\OneDrive\Documents\GymAppDB.V1.mdf;Integrated Security=True;Connect Timeout=30");
        //Adding information onto Data
        private void AddItem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into ItemTbl values(" + ItemId_txt.Text + ",'" + ItemName_txt.Text + "',"
                                                            + ItemQuantity_txt.Text + "," +ItemPrice_txt.Text+ ",'"+ItemsCategories_cBox.SelectedValue.ToString()+ "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added Succesfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Method for binding Comboxes with Database
        private void fillCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Name from CategoryTbl", Con);
            SqlDataReader rdr; 
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Load(rdr);
            ItemsCategories_cBox.ValueMember = "Name";
            ItemsCategories_cBox.DataSource = dt;
            Con.Close();
        }

        private void Forward2Categories_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Categories().Show();
            this.Hide();
        }

        

        //allows Item infotoreflect in input-panel 
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemId_txt.Text = ItemDGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemName_txt.Text = ItemDGV.SelectedRows[0].Cells[1].Value.ToString();
            ItemQuantity_txt.Text = ItemDGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPrice_txt.Text = ItemDGV.SelectedRows[0].Cells[3].Value.ToString();
            ItemsCategories_cBox.SelectedValue = ItemDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void RemoveItem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemId_txt.Text == "")
                {
                    MessageBox.Show("Select The Item to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ItemTbl where Id=" + ItemId_txt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Succesfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Edit item and reflects on database
        private void EditItem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemId_txt.Text == "" || ItemName_txt.Text == "" || ItemQuantity_txt.Text == "" || ItemPrice_txt.Text =="" )
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update ItemTbl set Name='" + ItemName_txt.Text + "',Quantity= '" + ItemQuantity_txt.Text + "',Price= '"+ItemPrice_txt.Text+ "',Category= '" +ItemsCategories_cBox.SelectedValue.ToString()+  "'where Id=" + ItemId_txt.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            
           Con.Open();
           SqlDataAdapter adapter = new SqlDataAdapter($"select * from ItemTbl where Name like '{search_txt.Text}%'", Con);
           DataTable DataT = new DataTable();
           adapter.Fill(DataT);
           ItemDGV.DataSource = adapter;
           Con.Close();
            populate();

        }







        //string item_category = SearchItems_cBox.Text;
        //try
        //{
        //    SqlCommand comm = new SqlCommand("SELECT FROM *[ ItemTbl] WHERE (name = '"+item_category+"')");
        //    SqlDataReader searchReader;
        //    searchReader = comm.ExecuteReader();
        //    while (searchReader.Read())
        //    {
        //        ItemsCategories_cBox.Text =  searchReader.GetValue(0).ToString();
        //    }
        //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show("Search Error" + ex);
        //}
        //finally
        //{
        //    Con.Close();

    }
}
