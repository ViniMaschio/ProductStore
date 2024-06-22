using ProductStore.Controler.Endereco;
using ProductStore.DAO.Cliente;
using ProductStore.Entidades.Cliente;
using ProductStore.Entidades.Endereco;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProductStore.Controler.Cliente
{
    public class ClienteControler
    {
        public ClienteControler() { }

        public void AddCliente(ClienteEntidade clienteEntidade)
        {
            ClienteDao clienteDao = new ClienteDao();

            clienteDao.Add(clienteEntidade);

            MessageBox.Show("Cliente Adicionado com sucesso!", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void AlterarCliente(ClienteEntidade clienteEntidade)
        {

            ClienteDao clienteDao = new ClienteDao();

            clienteDao.Update(clienteEntidade);

            MessageBox.Show("Cliente Alterado com sucesso!", "Aterar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void RemoverCliente(ClienteEntidade clienteEntidade)
        {
            ClienteDao clienteDao = new ClienteDao();

            if (MessageBox.Show("Deseja Deletar o Cliente : \n" + clienteEntidade.Id + " - " + clienteEntidade.NomeCliente,
                "Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clienteDao.Delete(clienteEntidade.Id);

                MessageBox.Show("Cliente Adicionado com sucesso!", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable BuscarTodosCliente()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int)); //0
            dataTable.Columns.Add("Nome", typeof(string));//1
            dataTable.Columns.Add("Sexo", typeof(string));//2
            dataTable.Columns.Add("Data", typeof(string));//3
            dataTable.Columns.Add("Rua", typeof(string));//4
            dataTable.Columns.Add("Numero", typeof(string));//5
            dataTable.Columns.Add("Bairro", typeof(string));//6
            dataTable.Columns.Add("Cidade", typeof(string));//7
            dataTable.Columns.Add("CEP", typeof(string));//8
            dataTable.Columns.Add("Salario", typeof(double));//9
            dataTable.Columns.Add("Trabalho", typeof(string));//10


            ClienteDao clienteDao = new ClienteDao();
            List<ClienteEntidade> listClienteEntidade = clienteDao.BuscarTodosCliente();

            SexoControler sexoControler = new SexoControler();
            RuaControler ruaControler = new RuaControler();
            BairroControler bairroControler = new BairroControler();
            CidadeControler cidadeControler = new CidadeControler();
            CidadeEntidade cidadeEntidade = new CidadeEntidade();
            CepControler cepControler = new CepControler();
            TrabalhoControler trabalhoControler = new TrabalhoControler();

            for (int i = 0; i < listClienteEntidade.Count; i++)
            {
                cidadeEntidade = cidadeControler.BuscarCidadePorId(listClienteEntidade[i].CodCidade);

                dataTable.Rows.Add(listClienteEntidade[i].Id,
                  listClienteEntidade[i].NomeCliente,
                  sexoControler.BuscarSexoPorId(listClienteEntidade[i].CodSexo),
                  listClienteEntidade[i].Datanasc.ToString("dd:MM:yyyy"),
                  ruaControler.BuscarPorId(listClienteEntidade[i].CodRua),
                  listClienteEntidade[i].NumeroCasa,
                  bairroControler.BuscarPorId(listClienteEntidade[i].CodBairro),
                  cidadeEntidade.Nomecidade,
                  cepControler.BuscarCepPorId(listClienteEntidade[i].CodCep),
                  listClienteEntidade[i].Salario,
                  trabalhoControler.BuscarTrabalhoPorId(listClienteEntidade[i].CodTrabalho)
                  );
            }


            return dataTable;
        }

        public ClienteEntidade BuscarClientePorId(int id)
        {
            ClienteDao clienteDao = new ClienteDao();

            return clienteDao.BuscarClientePorId(id);
        }
    }

}
