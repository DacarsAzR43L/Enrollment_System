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
    public partial class CourseOffered : Form
    {
        MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
        MySqlCommand myCmd = new MySqlCommand();
        MySqlDataAdapter adp;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public static CourseOffered instance;
        public DataGridView dg;


        public CourseOffered()
        {
            InitializeComponent();
            instance = this;
            dg = dgCourseOffered;

            dgCourseOffered.ColumnCount = 2;
            dgCourseOffered.Columns[0].Name = "Course ID";
            dgCourseOffered.Columns[1].Name = "Course Description";
            
            dgCourseOffered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgCourseOffered.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCourseOffered.MultiSelect = false;
        }



        private void studentNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                
                string query = "insert into coursesoffered(course_Id, c_desc)" +
                    "Values(@COURSEID, @CDESC)";
                myCmd = new MySqlCommand(query, myCon);
                myCmd.Parameters.AddWithValue("@COURSEID", courseTextBox.Text);
                myCmd.Parameters.AddWithValue("@CDESC", descTextBox.Text);

                courseTextBox.Clear();
                descTextBox.Clear();
                myCon.Open();

                if (myCmd.ExecuteNonQuery() > 0)
                {
                    string title = "Message Alert";
                    MessageBox.Show("Insert Successfully!", title,MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        

        private void retrieve()
        {
            dgCourseOffered.Rows.Clear();
            string query = "select * from coursesoffered";
            myCmd = new MySqlCommand(query, myCon);
            try
            {
                myCon.Open();
                adp = new MySqlDataAdapter(myCmd);
                adp.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString());

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

        private void populate(string c_Id, string c_desc)
        {
            dgCourseOffered.Rows.Add(c_Id, c_desc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudProfile f1 = new StudProfile();
            f1.Show();
            this.Hide();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            retrieve();
            /*MySqlCommand cmd = new MySqlCommand(query, myCon);
            myCon.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cnt += 1;
            }
            myCon.Close();*/
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            courseEdit ce = new courseEdit();
            ce.Show();
            string co = dgCourseOffered.SelectedRows[0].Cells[0].Value.ToString();
            string cd = dgCourseOffered.SelectedRows[0].Cells[1].Value.ToString();
            courseEdit.instance.courseId.Text = co;
            courseEdit.instance.courseDesc.Text = cd;



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

        private void CourseOffered_FormClosing(object sender, FormClosingEventArgs e)
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
