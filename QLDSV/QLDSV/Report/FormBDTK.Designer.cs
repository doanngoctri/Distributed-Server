namespace QLDSV.Report
{
    partial class FormBDTK
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKHOA = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.txtTENLOP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.sp_BANGDIEMTONGKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BANGDIEMTONGKETTableAdapter = new QLDSV.DSTableAdapters.sp_BANGDIEMTONGKETTableAdapter();
            this.sp_BANGDIEMTONGKETGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMTONGKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMTONGKETGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(973, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "KHOA";
            // 
            // comboBoxKHOA
            // 
            this.comboBoxKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKHOA.FormattingEnabled = true;
            this.comboBoxKHOA.Location = new System.Drawing.Point(211, 144);
            this.comboBoxKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKHOA.Name = "comboBoxKHOA";
            this.comboBoxKHOA.Size = new System.Drawing.Size(294, 24);
            this.comboBoxKHOA.TabIndex = 4;
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
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataSource = this.lOPBindingSource;
            this.txtTENLOP.DisplayMember = "TENLOP";
            this.txtTENLOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTENLOP.FormattingEnabled = true;
            this.txtTENLOP.Location = new System.Drawing.Point(211, 210);
            this.txtTENLOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Size = new System.Drawing.Size(294, 24);
            this.txtTENLOP.TabIndex = 6;
            this.txtTENLOP.ValueMember = "MALOP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên lớp";
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(390, 256);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.ReadOnly = true;
            this.txtMALOP.Size = new System.Drawing.Size(116, 23);
            this.txtMALOP.TabIndex = 8;
            // 
            // sp_BANGDIEMTONGKETBindingSource
            // 
            this.sp_BANGDIEMTONGKETBindingSource.DataMember = "sp_BANGDIEMTONGKET";
            this.sp_BANGDIEMTONGKETBindingSource.DataSource = this.dS;
            // 
            // sp_BANGDIEMTONGKETTableAdapter
            // 
            this.sp_BANGDIEMTONGKETTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BANGDIEMTONGKETGridControl
            // 
            this.sp_BANGDIEMTONGKETGridControl.DataSource = this.sp_BANGDIEMTONGKETBindingSource;
            this.sp_BANGDIEMTONGKETGridControl.Location = new System.Drawing.Point(117, 407);
            this.sp_BANGDIEMTONGKETGridControl.MainView = this.gridView1;
            this.sp_BANGDIEMTONGKETGridControl.Name = "sp_BANGDIEMTONGKETGridControl";
            this.sp_BANGDIEMTONGKETGridControl.Size = new System.Drawing.Size(794, 269);
            this.sp_BANGDIEMTONGKETGridControl.TabIndex = 9;
            this.sp_BANGDIEMTONGKETGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colTENMH,
            this.colDIEM});
            this.gridView1.GridControl = this.sp_BANGDIEMTONGKETGridControl;
            this.gridView1.Name = "gridView1";
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
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            this.colTENMH.Width = 94;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            this.colDIEM.Width = 94;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 289);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormBDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 703);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sp_BANGDIEMTONGKETGridControl);
            this.Controls.Add(this.txtMALOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTENLOP);
            this.Controls.Add(this.comboBoxKHOA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBDTK";
            this.Text = "FormBDTK";
            this.Load += new System.EventHandler(this.FormBDTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMTONGKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BANGDIEMTONGKETGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKHOA;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox txtTENLOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMALOP;
        private System.Windows.Forms.BindingSource sp_BANGDIEMTONGKETBindingSource;
        private DSTableAdapters.sp_BANGDIEMTONGKETTableAdapter sp_BANGDIEMTONGKETTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_BANGDIEMTONGKETGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.Button button3;
    }
}