namespace A107222008_UsedCar
{
    partial class frmCarMenu
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
            this.cbxCarBrand = new System.Windows.Forms.ComboBox();
            this.cbxCarType = new System.Windows.Forms.ComboBox();
            this.cbxCarStyle = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBuyerCR = new System.Windows.Forms.Button();
            this.btnSellerSC = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSellerCR = new System.Windows.Forms.Button();
            this.lbCB = new System.Windows.Forms.Label();
            this.lbCT = new System.Windows.Forms.Label();
            this.lbCS = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSCarOrder = new System.Windows.Forms.Button();
            this.btnBCarOrder = new System.Windows.Forms.Button();
            this.lbEC = new System.Windows.Forms.Label();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lbbbb = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCarBrand
            // 
            this.cbxCarBrand.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarBrand.FormattingEnabled = true;
            this.cbxCarBrand.Location = new System.Drawing.Point(272, 176);
            this.cbxCarBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCarBrand.Name = "cbxCarBrand";
            this.cbxCarBrand.Size = new System.Drawing.Size(160, 33);
            this.cbxCarBrand.TabIndex = 6;
            this.cbxCarBrand.SelectedIndexChanged += new System.EventHandler(this.cbxCarBrand_SelectedIndexChanged_1);
            // 
            // cbxCarType
            // 
            this.cbxCarType.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarType.FormattingEnabled = true;
            this.cbxCarType.Location = new System.Drawing.Point(493, 176);
            this.cbxCarType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCarType.Name = "cbxCarType";
            this.cbxCarType.Size = new System.Drawing.Size(165, 33);
            this.cbxCarType.TabIndex = 7;
            this.cbxCarType.SelectedIndexChanged += new System.EventHandler(this.cbxCarType_SelectedIndexChanged);
            // 
            // cbxCarStyle
            // 
            this.cbxCarStyle.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarStyle.FormattingEnabled = true;
            this.cbxCarStyle.Location = new System.Drawing.Point(709, 176);
            this.cbxCarStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCarStyle.Name = "cbxCarStyle";
            this.cbxCarStyle.Size = new System.Drawing.Size(160, 33);
            this.cbxCarStyle.TabIndex = 8;
            this.cbxCarStyle.Visible = false;
            this.cbxCarStyle.SelectedIndexChanged += new System.EventHandler(this.cbxCarStyle_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSearch.Location = new System.Drawing.Point(771, 78);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "尋找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(277, 78);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearch.MaxLength = 30;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(456, 25);
            this.tbxSearch.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(1288, 714);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 48);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignUp.Location = new System.Drawing.Point(1129, 714);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(129, 48);
            this.btnSignUp.TabIndex = 35;
            this.btnSignUp.Text = "註冊";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // btnBuyerCR
            // 
            this.btnBuyerCR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuyerCR.Location = new System.Drawing.Point(1129, 714);
            this.btnBuyerCR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuyerCR.Name = "btnBuyerCR";
            this.btnBuyerCR.Size = new System.Drawing.Size(129, 48);
            this.btnBuyerCR.TabIndex = 36;
            this.btnBuyerCR.Text = "查詢評價";
            this.btnBuyerCR.UseVisualStyleBackColor = true;
            this.btnBuyerCR.Click += new System.EventHandler(this.btnSellerCR_Click);
            // 
            // btnSellerSC
            // 
            this.btnSellerSC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSellerSC.Location = new System.Drawing.Point(807, 714);
            this.btnSellerSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSellerSC.Name = "btnSellerSC";
            this.btnSellerSC.Size = new System.Drawing.Size(129, 48);
            this.btnSellerSC.TabIndex = 37;
            this.btnSellerSC.Text = "賣車GO";
            this.btnSellerSC.UseVisualStyleBackColor = true;
            this.btnSellerSC.Click += new System.EventHandler(this.btnSellerSC_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.Location = new System.Drawing.Point(1288, 714);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 48);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSellerCR
            // 
            this.btnSellerCR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSellerCR.Location = new System.Drawing.Point(1129, 714);
            this.btnSellerCR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSellerCR.Name = "btnSellerCR";
            this.btnSellerCR.Size = new System.Drawing.Size(129, 48);
            this.btnSellerCR.TabIndex = 39;
            this.btnSellerCR.Text = "查詢評價";
            this.btnSellerCR.UseVisualStyleBackColor = true;
            this.btnSellerCR.Click += new System.EventHandler(this.btnSellerCR_Click_1);
            // 
            // lbCB
            // 
            this.lbCB.AutoSize = true;
            this.lbCB.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCB.Location = new System.Drawing.Point(272, 135);
            this.lbCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCB.Name = "lbCB";
            this.lbCB.Size = new System.Drawing.Size(62, 25);
            this.lbCB.TabIndex = 41;
            this.lbCB.Text = "廠牌";
            // 
            // lbCT
            // 
            this.lbCT.AutoSize = true;
            this.lbCT.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCT.Location = new System.Drawing.Point(500, 135);
            this.lbCT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCT.Name = "lbCT";
            this.lbCT.Size = new System.Drawing.Size(62, 25);
            this.lbCT.TabIndex = 42;
            this.lbCT.Text = "車款";
            // 
            // lbCS
            // 
            this.lbCS.AutoSize = true;
            this.lbCS.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCS.Location = new System.Drawing.Point(704, 135);
            this.lbCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCS.Name = "lbCS";
            this.lbCS.Size = new System.Drawing.Size(62, 25);
            this.lbCS.TabIndex = 43;
            this.lbCS.Text = "車型";
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(48, 240);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1400, 441);
            this.dgvData.TabIndex = 5;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowValidated);
            this.dgvData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvData_UserAddedRow);
            // 
            // btnSCarOrder
            // 
            this.btnSCarOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSCarOrder.Location = new System.Drawing.Point(964, 714);
            this.btnSCarOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSCarOrder.Name = "btnSCarOrder";
            this.btnSCarOrder.Size = new System.Drawing.Size(129, 48);
            this.btnSCarOrder.TabIndex = 44;
            this.btnSCarOrder.Text = "訂單交易";
            this.btnSCarOrder.UseVisualStyleBackColor = true;
            this.btnSCarOrder.Click += new System.EventHandler(this.btnCarOrder_Click);
            // 
            // btnBCarOrder
            // 
            this.btnBCarOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBCarOrder.Location = new System.Drawing.Point(964, 714);
            this.btnBCarOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBCarOrder.Name = "btnBCarOrder";
            this.btnBCarOrder.Size = new System.Drawing.Size(129, 48);
            this.btnBCarOrder.TabIndex = 45;
            this.btnBCarOrder.Text = "訂單交易";
            this.btnBCarOrder.UseVisualStyleBackColor = true;
            this.btnBCarOrder.Click += new System.EventHandler(this.btnBCarOrder_Click);
            // 
            // lbEC
            // 
            this.lbEC.AutoSize = true;
            this.lbEC.BackColor = System.Drawing.SystemColors.Control;
            this.lbEC.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbEC.Location = new System.Drawing.Point(277, 34);
            this.lbEC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEC.Name = "lbEC";
            this.lbEC.Size = new System.Drawing.Size(187, 25);
            this.lbEC.TabIndex = 46;
            this.lbEC.Text = "輸入想要的車子";
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.Font = new System.Drawing.Font("新細明體", 15F);
            this.nudMinPrice.Location = new System.Drawing.Point(948, 178);
            this.nudMinPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMinPrice.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(171, 37);
            this.nudMinPrice.TabIndex = 49;
            this.nudMinPrice.ValueChanged += new System.EventHandler(this.nudMinPrice_ValueChanged);
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.Font = new System.Drawing.Font("新細明體", 15F);
            this.nudMaxPrice.Location = new System.Drawing.Point(1160, 179);
            this.nudMaxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMaxPrice.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(160, 37);
            this.nudMaxPrice.TabIndex = 50;
            this.nudMaxPrice.ValueChanged += new System.EventHandler(this.nudMaxPrice_ValueChanged);
            this.nudMaxPrice.Leave += new System.EventHandler(this.nudMaxPrice_Leave);
            // 
            // lbbbb
            // 
            this.lbbbb.AutoSize = true;
            this.lbbbb.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbbbb.Location = new System.Drawing.Point(1127, 186);
            this.lbbbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbbb.Name = "lbbbb";
            this.lbbbb.Size = new System.Drawing.Size(25, 25);
            this.lbbbb.TabIndex = 51;
            this.lbbbb.Text = "~";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbPrice.Location = new System.Drawing.Point(959, 135);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(112, 25);
            this.lbPrice.TabIndex = 52;
            this.lbPrice.Text = "價格範圍";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(1348, 179);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 36);
            this.btnConfirm.TabIndex = 53;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmCarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 845);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbbbb);
            this.Controls.Add(this.nudMaxPrice);
            this.Controls.Add(this.nudMinPrice);
            this.Controls.Add(this.lbEC);
            this.Controls.Add(this.btnBCarOrder);
            this.Controls.Add(this.btnSCarOrder);
            this.Controls.Add(this.lbCS);
            this.Controls.Add(this.lbCT);
            this.Controls.Add(this.lbCB);
            this.Controls.Add(this.btnSellerCR);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSellerSC);
            this.Controls.Add(this.btnBuyerCR);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxCarStyle);
            this.Controls.Add(this.cbxCarType);
            this.Controls.Add(this.cbxCarBrand);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCarMenu";
            this.Text = "車子清單";
            this.Load += new System.EventHandler(this.frmDBTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCarBrand;
        private System.Windows.Forms.ComboBox cbxCarType;
        private System.Windows.Forms.ComboBox cbxCarStyle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBuyerCR;
        private System.Windows.Forms.Button btnSellerSC;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSellerCR;
        private System.Windows.Forms.Label lbCB;
        private System.Windows.Forms.Label lbCT;
        private System.Windows.Forms.Label lbCS;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSCarOrder;
        private System.Windows.Forms.Button btnBCarOrder;
        private System.Windows.Forms.Label lbEC;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.Label lbbbb;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnConfirm;
    }
}