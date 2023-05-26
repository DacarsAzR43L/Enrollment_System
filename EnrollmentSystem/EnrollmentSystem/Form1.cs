using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace EnrollmentSystem
{
    public partial class StudProfile : Form
    {
        MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
        MySqlCommand myCmd = new MySqlCommand();
        MySqlDataAdapter adp;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        

        public int year = 2019;
        public int num = 1;


        public int cnt = 1;

        public StudProfile()
        {
            InitializeComponent();

            dgStudentProfile.ColumnCount = 3;
            dgStudentProfile.Columns[0].Name = "Student Number";
            dgStudentProfile.Columns[1].Name = "First Name";
            dgStudentProfile.Columns[2].Name = "Last Name";
            dgStudentProfile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgStudentProfile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudentProfile.MultiSelect = false;

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        { 
            string query = "insert into studentprofile(student_Id, f_name, l_name, fullname)" +
                "Values(@STUDENTNUMBER, @FNAME, @LNAME, @FULLNAME)";
            myCmd = new MySqlCommand(query, myCon);
            myCmd.Parameters.AddWithValue("@STUDENTNUMBER", textBox1.Text);
            myCmd.Parameters.AddWithValue("@FNAME", textBox2.Text);
            myCmd.Parameters.AddWithValue("@LNAME", textBox3.Text);
            myCmd.Parameters.AddWithValue("@FULLNAME", textBox2.Text + " " + textBox3.Text);
            

            
            try
            {
                textBox2.Clear();
                textBox3.Clear();
                cnt += num;
                textBox1.Text = "PUPSMB-" + year + "-" + cnt;
                if (num == 100)
                {
                    year += cnt;
                    textBox1.Text = "PUPSMB-" + year + "-" + cnt;
                }
                myCon.Open();

                if(myCmd.ExecuteNonQuery()>0)
                {
                    string title = "Message Alert";
                    MessageBox.Show("Insert Successfully!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                myCon.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                myCon.Close();
            }
            
        }
        

        public void Form1_Load(object sender, EventArgs e)
        {

            
            string query = "SELECT * FROM StudentProfile";
            MySqlCommand cmd = new MySqlCommand(query, myCon);
            myCon.Open();
            MySqlDataReader rdr = cmd.ExecuteReader(); 
            while (rdr.Read())
            {
                cnt += 1;
            }
            textBox1.Text = "PUPSMB-" + year + "-" + cnt;
            myCon.Close();

            retrieve();
            
        }

        private void retrieve()
        {
            dgStudentProfile.Rows.Clear();
            string query = "select * from studentprofile";
            myCmd = new MySqlCommand(query, myCon);
            try
            {
                myCon.Open();
                adp = new MySqlDataAdapter(myCmd);
                adp.Fill(dt);
                

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
                    
                }
                myCon.Close();

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                myCon.Close();
            }
        }

        private void populate(string st_Id, string fname, string lname)
        {
            dgStudentProfile.Rows.Add(st_Id, fname, lname);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgStudentProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudProfile f1 = new StudProfile();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseOffered f2 = new CourseOffered();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sections f3 = new Sections();
            f3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tagging f5 = new tagging();
            f5.Show();
            this.Hide();
        }

        private void StudProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show(

            "Do You Want To Exit?",

            "Close Application",

             MessageBoxButtons.YesNo,

             MessageBoxIcon.Question,

             MessageBoxDefaultButton.Button2))

            {

                e.Cancel = true;

            }
        }

        

      
    }
}
