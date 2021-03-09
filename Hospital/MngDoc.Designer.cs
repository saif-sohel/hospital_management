namespace Hospital
{
    partial class MngDoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.ckbPass = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dBActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBActionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBActionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDoc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvUserID,
            this.dgvName,
            this.dgvGender,
            this.dgvDoB,
            this.dgvAddress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoc.Location = new System.Drawing.Point(3, 103);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.ReadOnly = true;
            this.dgvDoc.RowHeadersVisible = false;
            this.dgvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoc.Size = new System.Drawing.Size(889, 442);
            this.dgvDoc.TabIndex = 0;
            this.dgvDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellClick);
            this.dgvDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.ckbPass);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.cbGender);
            this.panel2.Controls.Add(this.dtpDoB);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblDoB);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(898, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 442);
            this.panel2.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(898, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 94);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(895, 100);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 94);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(760, 94);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Doctor Management Panel";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(772, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 94);
            this.panel4.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::Hospital.Properties.Resources.refresh_outline_50;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Location = new System.Drawing.Point(84, 59);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(3, 129);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(3, 160);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(80, 16);
            this.lblDoB.TabIndex = 5;
            this.lblDoB.Text = "Date of Birth";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 187);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(88, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(88, 42);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(147, 22);
            this.txtID.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(89, 184);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 60);
            this.txtAddress.TabIndex = 11;
            // 
            // dtpDoB
            // 
            this.dtpDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(88, 156);
            this.dtpDoB.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpDoB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(146, 22);
            this.dtpDoB.TabIndex = 12;
            this.dtpDoB.Value = new System.DateTime(2019, 12, 26, 0, 0, 0, 0);
            this.dtpDoB.ValueChanged += new System.EventHandler(this.dtpDoB_ValueChanged);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(88, 126);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(147, 24);
            this.cbGender.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(89, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPass.Location = new System.Drawing.Point(88, 70);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(125, 22);
            this.txtPass.TabIndex = 16;
            // 
            // ckbPass
            // 
            this.ckbPass.AutoSize = true;
            this.ckbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPass.Location = new System.Drawing.Point(219, 75);
            this.ckbPass.Name = "ckbPass";
            this.ckbPass.Size = new System.Drawing.Size(15, 14);
            this.ckbPass.TabIndex = 17;
            this.ckbPass.UseVisualStyleBackColor = true;
            this.ckbPass.CheckedChanged += new System.EventHandler(this.ckbPass_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(6, 247);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(228, 48);
            this.lblMsg.TabIndex = 18;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            this.dgvID.Width = 31;
            // 
            // dgvUserID
            // 
            this.dgvUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvUserID.DataPropertyName = "UserID";
            this.dgvUserID.HeaderText = "ID";
            this.dgvUserID.Name = "dgvUserID";
            this.dgvUserID.ReadOnly = true;
            this.dgvUserID.Width = 50;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvGender
            // 
            this.dgvGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGender.DataPropertyName = "Gender";
            this.dgvGender.HeaderText = "Gender";
            this.dgvGender.Name = "dgvGender";
            this.dgvGender.ReadOnly = true;
            // 
            // dgvDoB
            // 
            this.dgvDoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDoB.DataPropertyName = "DoB";
            this.dgvDoB.HeaderText = "Date of Birth";
            this.dgvDoB.Name = "dgvDoB";
            this.dgvDoB.ReadOnly = true;
            // 
            // dgvAddress
            // 
            this.dgvAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAddress.DataPropertyName = "Address";
            this.dgvAddress.HeaderText = "Address";
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(166, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dBActionBindingSource
            // 
            this.dBActionBindingSource.DataSource = typeof(Hospital.DBAction);
            // 
            // dBActionBindingSource1
            // 
            this.dBActionBindingSource1.DataSource = typeof(Hospital.DBAction);
            // 
            // MngDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MngDoc";
            this.Text = "MngDoc";
            this.Load += new System.EventHandler(this.MngDoc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBActionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource dBActionBindingSource;
        private System.Windows.Forms.BindingSource dBActionBindingSource1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox ckbPass;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.Button btnDelete;
    }
}