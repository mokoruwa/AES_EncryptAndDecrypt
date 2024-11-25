using System.Security.Cryptography;

namespace AES_EncryptAndDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnClear.Enabled = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {


            btnClear.Enabled = true;
            btnEncrypt.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnEncrypt.Enabled = true;
        }

        // For AES
        public string GenerateKey()
        {
            using (var aes = Aes.Create())
            {
                aes.GenerateKey();
                var bytesKEY = aes.Key;
                var base64KEY = Convert.ToBase64String(bytesKEY);
                return base64KEY;
            }
        }
    }
}
