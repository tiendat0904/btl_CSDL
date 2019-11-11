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
    public partial class frm_screening_details : Form
    {
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_screening_details()
        {
            InitializeComponent();
        }

        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("select * from screening_details");
        }


        private void Btn_add_Click(object sender, EventArgs e)
        {
            string sql = "insert into screening_details values(N'" + txt_screeningstrart.Text + "',N'" + txt_screeningend.Text + "',N'" + txt_movies_ID.Text + "',N'" + txt_audio_ID.Text + "')";
            query.CapNhatDuLieu(sql);
            fill();
            txt_idscreening.Text = "";
            txt_screeningstrart.Text = "";
            txt_screeningend.Text = "";
            txt_movies_ID.Text = "";
            txt_audio_ID.Text = "";
        }

        private void Frm_screening_details_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "delete from screening_details where PK_id=N'" + txt_idscreening.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                txt_idscreening.Text = "";
                txt_screeningstrart.Text = "";
                txt_screeningend.Text = "";
                txt_movies_ID.Text = "";
                txt_audio_ID.Text = "";
            }
        }

        private void Frm_screening_details_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_idscreening.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_screeningstrart.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_screeningend.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_movies_ID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_audio_ID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update screening_details set screening_start=N'" + txt_screeningstrart.Text + "',screnning_end=N'" + txt_screeningend.Text + "',FK_movie_id=N'" + txt_movies_ID.Text + "',FK_auditorium_id=N'" + txt_audio_ID.Text + "' where PK_id=N'" + txt_idscreening.Text + "'";
            query.CapNhatDuLieu(sql);
            fill();
            txt_idscreening.Text = "";
            txt_screeningstrart.Text = "";
            txt_screeningend.Text = "";
            txt_movies_ID.Text = "";
            txt_audio_ID.Text = "";
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
