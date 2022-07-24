namespace TuVanDuLich
{
    partial class TuVan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuVan));
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHT = new System.Windows.Forms.DataGridView();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.grTK = new System.Windows.Forms.GroupBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.cbxGia = new System.Windows.Forms.ComboBox();
            this.lbDD = new System.Windows.Forms.Label();
            this.cbxDD = new System.Windows.Forms.ComboBox();
            this.lbTG = new System.Windows.Forms.Label();
            this.cbxTG = new System.Windows.Forms.ComboBox();
            this.lbKH = new System.Windows.Forms.Label();
            this.grHT = new System.Windows.Forms.GroupBox();
            this.lsHT = new System.Windows.Forms.ListBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).BeginInit();
            this.grTK.SuspendLayout();
            this.grHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Silver;
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTim.Image = global::TuVanDuLich.Properties.Resources.Red_mark;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(204, 236);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 38);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvHT
            // 
            this.dgvHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHT.Location = new System.Drawing.Point(27, 34);
            this.dgvHT.Name = "dgvHT";
            this.dgvHT.Size = new System.Drawing.Size(957, 151);
            this.dgvHT.TabIndex = 1;
            this.dgvHT.Click += new System.EventHandler(this.dataDL);
            // 
            // cbxKH
            // 
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(111, 43);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(135, 24);
            this.cbxKH.TabIndex = 2;
            this.cbxKH.SelectedIndexChanged += new System.EventHandler(this.cbxKH_SelectedIndexChanged);
            // 
            // grTK
            // 
            this.grTK.BackColor = System.Drawing.Color.Transparent;
            this.grTK.Controls.Add(this.lbGia);
            this.grTK.Controls.Add(this.cbxGia);
            this.grTK.Controls.Add(this.lbDD);
            this.grTK.Controls.Add(this.cbxDD);
            this.grTK.Controls.Add(this.lbTG);
            this.grTK.Controls.Add(this.cbxTG);
            this.grTK.Controls.Add(this.lbKH);
            this.grTK.Controls.Add(this.cbxKH);
            this.grTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grTK.Location = new System.Drawing.Point(23, 30);
            this.grTK.Name = "grTK";
            this.grTK.Size = new System.Drawing.Size(527, 192);
            this.grTK.TabIndex = 4;
            this.grTK.TabStop = false;
            this.grTK.Text = "Thông tin tìm kiếm";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(286, 109);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(29, 16);
            this.lbGia.TabIndex = 7;
            this.lbGia.Text = "Giá";
            // 
            // cbxGia
            // 
            this.cbxGia.FormattingEnabled = true;
            this.cbxGia.Items.AddRange(new object[] {
            "Thấp",
            "Trung bình",
            "Cao"});
            this.cbxGia.Location = new System.Drawing.Point(359, 106);
            this.cbxGia.Name = "cbxGia";
            this.cbxGia.Size = new System.Drawing.Size(138, 24);
            this.cbxGia.TabIndex = 8;
            // 
            // lbDD
            // 
            this.lbDD.AutoSize = true;
            this.lbDD.Location = new System.Drawing.Point(276, 46);
            this.lbDD.Name = "lbDD";
            this.lbDD.Size = new System.Drawing.Size(65, 16);
            this.lbDD.TabIndex = 5;
            this.lbDD.Text = "Điểm đến";
            // 
            // cbxDD
            // 
            this.cbxDD.FormattingEnabled = true;
            this.cbxDD.Location = new System.Drawing.Point(359, 43);
            this.cbxDD.Name = "cbxDD";
            this.cbxDD.Size = new System.Drawing.Size(138, 24);
            this.cbxDD.TabIndex = 6;
            this.cbxDD.SelectedIndexChanged += new System.EventHandler(this.cbxDD_SelectedIndexChanged);
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Location = new System.Drawing.Point(24, 109);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(64, 16);
            this.lbTG.TabIndex = 3;
            this.lbTG.Text = "Thời gian";
            // 
            // cbxTG
            // 
            this.cbxTG.FormattingEnabled = true;
            this.cbxTG.Location = new System.Drawing.Point(111, 106);
            this.cbxTG.Name = "cbxTG";
            this.cbxTG.Size = new System.Drawing.Size(135, 24);
            this.cbxTG.TabIndex = 4;
            this.cbxTG.SelectedIndexChanged += new System.EventHandler(this.cbxTG_SelectedIndexChanged);
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Location = new System.Drawing.Point(21, 46);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(89, 16);
            this.lbKH.TabIndex = 2;
            this.lbKH.Text = "Nơi khởi hành";
            // 
            // grHT
            // 
            this.grHT.BackColor = System.Drawing.Color.Transparent;
            this.grHT.Controls.Add(this.dgvHT);
            this.grHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grHT.Location = new System.Drawing.Point(23, 280);
            this.grHT.Name = "grHT";
            this.grHT.Size = new System.Drawing.Size(1006, 209);
            this.grHT.TabIndex = 5;
            this.grHT.TabStop = false;
            this.grHT.Text = "Hiển thị";
            // 
            // lsHT
            // 
            this.lsHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lsHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lsHT.FormattingEnabled = true;
            this.lsHT.ItemHeight = 19;
            this.lsHT.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.lsHT.Location = new System.Drawing.Point(572, 30);
            this.lsHT.Name = "lsHT";
            this.lsHT.Size = new System.Drawing.Size(457, 232);
            this.lsHT.TabIndex = 6;
            // 
            // pic
            // 
            this.pic.BackgroundImage = global::TuVanDuLich.Properties.Resources.Cappadocia;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Location = new System.Drawing.Point(581, 93);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(158, 129);
            this.pic.TabIndex = 7;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "b.jpg");
            this.imageList1.Images.SetKeyName(1, "1554713265_tour-ha-long-6.jpg");
            this.imageList1.Images.SetKeyName(2, "cantho.jpg");
            this.imageList1.Images.SetKeyName(3, "caobang.jpg");
            this.imageList1.Images.SetKeyName(4, "condao.jpg");
            this.imageList1.Images.SetKeyName(5, "dalat.jpg");
            this.imageList1.Images.SetKeyName(6, "dânng.jpg");
            this.imageList1.Images.SetKeyName(7, "HaLong1.jpg");
            this.imageList1.Images.SetKeyName(8, "Hoian.jpg");
            this.imageList1.Images.SetKeyName(9, "huế.jpg");
            this.imageList1.Images.SetKeyName(10, "muine.jpg");
            this.imageList1.Images.SetKeyName(11, "NhaTrang.jpg");
            this.imageList1.Images.SetKeyName(12, "NinhBinh.jpg");
            this.imageList1.Images.SetKeyName(13, "phong nha.jpg");
            this.imageList1.Images.SetKeyName(14, "phuquoc1.jpg");
            this.imageList1.Images.SetKeyName(15, "quynhon.jpg");
            this.imageList1.Images.SetKeyName(16, "saigon.jpg");
            this.imageList1.Images.SetKeyName(17, "sâp.jpg");
            this.imageList1.Images.SetKeyName(18, "tuyenqua.jpg");
            this.imageList1.Images.SetKeyName(19, "vungtau.jpg");
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Silver;
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHuy.Image = global::TuVanDuLich.Properties.Resources.Erase;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(364, 236);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 38);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.link.Location = new System.Drawing.Point(745, 195);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(38, 17);
            this.link.TabIndex = 9;
            this.link.TabStop = true;
            this.link.Text = "Click";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // TuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TuVanDuLich.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 501);
            this.Controls.Add(this.link);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lsHT);
            this.Controls.Add(this.grHT);
            this.Controls.Add(this.grTK);
            this.Controls.Add(this.btnTim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TuVan";
            this.Text = "Tư vấn du lịch";
            this.Load += new System.EventHandler(this.TuVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).EndInit();
            this.grTK.ResumeLayout(false);
            this.grTK.PerformLayout();
            this.grHT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvHT;
        private System.Windows.Forms.ComboBox cbxKH;
        private System.Windows.Forms.GroupBox grTK;
        private System.Windows.Forms.GroupBox grHT;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.ComboBox cbxGia;
        private System.Windows.Forms.Label lbDD;
        private System.Windows.Forms.ComboBox cbxDD;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.ComboBox cbxTG;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.ListBox lsHT;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.LinkLabel link;
    }
}

