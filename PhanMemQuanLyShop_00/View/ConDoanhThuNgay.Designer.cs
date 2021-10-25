namespace PhanMemQuanLyShop_00.View
{
    partial class ConDoanhThuNgay
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
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnInThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grChucNang = new DevExpress.XtraEditors.GroupControl();
            this.txtTong = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChucNang)).BeginInit();
            this.grChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(432, 59);
            this.txtDenNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(262, 23);
            this.txtDenNgay.TabIndex = 9;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(91, 59);
            this.txtTuNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(262, 23);
            this.txtTuNgay.TabIndex = 8;
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInThongKe.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInThongKe.Appearance.Options.UseFont = true;
            this.btnInThongKe.Location = new System.Drawing.Point(1025, 15);
            this.btnInThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(230, 70);
            this.btnInThongKe.TabIndex = 5;
            this.btnInThongKe.Text = "IN THỐNG KÊ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 167);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1374, 521);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colThanhTien,
            this.gridColumn5});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên hàng";
            this.gridColumn1.FieldName = "TenHang";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TenHang", "SUM={0:0.##}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá bán";
            this.gridColumn3.FieldName = "GiaBan";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.MinWidth = 23;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", "SUM={0:0.##}")});
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 3;
            this.colThanhTien.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày bán";
            this.gridColumn5.FieldName = "NgayBan";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 87;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // grChucNang
            // 
            this.grChucNang.Controls.Add(this.txtTong);
            this.grChucNang.Controls.Add(this.label3);
            this.grChucNang.Controls.Add(this.txtDenNgay);
            this.grChucNang.Controls.Add(this.txtTuNgay);
            this.grChucNang.Controls.Add(this.btnInThongKe);
            this.grChucNang.Controls.Add(this.label2);
            this.grChucNang.Controls.Add(this.label1);
            this.grChucNang.Controls.Add(this.btnThongKe);
            this.grChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grChucNang.Location = new System.Drawing.Point(0, 0);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.ShowCaption = false;
            this.grChucNang.Size = new System.Drawing.Size(1379, 160);
            this.grChucNang.TabIndex = 4;
            this.grChucNang.Text = "groupControl1";
            this.grChucNang.Paint += new System.Windows.Forms.PaintEventHandler(this.grChucNang_Paint);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(1025, 102);
            this.txtTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTong.Name = "txtTong";
            this.txtTong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTong.Properties.Appearance.Options.UseFont = true;
            this.txtTong.Properties.Appearance.Options.UseForeColor = true;
            this.txtTong.Properties.Mask.EditMask = "c0";
            this.txtTong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTong.Size = new System.Drawing.Size(230, 44);
            this.txtTong.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng doanh thu";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Location = new System.Drawing.Point(763, 15);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(230, 70);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1379, 690);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách thống hàng nhập";
            // 
            // ConDoanhThuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 690);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConDoanhThuNgay";
            this.Text = "Doanh thu theo ngày";
            this.Load += new System.EventHandler(this.ConDoanhThuNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChucNang)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.grChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDenNgay;
        private System.Windows.Forms.DateTimePicker txtTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnInThongKe;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grChucNang;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit txtTong;
    }
}