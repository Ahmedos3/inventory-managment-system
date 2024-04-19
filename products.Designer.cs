namespace inventory_managment_system
{
    partial class products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            panel1 = new Panel();
            btnClose = new Button();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            producttable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Quntity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            btnopen = new Button();
            category = new ComboBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnADD = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            l_addproduct = new Label();
            t_pPRICE = new TextBox();
            t_pQTY = new TextBox();
            t_pName = new TextBox();
            t_pID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tipEdit = new ToolTip(components);
            tipOpen = new ToolTip(components);
            tipAdd = new ToolTip(components);
            tipDelete = new ToolTip(components);
            tipCategory = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)producttable).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 96, 129);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 87);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(2, 96, 129);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(1015, 13);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 27);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(462, 57);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 14);
            label5.TabIndex = 10;
            label5.Text = "mange products ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(483, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 38);
            label3.TabIndex = 9;
            label3.Text = "iMs";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventory_12141389;
            pictureBox1.Location = new Point(14, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 96, 129);
            panel2.Controls.Add(producttable);
            panel2.Location = new Point(491, 147);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 455);
            panel2.TabIndex = 1;
            // 
            // producttable
            // 
            producttable.AllowUserToResizeColumns = false;
            producttable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            producttable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            producttable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            producttable.Columns.AddRange(new DataGridViewColumn[] { ID, name, Quntity, Price });
            producttable.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            producttable.DefaultCellStyle = dataGridViewCellStyle6;
            producttable.EditMode = DataGridViewEditMode.EditProgrammatically;
            producttable.Location = new Point(21, 17);
            producttable.Margin = new Padding(4, 3, 4, 3);
            producttable.Name = "producttable";
            producttable.ReadOnly = true;
            producttable.Size = new Size(520, 421);
            producttable.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Quntity
            // 
            Quntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quntity.DefaultCellStyle = dataGridViewCellStyle4;
            Quntity.HeaderText = "Quntity";
            Quntity.Name = "Quntity";
            Quntity.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.DefaultCellStyle = dataGridViewCellStyle5;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // btnopen
            // 
            btnopen.BackColor = Color.FromArgb(2, 96, 129);
            btnopen.Cursor = Cursors.Hand;
            btnopen.FlatStyle = FlatStyle.Popup;
            btnopen.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnopen.ForeColor = Color.White;
            btnopen.Location = new Point(47, 367);
            btnopen.Margin = new Padding(4, 3, 4, 3);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(155, 42);
            btnopen.TabIndex = 5;
            btnopen.Text = "Open";
            btnopen.UseVisualStyleBackColor = false;
            btnopen.Click += btnopen_Click;
            btnopen.MouseHover += btnopen_MouseHover;
            // 
            // category
            // 
            category.BackColor = Color.FromArgb(2, 96, 129);
            category.Cursor = Cursors.Hand;
            category.FlatStyle = FlatStyle.Popup;
            category.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.ForeColor = Color.White;
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "laptops", "taplets", "phones", "headsets" });
            category.Location = new Point(47, 307);
            category.Margin = new Padding(4, 3, 4, 3);
            category.Name = "category";
            category.Size = new Size(271, 26);
            category.TabIndex = 4;
            category.MouseHover += category_MouseHover;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(2, 96, 129);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(47, 440);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 42);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseHover += btnEdit_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(2, 96, 129);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(233, 440);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnADD
            // 
            btnADD.BackColor = Color.FromArgb(2, 96, 129);
            btnADD.Cursor = Cursors.Hand;
            btnADD.Enabled = false;
            btnADD.FlatStyle = FlatStyle.Popup;
            btnADD.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnADD.ForeColor = Color.White;
            btnADD.Location = new Point(233, 367);
            btnADD.Margin = new Padding(4, 3, 4, 3);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(155, 42);
            btnADD.TabIndex = 1;
            btnADD.Text = "Add";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnAdd_Click;
            btnADD.MouseHover += btnADD_MouseHover;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(btnopen);
            panel4.Controls.Add(l_addproduct);
            panel4.Controls.Add(btnADD);
            panel4.Controls.Add(category);
            panel4.Controls.Add(t_pPRICE);
            panel4.Controls.Add(t_pQTY);
            panel4.Controls.Add(t_pName);
            panel4.Controls.Add(t_pID);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(26, 93);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 508);
            panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(326, 307);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // l_addproduct
            // 
            l_addproduct.AutoSize = true;
            l_addproduct.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_addproduct.ForeColor = Color.FromArgb(2, 96, 129);
            l_addproduct.Location = new Point(120, 10);
            l_addproduct.Margin = new Padding(4, 0, 4, 0);
            l_addproduct.Name = "l_addproduct";
            l_addproduct.Size = new Size(156, 25);
            l_addproduct.TabIndex = 9;
            l_addproduct.Text = "Add Product";
            // 
            // t_pPRICE
            // 
            t_pPRICE.BackColor = Color.FromArgb(2, 96, 129);
            t_pPRICE.BorderStyle = BorderStyle.FixedSingle;
            t_pPRICE.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pPRICE.ForeColor = Color.White;
            t_pPRICE.Location = new Point(208, 225);
            t_pPRICE.Margin = new Padding(4, 3, 4, 3);
            t_pPRICE.Name = "t_pPRICE";
            t_pPRICE.Size = new Size(218, 27);
            t_pPRICE.TabIndex = 8;
            // 
            // t_pQTY
            // 
            t_pQTY.BackColor = Color.FromArgb(2, 96, 129);
            t_pQTY.BorderStyle = BorderStyle.FixedSingle;
            t_pQTY.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pQTY.ForeColor = Color.White;
            t_pQTY.Location = new Point(208, 165);
            t_pQTY.Margin = new Padding(4, 3, 4, 3);
            t_pQTY.Name = "t_pQTY";
            t_pQTY.Size = new Size(218, 27);
            t_pQTY.TabIndex = 7;
            t_pQTY.KeyDown += t_pQTY_KeyDown;
            // 
            // t_pName
            // 
            t_pName.BackColor = Color.FromArgb(2, 96, 129);
            t_pName.BorderStyle = BorderStyle.FixedSingle;
            t_pName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pName.ForeColor = Color.White;
            t_pName.Location = new Point(208, 106);
            t_pName.Margin = new Padding(4, 3, 4, 3);
            t_pName.Name = "t_pName";
            t_pName.Size = new Size(218, 27);
            t_pName.TabIndex = 6;
            t_pName.KeyDown += t_pName_KeyDown;
            // 
            // t_pID
            // 
            t_pID.BackColor = Color.FromArgb(2, 96, 129);
            t_pID.BorderStyle = BorderStyle.FixedSingle;
            t_pID.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pID.ForeColor = Color.White;
            t_pID.Location = new Point(208, 53);
            t_pID.Margin = new Padding(4, 3, 4, 3);
            t_pID.Name = "t_pID";
            t_pID.Size = new Size(218, 26);
            t_pID.TabIndex = 5;
            t_pID.KeyDown += t_pID_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(2, 96, 129);
            label7.Location = new Point(21, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 3;
            label7.Text = "ProductPrice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(2, 96, 129);
            label6.Location = new Point(21, 103);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 2;
            label6.Text = "ProductName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(2, 96, 129);
            label4.Location = new Point(21, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 1;
            label4.Text = "ProductQty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(2, 96, 129);
            label2.Location = new Point(21, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 0;
            label2.Text = "ProductID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(2, 96, 129);
            label1.Location = new Point(682, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 5;
            label1.Text = "Product List";
            // 
            // products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 627);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)producttable).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView producttable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_pPRICE;
        private System.Windows.Forms.TextBox t_pQTY;
        private System.Windows.Forms.TextBox t_pName;
        private System.Windows.Forms.TextBox t_pID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label l_addproduct;
        private System.Windows.Forms.ToolTip tipEdit;
        private System.Windows.Forms.ToolTip tipOpen;
        private System.Windows.Forms.ToolTip tipAdd;
        private System.Windows.Forms.ToolTip tipDelete;
        private System.Windows.Forms.ToolTip tipCategory;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Quntity;
        private DataGridViewTextBoxColumn Price;
        private PictureBox pictureBox2;
    }
}