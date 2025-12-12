namespace ResponsiJunpro
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
            groupBox1 = new GroupBox();
            dropKontrak = new ComboBox();
            dropProyek = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbDev = new TextBox();
            lblNama = new Label();
            btnInsert = new Button();
            label2 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvTim = new DataGridView();
            groupBox2 = new GroupBox();
            tbBug = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbFitur = new TextBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTim).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dropKontrak);
            groupBox1.Controls.Add(dropProyek);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbDev);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // dropKontrak
            // 
            dropKontrak.Font = new Font("Segoe UI", 9F);
            dropKontrak.FormattingEnabled = true;
            dropKontrak.Location = new Point(123, 71);
            dropKontrak.Name = "dropKontrak";
            dropKontrak.Size = new Size(175, 23);
            dropKontrak.TabIndex = 10;
            // 
            // dropProyek
            // 
            dropProyek.Font = new Font("Segoe UI", 9F);
            dropProyek.FormattingEnabled = true;
            dropProyek.Location = new Point(123, 44);
            dropProyek.Name = "dropProyek";
            dropProyek.Size = new Size(175, 23);
            dropProyek.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(6, 75);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 6;
            label5.Text = "Status Kontrak :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 5;
            label4.Text = "Pilih Proyek :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Nama Developer :";
            // 
            // tbDev
            // 
            tbDev.Font = new Font("Segoe UI", 9F);
            tbDev.Location = new Point(123, 18);
            tbDev.Name = "tbDev";
            tbDev.Size = new Size(175, 23);
            tbDev.TabIndex = 2;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(206, 9);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(104, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "[App Title]";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(10, 261);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(157, 32);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += this.btnInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(135, 37);
            label2.Name = "label2";
            label2.Size = new Size(234, 19);
            label2.TabIndex = 3;
            label2.Text = "Developer Team Performance Tracker";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(186, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 32);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += this.btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(366, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 32);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += this.btnDelete_Click;
            // 
            // dgvTim
            // 
            dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTim.Location = new Point(6, 22);
            dgvTim.Name = "dgvTim";
            dgvTim.Size = new Size(501, 129);
            dgvTim.TabIndex = 6;
            dgvTim.CellContentClick += dgvTim_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbBug);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbFitur);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 74);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA DEVELOPER";
            // 
            // tbBug
            // 
            tbBug.Font = new Font("Segoe UI", 9F);
            tbBug.Location = new Point(123, 42);
            tbBug.Name = "tbBug";
            tbBug.Size = new Size(98, 23);
            tbBug.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(244, 46);
            label6.Name = "label6";
            label6.Size = new Size(153, 15);
            label6.TabIndex = 7;
            label6.Text = "(Jumlah bug yg ditemukan)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(244, 18);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 6;
            label1.Text = "(Jumlah fitur yg dikerjakan)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(6, 46);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 5;
            label7.Text = "Jumlah Bug :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 4;
            label8.Text = "Fitur Selesai :";
            // 
            // tbFitur
            // 
            tbFitur.Font = new Font("Segoe UI", 9F);
            tbFitur.Location = new Point(123, 13);
            tbFitur.Name = "tbFitur";
            tbFitur.Size = new Size(98, 23);
            tbFitur.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvTim);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 304);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 157);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "DATA PERFORMA TIM";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 47);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 470);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblNama);
            Controls.Add(label2);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTim).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnInsert;
        private TextBox tbDev;
        private Label lblNama;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvTim;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private TextBox tbFitur;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox tbBug;
        private Label label6;
        private ComboBox dropKontrak;
        private ComboBox dropProyek;
        private PictureBox pictureBox1;
    }
}
