namespace A107222008_UsedCar
{
    partial class frmSCreditRating
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
            this.lbTCR = new System.Windows.Forms.Label();
            this.lbMyID = new System.Windows.Forms.Label();
            this.dgvMyCR = new System.Windows.Forms.DataGridView();
            this.tpBuyerCR = new System.Windows.Forms.TabPage();
            this.cbxbuyerID = new System.Windows.Forms.ComboBox();
            this.lblSCR = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.btnCreditRating = new System.Windows.Forms.Button();
            this.dgvCreditRating = new System.Windows.Forms.DataGridView();
            this.tclPage.SuspendLayout();
            this.tpMyCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCR)).BeginInit();
            this.tpBuyerCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditRating)).BeginInit();
            this.SuspendLayout();
            // 
            // tclPage
            // 
            this.tclPage.Controls.Add(this.tpMyCR);
            this.tclPage.Controls.Add(this.tpBuyerCR);
            this.tclPage.Font = new System.Drawing.Font("新細明體", 12F);
            this.tclPage.Location = new System.Drawing.Point(4, 0);
            this.tclPage.Margin = new System.Windows.Forms.Padding(4);
            this.tclPage.Name = "tclPage";
            this.tclPage.SelectedIndex = 0;
            this.tclPage.Size = new System.Drawing.Size(811, 616);
            this.tclPage.TabIndex = 2;
            // 
            // tpMyCR
            // 
            this.tpMyCR.Controls.Add(this.lbTCR);
            this.tpMyCR.Controls.Add(this.lbMyID);
            this.tpMyCR.Controls.Add(this.dgvMyCR);
            this.tpMyCR.Font = new System.Drawing.Font("新細明體", 12F);
            this.tpMyCR.Location = new System.Drawing.Point(4, 30);
            this.tpMyCR.Margin = new System.Windows.Forms.Padding(4);
            this.tpMyCR.Name = "tpMyCR";
            this.tpMyCR.Padding = new System.Windows.Forms.Padding(4);
            this.tpMyCR.Size = new System.Drawing.Size(803, 582);
            this.tpMyCR.TabIndex = 0;
            this.tpMyCR.Text = "我的評價";
            this.tpMyCR.UseVisualStyleBackColor = true;
            this.tpMyCR.Click += new System.EventHandler(this.tpMyCR_Click);
            // 
            // lbTCR
            // 
            this.lbTCR.AutoSize = true;
            this.lbTCR.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbTCR.Location = new System.Drawing.Point(396, 41);
            this.lbTCR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTCR.Name = "lbTCR";
            this.lbTCR.Size = new System.Drawing.Size(100, 25);
            this.lbTCR.TabIndex = 2;
            this.lbTCR.Text = "總評價: ";
            // 
            // lbMyID
            // 
            this.lbMyID.AutoSize = true;
            this.lbMyID.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbMyID.Location = new System.Drawing.Point(36, 41);
            this.lbMyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMyID.Name = "lbMyID";
            this.lbMyID.Size = new System.Drawing.Size(125, 25);
            this.lbMyID.TabIndex = 1;
            this.lbMyID.Text = "商家名稱: ";
            // 
            // dgvMyCR
            // 
            this.dgvMyCR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyCR.Location = new System.Drawing.Point(8, 88);
            this.dgvMyCR.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMyCR.Name = "dgvMyCR";
            this.dgvMyCR.RowHeadersWidth = 51;
            this.dgvMyCR.RowTemplate.Height = 24;
            this.dgvMyCR.Size = new System.Drawing.Size(787, 439);
            this.dgvMyCR.TabIndex = 0;
            this.dgvMyCR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyCR_CellContentClick);
            // 
            // tpBuyerCR
            // 
            this.tpBuyerCR.Controls.Add(this.cbxbuyerID);
            this.tpBuyerCR.Controls.Add(this.lblSCR);
            this.tpBuyerCR.Controls.Add(this.lbS);
            this.tpBuyerCR.Controls.Add(this.btnCreditRating);
            this.tpBuyerCR.Controls.Add(this.dgvCreditRating);
            this.tpBuyerCR.Location = new System.Drawing.Point(4, 30);
            this.tpBuyerCR.Margin = new System.Windows.Forms.Padding(4);
            this.tpBuyerCR.Name = "tpBuyerCR";
            this.tpBuyerCR.Padding = new System.Windows.Forms.Padding(4);
            this.tpBuyerCR.Size = new System.Drawing.Size(803, 582);
            this.tpBuyerCR.TabIndex = 1;
            this.tpBuyerCR.Text = "買家的評價";
            this.tpBuyerCR.UseVisualStyleBackColor = true;
            // 
            // cbxbuyerID
            // 
            this.cbxbuyerID.FormattingEnabled = true;
            this.cbxbuyerID.Location = new System.Drawing.Point(240, 31);
            this.cbxbuyerID.Name = "cbxbuyerID";
            this.cbxbuyerID.Size = new System.Drawing.Size(121, 28);
            this.cbxbuyerID.TabIndex = 8;
            // 
            // lblSCR
            // 
            this.lblSCR.AutoSize = true;
            this.lblSCR.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblSCR.Location = new System.Drawing.Point(533, 34);
            this.lblSCR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSCR.Name = "lblSCR";
            this.lblSCR.Size = new System.Drawing.Size(100, 25);
            this.lblSCR.TabIndex = 7;
            this.lblSCR.Text = "總評分: ";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbS.Location = new System.Drawing.Point(33, 34);
            this.lbS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(200, 25);
            this.lbS.TabIndex = 6;
            this.lbS.Text = "請輸入買家編號: ";
            // 
            // btnCreditRating
            // 
            this.btnCreditRating.Location = new System.Drawing.Point(382, 27);
            this.btnCreditRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreditRating.Name = "btnCreditRating";
            this.btnCreditRating.Size = new System.Drawing.Size(105, 34);
            this.btnCreditRating.TabIndex = 5;
            this.btnCreditRating.Text = "查詢";
            this.btnCreditRating.UseVisualStyleBackColor = true;
            this.btnCreditRating.Click += new System.EventHandler(this.btnCreditRating_Click);
            // 
            // dgvCreditRating
            // 
            this.dgvCreditRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditRating.Location = new System.Drawing.Point(7, 95);
            this.dgvCreditRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCreditRating.Name = "dgvCreditRating";
            this.dgvCreditRating.RowHeadersWidth = 51;
            this.dgvCreditRating.RowTemplate.Height = 27;
            this.dgvCreditRating.Size = new System.Drawing.Size(788, 444);
            this.dgvCreditRating.TabIndex = 3;
            // 
            // frmSCreditRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 621);
            this.Controls.Add(this.tclPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSCreditRating";
            this.Text = "會員評價";
            this.Load += new System.EventHandler(this.frmSCreditRating_Load);
            this.tclPage.ResumeLayout(false);
            this.tpMyCR.ResumeLayout(false);
            this.tpMyCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyCR)).EndInit();
            this.tpBuyerCR.ResumeLayout(false);
            this.tpBuyerCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclPage;
        private System.Windows.Forms.TabPage tpMyCR;
        private System.Windows.Forms.Label lbTCR;
        private System.Windows.Forms.Label lbMyID;
        private System.Windows.Forms.DataGridView dgvMyCR;
        private System.Windows.Forms.TabPage tpBuyerCR;
        private System.Windows.Forms.Label lblSCR;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Button btnCreditRating;
        private System.Windows.Forms.DataGridView dgvCreditRating;
        private System.Windows.Forms.ComboBox cbxbuyerID;
    }
}