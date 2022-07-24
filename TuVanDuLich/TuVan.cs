using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TuVanDuLich
{
    public partial class TuVan : Form
    {
        public TuVan()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;

                if ((cbxKH.Text == "") && (cbxDD.Text == "") &&
                   (cbxTG.Text == "") && (cbxGia.Text == ""))
                {
                    MessageBox.Show("Bạn hãy nhập một điều kiện !!!", "Yêu cầu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql = "Select [Tên],[Nơi khởi hành],[Điểm đến],[Thời gian],[Giá] From DuLich WHERE 1=1 ";
                if (cbxKH.Text != "")
                    sql = sql + " AND [Nơi khởi hành] Like N'%" + cbxKH.Text + "%'";
                if (cbxDD.Text != "")
                    sql = sql + " AND [Tên] Like N'%" + cbxDD.Text + "%'";
                if (cbxTG.Text != "")
                    sql = sql + " AND [Thời gian] Like N'%" + cbxTG.Text + "%'";
                    
                
          
                if (cbxGia.Text == "Thấp")
                    sql = sql + " AND [Giá] < 1000000";
                if (cbxGia.Text == "Trung bình")
                    sql = sql + " AND [Giá]>=1000000 and [Giá] < 6000000 ";            
                if (cbxGia.Text == "Cao")
                    sql = sql + " AND [Giá]>=6000000 ";
                hienthi(sql, dgvHT);
                if (dgvHT.Rows.Count == 1)
                {
                    link.Text = "";
                    MessageBox.Show("Không tìm thấy sự lựa chọn nào thích hợp!!", "Thông báo", MessageBoxButtons.OK);
                    lsHT.Items.Clear();
                    lsHT.Items.Add("");
                    lsHT.Items.Add("");
                    lsHT.Items.Add(" Không tìm thấy sự lựa chọn nào thích hợp !");
                    lsHT.Items.Add("");
                    lsHT.Items.Add("");
                    lsHT.Items.Add("");
                    lsHT.Items.Add("");
                    lsHT.Items.Add("");
                    //lsHT.Items.Add("");
                    //lsHT.Items.Add("");
                    lsHT.Items.Add("");
                    lsHT.Items.Add("");

                    lsHT.Items.Add(" Bạn có thể tham khảo 1 số lựa chọn khác bên dưới !");
                    string s = "Select [Tên],[Nơi khởi hành],[Điểm đến],[Thời gian],[Giá] From DuLich WHERE 1=1 ";
                    if (cbxKH.Text != "" && cbxDD.Text != ""& cbxTG.Text!="")
                        s = s + " AND [Nơi khởi hành] Like N'%" + cbxKH.Text + "%' AND ([Tên] Like N'%" + cbxDD.Text + "%' Or[Thời gian] Like N'%" + cbxTG.Text + "%') ";
                    if (cbxKH.Text != "" && cbxDD.Text != "" & cbxTG.Text == "")
                        s = s + " AND ([Nơi khởi hành] Like N'%" + cbxKH.Text + "%' Or [Tên] Like N'%" + cbxDD.Text + "%' ) ";
                    if (cbxKH.Text != "" && cbxDD.Text == "" & cbxTG.Text != "")
                        s = s + " AND ([Nơi khởi hành] Like N'%" + cbxKH.Text + "%'  Or[Thời gian] Like N'%" + cbxTG.Text + "%') ";
                    if (cbxKH.Text == "" && cbxDD.Text != "" & cbxTG.Text != "")
                        s = s + "AND ([Tên] Like N'%" + cbxDD.Text + "%' Or[Thời gian] Like N'%" + cbxTG.Text + "%') ";
                    hienthi(s, dgvHT);
                }
                else
                {
                    lsHT.Items.Clear();
                   /* if (cbxDD.Text == "Hạ Long")
                    {
                        pic.BackgroundImage = imageList1.Images[1];
                    }*/
                    if (cbxDD.Text == "Cần Thơ")
                    {
                        pic.BackgroundImage = imageList1.Images[2];
                    }
                    if (cbxDD.Text == "Cao Bằng")
                    {
                        pic.BackgroundImage = imageList1.Images[3];
                    }
                    if (cbxDD.Text == "Côn Đảo")
                    {
                        pic.BackgroundImage = imageList1.Images[4];
                    }
                    if (cbxDD.Text == "Đà Lạt")
                    {
                        pic.BackgroundImage = imageList1.Images[5];
                    }
                    if (cbxDD.Text == "Đà Nẵng")
                    {
                        pic.BackgroundImage = imageList1.Images[6];
                    }
                    if (cbxDD.Text == "Hạ Long")
                    {
                        pic.BackgroundImage = imageList1.Images[7];
                    }
                    if (cbxDD.Text == "Hội An")
                    {
                        pic.BackgroundImage = imageList1.Images[8];
                    }
                    if (cbxDD.Text == "Huế")
                    {
                        pic.BackgroundImage = imageList1.Images[9];
                    }
                    if (cbxDD.Text == "Mũi Né")
                    {
                        pic.BackgroundImage = imageList1.Images[9];
                    }
                    if (cbxDD.Text == "Nha Trang")
                    {
                        pic.BackgroundImage = imageList1.Images[10];
                    }
                    if (cbxDD.Text == "Ninh Bình")
                    {
                        pic.BackgroundImage = imageList1.Images[11];
                    }
                    if (cbxDD.Text == "Phong Nha")
                    {
                        pic.BackgroundImage = imageList1.Images[12];
                    }
                    if (cbxDD.Text == "Phú Quốc")
                    {
                        pic.BackgroundImage = imageList1.Images[13];
                    }
                    if (cbxDD.Text == "Quy Nhơn")
                    {
                        pic.BackgroundImage = imageList1.Images[14];
                    }
                    if (cbxDD.Text == "Sài Gòn")
                    {
                        pic.BackgroundImage = imageList1.Images[15];
                    }
                    if (cbxDD.Text == "Sapa")
                    {
                        pic.BackgroundImage = imageList1.Images[16];
                    }
                    if (cbxDD.Text == "Tuyên Quang")
                    {
                        pic.BackgroundImage = imageList1.Images[17];
                    }
                    if (cbxDD.Text == "Vũng Tàu")
                    {
                        pic.BackgroundImage = imageList1.Images[18];
                    }

          
                    lsHT.Items.Add("");
                    lsHT.Items.Add("KẾT QUẢ:");
                    lsHT.Items.Add(" " + dgvHT.Rows[0].Cells[0].Value.ToString());
                    lsHT.Items.Add("");
                    lsHT.Items.Add("\t\t       " + lbKH.Text + ": \t" + dgvHT.Rows[0].Cells[1].Value.ToString());
                    lsHT.Items.Add("\t\t       " + lbDD.Text + ": \t" + dgvHT.Rows[0].Cells[2].Value.ToString());
                    lsHT.Items.Add("\t\t       " + lbTG.Text + ": \t" + dgvHT.Rows[0].Cells[3].Value.ToString());
                    lsHT.Items.Add("\t\t       " + lbGia.Text + ": \t\t" + dgvHT.Rows[0].Cells[4].Value.ToString());
                    int i = Convert.ToInt32(dgvHT.Rows.Count) - 1;
                    MessageBox.Show("Bạn có thể tham khảo "+i+ " sự lựa chọn sau!", "Thông báo", MessageBoxButtons.OK);
                    link.Text = "Click xem thông tin chi tiết";
                    link.Links.Add(0, 6, "https://tour.dulichvietnam.com.vn/");
                }
            }
            catch (Exception) { }
        }

        private void pic_Click(object sender, EventArgs e)
        {
       
        }
        string ketnoi = "Data Source=DESKTOP-D17Q2JP;Initial Catalog=QLDulich;Integrated Security=True";// Đối tượng kết nối
        SqlConnection con = null;// Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter da = null;// Đối tượng hiển thị dữ liệu lên Form
        DataTable dt = null;

        private void hienthi(string a, DataGridView b)
        {
            // Khởi động kết nối
            con = new SqlConnection(ketnoi);// Vận chuyển dữ liệu lên DataTable dtTABLENAME
            con.Open();
            da = new SqlDataAdapter(a, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            b.DataSource = dt;
        }
        private void HienNKH()
        {
            cbxKH.Items.Clear();
            int t = 0,j;
            try//Hiện cbxKH
            {
                while (dgvHT.Rows[t].Cells[1].Value.ToString() != null)
                {
                    j = 0;
                    for (int i = 0; i <= t; i++)
                    {
                        if (j > 1) break;
                        {
                            if (dgvHT.Rows[i].Cells[1].Value.ToString() == dgvHT.Rows[t].Cells[1].Value.ToString())
                            {
                                j++;
                            }
                        }
                    }
                    if (j == 1) cbxKH.Items.Add(dgvHT.Rows[t].Cells[1].Value.ToString());
                    t++;
                }
            }
            catch (Exception) { }
        }
  
        private void HienDD()
        {
            cbxDD.Items.Clear();
            con.Open();
            string sql = @"Select DISTINCT [Nơi đến] From DuLich";
            SqlCommand t = new SqlCommand(sql, con);
            SqlDataReader docDL = t.ExecuteReader();
            int i = 0;
    
            while (docDL.Read()) {
                
                cbxDD.Items.Add(docDL[0].ToString());
                i++;
            }
            con.Close();
            
        }
        private void HienTG()
        {
            cbxTG.Items.Clear();
            con.Open();
            string sql = @"Select DISTINCT [Thời gian] From DuLich";
            SqlCommand t = new SqlCommand(sql, con);
            SqlDataReader docDL = t.ExecuteReader();
            int i = 0;

            while (docDL.Read())
            {

                cbxTG.Items.Add(docDL[0].ToString());
                i++;
            }
            con.Close();

        }
        
        string DL = "Select [Tên],[Nơi Khởi hành],[Điểm đến],[Thời Gian],[Giá] From DuLich";
        private void TuVan_Load(object sender, EventArgs e)
        {
            hienthi(DL, dgvHT);
            HienNKH();
            HienDD();
            HienTG();
            link.Text = "";
           
            
        }

        private void dataDL(object sender, EventArgs e)
        {
            lsHT.Items.Clear();
            int i = dgvHT.CurrentRow.Index;
            if (dgvHT.Rows[i].Cells[2].Value.ToString().Equals("Du lịch Hạ Long"))
            {
                pic.BackgroundImage = imageList1.Images[1];
            }

            lsHT.Items.Add("");
            lsHT.Items.Add("KẾT QUẢ:");
            lsHT.Items.Add(" "+dgvHT.Rows[i].Cells[0].Value.ToString());
            lsHT.Items.Add("");
            lsHT.Items.Add("\t\t       " + lbKH.Text + ": \t" + dgvHT.Rows[i].Cells[1].Value.ToString());
            lsHT.Items.Add("\t\t       " + lbDD.Text + ": \t" + dgvHT.Rows[i].Cells[2].Value.ToString());
            lsHT.Items.Add("\t\t       " + lbTG.Text + ": \t" + dgvHT.Rows[i].Cells[3].Value.ToString());
            lsHT.Items.Add("\t\t       " + lbGia.Text + ": \t\t" + dgvHT.Rows[i].Cells[4].Value.ToString());
            
        }

        private void cbxTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbxDD.ResetText();
            cbxGia.ResetText();
            cbxKH.ResetText();
            cbxTG.ResetText();
            hienthi(DL, dgvHT);
            HienNKH();
            HienDD();
            HienTG();
            lsHT.Items.Clear();
            link.Text = "";
        }
        
        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void cbxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            HTKH();
        }

        private void HTKH() {
            cbxDD.Items.Clear();
            con.Open();
            string sql = @"Select DISTINCT [Nơi đến] From DuLich where [Nơi khởi hành] Like  N'%" + cbxKH.Text + "%'";
            SqlCommand t = new SqlCommand(sql, con);
            SqlDataReader docDL = t.ExecuteReader();
            int i = 0;

            while (docDL.Read())
            {

                cbxDD.Items.Add(docDL[0].ToString());
                i++;
            }
            con.Close();
        }
        private void HTDD() {
        
            
            cbxTG.Items.Clear();
            con.Open();
            string s1 = @"Select DISTINCT [Thời gian] From DuLich where [Nơi khởi hành] Like  N'%" + cbxKH.Text + "%' And [Tên] Like N'%" + cbxDD.Text + "%'";
            SqlCommand t1 = new SqlCommand(s1, con);
            SqlDataReader docDL1 = t1.ExecuteReader();
            int i1 = 0;

            while (docDL1.Read())
            {
                cbxTG.Items.Add(docDL1[0].ToString());
                i1++;
            }
            con.Close();


        }
        private void cbxDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            HTDD();
        }

    }
}
