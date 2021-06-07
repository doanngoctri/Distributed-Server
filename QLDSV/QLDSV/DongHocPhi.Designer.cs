namespace QLDSV
{
    partial class DongHocPhi
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mALOPLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QLDSV.DS();
            this.sP_THONGTINDONGHOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_THONGTINDONGHOCPHITableAdapter = new QLDSV.DSTableAdapters.SP_THONGTINDONGHOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.exitFormBn = new System.Windows.Forms.Button();
            this.exitBn = new System.Windows.Forms.Button();
            this.saveBn = new System.Windows.Forms.Button();
            this.beginBn = new System.Windows.Forms.Button();
            this.mALOPTextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.mASVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_THONGTINDONGHOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THONGTINDONGHOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THONGTINDONGHOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(22, 61);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(47, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(22, 111);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(32, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(22, 159);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(304, 56);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 6;
            mALOPLabel.Text = "MALOP:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1275, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 591);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1275, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 591);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1275, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 591);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_THONGTINDONGHOCPHIBindingSource
            // 
            this.sP_THONGTINDONGHOCPHIBindingSource.DataMember = "SP_THONGTINDONGHOCPHI";
            this.sP_THONGTINDONGHOCPHIBindingSource.DataSource = this.dS;
            // 
            // sP_THONGTINDONGHOCPHITableAdapter
            // 
            this.sP_THONGTINDONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.exitFormBn);
            this.groupControl1.Controls.Add(this.exitBn);
            this.groupControl1.Controls.Add(this.saveBn);
            this.groupControl1.Controls.Add(this.beginBn);
            this.groupControl1.Controls.Add(mALOPLabel);
            this.groupControl1.Controls.Add(this.mALOPTextBox);
            this.groupControl1.Controls.Add(tENLabel);
            this.groupControl1.Controls.Add(this.tENTextBox);
            this.groupControl1.Controls.Add(hOLabel);
            this.groupControl1.Controls.Add(this.hOTextBox);
            this.groupControl1.Controls.Add(mASVLabel);
            this.groupControl1.Controls.Add(this.mASVTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(298, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(809, 225);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Đóng học phí";
            // 
            // exitFormBn
            // 
            this.exitFormBn.Location = new System.Drawing.Point(541, 86);
            this.exitFormBn.Name = "exitFormBn";
            this.exitFormBn.Size = new System.Drawing.Size(107, 59);
            this.exitFormBn.TabIndex = 11;
            this.exitFormBn.Text = "Đóng Form";
            this.exitFormBn.UseVisualStyleBackColor = true;
            this.exitFormBn.Click += new System.EventHandler(this.exitFormBn_Click);
            // 
            // exitBn
            // 
            this.exitBn.Location = new System.Drawing.Point(398, 153);
            this.exitBn.Name = "exitBn";
            this.exitBn.Size = new System.Drawing.Size(68, 23);
            this.exitBn.TabIndex = 10;
            this.exitBn.Text = "Thoát";
            this.exitBn.UseVisualStyleBackColor = true;
            this.exitBn.Click += new System.EventHandler(this.exitBn_Click);
            // 
            // saveBn
            // 
            this.saveBn.Location = new System.Drawing.Point(307, 153);
            this.saveBn.Name = "saveBn";
            this.saveBn.Size = new System.Drawing.Size(68, 23);
            this.saveBn.TabIndex = 9;
            this.saveBn.Text = "Lưu";
            this.saveBn.UseVisualStyleBackColor = true;
            this.saveBn.Click += new System.EventHandler(this.saveBn_Click);
            // 
            // beginBn
            // 
            this.beginBn.Location = new System.Drawing.Point(307, 104);
            this.beginBn.Name = "beginBn";
            this.beginBn.Size = new System.Drawing.Size(159, 23);
            this.beginBn.TabIndex = 8;
            this.beginBn.Text = "Bắt Đầu";
            this.beginBn.UseVisualStyleBackColor = true;
            this.beginBn.Click += new System.EventHandler(this.beginBn_Click);
            // 
            // mALOPTextBox
            // 
            this.mALOPTextBox.Enabled = false;
            this.mALOPTextBox.Location = new System.Drawing.Point(366, 53);
            this.mALOPTextBox.Name = "mALOPTextBox";
            this.mALOPTextBox.Size = new System.Drawing.Size(100, 23);
            this.mALOPTextBox.TabIndex = 7;
            // 
            // tENTextBox
            // 
            this.tENTextBox.Enabled = false;
            this.tENTextBox.Location = new System.Drawing.Point(73, 156);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(127, 23);
            this.tENTextBox.TabIndex = 5;
            // 
            // hOTextBox
            // 
            this.hOTextBox.Enabled = false;
            this.hOTextBox.Location = new System.Drawing.Point(67, 108);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(133, 23);
            this.hOTextBox.TabIndex = 3;
            // 
            // mASVTextEdit
            // 
            this.mASVTextEdit.Location = new System.Drawing.Point(75, 58);
            this.mASVTextEdit.MenuManager = this.barManager1;
            this.mASVTextEdit.Name = "mASVTextEdit";
            this.mASVTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mASVTextEdit.TabIndex = 1;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
            // 
            // sP_THONGTINDONGHOCPHIGridControl
            // 
            this.sP_THONGTINDONGHOCPHIGridControl.DataSource = this.sP_THONGTINDONGHOCPHIBindingSource;
            this.sP_THONGTINDONGHOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_THONGTINDONGHOCPHIGridControl.Location = new System.Drawing.Point(0, 286);
            this.sP_THONGTINDONGHOCPHIGridControl.MainView = this.gridView1;
            this.sP_THONGTINDONGHOCPHIGridControl.MenuManager = this.barManager1;
            this.sP_THONGTINDONGHOCPHIGridControl.Name = "sP_THONGTINDONGHOCPHIGridControl";
            this.sP_THONGTINDONGHOCPHIGridControl.Size = new System.Drawing.Size(1275, 305);
            this.sP_THONGTINDONGHOCPHIGridControl.TabIndex = 9;
            this.sP_THONGTINDONGHOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG,
            this.colSOTIENDONG});
            this.gridView1.GridControl = this.sP_THONGTINDONGHOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.ReadOnly = true;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.ReadOnly = true;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.DisplayFormat.FormatString = "#,###";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.ReadOnly = true;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.DisplayFormat.FormatString = "#,###";
            this.colSOTIENDADONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.MinWidth = 25;
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.ReadOnly = true;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 94;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.DisplayFormat.FormatString = "#,###";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 25;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 4;
            this.colSOTIENDONG.Width = 94;
            // 
            // DongHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 611);
            this.Controls.Add(this.sP_THONGTINDONGHOCPHIGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DongHocPhi";
            this.Text = "DongHocPhi";
            this.Load += new System.EventHandler(this.DongHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THONGTINDONGHOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THONGTINDONGHOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource sP_THONGTINDONGHOCPHIBindingSource;
        private DS dS;
        private DSTableAdapters.SP_THONGTINDONGHOCPHITableAdapter sP_THONGTINDONGHOCPHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.Button saveBn;
        private System.Windows.Forms.Button beginBn;
        private System.Windows.Forms.TextBox mALOPTextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private DevExpress.XtraEditors.TextEdit mASVTextEdit;
        private System.Windows.Forms.Button exitBn;
        private System.Windows.Forms.Button exitFormBn;
        private DevExpress.XtraGrid.GridControl sP_THONGTINDONGHOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
    }
}