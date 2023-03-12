using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Session;
using MySql.Data.MySqlClient;

namespace my_music
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = Connections.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE data_music SET id = @id := (@id+1); " +
                "ALTER TABLE data_music AUTO_INCREMENT = 1;");

            script.Execute();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();

        }
        public DataTable getDataMusic()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_music", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataMusic();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            dataGridView1.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            dataGridView1.Columns.Add(colDelete);
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO data_music(judul, penyanyi, genre) VALUE(@judul, @penyanyi, @genre)";
                cmd.Parameters.AddWithValue("@judul", tb_judul.Text);
                cmd.Parameters.AddWithValue("@penyanyi", tb_penyanyi.Text);
                cmd.Parameters.AddWithValue("@genre", tb_genre.Text);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
                tb_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
                tb_judul.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                tb_penyanyi.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                tb_genre.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();

                tb_judul.Enabled = true;
                tb_penyanyi.Enabled = true;
                tb_genre.Enabled = true;
                btn_simpan.Enabled = true;
            }
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;

                try
                {
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM data_music WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");
                    resetIncrement();
                    koneksi.Close();

                    dataGridView1.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE data_music SET judul = @judul, penyanyi = @penyanyi, genre = @genre WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@judul", tb_judul.Text);
                cmd.Parameters.AddWithValue("@penyanyi", tb_penyanyi.Text);
                cmd.Parameters.AddWithValue("@genre", tb_genre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah");
                koneksi.Close();

                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM data_music WHERE CONCAT(judul, penyanyi, genre) LIKE  '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }
    }
}
