
using ProductStore.Controler.Login;
using ProductStore.Entidades.Login;
using System;
using System.Threading;
using System.Windows.Forms;
namespace ProductStore.View
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private Thread newThread;

        private LoginEntidade loginEntidade;
        private void bntEntrar_Click(object sender, EventArgs e)
        {

            LoginControler loginControler = new LoginControler();

            loginEntidade = loginControler.VerificarLogin(txtUser.Text, txtPass.Text);

            if (loginEntidade == null)
            {
                MessageBox.Show("Digite um usuario e senha validos");
            }
            else
            {
                SalvarLogin(loginEntidade.Id);

                this.Close();

                newThread = new Thread(AbrirNovaJanela);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();

            }
        }

        private void AbrirNovaJanela()
        {
            HomeScreen homeScreen = new HomeScreen(loginEntidade);
            homeScreen.ShowDialog();

        }

        private void SalvarLogin(int LoginId)
        {
            ControleLogSistemaControler controleLogSistemaControler = new ControleLogSistemaControler();
            controleLogSistemaControler.NovoLogin(LoginId);
        }

    }
}
