using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_managment_system
{
    public partial class Signup : Form
    {
        FileStream filestream;
        StreamReader sr;
        StreamWriter sw;
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
        private void signup_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        
        private void btnsignup_Click(object sender, EventArgs e)
        {
            filestream = new FileStream("users.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(filestream);

            if (txtfname.Text != "" && txtlname.Text != "" && txtemail.Text != "" && txtpassword.Text != "" && txtcpassword.Text != "" && txtusername.Text != "")
            {
                if (txtpassword.Text == txtcpassword.Text)
                {
                    txtcpassword.BackColor = Color.White;
                    sw.WriteLine($"{txtfname.Text},{txtlname.Text},{txtusername.Text},{txtemail.Text},{txtpassword.Text}");
                    sw.Flush();
                    filestream.Flush();
                    products products = new products();
                    products.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("please confirm Right pass");
                    txtcpassword.BackColor = Color.Red;
                    sw.Flush( );
                    filestream.Flush();
                }

            }
            else
            {
                if (txtfname.Text == "")
                {
                    txtfname.BackColor = Color.Red;
                }
                else
                {
                    txtfname.BackColor = Color.White;
                }
                if (txtlname.Text == "")
                {
                    txtlname.BackColor = Color.Red;
                }
                else
                {
                    txtlname.BackColor = Color.White;
                }
                if (txtusername.Text == "")
                {
                    txtusername.BackColor = Color.Red;
                }
                else
                {
                    txtusername.BackColor = Color.White;
                }
                if (txtemail.Text == "")
                {
                    txtemail.BackColor = Color.Red;
                }
                else
                {
                    txtemail.BackColor = Color.White;
                }
                if (txtpassword.Text == "")
                {
                    txtpassword.BackColor = Color.Red;
                }
                else
                {
                    txtpassword.BackColor = Color.White;
                }
                if (txtcpassword.Text == "")
                {
                    txtcpassword.BackColor = Color.Red;
                }
                else
                {
                    txtcpassword.BackColor = Color.White;
                }
                sw.Flush();
                filestream.Flush();
                MessageBox.Show("please enter all information", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            sw.Close();
            filestream.Close();
            

        }

        private void txtcpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
