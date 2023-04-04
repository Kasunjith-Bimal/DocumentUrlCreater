using System.Text;

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

        }

        private async void btn_reuslt_Click(object sender, EventArgs e)
        {
            if(txt_requestId.Text != "" && txt_stored.Text != "" && txt_tenetId.Text != "")
            {
                var value = await EncryptionHelper.EncryptStringAES($"{txt_tenetId.Text}~~{txt_requestId.Text}~~{txt_stored.Text}~~Tenant&RequestId&StoredName");
                txt_result.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
            }
            else
            {
                MessageBox.Show("please fill");
            }
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            txt_requestId.Text = "";
            txt_stored.Text = "";
            txt_tenetId.Text = "";
        }
    }
}