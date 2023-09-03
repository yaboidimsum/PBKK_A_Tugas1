namespace Tugas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            lbWelcome.Text = string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstName.Text;
            String lastName = tbLastName.Text;
            lbWelcome.Text = "Welcome! " + firstName + " " + lastName + " To PBKK A";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}