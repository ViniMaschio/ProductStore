
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

        Thread newThread;
        private void bntEntrar_Click(object sender, EventArgs e)
        {

            LoginControler loginControler = new LoginControler();

            LoginEntidade loginEntidade = loginControler.VerificarLogin(txtUser.Text, txtPass.Text);

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

        void AbrirNovaJanela()
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.ShowDialog();

        }

        void SalvarLogin(int LoginId)
        {
            ControleLogSistemaControler controleLogSistemaControler = new ControleLogSistemaControler();
            controleLogSistemaControler.NovoLogin(LoginId);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(AbrirNovaJanela);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
    }
}
