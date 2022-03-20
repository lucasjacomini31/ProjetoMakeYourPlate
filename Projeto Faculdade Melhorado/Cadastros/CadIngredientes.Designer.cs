namespace Projeto_faculdade_melhorado
{
    partial class CadIngredientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Gridingredientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Gridingredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // txtid
            // 
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(68, 222);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(278, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(68, 278);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(278, 20);
            this.txtnome.TabIndex = 3;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(271, 304);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 23);
            this.btninserir.TabIndex = 6;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.Btninserir_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastro de Ingredientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(68, 174);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(200, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pesquisar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btndel
            // 
            this.btndel.Enabled = false;
            this.btndel.Location = new System.Drawing.Point(172, 304);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 5;
            this.btndel.Text = "Apagar";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.Btndel_Click);
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(68, 304);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(75, 23);
            this.txtupdate.TabIndex = 4;
            this.txtupdate.Text = "Alterar";
            this.txtupdate.UseVisualStyleBackColor = true;
            this.txtupdate.Click += new System.EventHandler(this.Txtupdate_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ingredientes cadastrados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gridingredientes
            // 
            this.Gridingredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridingredientes.Location = new System.Drawing.Point(435, 99);
            this.Gridingredientes.Name = "Gridingredientes";
            this.Gridingredientes.Size = new System.Drawing.Size(364, 395);
            this.Gridingredientes.TabIndex = 7;
            // 
            // CadIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gridingredientes);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadIngredientes";
            this.Text = "CadIngredientes";
            ((System.ComponentModel.ISupportInitialize)(this.Gridingredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button txtupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Gridingredientes;
    }
}