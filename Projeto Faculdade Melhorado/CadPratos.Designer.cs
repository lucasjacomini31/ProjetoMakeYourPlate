namespace Projeto_faculdade_melhorado
{
    partial class CadPratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtcomputador = new System.Windows.Forms.TextBox();
            this.btncomputador = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Gridingredientes = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridingredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cadastro de Pratos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(276, 434);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 23);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.Btninserir_Click);
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(51, 128);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(175, 20);
            this.txtnome.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(51, 89);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(175, 20);
            this.txtid.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(51, 166);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(175, 20);
            this.txtpreco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preço estimado";
            // 
            // txtdescri
            // 
            this.txtdescri.Location = new System.Drawing.Point(51, 261);
            this.txtdescri.Multiline = true;
            this.txtdescri.Name = "txtdescri";
            this.txtdescri.Size = new System.Drawing.Size(300, 167);
            this.txtdescri.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 235);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingredientes contidos no prato";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 53);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtupdate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtpreco);
            this.panel2.Controls.Add(this.btndel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtcomputador);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btncomputador);
            this.panel2.Controls.Add(this.txtnome);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.txtdescri);
            this.panel2.Controls.Add(this.btninserir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 487);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pesquisar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(51, 51);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(175, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(53, 434);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(75, 23);
            this.txtupdate.TabIndex = 6;
            this.txtupdate.Text = "Alterar";
            this.txtupdate.UseVisualStyleBackColor = true;
            this.txtupdate.Click += new System.EventHandler(this.Txtupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Enabled = false;
            this.btndel.Location = new System.Drawing.Point(160, 434);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "Apagar";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.Btndel_Click);
            // 
            // txtcomputador
            // 
            this.txtcomputador.Location = new System.Drawing.Point(51, 198);
            this.txtcomputador.Name = "txtcomputador";
            this.txtcomputador.Size = new System.Drawing.Size(175, 20);
            this.txtcomputador.TabIndex = 20;
            // 
            // btncomputador
            // 
            this.btncomputador.Location = new System.Drawing.Point(235, 193);
            this.btncomputador.Name = "btncomputador";
            this.btncomputador.Size = new System.Drawing.Size(116, 28);
            this.btncomputador.TabIndex = 20;
            this.btncomputador.Text = "Procurar Imagem";
            this.btncomputador.UseVisualStyleBackColor = true;
            this.btncomputador.Click += new System.EventHandler(this.Btncomputador_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Gridingredientes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(401, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 487);
            this.panel3.TabIndex = 19;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ingredientes cadastrados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gridingredientes
            // 
            this.Gridingredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridingredientes.Location = new System.Drawing.Point(27, 65);
            this.Gridingredientes.Name = "Gridingredientes";
            this.Gridingredientes.Size = new System.Drawing.Size(440, 410);
            this.Gridingredientes.TabIndex = 9;
            this.Gridingredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridpratos_CellContentClick);
            // 
            // CadPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadPratos";
            this.Text = "CadPratos";
            this.Load += new System.EventHandler(this.atualiza);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridingredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Gridingredientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncomputador;
        private System.Windows.Forms.TextBox txtcomputador;
        private System.Windows.Forms.Button txtupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}