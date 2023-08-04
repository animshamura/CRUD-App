using System.Data.SqlClient;

namespace CRUD_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = t1.Text;
            string address = t2.Text;
            string email = t3.Text;
            string cellno = t4.Text;
            string city = t5.Text;

            try
            {
                string con = "Server=DESKTOP-NCKVTGK\\SQLEXPRESS; Database=CRUD; Integrated Security = true;";
                SqlConnection cont = new SqlConnection(con);
                string q = "insert into Traveler values(" + name + "," + address + "," + cellno + "," + email + "," + city + ")";
                SqlCommand com = new SqlCommand(q, cont);
                cont.Open();
                int t = com.ExecuteNonQuery();
                if (t == 1) MessageBox.Show("Saved Successfully!");
                else MessageBox.Show("Not Saved!");
                cont.Close();
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }

        }

    }
}