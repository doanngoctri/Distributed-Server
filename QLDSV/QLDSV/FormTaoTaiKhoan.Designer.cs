namespace QLDSV
{
    partial class FormTaoTaiKhoan
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
            System.Windows.Forms.Label hO_TENLabel;
            System.Windows.Forms.Label hO_TENLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dS = new QLDSV.DS();
            this.gETDSSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gETDSSVTableAdapter = new QLDSV.DSTableAdapters.GETDSSVTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.hO_TENComboBox = new System.Windows.Forms.ComboBox();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QLDSV.DSTableAdapters.GIANGVIENTableAdapter();
            this.hO_TENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtreMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            hO_TENLabel = new System.Windows.Forms.Label();
            hO_TENLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETDSSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hO_TENTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hO_TENLabel
            // 
            hO_TENLabel.AutoSize = true;
            hO_TENLabel.Location = new System.Drawing.Point(182, 299);
            hO_TENLabel.Name = "hO_TENLabel";
            hO_TENLabel.Size = new System.Drawing.Size(30, 17);
            hO_TENLabel.TabIndex = 11;
            hO_TENLabel.Text = "Mã:";
            // 
            // hO_TENLabel1
            // 
            hO_TENLabel1.AutoSize = true;
            hO_TENLabel1.Location = new System.Drawing.Point(182, 359);
            hO_TENLabel1.Name = "hO_TENLabel1";
            hO_TENLabel1.Size = new System.Drawing.Size(52, 17);
            hO_TENLabel1.TabIndex = 12;
            hO_TENLabel1.Text = "Họ Tên";
            hO_TENLabel1.Click += new System.EventHandler(this.hO_TENLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm quyền:";
            // 
            // cmbNhom
            // 
            this.cmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(338, 78);
            this.cmbNhom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(196, 24);
            this.cmbNhom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(338, 128);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(196, 23);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(338, 177);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(196, 23);
            this.txtMatKhau.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(281, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tạo TK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Location = new System.Drawing.Point(390, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gETDSSVBindingSource
            // 
            this.gETDSSVBindingSource.DataMember = "GETDSSV";
            this.gETDSSVBindingSource.DataSource = this.dS;
            // 
            // gETDSSVTableAdapter
            // 
            this.gETDSSVTableAdapter.ClearBeforeFill = true;
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
            // hO_TENComboBox
            // 
            this.hO_TENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gETDSSVBindingSource, "HO TEN", true));
            this.hO_TENComboBox.DataSource = this.gETDSSVBindingSource;
            this.hO_TENComboBox.DisplayMember = "MAGV";
            this.hO_TENComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hO_TENComboBox.FormattingEnabled = true;
            this.hO_TENComboBox.Location = new System.Drawing.Point(338, 296);
            this.hO_TENComboBox.Name = "hO_TENComboBox";
            this.hO_TENComboBox.Size = new System.Drawing.Size(196, 24);
            this.hO_TENComboBox.TabIndex = 12;
            this.hO_TENComboBox.ValueMember = "MAGV";
            this.hO_TENComboBox.SelectedIndexChanged += new System.EventHandler(this.hO_TENComboBox_SelectedIndexChanged);
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dS;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // hO_TENTextEdit
            // 
            this.hO_TENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gETDSSVBindingSource, "HO TEN", true));
            this.hO_TENTextEdit.Location = new System.Drawing.Point(338, 354);
            this.hO_TENTextEdit.Name = "hO_TENTextEdit";
            this.hO_TENTextEdit.Properties.ReadOnly = true;
            this.hO_TENTextEdit.Size = new System.Drawing.Size(196, 22);
            this.hO_TENTextEdit.TabIndex = 13;
            // 
            // txtreMatKhau
            // 
            this.txtreMatKhau.Location = new System.Drawing.Point(338, 230);
            this.txtreMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtreMatKhau.Name = "txtreMatKhau";
            this.txtreMatKhau.PasswordChar = '*';
            this.txtreMatKhau.Size = new System.Drawing.Size(196, 23);
            this.txtreMatKhau.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập Lại Mật khẩu";
            // 
            // FormTaoTaiKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 547);
            this.Controls.Add(this.txtreMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(hO_TENLabel1);
            this.Controls.Add(this.hO_TENTextEdit);
            this.Controls.Add(hO_TENLabel);
            this.Controls.Add(this.hO_TENComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNhom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "FormTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETDSSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hO_TENTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DS dS;
        private System.Windows.Forms.BindingSource gETDSSVBindingSource;
        private DSTableAdapters.GETDSSVTableAdapter gETDSSVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hO_TENComboBox;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DevExpress.XtraEditors.TextEdit hO_TENTextEdit;
        private System.Windows.Forms.TextBox txtreMatKhau;
        private System.Windows.Forms.Label label4;
    }
}