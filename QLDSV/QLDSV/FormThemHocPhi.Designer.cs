namespace QLDSV
{
    partial class FormThemHocPhi
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
            this.bnExitForm = new System.Windows.Forms.Button();
            this.exitBn = new System.Windows.Forms.Button();
            this.saveBn = new System.Windows.Forms.Button();
            this.beginBn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hpText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hkText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nkText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenSVText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV.DS();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHITableAdapter = new QLDSV.DSTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.hOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.lookUpSinhVien = new DevExpress.XtraEditors.LookUpEdit();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.sINHVIENTableAdapter1 = new QLDSV.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager1 = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bnExitForm
            // 
            this.bnExitForm.Location = new System.Drawing.Point(393, 564);
            this.bnExitForm.Name = "bnExitForm";
            this.bnExitForm.Size = new System.Drawing.Size(123, 70);
            this.bnExitForm.TabIndex = 33;
            this.bnExitForm.Text = "Đóng Form";
            this.bnExitForm.UseVisualStyleBackColor = true;
            this.bnExitForm.Click += new System.EventHandler(this.bnExitForm_Click);
            // 
            // exitBn
            // 
            this.exitBn.Location = new System.Drawing.Point(605, 441);
            this.exitBn.Name = "exitBn";
            this.exitBn.Size = new System.Drawing.Size(75, 23);
            this.exitBn.TabIndex = 32;
            this.exitBn.Text = "Thoát";
            this.exitBn.UseVisualStyleBackColor = true;
            this.exitBn.Click += new System.EventHandler(this.exitFormBn_Click);
            // 
            // saveBn
            // 
            this.saveBn.Location = new System.Drawing.Point(393, 441);
            this.saveBn.Name = "saveBn";
            this.saveBn.Size = new System.Drawing.Size(123, 23);
            this.saveBn.TabIndex = 31;
            this.saveBn.Text = "Thêm";
            this.saveBn.UseVisualStyleBackColor = true;
            this.saveBn.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // beginBn
            // 
            this.beginBn.Location = new System.Drawing.Point(236, 441);
            this.beginBn.Name = "beginBn";
            this.beginBn.Size = new System.Drawing.Size(75, 23);
            this.beginBn.TabIndex = 30;
            this.beginBn.Text = "Bắt Đầu";
            this.beginBn.UseVisualStyleBackColor = true;
            this.beginBn.Click += new System.EventHandler(this.beginBn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Học Phí";
            // 
            // hpText
            // 
            this.hpText.Location = new System.Drawing.Point(242, 343);
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(154, 23);
            this.hpText.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Học Kì";
            // 
            // hkText
            // 
            this.hkText.Location = new System.Drawing.Point(560, 251);
            this.hkText.Name = "hkText";
            this.hkText.Size = new System.Drawing.Size(154, 23);
            this.hkText.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Niên Khóa";
            // 
            // nkText
            // 
            this.nkText.Location = new System.Drawing.Point(239, 251);
            this.nkText.Name = "nkText";
            this.nkText.Size = new System.Drawing.Size(154, 23);
            this.nkText.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên SV";
            // 
            // tenSVText
            // 
            this.tenSVText.Location = new System.Drawing.Point(560, 100);
            this.tenSVText.Name = "tenSVText";
            this.tenSVText.Size = new System.Drawing.Size(241, 23);
            this.tenSVText.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Lớp";
            // 
            // mlText
            // 
            this.mlText.Location = new System.Drawing.Point(236, 161);
            this.mlText.Name = "mlText";
            this.mlText.Size = new System.Drawing.Size(154, 23);
            this.mlText.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã SV";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.dS;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHIGridControl
            // 
            this.hOCPHIGridControl.DataSource = this.hOCPHIBindingSource;
            this.hOCPHIGridControl.Location = new System.Drawing.Point(882, 100);
            this.hOCPHIGridControl.MainView = this.gridView1;
            this.hOCPHIGridControl.Name = "hOCPHIGridControl";
            this.hOCPHIGridControl.Size = new System.Drawing.Size(608, 534);
            this.hOCPHIGridControl.TabIndex = 34;
            this.hOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.hOCPHIGridControl.Click += new System.EventHandler(this.hOCPHIGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI});
            this.gridView1.GridControl = this.hOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.DisplayFormat.FormatString = "#,###";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 3;
            this.colHOCPHI.Width = 94;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lookUpSinhVien
            // 
            this.lookUpSinhVien.Location = new System.Drawing.Point(236, 95);
            this.lookUpSinhVien.Name = "lookUpSinhVien";
            this.lookUpSinhVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSinhVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpSinhVien.Properties.DataSource = this.sINHVIENBindingSource1;
            this.lookUpSinhVien.Properties.DisplayMember = "MASV";
            this.lookUpSinhVien.Properties.NullText = "Mã Sinh Viên";
            this.lookUpSinhVien.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lookUpSinhVien.Properties.ValueMember = "MASV";
            this.lookUpSinhVien.Size = new System.Drawing.Size(154, 22);
            this.lookUpSinhVien.TabIndex = 35;
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource1.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter1
            // 
            this.sINHVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.HOCPHITableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = this.sINHVIENTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormThemHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 735);
            this.Controls.Add(this.lookUpSinhVien);
            this.Controls.Add(this.hOCPHIGridControl);
            this.Controls.Add(this.bnExitForm);
            this.Controls.Add(this.exitBn);
            this.Controls.Add(this.saveBn);
            this.Controls.Add(this.beginBn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hpText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hkText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nkText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tenSVText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mlText);
            this.Controls.Add(this.label1);
            this.Name = "FormThemHocPhi";
            this.Text = "FormThemHocPhi";
            this.Load += new System.EventHandler(this.FormThemHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnExitForm;
        private System.Windows.Forms.Button exitBn;
        private System.Windows.Forms.Button saveBn;
        private System.Windows.Forms.Button beginBn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hpText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hkText;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nkText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenSVText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mlText;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private DSTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lookUpSinhVien;
        private DevExpress.XtraDataLayout.DataLayoutControl sINHVIENDataLayoutControl;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter1;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}