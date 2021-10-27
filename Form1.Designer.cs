
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sumary = new System.Windows.Forms.DataGridView();
            this.更新 = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.削除 = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.DataGridView();
            this.追加 = new System.Windows.Forms.Button();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sakamotoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // sumary
            // 
            this.sumary.AllowUserToAddRows = false;
            this.sumary.AllowUserToDeleteRows = false;
            this.sumary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumary.Location = new System.Drawing.Point(808, 80);
            this.sumary.Name = "sumary";
            this.sumary.ReadOnly = true;
            this.sumary.RowHeadersWidth = 62;
            this.sumary.RowTemplate.Height = 27;
            this.sumary.Size = new System.Drawing.Size(424, 544);
            this.sumary.TabIndex = 43;
            // 
            // 更新
            // 
            this.更新.Location = new System.Drawing.Point(227, 27);
            this.更新.Name = "更新";
            this.更新.Size = new System.Drawing.Size(75, 34);
            this.更新.TabIndex = 42;
            this.更新.Text = "更新";
            this.更新.UseVisualStyleBackColor = true;
            this.更新.Click += new System.EventHandler(this.更新_Click);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(138, 27);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(70, 25);
            this.month.TabIndex = 41;
            this.month.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(41, 27);
            this.year.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(82, 25);
            this.year.TabIndex = 40;
            this.year.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "食費",
            "外食",
            "日用品",
            "家賃",
            "電気代",
            "ガス代",
            "水道代",
            "娯楽・レジャー",
            "衣料",
            "家具",
            "その他",
            "不明"});
            this.comboBox1.Location = new System.Drawing.Point(402, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 39;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(402, 546);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 22);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "sakamoto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(554, 546);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 487);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 488);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // 削除
            // 
            this.削除.Location = new System.Drawing.Point(30, 546);
            this.削除.Name = "削除";
            this.削除.Size = new System.Drawing.Size(75, 30);
            this.削除.TabIndex = 34;
            this.削除.Text = "削除";
            this.削除.UseVisualStyleBackColor = true;
            this.削除.Click += new System.EventHandler(this.削除_Click);
            // 
            // detail
            // 
            this.detail.AllowUserToAddRows = false;
            this.detail.AllowUserToOrderColumns = true;
            this.detail.AutoGenerateColumns = false;
            this.detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.sakamotoDataGridViewCheckBoxColumn});
            this.detail.DataSource = this.expenseBindingSource;
            this.detail.Location = new System.Drawing.Point(43, 80);
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.RowHeadersWidth = 30;
            this.detail.Size = new System.Drawing.Size(709, 387);
            this.detail.TabIndex = 32;
            this.detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detail_CellContentClick);
            // 
            // 追加
            // 
            this.追加.Location = new System.Drawing.Point(30, 491);
            this.追加.Name = "追加";
            this.追加.Size = new System.Drawing.Size(75, 32);
            this.追加.TabIndex = 33;
            this.追加.Text = "追加";
            this.追加.UseVisualStyleBackColor = true;
            this.追加.Click += new System.EventHandler(this.追加_Click);
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(WindowsFormsApp2.Model.Expense);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 70;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.memoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.memoDataGridViewTextBoxColumn.Width = 80;
            // 
            // sakamotoDataGridViewCheckBoxColumn
            // 
            this.sakamotoDataGridViewCheckBoxColumn.DataPropertyName = "Sakamoto";
            this.sakamotoDataGridViewCheckBoxColumn.HeaderText = "Sakamoto";
            this.sakamotoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.sakamotoDataGridViewCheckBoxColumn.Name = "sakamotoDataGridViewCheckBoxColumn";
            this.sakamotoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.sakamotoDataGridViewCheckBoxColumn.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.sumary);
            this.Controls.Add(this.更新);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.削除);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.追加);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView sumary;
        private System.Windows.Forms.Button 更新;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button 削除;
        private System.Windows.Forms.DataGridView detail;
        private System.Windows.Forms.Button 追加;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sakamotoDataGridViewCheckBoxColumn;
    }
}

