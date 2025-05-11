namespace WFnobel
{
    partial class Nobel
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
            dgwPrikaz = new DataGridView();
            btnIsci = new Button();
            label1 = new Label();
            label2 = new Label();
            cbLeta = new ComboBox();
            cbPodrocja = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwPrikaz).BeginInit();
            SuspendLayout();
            // 
            // dgwPrikaz
            // 
            dgwPrikaz.BackgroundColor = SystemColors.Control;
            dgwPrikaz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPrikaz.Location = new Point(43, 51);
            dgwPrikaz.Name = "dgwPrikaz";
            dgwPrikaz.Size = new Size(325, 378);
            dgwPrikaz.TabIndex = 0;
            // 
            // btnIsci
            // 
            btnIsci.Location = new Point(410, 325);
            btnIsci.Name = "btnIsci";
            btnIsci.Size = new Size(97, 37);
            btnIsci.TabIndex = 1;
            btnIsci.Text = "Išči";
            btnIsci.UseVisualStyleBackColor = true;
            btnIsci.Click += btnIsci_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 172);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Izberi leto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 241);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Izberi področje:";
            // 
            // cbLeta
            // 
            cbLeta.FormattingEnabled = true;
            cbLeta.Location = new Point(408, 191);
            cbLeta.Name = "cbLeta";
            cbLeta.Size = new Size(90, 23);
            cbLeta.TabIndex = 6;
            // 
            // cbPodrocja
            // 
            cbPodrocja.FormattingEnabled = true;
            cbPodrocja.Location = new Point(410, 259);
            cbPodrocja.Name = "cbPodrocja";
            cbPodrocja.Size = new Size(86, 23);
            cbPodrocja.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(377, 37);
            label3.Name = "label3";
            label3.Size = new Size(266, 65);
            label3.TabIndex = 8;
            label3.Text = "NOBELOVI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(423, 102);
            label4.Name = "label4";
            label4.Size = new Size(255, 50);
            label4.TabIndex = 9;
            label4.Text = "NAGRAJENCI";
            // 
            // Nobel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbPodrocja);
            Controls.Add(cbLeta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIsci);
            Controls.Add(dgwPrikaz);
            Name = "Nobel";
            Text = "N O B E L";
            ((System.ComponentModel.ISupportInitialize)dgwPrikaz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwPrikaz;
        private Button btnIsci;
        private Label label1;
        private Label label2;
        private ComboBox cbLeta;
        private ComboBox cbPodrocja;
        private Label label3;
        private Label label4;
    }
}
