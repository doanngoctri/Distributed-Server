namespace QLDSV
{
    partial class FormDiem1
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKHOA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLan = new System.Windows.Forms.ComboBox();
            this.txtTENMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTENLOP = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.dIEMTableAdapter = new QLDSV.DSTableAdapters.DIEMTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataSetMaster1 = new QLDSV.DataSetMaster();
            this.dataSetMaster2 = new QLDSV.DataSetMaster();
            this.sp_DANHSACHNHAPDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DANHSACHNHAPDIEMTableAdapter = new QLDSV.DSTableAdapters.sp_DANHSACHNHAPDIEMTableAdapter();
            this.sp_DANHSACHNHAPDIEMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_NhapDiemTheoMonHocTableAdapter1 = new QLDSV.DSTableAdapters.sp_NhapDiemTheoMonHocTableAdapter();
            this.vDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV.DataSetMasterTableAdapters.V_DSPMTableAdapter();
            this.vDSPMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ExitForm = new System.Windows.Forms.Button();
            tENMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DANHSACHNHAPDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DANHSACHNHAPDIEMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(6, 184);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(90, 17);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Tên môn học";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(23, 113);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 17);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "Mã lớp";
            mALOPLabel.Click += new System.EventHandler(this.mALOPLabel_Click);
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(12, 263);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(84, 17);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "Mã môn học";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(12, 324);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(30, 17);
            lANLabel.TabIndex = 8;
            lANLabel.Text = "Lần";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxKHOA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 54);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxKHOA
            // 
            this.comboBoxKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKHOA.Enabled = false;
            this.comboBoxKHOA.FormattingEnabled = true;
            this.comboBoxKHOA.Location = new System.Drawing.Point(246, 21);
            this.comboBoxKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKHOA.Name = "comboBoxKHOA";
            this.comboBoxKHOA.Size = new System.Drawing.Size(216, 24);
            this.comboBoxKHOA.TabIndex = 2;
            this.comboBoxKHOA.SelectedIndexChanged += new System.EventHandler(this.comboBoxKHOA_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxLan);
            this.groupBox1.Controls.Add(this.txtTENMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTENLOP);
            this.groupBox1.Controls.Add(lANLabel);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.txtMAMH);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.txtMALOP);
            this.groupBox1.Controls.Add(tENMHLabel);
            this.groupBox1.Location = new System.Drawing.Point(26, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(623, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // comboBoxLan
            // 
            this.comboBoxLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLan.FormattingEnabled = true;
            this.comboBoxLan.Location = new System.Drawing.Point(102, 324);
            this.comboBoxLan.Name = "comboBoxLan";
            this.comboBoxLan.Size = new System.Drawing.Size(146, 24);
            this.comboBoxLan.TabIndex = 11;
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataSource = this.mONHOCBindingSource1;
            this.txtTENMH.DisplayMember = "TENMH";
            this.txtTENMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTENMH.FormattingEnabled = true;
            this.txtTENMH.Location = new System.Drawing.Point(102, 181);
            this.txtTENMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(334, 24);
            this.txtTENMH.TabIndex = 10;
            this.txtTENMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource1
            // 
            this.mONHOCBindingSource1.DataMember = "MONHOC";
            this.mONHOCBindingSource1.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Lớp:";
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataSource = this.lOPBindingSource1;
            this.txtTENLOP.DisplayMember = "TENLOP";
            this.txtTENLOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTENLOP.FormattingEnabled = true;
            this.txtTENLOP.Location = new System.Drawing.Point(102, 43);
            this.txtTENLOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Size = new System.Drawing.Size(334, 24);
            this.txtTENLOP.TabIndex = 9;
            this.txtTENLOP.ValueMember = "MALOP";
            this.txtTENLOP.SelectedIndexChanged += new System.EventHandler(this.txtTENLOP_SelectedIndexChanged);
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "LOP";
            this.lOPBindingSource1.DataSource = this.dS;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource1, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(102, 257);
            this.txtMAMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.ReadOnly = true;
            this.txtMAMH.Size = new System.Drawing.Size(146, 23);
            this.txtMAMH.TabIndex = 7;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource1, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(102, 113);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.ReadOnly = true;
            this.txtMALOP.Size = new System.Drawing.Size(146, 23);
            this.txtMALOP.TabIndex = 5;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(26, 509);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(87, 28);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(201, 509);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(87, 28);
            this.btnGhi.TabIndex = 3;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(201, 584);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 28);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataSetMaster1
            // 
            this.dataSetMaster1.DataSetName = "DataSetMaster";
            this.dataSetMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetMaster2
            // 
            this.dataSetMaster2.DataSetName = "DataSetMaster";
            this.dataSetMaster2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_DANHSACHNHAPDIEMBindingSource
            // 
            this.sp_DANHSACHNHAPDIEMBindingSource.DataMember = "sp_DANHSACHNHAPDIEM";
            this.sp_DANHSACHNHAPDIEMBindingSource.DataSource = this.dS;
            // 
            // sp_DANHSACHNHAPDIEMTableAdapter
            // 
            this.sp_DANHSACHNHAPDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // sp_DANHSACHNHAPDIEMDataGridView
            // 
            this.sp_DANHSACHNHAPDIEMDataGridView.AutoGenerateColumns = false;
            this.sp_DANHSACHNHAPDIEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_DANHSACHNHAPDIEMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sp_DANHSACHNHAPDIEMDataGridView.DataSource = this.sp_DANHSACHNHAPDIEMBindingSource;
            this.sp_DANHSACHNHAPDIEMDataGridView.Location = new System.Drawing.Point(670, 105);
            this.sp_DANHSACHNHAPDIEMDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sp_DANHSACHNHAPDIEMDataGridView.Name = "sp_DANHSACHNHAPDIEMDataGridView";
            this.sp_DANHSACHNHAPDIEMDataGridView.RowHeadersWidth = 51;
            this.sp_DANHSACHNHAPDIEMDataGridView.Size = new System.Drawing.Size(518, 599);
            this.sp_DANHSACHNHAPDIEMDataGridView.TabIndex = 7;
            this.sp_DANHSACHNHAPDIEMDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sp_DANHSACHNHAPDIEMDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "HOTEN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEM";
            this.dataGridViewTextBoxColumn3.HeaderText = "DIEM";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // sp_NhapDiemTheoMonHocTableAdapter1
            // 
            this.sp_NhapDiemTheoMonHocTableAdapter1.ClearBeforeFill = true;
            // 
            // vDSPMBindingSource
            // 
            this.vDSPMBindingSource.DataMember = "V_DSPM";
            this.vDSPMBindingSource.DataSource = this.dataSetMaster1;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // vDSPMBindingSource1
            // 
            this.vDSPMBindingSource1.DataMember = "V_DSPM";
            this.vDSPMBindingSource1.DataSource = this.dataSetMaster1;
            // 
            // ExitForm
            // 
            this.ExitForm.Location = new System.Drawing.Point(499, 536);
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(75, 76);
            this.ExitForm.TabIndex = 8;
            this.ExitForm.Text = "Đóng Form";
            this.ExitForm.UseVisualStyleBackColor = true;
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // FormDiem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 657);
            this.Controls.Add(this.ExitForm);
            this.Controls.Add(this.sp_DANHSACHNHAPDIEMDataGridView);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDiem1";
            this.Text = "FormDiem1";
            this.Load += new System.EventHandler(this.FormDiem1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DANHSACHNHAPDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DANHSACHNHAPDIEMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPMBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKHOA;
        private System.Windows.Forms.GroupBox groupBox1;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.TextBox txtMALOP;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThoat;
        private DataSetMaster dataSetMaster1;
        private DataSetMaster dataSetMaster2;
        private System.Windows.Forms.BindingSource sp_DANHSACHNHAPDIEMBindingSource;
        private DSTableAdapters.sp_DANHSACHNHAPDIEMTableAdapter sp_DANHSACHNHAPDIEMTableAdapter;
        private System.Windows.Forms.DataGridView sp_DANHSACHNHAPDIEMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtTENLOP;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
        private System.Windows.Forms.ComboBox txtTENMH;
        private System.Windows.Forms.BindingSource mONHOCBindingSource1;
        private DSTableAdapters.sp_NhapDiemTheoMonHocTableAdapter sp_NhapDiemTheoMonHocTableAdapter1;
        private System.Windows.Forms.BindingSource vDSPMBindingSource;
        private DataSetMasterTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private System.Windows.Forms.BindingSource vDSPMBindingSource1;
        private System.Windows.Forms.Button ExitForm;
        private System.Windows.Forms.ComboBox comboBoxLan;
    }
}