namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonMeusFavoritos = new Button();
            buttonBuscarRaca = new Button();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelMain = new Panel();
            controlBuscarRacas = new UserControl1();
            controlMeusFavoritos = new UserControl2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 47, 81);
            panel1.Controls.Add(buttonMeusFavoritos);
            panel1.Controls.Add(buttonBuscarRaca);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 67);
            panel1.TabIndex = 0;
            // 
            // buttonMeusFavoritos
            // 
            buttonMeusFavoritos.AutoEllipsis = true;
            buttonMeusFavoritos.BackColor = Color.Transparent;
            buttonMeusFavoritos.FlatAppearance.BorderSize = 0;
            buttonMeusFavoritos.FlatStyle = FlatStyle.Flat;
            buttonMeusFavoritos.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMeusFavoritos.ForeColor = Color.WhiteSmoke;
            buttonMeusFavoritos.Location = new Point(395, 3);
            buttonMeusFavoritos.Name = "buttonMeusFavoritos";
            buttonMeusFavoritos.Size = new Size(165, 67);
            buttonMeusFavoritos.TabIndex = 2;
            buttonMeusFavoritos.Text = "Meus Favoritos";
            buttonMeusFavoritos.UseVisualStyleBackColor = false;
            buttonMeusFavoritos.Click += buttonMeusFavoritos_Click;
            // 
            // buttonBuscarRaca
            // 
            buttonBuscarRaca.AutoEllipsis = true;
            buttonBuscarRaca.BackColor = Color.Transparent;
            buttonBuscarRaca.FlatAppearance.BorderSize = 0;
            buttonBuscarRaca.FlatStyle = FlatStyle.Flat;
            buttonBuscarRaca.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuscarRaca.ForeColor = Color.WhiteSmoke;
            buttonBuscarRaca.Location = new Point(224, 0);
            buttonBuscarRaca.Name = "buttonBuscarRaca";
            buttonBuscarRaca.Size = new Size(165, 67);
            buttonBuscarRaca.TabIndex = 1;
            buttonBuscarRaca.Text = "Buscar Raças";
            buttonBuscarRaca.UseVisualStyleBackColor = false;
            buttonBuscarRaca.Click += buttonBuscarRaca_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 46);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Roboto Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(68, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(150, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Cat As Service";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(162, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(416, 316);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(661, 58);
            label1.TabIndex = 2;
            label1.Text = "Bem-Vindo ao Cat As Service";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(controlMeusFavoritos);
            panelMain.Controls.Add(controlBuscarRacas);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(pictureBox2);
            panelMain.Location = new Point(0, 73);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(734, 534);
            panelMain.TabIndex = 3;
            // 
            // controlBuscarRacas
            // 
            controlBuscarRacas.BackColor = Color.FromArgb(29, 29, 66);
            controlBuscarRacas.Dock = DockStyle.Fill;
            controlBuscarRacas.Location = new Point(0, 0);
            controlBuscarRacas.Name = "controlBuscarRacas";
            controlBuscarRacas.Size = new Size(734, 534);
            controlBuscarRacas.TabIndex = 3;
            controlBuscarRacas.Visible = false;
            // 
            // controlMeusFavoritos
            // 
            controlMeusFavoritos.BackColor = Color.FromArgb(29, 29, 69);
            controlMeusFavoritos.Dock = DockStyle.Fill;
            controlMeusFavoritos.Location = new Point(0, 0);
            controlMeusFavoritos.Name = "controlMeusFavoritos";
            controlMeusFavoritos.Size = new Size(734, 534);
            controlMeusFavoritos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 66);
            ClientSize = new Size(734, 606);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTitle;
        private Button buttonBuscarRaca;
        private Button buttonMeusFavoritos;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panelMain;
        private UserControl1 controlBuscarRacas;
        private UserControl2 controlMeusFavoritos;
    }
}