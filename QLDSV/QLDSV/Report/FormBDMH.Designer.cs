namespace QLDSV.Report
{
    partial class FormBDMH
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label lANLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKHOA = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLan = new System.Windows.Forms.TextBox();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.sp_BANGDIEMMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BANGDIEMMONHOCTableAdapter = new QLDSV.DSTableAdapters.sp_BANGDIEMMONHOCTableAdapter();
            this.sp_BANGDIEMMONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHỌVÀTÊN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐIỂM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMMONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(150, 228);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 17);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(466, 166);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(90, 17);
            tENMHLabel.TabIndex = 5;
            tENMHLabel.Text = "Tên môn học";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(487, 228);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(49, 17);
            lANLabel.TabIndex = 7;
            lANLabel.Text = "Lần thi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 123);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "KHOA";
            // 
            // comboBoxKHOA
            // 
            this.comboBoxKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKHOA.FormattingEnabled = true;
            this.comboBoxKHOA.Location = new System.Drawing.Point(230, 164);
            this.comboBoxKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKHOA.Name = "comboBoxKHOA";
            this.comboBoxKHOA.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKHOA.TabIndex = 2;
            this.comboBoxKHOA.SelectedIndexChanged += new System.EventHandler(this.comboBoxKHOA_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLan
            // 
            this.txtLan.Location = new System.Drawing.Point(562, 228);
            this.txtLan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(116, 23);
            this.txtLan.TabIndex = 11;
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "LOP";
            this.lOPBindingSource1.DataSource = this.dS;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.lOPBindingSource1;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(230, 224);
            this.cmbTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(160, 24);
            this.cmbTenLop.TabIndex = 11;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.txttenlop_SelectedIndexChanged_1);
            // 
            // mONHOCBindingSource1
            // 
            this.mONHOCBindingSource1.DataMember = "MONHOC";
            this.mONHOCBindingSource1.DataSource = this.dS;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.mONHOCBindingSource1;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(560, 160);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(160, 24);
            this.cmbMonHoc.TabIndex = 11;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // sp_BANGDIEMMONHOCBindingSource
            // 
            this.sp_BANGDIEMMONHOCBindingSource.DataMember = "sp_BANGDIEMMONHOC";
            this.sp_BANGDIEMMONHOCBindingSource.DataSource = this.dS;
            // 
            // sp_BANGDIEMMONHOCTableAdapter
            // 
            this.sp_BANGDIEMMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BANGDIEMMONHOCGridControl
            // 
            this.sp_BANGDIEMMONHOCGridControl.DataSource = this.sp_BANGDIEMMONHOCBindingSource;
            this.sp_BANGDIEMMONHOCGridControl.Location = new System.Drawing.Point(130, 423);
            this.sp_BANGDIEMMONHOCGridControl.MainView = this.gridView1;
            this.sp_BANGDIEMMONHOCGridControl.Name = "sp_BANGDIEMMONHOCGridControl";
            this.sp_BANGDIEMMONHOCGridControl.Size = new System.Drawing.Size(826, 220);
            this.sp_BANGDIEMMONHOCGridControl.TabIndex = 12;
            this.sp_BANGDIEMMONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colHỌVÀTÊN,
            this.colĐIỂM});
            this.gridView1.GridControl = this.sp_BANGDIEMMONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 94;
            // 
            // colHỌVÀTÊN
            // 
            this.colHỌVÀTÊN.FieldName = " HỌ VÀ TÊN ";
            this.colHỌVÀTÊN.MinWidth = 25;
            this.colHỌVÀTÊN.Name = "colHỌVÀTÊN";
            this.colHỌVÀTÊN.Visible = true;
            this.colHỌVÀTÊN.VisibleIndex = 1;
            this.colHỌVÀTÊN.Width = 94;
            // 
            // colĐIỂM
            // 
            this.colĐIỂM.FieldName = "ĐIỂM";
            this.colĐIỂM.MinWidth = 25;
            this.colĐIỂM.Name = "colĐIỂM";
            this.colĐIỂM.Visible = true;
            this.colĐIỂM.VisibleIndex = 2;
            this.colĐIỂM.Width = 94;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormBDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 691);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sp_BANGDIEMMONHOCGridControl);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.cmbTenLop);
            this.Controls.Add(this.txtLan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(lANLabel);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.comboBoxKHOA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBDMH";
            this.Text = "FormBDMH";
            this.Load += new System.EventHandler(this.FormBDMH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMMONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKHOA;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.BindingSource mONHOCBindingSource1;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.BindingSource sp_BANGDIEMMONHOCBindingSource;
        private DSTableAdapters.sp_BANGDIEMMONHOCTableAdapter sp_BANGDIEMMONHOCTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_BANGDIEMMONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHỌVÀTÊN;
        private DevExpress.XtraGrid.Columns.GridColumn colĐIỂM;
        private System.Windows.Forms.Button button3;
    }
}