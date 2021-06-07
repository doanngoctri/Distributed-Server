namespace QLDSV.Report
{
    partial class FormInDSSV
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
            this.tableAdapterManager1 = new QLDSV.DataSetMasterTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKHOA = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV.DS();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sp_InDSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_InDSSVTableAdapter = new QLDSV.DSTableAdapters.sp_InDSSVTableAdapter();
            this.sp_InDSSVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDSSVGridControl)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1000, 123);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLDSV.DataSetMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "KHOA";
            // 
            // comboBoxKHOA
            // 
            this.comboBoxKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKHOA.FormattingEnabled = true;
            this.comboBoxKHOA.Location = new System.Drawing.Point(154, 143);
            this.comboBoxKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKHOA.Name = "comboBoxKHOA";
            this.comboBoxKHOA.Size = new System.Drawing.Size(289, 24);
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
            this.lOPBindingSource.CurrentChanged += new System.EventHandler(this.lOPBindingSource_CurrentChanged);
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
            // lOPComboBox
            // 
            this.lOPComboBox.DataSource = this.lOPBindingSource;
            this.lOPComboBox.DisplayMember = "TENLOP";
            this.lOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lOPComboBox.FormattingEnabled = true;
            this.lOPComboBox.Location = new System.Drawing.Point(154, 198);
            this.lOPComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(289, 24);
            this.lOPComboBox.TabIndex = 4;
            this.lOPComboBox.ValueMember = "MALOP";
            this.lOPComboBox.SelectedIndexChanged += new System.EventHandler(this.lOPComboBox_SelectedIndexChanged);
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.txtMALOP.Enabled = false;
            this.txtMALOP.Location = new System.Drawing.Point(471, 198);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(167, 23);
            this.txtMALOP.TabIndex = 5;
            this.txtMALOP.TextChanged += new System.EventHandler(this.txtMALOP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên lớp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 288);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sp_InDSSVBindingSource
            // 
            this.sp_InDSSVBindingSource.DataMember = "sp_InDSSV";
            this.sp_InDSSVBindingSource.DataSource = this.dS;
            // 
            // sp_InDSSVTableAdapter
            // 
            this.sp_InDSSVTableAdapter.ClearBeforeFill = true;
            // 
            // sp_InDSSVGridControl
            // 
            this.sp_InDSSVGridControl.DataSource = this.sp_InDSSVBindingSource;
            this.sp_InDSSVGridControl.Location = new System.Drawing.Point(33, 437);
            this.sp_InDSSVGridControl.MainView = this.gridView1;
            this.sp_InDSSVGridControl.Name = "sp_InDSSVGridControl";
            this.sp_InDSSVGridControl.Size = new System.Drawing.Size(967, 220);
            this.sp_InDSSVGridControl.TabIndex = 10;
            this.sp_InDSSVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI});
            this.gridView1.GridControl = this.sp_InDSSVGridControl;
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
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            this.colNGAYSINH.Width = 94;
            // 
            // colNOISINH
            // 
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.MinWidth = 25;
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 5;
            this.colNOISINH.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 6;
            this.colDIACHI.Width = 94;
            // 
            // FormInDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 718);
            this.Controls.Add(this.sp_InDSSVGridControl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMALOP);
            this.Controls.Add(this.lOPComboBox);
            this.Controls.Add(this.comboBoxKHOA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInDSSV";
            this.Text = "FormInDSSV";
            this.Load += new System.EventHandler(this.FormInDSSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InDSSVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DataSetMasterTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKHOA;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox lOPComboBox;
        private System.Windows.Forms.TextBox txtMALOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource sp_InDSSVBindingSource;
        private DSTableAdapters.sp_InDSSVTableAdapter sp_InDSSVTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_InDSSVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
    }
}