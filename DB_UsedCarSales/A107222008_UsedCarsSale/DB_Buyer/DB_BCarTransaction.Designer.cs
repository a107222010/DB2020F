namespace A107222008_UsedCar
{
    partial class frmBCarTransaction
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
            this.tclPage = new System.Windows.Forms.TabControl();
            this.tpMyCR = new System.Windows.Forms.TabPage();
            this.lb123 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.cbxOrderID = new System.Windows.Forms.ComboBox();
            this.lbMyID = new System.Windows.Forms.Label();
            this.dgvMyOF = new System.Windows.Forms.DataGridView();
            this.tpBuyerCR = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.tbxCR = new System.Windows.Forms.TextBox();
            this.cbxRI = new System.Windows.Forms.ComboBox();
            this.btnGiveCR = new System.Windows.Forms.Button();
            this.lbFOFS = new System.Windows.Forms.Label();
            this.dgvFOF = new System.Windows.Forms.DataGridView();
            this.tclPage.SuspendLayout();
            this.tpMyCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOF)).BeginInit();
            this.tpBuyerCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFOF)).BeginInit();
            this.SuspendLayout();
            // 
            // tclPage
            // 
            this.tclPage.Controls.Add(this.tpMyCR);
            this.tclPage.Controls.Add(this.tpBuyerCR);
            this.tclPage.Font = new System.Drawing.Font("新細明體", 12F);
            this.tclPage.Location = new System.Drawing.Point(8, 15);
            this.tclPage.Margin = new System.Windows.Forms.Padding(4);
            this.tclPage.Name = "tclPage";
            this.tclPage.SelectedIndex = 0;
            this.tclPage.Size = new System.Drawing.Size(1164, 694);
            this.tclPage.TabIndex = 4;
            // 
            // tpMyCR
            // 
            this.tpMyCR.Controls.Add(this.lb123);
            this.tpMyCR.Controls.Add(this.btnCancel);
            this.tpMyCR.Controls.Add(this.btnFinish);
            this.tpMyCR.Controls.Add(this.cbxOrderID);
            this.tpMyCR.Controls.Add(this.lbMyID);
            this.tpMyCR.Controls.Add(this.dgvMyOF);
            this.tpMyCR.Font = new System.Drawing.Font("新細明體", 12F);
            this.tpMyCR.Location = new System.Drawing.Point(4, 30);
            this.tpMyCR.Margin = new System.Windows.Forms.Padding(4);
            this.tpMyCR.Name = "tpMyCR";
            this.tpMyCR.Padding = new System.Windows.Forms.Padding(4);
            this.tpMyCR.Size = new System.Drawing.Size(1156, 660);
            this.tpMyCR.TabIndex = 0;
            this.tpMyCR.Text = "目前訂單";
            this.tpMyCR.UseVisualStyleBackColor = true;
            this.tpMyCR.Click += new System.EventHandler(this.tpMyCR_Click);
            // 
            // lb123
            // 
            this.lb123.AutoSize = true;
            this.lb123.Font = new System.Drawing.Font("新細明體", 15F);
            this.lb123.Location = new System.Drawing.Point(375, 18);
            this.lb123.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb123.Name = "lb123";
            this.lb123.Size = new System.Drawing.Size(112, 25);
            this.lb123.TabIndex = 9;
            this.lb123.Text = "訂單編號";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(689, 56);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "刪除訂單";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(569, 56);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 36);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "完成訂單";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click_1);
            // 
            // cbxOrderID
            // 
            this.cbxOrderID.FormattingEnabled = true;
            this.cbxOrderID.Location = new System.Drawing.Point(380, 60);
            this.cbxOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOrderID.Name = "cbxOrderID";
            this.cbxOrderID.Size = new System.Drawing.Size(160, 28);
            this.cbxOrderID.TabIndex = 6;
            this.cbxOrderID.SelectedIndexChanged += new System.EventHandler(this.cbxOrderID_SelectedIndexChanged);
            // 
            // lbMyID
            // 
            this.lbMyID.AutoSize = true;
            this.lbMyID.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbMyID.Location = new System.Drawing.Point(33, 56);
            this.lbMyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMyID.Name = "lbMyID";
            this.lbMyID.Size = new System.Drawing.Size(125, 25);
            this.lbMyID.TabIndex = 1;
            this.lbMyID.Text = "買家名稱: ";
            // 
            // dgvMyOF
            // 
            this.dgvMyOF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyOF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyOF.Location = new System.Drawing.Point(8, 116);
            this.dgvMyOF.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMyOF.Name = "dgvMyOF";
            this.dgvMyOF.RowHeadersWidth = 51;
            this.dgvMyOF.RowTemplate.Height = 24;
            this.dgvMyOF.Size = new System.Drawing.Size(1140, 511);
            this.dgvMyOF.TabIndex = 0;
            this.dgvMyOF.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyOF_RowEnter);
            // 
            // tpBuyerCR
            // 
            this.tpBuyerCR.Controls.Add(this.label1);
            this.tpBuyerCR.Controls.Add(this.lblR);
            this.tpBuyerCR.Controls.Add(this.tbxCR);
            this.tpBuyerCR.Controls.Add(this.cbxRI);
            this.tpBuyerCR.Controls.Add(this.btnGiveCR);
            this.tpBuyerCR.Controls.Add(this.lbFOFS);
            this.tpBuyerCR.Controls.Add(this.dgvFOF);
            this.tpBuyerCR.Location = new System.Drawing.Point(4, 30);
            this.tpBuyerCR.Margin = new System.Windows.Forms.Padding(4);
            this.tpBuyerCR.Name = "tpBuyerCR";
            this.tpBuyerCR.Padding = new System.Windows.Forms.Padding(4);
            this.tpBuyerCR.Size = new System.Drawing.Size(1156, 660);
            this.tpBuyerCR.TabIndex = 1;
            this.tpBuyerCR.Text = "完成訂單";
            this.tpBuyerCR.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(505, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "評分(1~100分)";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblR.Location = new System.Drawing.Point(340, 25);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(112, 25);
            this.lblR.TabIndex = 10;
            this.lblR.Text = "紀錄編號";
            // 
            // tbxCR
            // 
            this.tbxCR.Location = new System.Drawing.Point(511, 66);
            this.tbxCR.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCR.Name = "tbxCR";
            this.tbxCR.Size = new System.Drawing.Size(163, 31);
            this.tbxCR.TabIndex = 9;
            this.tbxCR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCR_KeyPress);
            // 
            // cbxRI
            // 
            this.cbxRI.FormattingEnabled = true;
            this.cbxRI.Location = new System.Drawing.Point(345, 66);
            this.cbxRI.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRI.Name = "cbxRI";
            this.cbxRI.Size = new System.Drawing.Size(133, 28);
            this.cbxRI.TabIndex = 8;
            // 
            // btnGiveCR
            // 
            this.btnGiveCR.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnGiveCR.Location = new System.Drawing.Point(687, 60);
            this.btnGiveCR.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiveCR.Name = "btnGiveCR";
            this.btnGiveCR.Size = new System.Drawing.Size(136, 40);
            this.btnGiveCR.TabIndex = 7;
            this.btnGiveCR.Text = "儲存評價";
            this.btnGiveCR.UseVisualStyleBackColor = true;
            this.btnGiveCR.Click += new System.EventHandler(this.btnGiveCR_Click);
            // 
            // lbFOFS
            // 
            this.lbFOFS.AutoSize = true;
            this.lbFOFS.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbFOFS.Location = new System.Drawing.Point(32, 71);
            this.lbFOFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFOFS.Name = "lbFOFS";
            this.lbFOFS.Size = new System.Drawing.Size(119, 25);
            this.lbFOFS.TabIndex = 6;
            this.lbFOFS.Text = "買家名稱:";
            // 
            // dgvFOF
            // 
            this.dgvFOF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFOF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFOF.Location = new System.Drawing.Point(7, 138);
            this.dgvFOF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFOF.Name = "dgvFOF";
            this.dgvFOF.RowHeadersWidth = 51;
            this.dgvFOF.RowTemplate.Height = 27;
            this.dgvFOF.Size = new System.Drawing.Size(1142, 472);
            this.dgvFOF.TabIndex = 3;
            this.dgvFOF.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFOF_RowEnter);
            // 
            // frmBCarTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 709);
            this.Controls.Add(this.tclPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBCarTransaction";
            this.Text = "訂單交易";
            this.Load += new System.EventHandler(this.frmBCT_Load);
            this.tclPage.ResumeLayout(false);
            this.tpMyCR.ResumeLayout(false);
            this.tpMyCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyOF)).EndInit();
            this.tpBuyerCR.ResumeLayout(false);
            this.tpBuyerCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFOF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclPage;
        private System.Windows.Forms.TabPage tpMyCR;
        private System.Windows.Forms.Label lbMyID;
        private System.Windows.Forms.DataGridView dgvMyOF;
        private System.Windows.Forms.TabPage tpBuyerCR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox tbxCR;
        private System.Windows.Forms.ComboBox cbxRI;
        private System.Windows.Forms.Button btnGiveCR;
        private System.Windows.Forms.Label lbFOFS;
        private System.Windows.Forms.DataGridView dgvFOF;
        private System.Windows.Forms.Label lb123;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cbxOrderID;
    }
}