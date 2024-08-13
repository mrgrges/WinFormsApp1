
using System.Data;
using System.Data.SqlClient;

    namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kgeor\\OneDrive\\Documents\\Data3.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
            SqlDataAdapter sda = new SqlDataAdapater("Select Count(*) From Login where Username='" + textBox1.Text + "' and Password= '" + textBox2.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            { 
                            
            this.Hide();

            Main ss = new Main();
            ss.Show();
        }
        else 
                {
                MessageBox.Show("Please Check your Username and Password")

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
