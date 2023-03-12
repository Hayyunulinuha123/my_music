
namespace my_music
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.tb_penyanyi = new System.Windows.Forms.TextBox();
            this.tb_judul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(753, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 83);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyMusic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_genre);
            this.panel2.Controls.Add(this.tb_penyanyi);
            this.panel2.Controls.Add(this.tb_judul);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 339);
            this.panel2.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(336, 80);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(423, 31);
            this.tb_id.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Id";
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(336, 258);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(423, 31);
            this.tb_genre.TabIndex = 6;
            // 
            // tb_penyanyi
            // 
            this.tb_penyanyi.Location = new System.Drawing.Point(336, 199);
            this.tb_penyanyi.Name = "tb_penyanyi";
            this.tb_penyanyi.Size = new System.Drawing.Size(423, 31);
            this.tb_penyanyi.TabIndex = 5;
            // 
            // tb_judul
            // 
            this.tb_judul.Location = new System.Drawing.Point(336, 140);
            this.tb_judul.Name = "tb_judul";
            this.tb_judul.Size = new System.Drawing.Size(423, 31);
            this.tb_judul.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Penyanyi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Judul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "| Formulir Music";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.tb_search);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(30, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 354);
            this.panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(27, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "List Music";
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_tambah.ForeColor = System.Drawing.Color.Black;
            this.btn_tambah.Location = new System.Drawing.Point(41, 51);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(132, 34);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btn_simpan);
            this.panel4.Controls.Add(this.btn_tambah);
            this.panel4.Location = new System.Drawing.Point(30, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 339);
            this.panel4.TabIndex = 8;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_simpan.ForeColor = System.Drawing.Color.Black;
            this.btn_simpan.Location = new System.Drawing.Point(41, 115);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(132, 34);
            this.btn_simpan.TabIndex = 8;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(103, 63);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(677, 31);
            this.tb_search.TabIndex = 9;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 857);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.TextBox tb_penyanyi;
        private System.Windows.Forms.TextBox tb_judul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.TextBox tb_search;
    }
}

