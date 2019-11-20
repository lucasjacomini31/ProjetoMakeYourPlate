using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Projeto_faculdade_melhorado
{
    
    
    public partial class Form1 : Form
    {
        make formmake = new make();
        CadIngredientes forcad = new CadIngredientes();
        CadPratos forcadprato = new CadPratos();
        bool mover = false;
        Point posicao_inicial;
        

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void Timeroculta_Tick(object sender, EventArgs e)
        {
            if (PainelMenu.Width <= 60)
            {
                this.timeroculta.Enabled = false;
            }
            else
            {
                this.PainelMenu.Width = PainelMenu.Width - 20;
            }
        }

        private void Timermostrar_Tick(object sender, EventArgs e)
        {
            if (PainelMenu.Width >= 220)
            {
                this.timermostrar.Enabled = false;
            }
            else
            {
                this.PainelMenu.Width = PainelMenu.Width + 20;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (PainelMenu.Width == 220)
            {
                timeroculta.Enabled = true;
            }
            else if (PainelMenu.Width == 60)
            {
                timermostrar.Enabled = true;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            forcad.Visible = false;
            forcadprato.Visible = false;
            

            if (formmake.Visible == false)
            {

                formmake.TopLevel = false;
                formmake.Parent = painelcentro;
                painelcentro.Controls.Add(formmake);
                formmake.Visible = true;
                

            }
           



        }


        private void PainelTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }
        private void form1_MouseUP(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void PainelTopo_MouseUP(object sender, MouseEventArgs e)
        {
            
        }

        private void form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicial.X, novo.Y - posicao_inicial.Y);
            }
        }
        private void PainelTopo_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Btningred_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
            }
               
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            forcadprato.Visible = false;
            formmake.Visible = false;


            if (forcad.Visible == false)
            {
                forcad.TopLevel = false;
                forcad.Parent = painelcentro;
                painelcentro.Controls.Add(forcad);
                forcad.Visible = true;


            }
            


            


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            formmake.Visible = false;
            forcad.Visible = false;

            if (forcadprato.Visible == false)
            {
                forcadprato.TopLevel = false;
                forcadprato.Parent = painelcentro;
                painelcentro.Controls.Add(forcadprato);
                forcadprato.Visible = true;
                
            }
            
           
        }
    }
}
