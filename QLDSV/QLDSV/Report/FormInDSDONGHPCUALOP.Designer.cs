namespace QLDSV.Report
{
    partial class FormInDSDONGHPCUALOP
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txthocky = new System.Windows.Forms.TextBox();
            this.txtnienkhoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sP_RPDONGHOCPHINEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_RPDONGHOCPHINEWTableAdapter = new QLDSV.DSTableAdapters.SP_RPDONGHOCPHINEWTableAdapter();
            this.sP_RPDONGHOCPHINEWBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtmalop = new DevExpress.XtraEditors.LookUpEdit();
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager1 = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            mALOPLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_RPDONGHOCPHINEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_RPDONGHOCPHINEWBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(220, 177);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 17);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "Mã lớp";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(535, 245);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(51, 17);
            hOCKYLabel.TabIndex = 7;
            hOCKYLabel.Text = "Học kỳ";
            hOCKYLabel.Click += new System.EventHandler(this.hOCKYLabel_Click);
            // 
            // nIENKHOALabel1
            // 
            nIENKHOALabel1.AutoSize = true;
            nIENKHOALabel1.Location = new System.Drawing.Point(530, 177);
            nIENKHOALabel1.Name = "nIENKHOALabel1";
            nIENKHOALabel1.Size = new System.Drawing.Size(68, 17);
            nIENKHOALabel1.TabIndex = 9;
            nIENKHOALabel1.Text = "Niên khóa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN DANH SÁCH ĐÓNG HỌC PHÍ CỦA LỚP";
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.dS;
            // 
            // txthocky
            // 
            this.txthocky.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "HOCKY", true));
            this.txthocky.Location = new System.Drawing.Point(610, 241);
            this.txthocky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthocky.Name = "txthocky";
            this.txthocky.Size = new System.Drawing.Size(140, 23);
            this.txthocky.TabIndex = 8;
            // 
            // txtnienkhoa
            // 
            this.txtnienkhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "NIENKHOA", true));
            this.txtnienkhoa.Location = new System.Drawing.Point(610, 171);
            this.txtnienkhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnienkhoa.Name = "txtnienkhoa";
            this.txtnienkhoa.Size = new System.Drawing.Size(140, 23);
            this.txtnienkhoa.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sP_RPDONGHOCPHINEWBindingSource
            // 
            this.sP_RPDONGHOCPHINEWBindingSource.DataSource = this.dS;
            this.sP_RPDONGHOCPHINEWBindingSource.Position = 0;
            // 
            // sP_RPDONGHOCPHINEWTableAdapter
            // 
            this.sP_RPDONGHOCPHINEWTableAdapter.ClearBeforeFill = true;
            // 
            // sP_RPDONGHOCPHINEWBindingSource1
            // 
            this.sP_RPDONGHOCPHINEWBindingSource1.DataSource = this.dS;
            this.sP_RPDONGHOCPHINEWBindingSource1.Position = 0;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(295, 174);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmalop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtmalop.Properties.DataSource = this.lOPBindingSource;
            this.txtmalop.Properties.DisplayMember = "MALOP";
            this.txtmalop.Properties.NullText = "";
            this.txtmalop.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.txtmalop.Properties.ValueMember = "MALOP";
            this.txtmalop.Size = new System.Drawing.Size(214, 22);
            this.txtmalop.TabIndex = 13;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.HOCPHITableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager1.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormInDSDONGHPCUALOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 705);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nIENKHOALabel1);
            this.Controls.Add(this.txtnienkhoa);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.txthocky);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInDSDONGHPCUALOP";
            this.Text = "FormInDSDONGHPCUALOP";
            this.Load += new System.EventHandler(this.FormInDSDONGHPCUALOP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_RPDONGHOCPHINEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_RPDONGHOCPHINEWBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private System.Windows.Forms.TextBox txthocky;
        private System.Windows.Forms.TextBox txtnienkhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sP_RPDONGHOCPHINEWBindingSource;
        private DSTableAdapters.SP_RPDONGHOCPHINEWTableAdapter sP_RPDONGHOCPHINEWTableAdapter;
        private System.Windows.Forms.BindingSource sP_RPDONGHOCPHINEWBindingSource1;
        private DevExpress.XtraEditors.LookUpEdit txtmalop;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}