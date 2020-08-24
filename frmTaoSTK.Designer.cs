namespace STK
{
    partial class frmTaoSTK
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
            this.lblKyHan_TTLX = new System.Windows.Forms.Label();
            this.lblPhuongThuc_TTLX = new System.Windows.Forms.Label();
            this.lblValueKyHan_TTLX = new System.Windows.Forms.Label();
            this.lblValuePhuongThuc_TTLX = new System.Windows.Forms.Label();
            this.gbThongTinLaiXuat = new System.Windows.Forms.GroupBox();
            this.gbBoLoc = new System.Windows.Forms.GroupBox();
            this.btnBoLocLaiXuat = new System.Windows.Forms.Button();
            this.cbxPhuongThuc = new System.Windows.Forms.ComboBox();
            this.cbxKyHan = new System.Windows.Forms.ComboBox();
            this.lblPhuongThucBLLX = new System.Windows.Forms.Label();
            this.lblKyHanBLLX = new System.Windows.Forms.Label();
            this.gbKhachHang = new System.Windows.Forms.GroupBox();
            this.lblSDT_KH = new System.Windows.Forms.Label();
            this.lblValueTenKH_KH = new System.Windows.Forms.Label();
            this.lblTenKH_KH = new System.Windows.Forms.Label();
            this.lblValueSDT_KH = new System.Windows.Forms.Label();
            this.gbBoLocKhachHang = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnBoLocKH = new System.Windows.Forms.Button();
            this.lblTenKH_BLKH = new System.Windows.Forms.Label();
            this.lblSDT_BLKH = new System.Windows.Forms.Label();
            this.btnTaoSTK = new System.Windows.Forms.Button();
            this.txtTienTK = new System.Windows.Forms.TextBox();
            this.lblTienTK = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lvLaiXuat = new System.Windows.Forms.ListView();
            this.lvKhachHang = new System.Windows.Forms.ListView();
            this.gbThongTinLaiXuat.SuspendLayout();
            this.gbBoLoc.SuspendLayout();
            this.gbKhachHang.SuspendLayout();
            this.gbBoLocKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKyHan_TTLX
            // 
            this.lblKyHan_TTLX.AutoSize = true;
            this.lblKyHan_TTLX.Location = new System.Drawing.Point(6, 246);
            this.lblKyHan_TTLX.Name = "lblKyHan_TTLX";
            this.lblKyHan_TTLX.Size = new System.Drawing.Size(79, 23);
            this.lblKyHan_TTLX.TabIndex = 2;
            this.lblKyHan_TTLX.Text = "Ky han :";
            // 
            // lblPhuongThuc_TTLX
            // 
            this.lblPhuongThuc_TTLX.AutoSize = true;
            this.lblPhuongThuc_TTLX.Location = new System.Drawing.Point(6, 301);
            this.lblPhuongThuc_TTLX.Name = "lblPhuongThuc_TTLX";
            this.lblPhuongThuc_TTLX.Size = new System.Drawing.Size(126, 23);
            this.lblPhuongThuc_TTLX.TabIndex = 3;
            this.lblPhuongThuc_TTLX.Text = "Phuong thuc :";
            // 
            // lblValueKyHan_TTLX
            // 
            this.lblValueKyHan_TTLX.AutoSize = true;
            this.lblValueKyHan_TTLX.Location = new System.Drawing.Point(143, 246);
            this.lblValueKyHan_TTLX.Name = "lblValueKyHan_TTLX";
            this.lblValueKyHan_TTLX.Size = new System.Drawing.Size(92, 23);
            this.lblValueKyHan_TTLX.TabIndex = 4;
            this.lblValueKyHan_TTLX.Text = "<Ky han>";
            // 
            // lblValuePhuongThuc_TTLX
            // 
            this.lblValuePhuongThuc_TTLX.AutoSize = true;
            this.lblValuePhuongThuc_TTLX.Location = new System.Drawing.Point(143, 301);
            this.lblValuePhuongThuc_TTLX.Name = "lblValuePhuongThuc_TTLX";
            this.lblValuePhuongThuc_TTLX.Size = new System.Drawing.Size(139, 23);
            this.lblValuePhuongThuc_TTLX.TabIndex = 5;
            this.lblValuePhuongThuc_TTLX.Text = "<Phuong thuc>";
            // 
            // gbThongTinLaiXuat
            // 
            this.gbThongTinLaiXuat.Controls.Add(this.lvLaiXuat);
            this.gbThongTinLaiXuat.Controls.Add(this.lblKyHan_TTLX);
            this.gbThongTinLaiXuat.Controls.Add(this.lblValuePhuongThuc_TTLX);
            this.gbThongTinLaiXuat.Controls.Add(this.lblPhuongThuc_TTLX);
            this.gbThongTinLaiXuat.Controls.Add(this.lblValueKyHan_TTLX);
            this.gbThongTinLaiXuat.Location = new System.Drawing.Point(541, 12);
            this.gbThongTinLaiXuat.Name = "gbThongTinLaiXuat";
            this.gbThongTinLaiXuat.Size = new System.Drawing.Size(343, 352);
            this.gbThongTinLaiXuat.TabIndex = 6;
            this.gbThongTinLaiXuat.TabStop = false;
            this.gbThongTinLaiXuat.Text = "Thong tin lai xuat";
            // 
            // gbBoLoc
            // 
            this.gbBoLoc.Controls.Add(this.btnBoLocLaiXuat);
            this.gbBoLoc.Controls.Add(this.cbxPhuongThuc);
            this.gbBoLoc.Controls.Add(this.cbxKyHan);
            this.gbBoLoc.Controls.Add(this.lblPhuongThucBLLX);
            this.gbBoLoc.Controls.Add(this.lblKyHanBLLX);
            this.gbBoLoc.Location = new System.Drawing.Point(289, 12);
            this.gbBoLoc.Name = "gbBoLoc";
            this.gbBoLoc.Size = new System.Drawing.Size(246, 166);
            this.gbBoLoc.TabIndex = 7;
            this.gbBoLoc.TabStop = false;
            this.gbBoLoc.Text = "Bo loc lai xuat";
            this.gbBoLoc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBoLocLaiXuat
            // 
            this.btnBoLocLaiXuat.Location = new System.Drawing.Point(10, 114);
            this.btnBoLocLaiXuat.Name = "btnBoLocLaiXuat";
            this.btnBoLocLaiXuat.Size = new System.Drawing.Size(230, 37);
            this.btnBoLocLaiXuat.TabIndex = 9;
            this.btnBoLocLaiXuat.Text = "Tim kiem";
            this.btnBoLocLaiXuat.UseVisualStyleBackColor = true;
            this.btnBoLocLaiXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPhuongThuc
            // 
            this.cbxPhuongThuc.FormattingEnabled = true;
            this.cbxPhuongThuc.Location = new System.Drawing.Point(138, 72);
            this.cbxPhuongThuc.Name = "cbxPhuongThuc";
            this.cbxPhuongThuc.Size = new System.Drawing.Size(102, 31);
            this.cbxPhuongThuc.TabIndex = 8;
            // 
            // cbxKyHan
            // 
            this.cbxKyHan.FormattingEnabled = true;
            this.cbxKyHan.Location = new System.Drawing.Point(138, 28);
            this.cbxKyHan.Name = "cbxKyHan";
            this.cbxKyHan.Size = new System.Drawing.Size(102, 31);
            this.cbxKyHan.TabIndex = 7;
            // 
            // lblPhuongThucBLLX
            // 
            this.lblPhuongThucBLLX.AutoSize = true;
            this.lblPhuongThucBLLX.Location = new System.Drawing.Point(6, 75);
            this.lblPhuongThucBLLX.Name = "lblPhuongThucBLLX";
            this.lblPhuongThucBLLX.Size = new System.Drawing.Size(115, 23);
            this.lblPhuongThucBLLX.TabIndex = 6;
            this.lblPhuongThucBLLX.Text = "Phuong thuc";
            // 
            // lblKyHanBLLX
            // 
            this.lblKyHanBLLX.AutoSize = true;
            this.lblKyHanBLLX.Location = new System.Drawing.Point(6, 31);
            this.lblKyHanBLLX.Name = "lblKyHanBLLX";
            this.lblKyHanBLLX.Size = new System.Drawing.Size(68, 23);
            this.lblKyHanBLLX.TabIndex = 3;
            this.lblKyHanBLLX.Text = "Ky han";
            // 
            // gbKhachHang
            // 
            this.gbKhachHang.Controls.Add(this.lvKhachHang);
            this.gbKhachHang.Controls.Add(this.lblSDT_KH);
            this.gbKhachHang.Controls.Add(this.lblValueTenKH_KH);
            this.gbKhachHang.Controls.Add(this.lblTenKH_KH);
            this.gbKhachHang.Controls.Add(this.lblValueSDT_KH);
            this.gbKhachHang.Location = new System.Drawing.Point(12, 12);
            this.gbKhachHang.Name = "gbKhachHang";
            this.gbKhachHang.Size = new System.Drawing.Size(271, 352);
            this.gbKhachHang.TabIndex = 8;
            this.gbKhachHang.TabStop = false;
            this.gbKhachHang.Text = "Khach hang";
            // 
            // lblSDT_KH
            // 
            this.lblSDT_KH.AutoSize = true;
            this.lblSDT_KH.Location = new System.Drawing.Point(6, 246);
            this.lblSDT_KH.Name = "lblSDT_KH";
            this.lblSDT_KH.Size = new System.Drawing.Size(59, 23);
            this.lblSDT_KH.TabIndex = 6;
            this.lblSDT_KH.Text = "SDT :";
            // 
            // lblValueTenKH_KH
            // 
            this.lblValueTenKH_KH.AutoSize = true;
            this.lblValueTenKH_KH.Location = new System.Drawing.Point(89, 301);
            this.lblValueTenKH_KH.Name = "lblValueTenKH_KH";
            this.lblValueTenKH_KH.Size = new System.Drawing.Size(99, 23);
            this.lblValueTenKH_KH.TabIndex = 9;
            this.lblValueTenKH_KH.Text = "<Ten KH>";
            // 
            // lblTenKH_KH
            // 
            this.lblTenKH_KH.AutoSize = true;
            this.lblTenKH_KH.Location = new System.Drawing.Point(6, 301);
            this.lblTenKH_KH.Name = "lblTenKH_KH";
            this.lblTenKH_KH.Size = new System.Drawing.Size(51, 23);
            this.lblTenKH_KH.TabIndex = 7;
            this.lblTenKH_KH.Text = "Ten :";
            // 
            // lblValueSDT_KH
            // 
            this.lblValueSDT_KH.AutoSize = true;
            this.lblValueSDT_KH.Location = new System.Drawing.Point(89, 246);
            this.lblValueSDT_KH.Name = "lblValueSDT_KH";
            this.lblValueSDT_KH.Size = new System.Drawing.Size(72, 23);
            this.lblValueSDT_KH.TabIndex = 8;
            this.lblValueSDT_KH.Text = "<SDT>";
            // 
            // gbBoLocKhachHang
            // 
            this.gbBoLocKhachHang.Controls.Add(this.txtTenKH);
            this.gbBoLocKhachHang.Controls.Add(this.txtMaKH);
            this.gbBoLocKhachHang.Controls.Add(this.btnBoLocKH);
            this.gbBoLocKhachHang.Controls.Add(this.lblTenKH_BLKH);
            this.gbBoLocKhachHang.Controls.Add(this.lblSDT_BLKH);
            this.gbBoLocKhachHang.Location = new System.Drawing.Point(289, 198);
            this.gbBoLocKhachHang.Name = "gbBoLocKhachHang";
            this.gbBoLocKhachHang.Size = new System.Drawing.Size(246, 166);
            this.gbBoLocKhachHang.TabIndex = 10;
            this.gbBoLocKhachHang.TabStop = false;
            this.gbBoLocKhachHang.Text = "Bo loc khach hang";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(138, 72);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 32);
            this.txtTenKH.TabIndex = 11;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(138, 28);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 32);
            this.txtMaKH.TabIndex = 10;
            // 
            // btnBoLocKH
            // 
            this.btnBoLocKH.Location = new System.Drawing.Point(10, 114);
            this.btnBoLocKH.Name = "btnBoLocKH";
            this.btnBoLocKH.Size = new System.Drawing.Size(230, 37);
            this.btnBoLocKH.TabIndex = 9;
            this.btnBoLocKH.Text = "Tim kiem";
            this.btnBoLocKH.UseVisualStyleBackColor = true;
            // 
            // lblTenKH_BLKH
            // 
            this.lblTenKH_BLKH.AutoSize = true;
            this.lblTenKH_BLKH.Location = new System.Drawing.Point(6, 75);
            this.lblTenKH_BLKH.Name = "lblTenKH_BLKH";
            this.lblTenKH_BLKH.Size = new System.Drawing.Size(40, 23);
            this.lblTenKH_BLKH.TabIndex = 6;
            this.lblTenKH_BLKH.Text = "Ten";
            // 
            // lblSDT_BLKH
            // 
            this.lblSDT_BLKH.AutoSize = true;
            this.lblSDT_BLKH.Location = new System.Drawing.Point(6, 31);
            this.lblSDT_BLKH.Name = "lblSDT_BLKH";
            this.lblSDT_BLKH.Size = new System.Drawing.Size(48, 23);
            this.lblSDT_BLKH.TabIndex = 3;
            this.lblSDT_BLKH.Text = "SDT";
            // 
            // btnTaoSTK
            // 
            this.btnTaoSTK.Location = new System.Drawing.Point(654, 370);
            this.btnTaoSTK.Name = "btnTaoSTK";
            this.btnTaoSTK.Size = new System.Drawing.Size(230, 37);
            this.btnTaoSTK.TabIndex = 12;
            this.btnTaoSTK.Text = "Tao STK";
            this.btnTaoSTK.UseVisualStyleBackColor = true;
            // 
            // txtTienTK
            // 
            this.txtTienTK.Location = new System.Drawing.Point(427, 368);
            this.txtTienTK.Name = "txtTienTK";
            this.txtTienTK.Size = new System.Drawing.Size(100, 32);
            this.txtTienTK.TabIndex = 12;
            // 
            // lblTienTK
            // 
            this.lblTienTK.AutoSize = true;
            this.lblTienTK.Location = new System.Drawing.Point(295, 377);
            this.lblTienTK.Name = "lblTienTK";
            this.lblTienTK.Size = new System.Drawing.Size(121, 23);
            this.lblTienTK.TabIndex = 12;
            this.lblTienTK.Text = "Tien gui TK :";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(533, 377);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(69, 23);
            this.lblDVT.TabIndex = 13;
            this.lblDVT.Text = "(VND)";
            // 
            // lvLaiXuat
            // 
            this.lvLaiXuat.HideSelection = false;
            this.lvLaiXuat.Location = new System.Drawing.Point(6, 31);
            this.lvLaiXuat.Name = "lvLaiXuat";
            this.lvLaiXuat.Size = new System.Drawing.Size(331, 209);
            this.lvLaiXuat.TabIndex = 6;
            this.lvLaiXuat.UseCompatibleStateImageBehavior = false;
            // 
            // lvKhachHang
            // 
            this.lvKhachHang.HideSelection = false;
            this.lvKhachHang.Location = new System.Drawing.Point(10, 31);
            this.lvKhachHang.Name = "lvKhachHang";
            this.lvKhachHang.Size = new System.Drawing.Size(255, 209);
            this.lvKhachHang.TabIndex = 7;
            this.lvKhachHang.UseCompatibleStateImageBehavior = false;
            // 
            // frmTaoSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 433);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.lblTienTK);
            this.Controls.Add(this.txtTienTK);
            this.Controls.Add(this.btnTaoSTK);
            this.Controls.Add(this.gbBoLocKhachHang);
            this.Controls.Add(this.gbKhachHang);
            this.Controls.Add(this.gbBoLoc);
            this.Controls.Add(this.gbThongTinLaiXuat);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmTaoSTK";
            this.Text = "Quan ly so tiet kiem";
            this.gbThongTinLaiXuat.ResumeLayout(false);
            this.gbThongTinLaiXuat.PerformLayout();
            this.gbBoLoc.ResumeLayout(false);
            this.gbBoLoc.PerformLayout();
            this.gbKhachHang.ResumeLayout(false);
            this.gbKhachHang.PerformLayout();
            this.gbBoLocKhachHang.ResumeLayout(false);
            this.gbBoLocKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKyHan_TTLX;
        private System.Windows.Forms.Label lblPhuongThuc_TTLX;
        private System.Windows.Forms.Label lblValueKyHan_TTLX;
        private System.Windows.Forms.Label lblValuePhuongThuc_TTLX;
        private System.Windows.Forms.GroupBox gbThongTinLaiXuat;
        private System.Windows.Forms.GroupBox gbBoLoc;
        private System.Windows.Forms.Button btnBoLocLaiXuat;
        private System.Windows.Forms.ComboBox cbxPhuongThuc;
        private System.Windows.Forms.ComboBox cbxKyHan;
        private System.Windows.Forms.Label lblPhuongThucBLLX;
        private System.Windows.Forms.Label lblKyHanBLLX;
        private System.Windows.Forms.GroupBox gbKhachHang;
        private System.Windows.Forms.Label lblSDT_KH;
        private System.Windows.Forms.Label lblValueTenKH_KH;
        private System.Windows.Forms.Label lblTenKH_KH;
        private System.Windows.Forms.Label lblValueSDT_KH;
        private System.Windows.Forms.GroupBox gbBoLocKhachHang;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnBoLocKH;
        private System.Windows.Forms.Label lblTenKH_BLKH;
        private System.Windows.Forms.Label lblSDT_BLKH;
        private System.Windows.Forms.Button btnTaoSTK;
        private System.Windows.Forms.TextBox txtTienTK;
        private System.Windows.Forms.Label lblTienTK;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.ListView lvLaiXuat;
        private System.Windows.Forms.ListView lvKhachHang;
    }
}

