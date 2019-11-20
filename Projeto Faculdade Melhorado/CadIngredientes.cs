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

namespace Projeto_faculdade_melhorado
{
    public partial class CadIngredientes : Form
    {
        metodos objmetodo = new metodos();
        public CadIngredientes()
        {
            InitializeComponent();
        }

        void atualiza1()
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {

                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("", objcon);


                DataTable dtTabelas = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from ingredientes ", objcon);
                da.Fill(dtTabelas);
                Gridingredientes.DataSource = dtTabelas;
                Gridingredientes.Sort(Gridingredientes.Columns["nome"], ListSortDirection.Ascending);

                Gridingredientes.Columns[0].HeaderText = "ID"; // definir o nome da coluna
                Gridingredientes.Columns[0].Width = 50; // definir o tamanho da coluna                
                Gridingredientes.Columns[1].HeaderText = "INGREDIENTE"; // definir o nome da coluna
                Gridingredientes.Columns[1].Width = 250; // definir o tamanho da coluna


            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Falha de conexão ao banco de dados  ");
            }
            finally
            {
                objcon.Close();
            }
        }
        private void atualiza(object sender, EventArgs e)
        {
            atualiza1();

           
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Btninserir_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {
                
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("insert into ingredientes (id , nome) values (null,? ) ",objcon);

                objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 20).Value = txtnome.Text ;

                objcmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro de ingrediente concluido com sucesso!!!!");
                txtnome.Text = "";
                atualiza1();
            }
            catch(Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Falha ao cadastrar ingrediente "+ erro);
            }
            finally
            {
                objcon.Close();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            if (MessageBox.Show("Tem certeza que deseja apagar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {                    
                    objcon.Open();
                    string concatena = Convert.ToString(txtid.Text);                    
                    string select = string.Concat("delete from ingredientes where id = '" + concatena + "' limit 1");
                    MySqlCommand objcmd = new MySqlCommand(select, objcon);
                    objcmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Deletado com sucesso");
                    txtid.Text = "";
                    txtnome.Text = "";
                    txtbuscar.Text = "";
                    txtbuscar.Focus();
                    atualiza1();

                }
                catch (Exception erro)
                {
                    System.Windows.Forms.MessageBox.Show("Falha ao Deletar ingrediente " + erro);
                }
                finally
                {
                    objcon.Close();
                }
                
            }
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {
                
                objcon.Open();
                string concatena = Convert.ToString(txtbuscar.Text);
                string select = string.Concat("select * from ingredientes where id like '" + concatena + "'");
                MySqlCommand objcmd = new MySqlCommand(select, objcon);

                objcmd.CommandType = CommandType.Text;

                MySqlDataReader reader;
                reader = objcmd.ExecuteReader();
                reader.Read();

                txtid.Text = reader.GetString(0);
                txtnome.Text = reader.GetString(1);
                atualiza1();
                reader.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Não foi possivel Buscar ");
            }
            finally
            {
                objcon.Close();
            }
        }

        private void Txtupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {
                
                objcon.Open();
                string concatena = Convert.ToString(txtid.Text);
                string concatenanome = Convert.ToString(txtnome.Text);
                string select = string.Concat("update ingredientes set nome = '" + concatenanome + "' where id = '" + concatena + "'");
                MySqlCommand objcmd = new MySqlCommand(select, objcon);
                objcmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Alterado com sucesso");
                txtid.Text = "";
                txtnome.Text = "";
                txtbuscar.Text = "";
                txtbuscar.Focus();
                atualiza1();
                
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Falha ao Alterar ingrediente " + erro);
            }
            finally
            {
                objcon.Close();
            }
        }

        private void Gridingredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
