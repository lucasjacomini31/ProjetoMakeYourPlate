namespace Projeto_faculdade_melhorado
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PainelTopo = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btningred = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painelcentro = new System.Windows.Forms.Panel();
            this.timeroculta = new System.Windows.Forms.Timer(this.components);
            this.timermostrar = new System.Windows.Forms.Timer(this.components);
            this.PainelTopo.SuspendLayout();
            this.PainelMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelTopo
            // 
            this.PainelTopo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PainelTopo.Controls.Add(this.btnminimizar);
            this.PainelTopo.Controls.Add(this.btnfechar);
            this.PainelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelTopo.Location = new System.Drawing.Point(0, 0);
            this.PainelTopo.Name = "PainelTopo";
            this.PainelTopo.Size = new System.Drawing.Size(1100, 40);
            this.PainelTopo.TabIndex = 0;
            this.PainelTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.PainelTopo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form1_MouseMove);
            this.PainelTopo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form1_MouseUP);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Image = global::Projeto_faculdade_melhorado.Properties.Resources.Icono_Minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(1015, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(40, 40);
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Click += new System.EventHandler(this.Btnminimizar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Image = global::Projeto_faculdade_melhorado.Properties.Resources.Icono_cerrar_FN;
            this.btnfechar.Location = new System.Drawing.Point(1057, 0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(40, 40);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.Btnfechar_Click);
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.PainelMenu.Controls.Add(this.panel5);
            this.PainelMenu.Controls.Add(this.panel3);
            this.PainelMenu.Controls.Add(this.panel1);
            this.PainelMenu.Controls.Add(this.button1);
            this.PainelMenu.Controls.Add(this.btningred);
            this.PainelMenu.Controls.Add(this.pictureBox2);
            this.PainelMenu.Controls.Add(this.pictureBox1);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 40);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(220, 540);
            this.PainelMenu.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(0, 253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 106);
            this.panel5.TabIndex = 7;
            this.panel5.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "     Ingredientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pratos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 52);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 52);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 52);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 52);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Image = global::Projeto_faculdade_melhorado.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pratos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btningred
            // 
            this.btningred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningred.FlatAppearance.BorderSize = 0;
            this.btningred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btningred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btningred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningred.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btningred.Image = global::Projeto_faculdade_melhorado.Properties.Resources.ingrediente1;
            this.btningred.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningred.Location = new System.Drawing.Point(0, 203);
            this.btningred.Name = "btningred";
            this.btningred.Size = new System.Drawing.Size(220, 50);
            this.btningred.TabIndex = 2;
            this.btningred.Text = "      Cadastros";
            this.btningred.UseVisualStyleBackColor = true;
            this.btningred.Click += new System.EventHandler(this.Btningred_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_faculdade_melhorado.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Projeto_faculdade_melhorado.Properties.Resources.Mobile_Menu_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(164, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // painelcentro
            // 
            this.painelcentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelcentro.Cursor = System.Windows.Forms.Cursors.Default;
            this.painelcentro.Location = new System.Drawing.Point(220, 40);
            this.painelcentro.Name = "painelcentro";
            this.painelcentro.Size = new System.Drawing.Size(880, 540);
            this.painelcentro.TabIndex = 2;
            // 
            // timeroculta
            // 
            this.timeroculta.Interval = 10;
            this.timeroculta.Tick += new System.EventHandler(this.Timeroculta_Tick);
            // 
            // timermostrar
            // 
            this.timermostrar.Interval = 10;
            this.timermostrar.Tick += new System.EventHandler(this.Timermostrar_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.painelcentro);
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.PainelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PainelTopo.ResumeLayout(false);
            this.PainelMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelTopo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Panel painelcentro;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timeroculta;
        private System.Windows.Forms.Timer timermostrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btningred;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

