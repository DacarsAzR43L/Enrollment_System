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
    public partial class Sections : Form
    {
        MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
        MySqlCommand myCmd = new MySqlCommand();
        MySqlDataAdapter adp;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public int num = 1;
        public int cnt = 1;

        public Sections()
        {
            InitializeComponent();
            dgSections.ColumnCount = 2;
            dgSections.Columns[0].Name = "Section ID";
            dgSections.Columns[1].Name = "Description";
            dgSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSections.MultiSelect = false;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Sections";
            MySqlCommand cmd = new MySqlCommand(query, myCon);
            myCon.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cnt += 1;
            }
            textBoxSecID.Text = "PUPSMB-SEC" + cnt;
            myCon.Close();

            retrieve();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseOffered f2 = new CourseOffered();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudProfile f1 = new StudProfile();
            f1.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string query = "insert into sections(section_Id, sec_descrip)" +
                "Values(@SECTIONID, @SECDESCRIP)";
            myCmd = new MySqlCommand(query, myCon);
            myCmd.Parameters.AddWithValue("@SECTIONID", textBoxSecID.Text);
            myCmd.Parameters.AddWithValue("@SECDESCRIP", textBoxSecDesc.Text);
            


            try
            {
                
                textBoxSecDesc.Clear();
                cnt += num;
                textBoxSecID.Text = "PUPSMB-SEC" + cnt;
                /*if (num == 100)
                {
                    year += cnt;
                    textBox1.Text = "PUPSMB-" + year + "-" + cnt;
                }*/
                myCon.Open();

                if (myCmd.ExecuteNonQuery() > 0)
                {string title = "Message Alert";
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

        private void retrieve()
        {
            dgSections.Rows.Clear();
            string query = "select * from sections";
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

        private void populate(string secID, string secDesc)
        {
            dgSections.Rows.Add(secID, secDesc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tagging f5 = new tagging();
            f5.Show();
            this.Hide();
        }

        private void Sections_FormClosing(object sender, FormClosingEventArgs e)
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
