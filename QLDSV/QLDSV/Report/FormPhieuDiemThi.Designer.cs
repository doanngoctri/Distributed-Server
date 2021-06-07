namespace QLDSV.Report
{
    partial class FormPhieuDiemThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKHOA = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lanThi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateEditThi = new DevExpress.XtraEditors.DateEdit();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.rP_DANHSACHTHIHETMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rP_DANHSACHTHIHETMONTableAdapter = new QLDSV.DSTableAdapters.RP_DANHSACHTHIHETMONTableAdapter();
            this.rP_DANHSACHTHIHETMONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rP_DANHSACHTHIHETMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rP_DANHSACHTHIHETMONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 103);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH THI HẾT MÔN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "KHOA";
            // 
            // comboBoxKHOA
            // 
            this.comboBoxKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKHOA.FormattingEnabled = true;
            this.comboBoxKHOA.Location = new System.Drawing.Point(253, 139);
            this.comboBoxKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKHOA.Name = "comboBoxKHOA";
            this.comboBoxKHOA.Size = new System.Drawing.Size(240, 24);
            this.comboBoxKHOA.TabIndex = 2;
            this.comboBoxKHOA.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lOPBindingSource;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(253, 203);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(240, 24);
            this.cmbLop.TabIndex = 4;
            this.cmbLop.ValueMember = "MALOP";
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên lớp";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.mONHOCBindingSource;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(253, 278);
            this.cmbTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(240, 24);
            this.cmbTenMH.TabIndex = 5;
            this.cmbTenMH.ValueMember = "MAMH";
            this.cmbTenMH.SelectedIndexChanged += new System.EventHandler(this.cmbTenMH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Học kỳ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày thi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lần thi";
            // 
            // lanThi
            // 
            this.lanThi.Location = new System.Drawing.Point(650, 274);
            this.lanThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lanThi.Name = "lanThi";
            this.lanThi.Size = new System.Drawing.Size(116, 23);
            this.lanThi.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateEditThi
            // 
            this.dateEditThi.EditValue = null;
            this.dateEditThi.Location = new System.Drawing.Point(650, 203);
            this.dateEditThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEditThi.Name = "dateEditThi";
            this.dateEditThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditThi.Size = new System.Drawing.Size(117, 22);
            this.dateEditThi.TabIndex = 15;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(372, 242);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(116, 23);
            this.txtMaLop.TabIndex = 16;
            // 
            // rP_DANHSACHTHIHETMONBindingSource
            // 
            this.rP_DANHSACHTHIHETMONBindingSource.DataMember = "RP_DANHSACHTHIHETMON";
            this.rP_DANHSACHTHIHETMONBindingSource.DataSource = this.dS;
            // 
            // rP_DANHSACHTHIHETMONTableAdapter
            // 
            this.rP_DANHSACHTHIHETMONTableAdapter.ClearBeforeFill = true;
            // 
            // rP_DANHSACHTHIHETMONGridControl
            // 
            this.rP_DANHSACHTHIHETMONGridControl.DataSource = this.rP_DANHSACHTHIHETMONBindingSource;
            this.rP_DANHSACHTHIHETMONGridControl.Location = new System.Drawing.Point(61, 470);
            this.rP_DANHSACHTHIHETMONGridControl.MainView = this.gridView1;
            this.rP_DANHSACHTHIHETMONGridControl.Name = "rP_DANHSACHTHIHETMONGridControl";
            this.rP_DANHSACHTHIHETMONGridControl.Size = new System.Drawing.Size(927, 220);
            this.rP_DANHSACHTHIHETMONGridControl.TabIndex = 17;
            this.rP_DANHSACHTHIHETMONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMASV,
            this.colHOTEN,
            this.colSOTO,
            this.colDIEM,
            this.colCHUKY});
            this.gridView1.GridControl = this.rP_DANHSACHTHIHETMONGridControl;
            this.gridView1.Name = "gridView1";
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
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 1;
            this.colMASV.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            this.colHOTEN.Width = 94;
            // 
            // colSOTO
            // 
            this.colSOTO.FieldName = "SOTO";
            this.colSOTO.MinWidth = 25;
            this.colSOTO.Name = "colSOTO";
            this.colSOTO.Visible = true;
            this.colSOTO.VisibleIndex = 3;
            this.colSOTO.Width = 94;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 4;
            this.colDIEM.Width = 94;
            // 
            // colCHUKY
            // 
            this.colCHUKY.FieldName = "CHUKY";
            this.colCHUKY.MinWidth = 25;
            this.colCHUKY.Name = "colCHUKY";
            this.colCHUKY.Visible = true;
            this.colCHUKY.VisibleIndex = 5;
            this.colCHUKY.Width = 94;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 364);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormPhieuDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 739);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rP_DANHSACHTHIHETMONGridControl);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.dateEditThi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lanThi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTenMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.comboBoxKHOA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPhieuDiemThi";
            this.Text = "FormPhieuDiemThi";
            this.Load += new System.EventHandler(this.FormPhieuDiemThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rP_DANHSACHTHIHETMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rP_DANHSACHTHIHETMONGridControl)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lanThi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.DateEdit dateEditThi;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.BindingSource rP_DANHSACHTHIHETMONBindingSource;
        private DSTableAdapters.RP_DANHSACHTHIHETMONTableAdapter rP_DANHSACHTHIHETMONTableAdapter;
        private DevExpress.XtraGrid.GridControl rP_DANHSACHTHIHETMONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUKY;
        private System.Windows.Forms.Button button3;
    }
}