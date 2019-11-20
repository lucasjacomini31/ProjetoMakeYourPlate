using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;

namespace Projeto_faculdade_melhorado
{
    
    public partial class make : Form
    {
        string index;
        metodos objmetodo = new metodos();

        public make()
        {
            InitializeComponent();
        }

       
        void atualiza()
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {
                objcon.Open();
                DataTable dtTabelas = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select nome from ingredientes  ", objcon);
                da.Fill(dtTabelas);
                cboingredientes.DataSource = dtTabelas;
                cboingredientes.DisplayMember = "nome";
                cboingredientes.ValueMember = "nome";

            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Falha de conexão com o banco de dados " + erro);
            }
            finally
            {
                objcon.Close();
            }
        }
        private void Make_Load(object sender, EventArgs e)
        {

            atualiza();
           


        }

        

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

       

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            paineldetalhes.Visible = false;
           
            string item1;
            string item2;
            string item3;
            string item4;
             

            if (Lsbingredientes.Items.Count == 1) //testar se a list esta vazia
            {
                item1 = Lsbingredientes.Items[0].ToString(); // pegar o primeiro item da list de um determinado index
            }
            else
            {
                item1 = null;
            }

            if (Lsbingredientes.Items.Count == 2) //testar se a list esta vazia
            {
                item2 = Lsbingredientes.Items[1].ToString(); // pegar o primeiro item da list de um determinado index
            }
            else
            {
                item2 = null;
            }

            if (Lsbingredientes.Items.Count == 3) //testar se a list esta vazia
            {
                item3 = Lsbingredientes.Items[2].ToString(); // pegar o primeiro item da list de um determinado index
            }
            else
            {
                item3 = null;
            }

            if (Lsbingredientes.Items.Count == 4) //testar se a list esta vazia
            {
                item4 = Lsbingredientes.Items[3].ToString(); // pegar o primeiro item da list de um determinado index
            }
            else
            {
                item4 = null;
            }



            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());

            try
            {                                             
                //abrir conexao
                objcon.Open();

                
                DataTable dtTabelas = new DataTable();
                
                string concatena = Convert.ToString(cboingredientes.Text);
                string select = string.Concat("select nome,preco, modopreparo from pratos where modopreparo like '%" + concatena + "%' and modopreparo like '%"+ item1 + "%' and modopreparo like '%" + item2 + "%' and modopreparo like '%" + item3 + "%' and modopreparo like '%" + item4 + "%'"); //buscar no banco
                
                MySqlDataAdapter da = new MySqlDataAdapter(select, objcon);

                
                

                da.Fill(dtTabelas);
                Gridbuscar.DataSource = dtTabelas;
                Gridbuscar.Sort(Gridbuscar.Columns["nome"], ListSortDirection.Ascending);
                



                Gridbuscar.Columns[0].HeaderText = "Nome do Prato"; // definir o nome da coluna
                Gridbuscar.Columns[0].Width = 200; // definir o tamanho da coluna                
                Gridbuscar.Columns[1].HeaderText = "Preço do Prato"; // definir o nome da coluna
                Gridbuscar.Columns[1].Width = 120; // definir o tamanho da coluna
                Gridbuscar.Columns[2].HeaderText = "Ingredientes contidos no Prato"; // definir o nome da coluna
                Gridbuscar.Columns[2].Width = 200; // definir o tamanho da coluna

            }
                      
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Sem conexão com o banco de dados ");
            }
            finally
            {
                objcon.Close();   
            }
            

        }

        private void Btnadicionar_Click(object sender, EventArgs e)
        {
            string contador =  Lsbingredientes.Items.Count.ToString(); // pega a soma de itens da lista
            

            if (Convert.ToInt32(contador) < 4) // teste para limitar campos adicionados na listbox
            {
                if (Lsbingredientes.Items.Contains(cboingredientes.Text)) // teste para ver se o ingredinte ja existe na lista
                {
                    MessageBox.Show("Ja possui " + cboingredientes.Text + " na lista");
                }
                else
                {
                    Lsbingredientes.Items.Add(cboingredientes.Text.ToString());  // adiciona itens a lista
                }
                
            }
            else
            {
                MessageBox.Show("Você pode adicionar apenas 4 ingredientes a lista");
            }
                        
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            
            
            try 
            { 
                Lsbingredientes.Items.RemoveAt(Convert.ToInt32(index)); 
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor selecione um ingrediente ou não possui mais ingredientes na lista");
            }
            catch (Exception)
            {
                MessageBox.Show("Contate a um administrador do sistema ocorreu um erro inesperado" );
            }
            

        }

        private void Lsbingredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = Lsbingredientes.SelectedIndex.ToString();
        }

        private void Gridbuscar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //quando clicar 2 vezes.

            paineldetalhes.Visible = true;
          

            lblnome.Text = Gridbuscar.CurrentRow.Cells[0].Value.ToString();
            lblpreco.Text = string.Format("R$ {0:#.###,##}", Gridbuscar.CurrentRow.Cells[1].Value.ToString()); //formatar label para R$
            lblIngredientes.Text = Gridbuscar.CurrentRow.Cells[2].Value.ToString();

            string concatenanome = lblnome.Text;

            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            string select = string.Concat("select imagem from pratos where nome like '%" + concatenanome + "%' "); //buscar no banco
            try
            {
                objcon.Open();

                MySqlCommand cmd = new MySqlCommand(select, objcon);

                MySqlDataReader readerimage;

                readerimage = cmd.ExecuteReader();

                pctimagem.Image = null;

                while (readerimage.Read())
                {
                    byte[] imagem = (byte[])(readerimage["imagem"]);

                    
                    if (imagem == null)
                    {
                        pctimagem.Image = null;
                        
                    }
                    else
                    {
                        
                        MemoryStream mystream = new MemoryStream(imagem);
                        
                        pctimagem.Image = System.Drawing.Image.FromStream(mystream);
                        

                    }
                }


            }
            catch(Exception)
            {

            }
            finally
            {
                objcon.Close();
            }
            


        }

        private void Btnprincipal_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            paineldetalhes.Visible = false;
            
        }

        private void Cboingredientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            atualiza();
        }

        private void btnlimparlista_Click(object sender, EventArgs e)
        {
                       
        Lsbingredientes.Items.Clear();
                     
            
        }
    }
}
