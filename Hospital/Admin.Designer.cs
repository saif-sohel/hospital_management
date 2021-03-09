namespace Hospital
{
    partial class Admin
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
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnPat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.welMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(12, 12);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(160, 50);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Manage Doctors";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnPat
            // 
            this.btnPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPat.Location = new System.Drawing.Point(178, 12);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(150, 50);
            this.btnPat.TabIndex = 2;
            this.btnPat.Text = "Manage Patients";
            this.btnPat.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(334, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Manage Rooms";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(334, 68);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // welMsg
            // 
            this.welMsg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.welMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welMsg.Location = new System.Drawing.Point(12, 68);
            this.welMsg.Name = "welMsg";
            this.welMsg.Size = new System.Drawing.Size(316, 50);
            this.welMsg.TabIndex = 5;
            this.welMsg.Text = "Welcome <PlaceHolder>.";
            this.welMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 130);
            this.Controls.Add(this.welMsg);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPat);
            this.Controls.Add(this.btnDoc);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label welMsg;
    }
}