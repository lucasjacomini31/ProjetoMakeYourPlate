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
    
    public partial class CadPratos : Form
    {
        metodos objmetodo = new metodos();
        


        public CadPratos()
        {
            InitializeComponent();
            

        }

        void limpar()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtpreco.Text = "";
            txtdescri.Text = "";
            txtbuscar.Text = "";
            txtcomputador.Text = "";
            txtbuscar.Focus();
        }


        private void Btninserir_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {

                byte[] imagembyte = null;
                FileStream fstream = new FileStream(txtcomputador.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagembyte = br.ReadBytes((int)fstream.Length);
                
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("insert into pratos (id , nome, preco, modopreparo,imagem) values (null,?,?,?,?) ", objcon);

                objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 20).Value = txtnome.Text;
                objcmd.Parameters.Add("@preco", MySqlDbType.Float).Value = txtpreco.Text;
                objcmd.Parameters.Add("@modopreparo", MySqlDbType.VarChar, 4000).Value = txtdescri.Text;
                objcmd.Parameters.Add("@imagem", MySqlDbType.LongBlob).Value = imagembyte;

                objcmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro de ingrediente concluido com sucesso!!!!");
                limpar();
                atualiza();
                
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Falha ao cadastrar ingrediente " + erro);
            }
            finally
            {
                objcon.Close();
            }
        }

        private void Gridpratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void atualiza()
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {
                
                objcon.Open();
                MySqlCommand objcmd = new MySqlCommand("", objcon);

                
                DataTable dtTabelas = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from pratos ", objcon);
                da.Fill(dtTabelas);
                Gridingredientes.DataSource = dtTabelas;
                Gridingredientes.Sort(Gridingredientes.Columns["nome"], ListSortDirection.Ascending);

                Gridingredientes.Columns[0].HeaderText = "ID"; // definir o nome da coluna
                Gridingredientes.Columns[0].Width = 40; // definir o tamanho da coluna                
                Gridingredientes.Columns[1].HeaderText = "PRATO"; // definir o nome da coluna
                Gridingredientes.Columns[1].Width = 100; // definir o tamanho da coluna
                Gridingredientes.Columns[2].HeaderText = "PREÇO"; // definir o nome da coluna
                Gridingredientes.Columns[2].Width = 50; // definir o tamanho da coluna                
                Gridingredientes.Columns[3].HeaderText = "INGREDIENTES CONTIDOS NO PRATO"; // definir o nome da coluna
                Gridingredientes.Columns[3].Width = 250; // definir o tamanho da coluna


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
        private void Btnatualiza_Click(object sender, EventArgs e)
        {
            atualiza();
        }

        private void atualiza(object sender, EventArgs e)
        {

            atualiza();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btncomputador_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string foto = ofd.FileName.ToString();
                txtcomputador.Text = foto;
                
                
            }



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
                    string select = string.Concat("delete from pratos where id = '" + concatena + "' limit 1");
                    MySqlCommand objcmd = new MySqlCommand(select, objcon);
                    objcmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Deletado com sucesso");
                    limpar();
                    atualiza();
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

        private void Txtupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {
                
                objcon.Open();
                string concatena = Convert.ToString(txtid.Text);
                string concatenanome = Convert.ToString(txtnome.Text);
                string concatenapreco = Convert.ToString(txtpreco.Text);
                string concatenadesc = Convert.ToString(txtdescri.Text);
                string select = string.Concat("update pratos set nome = '" + concatenanome + "' , preco ='"+ concatenapreco +"', modopreparo = '"+concatenadesc+"' where id = '" + concatena + "'");
                MySqlCommand objcmd = new MySqlCommand(select, objcon);
                objcmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Alterado com sucesso");
                limpar();
                atualiza();

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

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection(objmetodo.conectaBD());
            try
            {

                objcon.Open();
                string concatena = Convert.ToString(txtbuscar.Text);
                string select = string.Concat("select * from pratos where id like '" + concatena + "'");
                MySqlCommand objcmd = new MySqlCommand(select, objcon);

                objcmd.CommandType = CommandType.Text;

                MySqlDataReader reader;
                reader = objcmd.ExecuteReader();
                reader.Read();

                txtid.Text = reader.GetString(0);
                txtnome.Text = reader.GetString(1);
                txtpreco.Text = reader.GetString(2);
                txtdescri.Text = reader.GetString(3);
                atualiza();
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
    }
}
