namespace RestaurantManagementProject
{
    partial class frmFood
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
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdUpDate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.lsvFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpLeft.Controls.Add(this.cmdDelete);
            this.grpLeft.Controls.Add(this.cmdUpDate);
            this.grpLeft.Controls.Add(this.cmdAdd);
            this.grpLeft.Controls.Add(this.cmdClear);
            this.grpLeft.Controls.Add(this.txtNotes);
            this.grpLeft.Controls.Add(this.cbbCategory);
            this.grpLeft.Controls.Add(this.label6);
            this.grpLeft.Controls.Add(this.label5);
            this.grpLeft.Controls.Add(this.txtPrice);
            this.grpLeft.Controls.Add(this.label3);
            this.grpLeft.Controls.Add(this.txtUnit);
            this.grpLeft.Controls.Add(this.label2);
            this.grpLeft.Controls.Add(this.txtName);
            this.grpLeft.Controls.Add(this.label1);
            this.grpLeft.Location = new System.Drawing.Point(13, 13);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(411, 433);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Chức Năng";
            // 
            // grpRight
            // 
            this.grpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRight.Controls.Add(this.lsvFood);
            this.grpRight.Controls.Add(this.cmdExit);
            this.grpRight.Controls.Add(this.lblStatistic);
            this.grpRight.Location = new System.Drawing.Point(430, 13);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(368, 433);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh Sách Thức Ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Thực Phẩm";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn Vị Tính";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(171, 83);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(233, 20);
            this.txtUnit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn Giá ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(171, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(233, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại Thực Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi Chú";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(171, 189);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(233, 21);
            this.cbbCategory.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(171, 233);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(233, 163);
            this.txtNotes.TabIndex = 3;
            this.txtNotes.Text = "";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(27, 402);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Nhập Lại";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(133, 402);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdUpDate
            // 
            this.cmdUpDate.Location = new System.Drawing.Point(233, 404);
            this.cmdUpDate.Name = "cmdUpDate";
            this.cmdUpDate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpDate.TabIndex = 4;
            this.cmdUpDate.Text = "Sửa";
            this.cmdUpDate.UseVisualStyleBackColor = true;
            this.cmdUpDate.Click += new System.EventHandler(this.cmdUpDate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(329, 404);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 4;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(283, 404);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(17, 402);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(54, 13);
            this.lblStatistic.TabIndex = 0;
            this.lblStatistic.Text = "Thống Kê";
            // 
            // lsvFood
            // 
            this.lsvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvFood.FullRowSelect = true;
            this.lsvFood.GridLines = true;
            this.lsvFood.HideSelection = false;
            this.lsvFood.Location = new System.Drawing.Point(6, 32);
            this.lsvFood.MultiSelect = false;
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(352, 364);
            this.lsvFood.TabIndex = 5;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
            this.lsvFood.View = System.Windows.Forms.View.Details;
            this.lsvFood.SelectedIndexChanged += new System.EventHandler(this.lsvFood_SelectedIndexChanged);
            this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thực phẩm";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐVT";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại Thực Phẩm";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi Chú";
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Name = "frmFood";
            this.Text = "Thêm Xóa Sửa ";
            this.Load += new System.EventHandler(this.frmFood_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.grpRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpDate;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

