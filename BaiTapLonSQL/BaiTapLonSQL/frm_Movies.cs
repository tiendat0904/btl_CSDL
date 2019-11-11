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
    public partial class frm_Movies : Form
    {
        ConnectAndQuery query = new ConnectAndQuery();
        public frm_Movies()
        {
            InitializeComponent();
        }

        private void fill()
        {
            dataGridView1.DataSource = query.DocBang("select * from movie");
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            String sql = "insert into movie values(N'" + txt_avtmovie.Text + "',N'" + txt_namemovie.Text + "',N'" + txt_directormovie.Text + "',N'" + txt_castmovie.Text + "',N'" + txt_ratedmovie.Text + "',N'" + txt_lengthmovie.Text + "',N'" + txt_languagemovie.Text + "',N'" + txt_genremovie.Text + "',N'" + txt_descriptmovie.Text + "',N'" + txt_statusmovie.Text + "',N'" + date_rele.Text + "')";
            query.CapNhatDuLieu(sql);
            fill();
            txt_avtmovie.Text = "";
            txt_namemovie.Text = "";
            txt_directormovie.Text = "";
            txt_castmovie.Text = "";
            txt_ratedmovie.Text = "";
            txt_lengthmovie.Text = "";
            txt_languagemovie.Text = "";
            txt_genremovie.Text = "";
            txt_descriptmovie.Text = "";
            txt_statusmovie.Text = "";

        }

        private void Frm_Movies_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string sql = "delete from movie where PK_id = N'" + txt_idmovie.Text + "'";
                query.CapNhatDuLieu(sql);
                fill();
                txt_avtmovie.Text = "";
                txt_namemovie.Text = "";
                txt_directormovie.Text = "";
                txt_castmovie.Text = "";
                txt_ratedmovie.Text = "";
                txt_lengthmovie.Text = "";
                txt_languagemovie.Text = "";
                txt_genremovie.Text = "";
                txt_descriptmovie.Text = "";
                txt_statusmovie.Text = "";
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_idmovie.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_avtmovie.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_namemovie.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_directormovie.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_castmovie.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_ratedmovie.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_lengthmovie.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_languagemovie.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_genremovie.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_descriptmovie.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_statusmovie.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            date_rele.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update movie set ava_url=N'" + txt_avtmovie.Text + "',name=N'" + txt_namemovie.Text + "',director=N'" + txt_directormovie.Text + "',cast=N'" + txt_castmovie.Text + "',rated=N'" + txt_ratedmovie.Text + "',length=N'" + txt_lengthmovie.Text + "',genre=N'"+txt_genremovie.Text+ "',description=N'"+txt_descriptmovie.Text+"',status=N'"+txt_statusmovie.Text+ "',released_date=N'"+date_rele.Text+"' where PK_id=N'"+txt_idmovie.Text+"'";
            query.CapNhatDuLieu(sql);
            fill();
            txt_avtmovie.Text = "";
            txt_namemovie.Text = "";
            txt_directormovie.Text = "";
            txt_castmovie.Text = "";
            txt_ratedmovie.Text = "";
            txt_lengthmovie.Text = "";
            txt_languagemovie.Text = "";
            txt_genremovie.Text = "";
            txt_descriptmovie.Text = "";
            txt_statusmovie.Text = "";
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
