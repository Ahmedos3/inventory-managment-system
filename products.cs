﻿using System;
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
    public partial class products : Form
    {
        public string filename = "";
        public int selectedRow = 0;
        public int rownum = 0;
        bool opencheck = false;
        FileStream myfile;
        StreamReader sr;
        StreamWriter sw;
        public string record;
        public string[] field;
        public products()
        {
            InitializeComponent();
        }

        // check data ID if exist or not
        public bool datacheck()
        {
            bool check = false;
            string record;
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            sr = new StreamReader(myfile);
            while ((record = sr.ReadLine()) != null)
            {
                string[] field = record.Split(',');
                if (field[0] != "#")
                {
                    if (field[1] == t_pID.Text)
                    {
                        check = true;
                    }
                }

            }
            sr.Close();
            myfile.Close();
            return check;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {

            producttable.Rows.Clear(); // to delete data form gride for open new category
            //chose category and define the filename to save data for each category
            if (category.Text == "laptops")
            {
                filename = "p_laptop.txt";
            }
            else if (category.Text == "taplets")
            {
                filename = "p_taplets.txt";
            }
            else if (category.Text == "phones")
            {
                filename = "P_phones.txt";
            }
            else if (category.Text == "headsets")
            {
                filename = "p_headsets.txt";
            }
            else
            {
                MessageBox.Show("please select a category", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // show data in datagrideview 
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            sr = new StreamReader(myfile);
            string record;
            while ((record = sr.ReadLine()) != null)
            {
                string[] field = record.Split(',');
                if (field[0] != "#")
                {
                    producttable.Rows.Add(field[1], field[2], field[3], field[4]);
                }

            }
            myfile.Flush();
            sr.Close();
            myfile.Close();
            btnADD.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            opencheck = true;
            MessageBox.Show("file opened", "excellent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (t_pID.Text != "" && t_pName.Text != "" && t_pQTY.Text != "" && t_pPRICE.Text != "")
            {
                //check data
                if (datacheck() == false)
                {
                    myfile = new FileStream(filename, FileMode.Append, FileAccess.Write);
                    producttable.Rows.Add(t_pID.Text, t_pName.Text, t_pQTY.Text, t_pPRICE.Text);
                    sw = new StreamWriter(myfile);
                    sw.WriteLine($"{rownum},{t_pID.Text},{t_pName.Text},{t_pQTY.Text},{t_pPRICE.Text}");
                    Console.WriteLine();
                    sw.Flush();
                    myfile.Close();
                    rownum++;
                    t_pID.Clear();
                    t_pName.Clear();
                    t_pQTY.Clear();
                    t_pPRICE.Clear();

                }
                else
                {
                    MessageBox.Show("this id already exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t_pID.Clear();
                    t_pName.Clear();
                    t_pQTY.Clear();
                    t_pPRICE.Clear();
                }
            }
            else
            {
                MessageBox.Show("please enter all informations", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //edit data in file
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sr = new StreamReader(myfile);
            sw = new StreamWriter(myfile);
            myfile.Seek(0, SeekOrigin.Begin);
            string record;
            string[] field;
            int steps = 2;
            while ((record = sr.ReadLine()) != null)
            {
                field = record.Split(',');
                if (field[1] == t_pID.Text)
                {
                    myfile.Seek(steps, SeekOrigin.Begin);
                    sw.Write($"{t_pID.Text},{t_pName.Text},{t_pQTY.Text},{t_pPRICE.Text}");
                    sw.Flush();
                    MessageBox.Show("done");
                    break;
                }
                steps += record.Length + 2;
            }

            myfile.Flush();
            sw.Flush();

            //show data on datagridview
            producttable.Rows.Clear();
            sr = new StreamReader(myfile);
            myfile.Seek(0, SeekOrigin.Begin);
            while ((record = sr.ReadLine()) != null)
            {
                field = record.Split(',');
                if (field[0] != "#")
                {
                    producttable.Rows.Add(field[1], field[2], field[3], field[4]);
                }
            }
            sw.Close();
            sr.Close();
            myfile.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // marked the data to be deleted
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sr = new StreamReader(myfile);
            sw = new StreamWriter(myfile);
            myfile.Seek(0, SeekOrigin.Begin);
            myfile.Flush();
            sw.Flush();
            string record;
            int steps = 0;
            while ((record = sr.ReadLine()) != null)
            {
                string[] field = record.Split(',');
                string ID = t_pID.Text;
                if (ID == field[1])
                {
                    myfile.Seek(steps, SeekOrigin.Begin);
                    sw.Write("#");
                    sw.Flush();
                    MessageBox.Show("done");
                    break;
                }
                steps += record.Length + 2;
            }
            myfile.Flush();
            sw.Flush();

            //show data on datagridview
            producttable.Rows.Clear();
            myfile.Seek(0, SeekOrigin.Begin);
            sr = new StreamReader(myfile);
            while ((record = sr.ReadLine()) != null)
            {
                string[] field = record.Split(',');
                string ID = t_pID.Text;
                if (field[0] != "#")
                {

                    producttable.Rows.Add(field[1], field[2], field[3], field[4]);

                }

            }
            sw.Close();
            sr.Close();
            myfile.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //make a new file with the same name to remove deleted data
            if (opencheck == true)
            {
                string record;
                myfile = new FileStream(filename, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(myfile);
                myfile.Seek(0, SeekOrigin.Begin);
                FileStream newfile = new FileStream("x.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(newfile);
                while ((record = sr.ReadLine()) != null)
                {
                    if (record[0] != '#')
                    {
                        writer.WriteLine(record);
                        writer.Flush();
                    }
                }
                sr.Close();
                myfile.Close();
                writer.Close();
                newfile.Close();
                File.Delete(filename);
                File.Copy("x.txt", filename);
                File.Delete("x.txt");
                MessageBox.Show("dooone");
            }

            //close the program
            this.Close();

        }

        private void btnopen_MouseHover(object sender, EventArgs e)
        {
            tipEdit.Show("open the category file", btnopen);
        }
        private void btnADD_MouseHover(object sender, EventArgs e)
        {
            tipEdit.Show("add new product", btnADD);
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            tipEdit.Show("Write Product ID to Edit (name,price,quntity)", btnEdit);
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            tipEdit.Show("Delete product ", btnDelete);
        }

        private void category_MouseHover(object sender, EventArgs e)
        {
            tipEdit.Show("chose category", category);
        }

        private void accounts_Load(object sender, EventArgs e)
        {

        }
    }
}