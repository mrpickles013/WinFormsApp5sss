using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        Form2 f = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //int numerocasa = int.Parse(maskedTextBox2.Text);
            if (txtNome.Text == "")
            {
                MessageBox.Show("Insira um nome");
                txtNome.Focus();
                return;
            }

            string email = txtEmail.Text.Trim();
            // Console.WriteLine(email);
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("DIGITE UM E-MAIL VÁLIDO CAPETA!!!");
                txtEmail.Focus();
                return;
            }



            DialogResult r = MessageBox.Show("|Deseja continuar com o cadastro?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro realizado com sucesso");
                f.Show();
            }
            else
            {
                MessageBox.Show("Cadastro cancelado!");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private async Task maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cep = maskedTextBox2.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                MessageBox.Show("Digite um CEP VÁLIDO!!!");
                maskedTextBox2.Focus();
                return;
            }
            try
            {
                string url = $"https:www.viacep.com.br/ws/{cep}/json";
                string jsonResposta = await client.GetStringAsync(url);
                viacep resultado = JsonSerializer.Deserialize<viacep>(jsonResposta);

                if (resultado.erro) 
                {
                    MessageBox.Show("DIGITE O CEP CORRETAMENTE");
                    maskedTextBox2.Focus();
                    return;
                }

              //  txtLog.Text = resultado.logradouro;
              //  txtBairro.Text = resultado.bairro;
              //  txtCidade.Text = resultado.cidade;
              //  txtUF.Text = resultado.uf;
              //  txtComp.Text = resultado.complemento;
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro ao buscar CEP, ERRO: {ex}   ==> VERIFIQUE SUA CONEXÃO <==");
            }



        }
    }
    public class viacep
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        
        public bool erro { get;set; }

    }
}
