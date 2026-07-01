
using School_Managment_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myprojeck
{
    public partial class TabsControlForm : Form
    {
        public TabsControlForm()
        {
            InitializeComponent();
        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtFullName.Text)
                    || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhone.Text) ||
                    string.IsNullOrEmpty(nuAge.Value.ToString()))
                    {
                return;
                    }

            ListViewItem Item = new ListViewItem(txtID.Text);

            Item.SubItems.Add(txtFullName.Text);
            Item.SubItems.Add(txtEmail.Text);
            Item.SubItems.Add(txtPhone.Text);
            Item.SubItems.Add(nuAge.Value.ToString());
            if(radioButton1.Checked == true)
            {
                Item.SubItems.Add(radioButton1.Text);
            }
            else
            {
                Item.SubItems.Add(radioButton2.Text);
            }

            if(rdoMale.Checked == true)
            {
                Item.SubItems.Add(rdoMale.Text);
                Item.ImageIndex = 0;
            }
            else
            {
                Item.SubItems.Add(rdoFamle.Text);
                Item.ImageIndex = 1;
            }

            listView1.Items.Add(Item);

            txtID.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            nuAge.Value = 0;
            radioButton1.Checked = true;
            rdoMale.Checked = true;

            tabControl1.SelectedIndex = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (comboBox1.Text == "search")
            {
                tabControl1.SelectedIndex = 2;
                return;
            }

            if (comboBox1.Text == "LargIcon")
            {
                listView1.View = View.LargeIcon;
                return;
            }
            else if(comboBox1.Text == "Small Icon")
            {
                listView1.View = View.SmallIcon;
                return;
            }
            else if(comboBox1.Text == "Tilt")
            {
                listView1.View = View.Tile;
                return;
            }
            else if(comboBox1.Text == "List")
            {
                listView1.View = View.List;
                return;
            }
            else
            {
                listView1.View = View.Details;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           foreach(ListViewItem Items in listView1.Items)
            {
                if (Items.SubItems[1].Text == txtStudentName.Text)
                {
                    int i = Convert.ToInt32(Items.StateImageIndex);

                    if(i > 0)
                    {
                        pictureBox2.Image = Resources.Man;
                    }
                   else
                    {
                        pictureBox2.Image = Resources.FamlePNG;
                    }

                        lblIDInfo.Text = Items.SubItems[0].Text;
                    lblFullNameInfo.Text = Items.SubItems[1].Text;
                    lblEmailInfo.Text = Items.SubItems[2].Text;
                    lblPhoneInfo.Text = Items.SubItems[3].Text;
                    lblAgeInfo.Text = Items.SubItems[4].Text;
                    lblSpecInfo.Text = Items.SubItems[5].Text;
                    lblGenderInfo.Text = Items.SubItems[6].Text;
                }
            }
           
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtID_Click(object sender, EventArgs e)
        {
          
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtFullName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                nuAge.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void nuAge_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void EnterSearch(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void radioButton2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void radioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void rdoFamle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus(); e.SuppressKeyPress = true;
            }
        }

        private void TabsControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
