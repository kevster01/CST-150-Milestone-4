using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cst150Project
{
    public partial class members : Form
    {
        List<String> myMembers = new List<String>();
        BindingSource bs = new BindingSource();
        
        public members()
        {
            InitializeComponent();
            bs.DataSource= myMembers;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            myMembers.Add(members_txt.Text);
            memberDispay.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myMembers.Count + " person(s) in the list";




          //  memberDispay.Items.Add(members_txt.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            memberDispay.DataSource = bs;
            myMembers.Add("Kevin");
            myMembers.Add("Adam");
            myMembers.Add("Rachel");
            myMembers.Add("Justin");
            myMembers.Add("Xavier");
            bs.ResetBindings(false);
            label1.Text = "There are " + myMembers.Count + " person(s) in the list";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            myMembers.Sort();
            bs.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myMembers.Sort();
            myMembers.Reverse();
            bs.ResetBindings(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPortal().Show();
        }
    }
}
