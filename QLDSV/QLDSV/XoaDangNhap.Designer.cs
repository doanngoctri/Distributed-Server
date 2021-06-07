namespace QLDSV
{
    partial class XoaDangNhap
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
            this.dS = new QLDSV.DS();
            this.v_LoginAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_LoginAccTableAdapter = new QLDSV.DSTableAdapters.V_LoginAccTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.v_LoginAccGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTàiKhoản = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyền = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LoginAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LoginAccGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_LoginAccBindingSource
            // 
            this.v_LoginAccBindingSource.DataMember = "V_LoginAcc";
            this.v_LoginAccBindingSource.DataSource = this.dS;
            // 
            // v_LoginAccTableAdapter
            // 
            this.v_LoginAccTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_LoginAccGridControl
            // 
            this.v_LoginAccGridControl.DataSource = this.v_LoginAccBindingSource;
            this.v_LoginAccGridControl.Location = new System.Drawing.Point(83, 161);
            this.v_LoginAccGridControl.MainView = this.gridView1;
            this.v_LoginAccGridControl.Name = "v_LoginAccGridControl";
            this.v_LoginAccGridControl.Size = new System.Drawing.Size(849, 341);
            this.v_LoginAccGridControl.TabIndex = 0;
            this.v_LoginAccGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTàiKhoản,
            this.colTên,
            this.colQuyền});
            this.gridView1.GridControl = this.v_LoginAccGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colTàiKhoản
            // 
            this.colTàiKhoản.FieldName = "Tài Khoản";
            this.colTàiKhoản.MinWidth = 25;
            this.colTàiKhoản.Name = "colTàiKhoản";
            this.colTàiKhoản.Visible = true;
            this.colTàiKhoản.VisibleIndex = 0;
            this.colTàiKhoản.Width = 94;
            // 
            // colTên
            // 
            this.colTên.FieldName = "Tên";
            this.colTên.MinWidth = 25;
            this.colTên.Name = "colTên";
            this.colTên.Visible = true;
            this.colTên.VisibleIndex = 1;
            this.colTên.Width = 94;
            // 
            // colQuyền
            // 
            this.colQuyền.FieldName = "Quyền";
            this.colQuyền.MinWidth = 25;
            this.colQuyền.Name = "colQuyền";
            this.colQuyền.Visible = true;
            this.colQuyền.VisibleIndex = 2;
            this.colQuyền.Width = 94;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(83, 85);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(187, 49);
            this.delete.TabIndex = 1;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(745, 85);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(187, 49);
            this.exit.TabIndex = 2;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(399, 85);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(187, 49);
            this.update.TabIndex = 3;
            this.update.Text = "Cập Nhật";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // XoaDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 668);
            this.Controls.Add(this.update);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.v_LoginAccGridControl);
            this.Name = "XoaDangNhap";
            this.Text = "XoaDangNhap";
            this.Load += new System.EventHandler(this.XoaDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LoginAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LoginAccGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource v_LoginAccBindingSource;
        private DSTableAdapters.V_LoginAccTableAdapter v_LoginAccTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_LoginAccGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTàiKhoản;
        private DevExpress.XtraGrid.Columns.GridColumn colTên;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyền;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button update;
    }
}