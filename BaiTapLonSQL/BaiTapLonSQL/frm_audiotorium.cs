using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonSQL
{
    public partial class frm_audiotorium : Form
    {
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_audiotorium()
        {
            InitializeComponent();
        }

        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("Select * from auditorium");
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            String sql = "insert into auditorium values(N'" + txt_nameaudio.Text + "',N'" + txt_status.Text + "',N'" + txt_theater.Text + "',N'" + txt_audiotorium.Text + "',N'" + txt_width.Text + "',N'" + txt_height.Text + "')";
            query.CapNhatDuLieu(sql);
            fill();
            txt_ID_audio.Text = "";
            txt_nameaudio.Text = "";
            txt_status.Text = "";
            txt_theater.Text = "";
            txt_audiotorium.Text = "";
            txt_width.Text = "";
            txt_height.Text = "";
        }

        private void Frm_audiotorium_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update auditorium set name=N'" + txt_nameaudio.Text + "',status=N'" + txt_status.Text + "',FK_theater_id=N'" + txt_theater.Text + "',FK_theater_type_id=N'" + txt_audiotorium.Text + "',width=N'" + txt_width.Text + "',height=N'" + txt_height.Text + "'where PK_id=N'" + txt_ID_audio.Text + "'";
            query.CapNhatDuLieu(sql);
            fill();
            txt_ID_audio.Text = "";
            txt_nameaudio.Text = "";
            txt_status.Text = "";
            txt_theater.Text = "";
            txt_audiotorium.Text = "";
            txt_width.Text = "";
            txt_height.Text = "";
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_ID_audio.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nameaudio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_status.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_theater.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_audiotorium.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_width.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_height.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string sql = "delete from auditorium where PK_id = N'" + txt_ID_audio.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                txt_ID_audio.Text = "";
                txt_nameaudio.Text = "";
                txt_status.Text = "";
                txt_theater.Text = "";
                txt_audiotorium.Text = "";
                txt_width.Text = "";
                txt_height.Text = "";
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
