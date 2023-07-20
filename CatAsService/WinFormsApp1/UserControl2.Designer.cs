namespace WinFormsApp1
{
    partial class UserControl2
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            listView1 = new ListView();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label6 = new Label();
            buttonExcluirFavorito = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Default;
            listView1.ForeColor = Color.Black;
            listView1.Location = new Point(224, 130);
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.Yes;
            listView1.Size = new Size(306, 366);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(0, 113);
            label1.Name = "label1";
            label1.Size = new Size(735, 2);
            label1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(677, 480);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 48);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 7);
            tableLayoutPanel1.Margin = new Padding(15, 3, 15, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(734, 100);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Font = new Font("Roboto Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(728, 20);
            label3.TabIndex = 11;
            label3.Text = "Aqui você encontrara os seus gatinhos favoritos. :3";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(728, 80);
            label6.TabIndex = 10;
            label6.Text = "Meus Favoritos";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonExcluirFavorito
            // 
            buttonExcluirFavorito.Location = new Point(428, 502);
            buttonExcluirFavorito.Name = "buttonExcluirFavorito";
            buttonExcluirFavorito.Size = new Size(102, 23);
            buttonExcluirFavorito.TabIndex = 13;
            buttonExcluirFavorito.Text = "Excluir Favoritos";
            buttonExcluirFavorito.UseVisualStyleBackColor = true;
            buttonExcluirFavorito.Click += buttonExcluirFavorito_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(347, 502);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 69);
            Controls.Add(btnRefresh);
            Controls.Add(buttonExcluirFavorito);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(tableLayoutPanel1);
            Name = "UserControl2";
            Size = new Size(734, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label6;
        private Button buttonExcluirFavorito;
        private Button btnRefresh;
    }
}
