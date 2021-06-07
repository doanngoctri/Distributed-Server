namespace QLDSV
{
    partial class FormChuyenLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mASVLabel1;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            this.dS = new QLDSV.DS();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.comboBoxKHOA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Begin = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sINHVIENComboBox = new DevExpress.XtraEditors.LookUpEdit();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.mALOPTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mALOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.dataSetMaster = new QLDSV.DataSetMaster();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV.DataSetMasterTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager1 = new QLDSV.DataSetMasterTableAdapters.TableAdapterManager();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.v_STUDENTTableAdapter = new QLDSV.DSTableAdapters.V_STUDENTTableAdapter();
            this.v_STUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_STUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PHIEUDIEMTableAdapter1 = new QLDSV.DSTableAdapters.sp_PHIEUDIEMTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            mASVLabel1 = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_STUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_STUDENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(56, 100);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(52, 17);
            mALOPLabel.TabIndex = 5;
            mALOPLabel.Text = "Mã Lớp";
            // 
            // mASVLabel1
            // 
            mASVLabel1.AutoSize = true;
            mASVLabel1.Location = new System.Drawing.Point(59, 183);
            mASVLabel1.Name = "mASVLabel1";
            mASVLabel1.Size = new System.Drawing.Size(108, 17);
            mASVLabel1.TabIndex = 9;
            mASVLabel1.Text = "Mã Sinh Viên Mới";
            mASVLabel1.Click += new System.EventHandler(this.mASVLabel1_Click);
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(542, 121);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(52, 17);
            mALOPLabel1.TabIndex = 17;
            mALOPLabel1.Text = "Mã Lớp";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(529, 44);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(25, 17);
            hOLabel.TabIndex = 19;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(529, 100);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(31, 17);
            tENLabel.TabIndex = 20;
            tENLabel.Text = "Tên";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // comboBoxKHOA
            // 
            this.comboBoxKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKHOA.FormattingEnabled = true;
            this.comboBoxKHOA.Location = new System.Drawing.Point(182, 46);
            this.comboBoxKHOA.Name = "comboBoxKHOA";
            this.comboBoxKHOA.Size = new System.Drawing.Size(291, 24);
            this.comboBoxKHOA.TabIndex = 12;
            this.comboBoxKHOA.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đến Chi Nhánh";
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(173, 171);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(125, 32);
            this.Begin.TabIndex = 15;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(307, 242);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(125, 32);
            this.Move.TabIndex = 16;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sINHVIENComboBox);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tENTextBox);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hOTextBox);
            this.groupBox1.Controls.Add(this.EXIT);
            this.groupBox1.Controls.Add(this.mALOPTextEdit1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Begin);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Location = new System.Drawing.Point(108, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 245);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ";
            // 
            // sINHVIENComboBox
            // 
            this.sINHVIENComboBox.Location = new System.Drawing.Point(173, 43);
            this.sINHVIENComboBox.Name = "sINHVIENComboBox";
            this.sINHVIENComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sINHVIENComboBox.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.sINHVIENComboBox.Properties.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENComboBox.Properties.DisplayMember = "MASV";
            this.sINHVIENComboBox.Properties.NullText = "";
            this.sINHVIENComboBox.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.sINHVIENComboBox.Properties.ValueMember = "MASV";
            this.sINHVIENComboBox.Size = new System.Drawing.Size(300, 22);
            this.sINHVIENComboBox.TabIndex = 22;
            this.sINHVIENComboBox.EditValueChanged += new System.EventHandler(this.sINHVIENComboBox_EditValueChanged);
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "TEN", true));
            this.tENTextBox.Location = new System.Drawing.Point(573, 97);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.ReadOnly = true;
            this.tENTextBox.Size = new System.Drawing.Size(151, 23);
            this.tENTextBox.TabIndex = 21;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(573, 41);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.ReadOnly = true;
            this.hOTextBox.Size = new System.Drawing.Size(271, 23);
            this.hOTextBox.TabIndex = 20;
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(501, 161);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(125, 53);
            this.EXIT.TabIndex = 19;
            this.EXIT.Text = "Đóng Form";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // mALOPTextEdit1
            // 
            this.mALOPTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "MALOP", true));
            this.mALOPTextEdit1.Location = new System.Drawing.Point(175, 97);
            this.mALOPTextEdit1.Name = "mALOPTextEdit1";
            this.mALOPTextEdit1.Properties.ReadOnly = true;
            this.mALOPTextEdit1.Size = new System.Drawing.Size(209, 22);
            this.mALOPTextEdit1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã Sinh Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(mALOPLabel1);
            this.groupBox2.Controls.Add(this.mALOPTextEdit);
            this.groupBox2.Controls.Add(this.lOPComboBox);
            this.groupBox2.Controls.Add(this.Cancel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Move);
            this.groupBox2.Controls.Add(mASVLabel1);
            this.groupBox2.Controls.Add(this.comboBoxKHOA);
            this.groupBox2.Location = new System.Drawing.Point(108, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 359);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đến";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Lớp";
            // 
            // mALOPTextEdit
            // 
            this.mALOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.mALOPTextEdit.Location = new System.Drawing.Point(661, 116);
            this.mALOPTextEdit.Name = "mALOPTextEdit";
            this.mALOPTextEdit.Properties.ReadOnly = true;
            this.mALOPTextEdit.Size = new System.Drawing.Size(155, 22);
            this.mALOPTextEdit.TabIndex = 18;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lOPComboBox
            // 
            this.lOPComboBox.DataSource = this.lOPBindingSource;
            this.lOPComboBox.DisplayMember = "TENLOP";
            this.lOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lOPComboBox.FormattingEnabled = true;
            this.lOPComboBox.Location = new System.Drawing.Point(182, 114);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(300, 24);
            this.lOPComboBox.TabIndex = 17;
            this.lOPComboBox.ValueMember = "MALOP";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(512, 242);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(125, 32);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetMaster
            // 
            this.dataSetMaster.DataSetName = "DataSetMaster";
            this.dataSetMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.dataSetMaster;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.DataSetMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataSource = this.dS;
            this.sINHVIENBindingSource1.Position = 0;
            // 
            // v_STUDENTTableAdapter
            // 
            this.v_STUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // v_STUDENTBindingSource
            // 
            this.v_STUDENTBindingSource.DataSource = this.dS;
            this.v_STUDENTBindingSource.Position = 0;
            // 
            // v_STUDENTBindingSource1
            // 
            this.v_STUDENTBindingSource1.DataSource = this.dS;
            this.v_STUDENTBindingSource1.Position = 0;
            // 
            // sp_PHIEUDIEMTableAdapter1
            // 
            this.sp_PHIEUDIEMTableAdapter1.ClearBeforeFill = true;
            // 
            // FormChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChuyenLop";
            this.Text = "FormChuyenLop";
            this.Load += new System.EventHandler(this.FormChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_STUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_STUDENTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxKHOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit;
        private System.Windows.Forms.ComboBox lOPComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private DataSetMaster dataSetMaster;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private DataSetMasterTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private DataSetMasterTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private DSTableAdapters.V_STUDENTTableAdapter v_STUDENTTableAdapter;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit1;
        private System.Windows.Forms.BindingSource v_STUDENTBindingSource1;
        private System.Windows.Forms.BindingSource v_STUDENTBindingSource;
        private System.Windows.Forms.Button EXIT;
        private DSTableAdapters.sp_PHIEUDIEMTableAdapter sp_PHIEUDIEMTableAdapter1;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private DevExpress.XtraEditors.LookUpEdit sINHVIENComboBox;
    }
}