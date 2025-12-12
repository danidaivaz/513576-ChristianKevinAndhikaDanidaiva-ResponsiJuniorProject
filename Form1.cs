using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        public string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
            LoadKontrakDropdown();
            LoadProyekDropdown();
            ClearFields();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                dgvTim.DataSource = null;
                sql = "SELECT * FROM developer";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvTim.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Data FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void LoadKontrakDropdown()
        {
            dropKontrak.Items.Clear();
            dropKontrak.Items.Add("Full Time");
            dropKontrak.Items.Add("Freelance");
            dropKontrak.SelectedIndex = 0;
        }

        private void LoadProyekDropdown()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                sql = "SELECT id_proyek, nama_proyek FROM proyek";
                cmd = new NpgsqlCommand(sql, conn);
                DataTable dtProyek = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dtProyek.Load(rd);

                dropProyek.DataSource = dtProyek;
                dropProyek.DisplayMember = "nama_proyek";
                dropProyek.ValueMember = "id_proyek";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM st_insert(:_id_proyek, :_nama_dev, :_status_kontrak, :_fitur_selesai, :_jumlah_bug)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_proyek", dropProyek.SelectedValue);
                cmd.Parameters.AddWithValue("_nama_dev", tbDev.Text);
                cmd.Parameters.AddWithValue("_status_kontrak", dropKontrak.Text);
                cmd.Parameters.AddWithValue("_fitur_selesai", int.Parse(tbFitur.Text));
                cmd.Parameters.AddWithValue("_jumlah_bug", int.Parse(tbBug.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbDev.Text = tbFitur.Text = tbBug.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Gagal insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = "SELECT * FROM st_update(:_id_dev, :_id_proyek, :_nama_dev, :_status_kontrak, :_fitur_selesai, :_jumlah_bug)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_dev", r.Cells["id_dev"].Value);
                cmd.Parameters.AddWithValue("_id_proyek", dropProyek.SelectedValue);
                cmd.Parameters.AddWithValue("_nama_dev", tbDev.Text);
                cmd.Parameters.AddWithValue("_status_kontrak", dropKontrak.Text);
                cmd.Parameters.AddWithValue("_fitur_selesai", int.Parse(tbFitur.Text));
                cmd.Parameters.AddWithValue("_jumlah_bug", int.Parse(tbBug.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Developer Berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    ClearFields();
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Hapus data " + r.Cells["nama_dev"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = "SELECT * FROM st_delete(:_id_dev)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_dev", r.Cells["id_dev"].Value);

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadData();
                        ClearFields();
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Gagal Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void ClearFields()
        {
            tbDev.Text = string.Empty;
            tbFitur.Text = string.Empty;
            tbBug.Text = string.Empty;
            dropProyek.SelectedIndex = -1;
            dropKontrak.SelectedIndex = 0;
        }

        private void dgvTim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvTim.Rows[e.RowIndex];
                tbDev.Text = r.Cells["nama_dev"].Value.ToString();
                dropProyek.SelectedValue = r.Cells["id_proyek"].Value;
                dropKontrak.Text = r.Cells["status_kontrak"].Value.ToString();
                tbFitur.Text = r.Cells["fitur_selesai"].Value.ToString();
                tbBug.Text = r.Cells["jumlah_bug"].Value.ToString();
            }
        }
    }
}
