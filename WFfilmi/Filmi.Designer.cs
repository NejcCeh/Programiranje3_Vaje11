namespace WFfilmi
{
    partial class Filmi
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
            btnPrikazFilmov = new Button();
            dgwPrikaz = new DataGridView();
            label1 = new Label();
            tbOcena = new TextBox();
            btnIsci = new Button();
            label2 = new Label();
            tbNaslov = new TextBox();
            btnIsciNaslov = new Button();
            label3 = new Label();
            tbReziser = new TextBox();
            btnReziser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwPrikaz).BeginInit();
            SuspendLayout();
            // 
            // btnPrikazFilmov
            // 
            btnPrikazFilmov.Location = new Point(30, 34);
            btnPrikazFilmov.Name = "btnPrikazFilmov";
            btnPrikazFilmov.Size = new Size(121, 36);
            btnPrikazFilmov.TabIndex = 0;
            btnPrikazFilmov.Text = "Prikaži vse filme";
            btnPrikazFilmov.UseVisualStyleBackColor = true;
            btnPrikazFilmov.Click += btnPrikazFilmov_Click;
            // 
            // dgwPrikaz
            // 
            dgwPrikaz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwPrikaz.BackgroundColor = SystemColors.Control;
            dgwPrikaz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPrikaz.Location = new Point(305, 20);
            dgwPrikaz.Name = "dgwPrikaz";
            dgwPrikaz.Size = new Size(470, 406);
            dgwPrikaz.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 97);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Najnižja ocena filma:";
            // 
            // tbOcena
            // 
            tbOcena.Location = new Point(156, 94);
            tbOcena.Name = "tbOcena";
            tbOcena.Size = new Size(52, 23);
            tbOcena.TabIndex = 3;
            // 
            // btnIsci
            // 
            btnIsci.Location = new Point(33, 128);
            btnIsci.Name = "btnIsci";
            btnIsci.Size = new Size(78, 28);
            btnIsci.TabIndex = 4;
            btnIsci.Text = "Išči";
            btnIsci.UseVisualStyleBackColor = true;
            btnIsci.Click += btnOcena_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 194);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Naslov filma:";
            // 
            // tbNaslov
            // 
            tbNaslov.Location = new Point(131, 188);
            tbNaslov.Name = "tbNaslov";
            tbNaslov.Size = new Size(141, 23);
            tbNaslov.TabIndex = 6;
            // 
            // btnIsciNaslov
            // 
            btnIsciNaslov.Location = new Point(33, 224);
            btnIsciNaslov.Name = "btnIsciNaslov";
            btnIsciNaslov.Size = new Size(78, 28);
            btnIsciNaslov.TabIndex = 7;
            btnIsciNaslov.Text = "Išči";
            btnIsciNaslov.UseVisualStyleBackColor = true;
            btnIsciNaslov.Click += btnIsciNaslov_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 288);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Izberi režiserja:";
            // 
            // tbReziser
            // 
            tbReziser.Location = new Point(131, 285);
            tbReziser.Name = "tbReziser";
            tbReziser.Size = new Size(141, 23);
            tbReziser.TabIndex = 9;
            // 
            // btnReziser
            // 
            btnReziser.Location = new Point(33, 329);
            btnReziser.Name = "btnReziser";
            btnReziser.Size = new Size(78, 28);
            btnReziser.TabIndex = 10;
            btnReziser.Text = "Išči";
            btnReziser.UseVisualStyleBackColor = true;
            btnReziser.Click += btnReziser_Click;
            // 
            // Filmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 435);
            Controls.Add(btnReziser);
            Controls.Add(tbReziser);
            Controls.Add(label3);
            Controls.Add(btnIsciNaslov);
            Controls.Add(tbNaslov);
            Controls.Add(label2);
            Controls.Add(btnIsci);
            Controls.Add(tbOcena);
            Controls.Add(label1);
            Controls.Add(dgwPrikaz);
            Controls.Add(btnPrikazFilmov);
            Name = "Filmi";
            Text = "F i l m i";
            ((System.ComponentModel.ISupportInitialize)dgwPrikaz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrikazFilmov;
        private DataGridView dgwPrikaz;
        private Label label1;
        private TextBox tbOcena;
        private Button btnIsci;
        private Label label2;
        private TextBox tbNaslov;
        private Button btnIsciNaslov;
        private Label label3;
        private TextBox tbReziser;
        private Button btnReziser;
    }
}
