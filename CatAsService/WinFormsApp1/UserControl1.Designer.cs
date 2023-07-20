namespace WinFormsApp1
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            buttonBuscar = new Button();
            buttonFavoritar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            comboBoxRaca = new ComboBox();
            labelTemperamento = new Label();
            labelOrigem = new Label();
            labelDescricao = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(530, 476);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(132, 48);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonFavoritar
            // 
            buttonFavoritar.Location = new Point(392, 476);
            buttonFavoritar.Name = "buttonFavoritar";
            buttonFavoritar.Size = new Size(132, 48);
            buttonFavoritar.TabIndex = 13;
            buttonFavoritar.Text = "Favoritar";
            buttonFavoritar.UseVisualStyleBackColor = true;
            buttonFavoritar.Click += buttonFavoritar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxRaca, 1, 0);
            tableLayoutPanel1.Controls.Add(labelTemperamento, 1, 1);
            tableLayoutPanel1.Controls.Add(labelOrigem, 1, 2);
            tableLayoutPanel1.Controls.Add(labelDescricao, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Location = new Point(199, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(373, 320);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoEllipsis = true;
            label9.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(3, 240);
            label9.Name = "label9";
            label9.Size = new Size(180, 80);
            label9.TabIndex = 12;
            label9.Text = "Descrição";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(3, 160);
            label8.Name = "label8";
            label8.Size = new Size(180, 80);
            label8.TabIndex = 11;
            label8.Text = "Origem";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(3, 80);
            label7.Name = "label7";
            label7.Size = new Size(180, 80);
            label7.TabIndex = 10;
            label7.Text = "Temperamento";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxRaca
            // 
            comboBoxRaca.FormattingEnabled = true;
            comboBoxRaca.Location = new Point(189, 32);
            comboBoxRaca.Margin = new Padding(3, 32, 3, 3);
            comboBoxRaca.Name = "comboBoxRaca";
            comboBoxRaca.Size = new Size(181, 23);
            comboBoxRaca.TabIndex = 4;
            // 
            // labelTemperamento
            // 
            labelTemperamento.AutoEllipsis = true;
            labelTemperamento.Font = new Font("Roboto Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemperamento.ForeColor = Color.WhiteSmoke;
            labelTemperamento.Location = new Point(189, 80);
            labelTemperamento.Name = "labelTemperamento";
            labelTemperamento.Size = new Size(181, 80);
            labelTemperamento.TabIndex = 6;
            labelTemperamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOrigem
            // 
            labelOrigem.AutoEllipsis = true;
            labelOrigem.Font = new Font("Roboto Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrigem.ForeColor = Color.WhiteSmoke;
            labelOrigem.Location = new Point(189, 160);
            labelOrigem.Name = "labelOrigem";
            labelOrigem.Size = new Size(181, 80);
            labelOrigem.TabIndex = 7;
            labelOrigem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoEllipsis = true;
            labelDescricao.Font = new Font("Roboto Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.ForeColor = Color.WhiteSmoke;
            labelDescricao.Location = new Point(189, 240);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(181, 80);
            labelDescricao.TabIndex = 8;
            labelDescricao.Text = " ";
            labelDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 80);
            label6.TabIndex = 9;
            label6.Text = "Raça do Gato";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(677, 476);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 48);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(29, 29, 69);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(710, 19);
            textBox1.TabIndex = 11;
            textBox1.Text = "Selecione abaixo as características do seu gatinho. Miau";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(324, 25);
            label2.TabIndex = 10;
            label2.Text = "Procure pelo seu gatinho ideal :3";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(0, 84);
            label1.Name = "label1";
            label1.Size = new Size(735, 2);
            label1.TabIndex = 8;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 66);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonFavoritar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(734, 534);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscar;
        private Button buttonFavoritar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox comboBoxRaca;
        private Label labelTemperamento;
        private Label labelOrigem;
        private Label labelDescricao;
        private Label label6;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
