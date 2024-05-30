namespace Assignment_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameBox.Text=="Teacher" &&  PasswordBox.Text=="Admin")
            {
                StudentInformation studentInformation = new StudentInformation();
                studentInformation.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login"); 
            }
        }
    }
}
