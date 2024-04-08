namespace inventory_managment_system
{
    public partial class login : Form
    {
        FileStream users;
        StreamReader Usr;

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l_reset_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            users = new FileStream("users.txt", FileMode.Open, FileAccess.Read);
            Usr = new StreamReader(users);
            string record;
            string[] field;
            bool check = false;
            while ((record = Usr.ReadLine()) != null)
            {
                field = record.Split(',');
                if (txtuser.Text == field[2] && txtpass.Text == field[4])
                {
                    this.Hide();
                    products f = new products();
                    f.ShowDialog();
                    this.Close();
                    check = true;
                    break;

                }
            }

            if (check == false)
            {
                MessageBox.Show("Wrong username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
