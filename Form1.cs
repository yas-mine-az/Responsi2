using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Responsi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5434; Username=postgres; Password=postgres; Database=Responsi2";
    
        public DataTable df;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        public

        private void Form1_Load_1(object sender, EventArgs e) => conn = new NpgsqlConnection(connstring);

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dropdownDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
          try
            {
                conn.Open();
                sql = @"select * from st_insert(:_name, :_depname)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", tbNama.Text);
                cmd.Parameters.AddWithValue("_depname", dropdownDep.Text);
                if((int)cmd.ExecuteString()==1)
                {
                    MessageBox.Show("Data Users berhasil diinputkan", "Yey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" +  ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv.Rows[e.RowIndex];
                tbNama = r.Cells["_name"].Value.ToString();
                dropdownDep = r.Cells["_depname"].Value.ToString() ;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data" + r.Cells["_name"],Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

            }
        }

        private void tabeldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
