namespace LibraryManagement
{
    partial class FormUserManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.AddOrUpdateButton = new System.Windows.Forms.Button();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.UserIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserFullNameRadio = new System.Windows.Forms.RadioButton();
            this.UsernameRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1152, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی کاربر : ";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Location = new System.Drawing.Point(913, 12);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(240, 33);
            this.FullNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور :";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(11, 12);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(240, 33);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام کاربری :";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(467, 12);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(240, 33);
            this.UsernameTextbox.TabIndex = 2;
            // 
            // AddOrUpdateButton
            // 
            this.AddOrUpdateButton.Location = new System.Drawing.Point(11, 61);
            this.AddOrUpdateButton.Name = "AddOrUpdateButton";
            this.AddOrUpdateButton.Size = new System.Drawing.Size(123, 39);
            this.AddOrUpdateButton.TabIndex = 4;
            this.AddOrUpdateButton.Text = "ذخیره";
            this.AddOrUpdateButton.UseVisualStyleBackColor = true;
            this.AddOrUpdateButton.Click += new System.EventHandler(this.AddOrUpdateButton_Click);
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdColumn,
            this.UserFullNameColumn,
            this.UsernameColumn,
            this.PasswordColumn});
            this.UserDataGridView.Location = new System.Drawing.Point(12, 106);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 24;
            this.UserDataGridView.Size = new System.Drawing.Size(1299, 579);
            this.UserDataGridView.TabIndex = 8;
            this.UserDataGridView.SelectionChanged += new System.EventHandler(this.UserDataGridView_SelectionChanged);
            // 
            // UserIdColumn
            // 
            this.UserIdColumn.HeaderText = "شناسه کاربر";
            this.UserIdColumn.MinimumWidth = 6;
            this.UserIdColumn.Name = "UserIdColumn";
            // 
            // UserFullNameColumn
            // 
            this.UserFullNameColumn.HeaderText = "نام و نام خانوادگی";
            this.UserFullNameColumn.MinimumWidth = 6;
            this.UserFullNameColumn.Name = "UserFullNameColumn";
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.HeaderText = "نام کاربری";
            this.UsernameColumn.MinimumWidth = 6;
            this.UsernameColumn.Name = "UsernameColumn";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "رمز عبور";
            this.PasswordColumn.MinimumWidth = 6;
            this.PasswordColumn.Name = "PasswordColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1246, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "جستجو : ";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(713, 67);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(527, 33);
            this.SearchTextbox.TabIndex = 5;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UsernameRadio);
            this.panel1.Controls.Add(this.UserFullNameRadio);
            this.panel1.Location = new System.Drawing.Point(421, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 39);
            this.panel1.TabIndex = 4;
            // 
            // UserFullNameRadio
            // 
            this.UserFullNameRadio.AutoSize = true;
            this.UserFullNameRadio.Location = new System.Drawing.Point(134, 3);
            this.UserFullNameRadio.Name = "UserFullNameRadio";
            this.UserFullNameRadio.Size = new System.Drawing.Size(140, 30);
            this.UserFullNameRadio.TabIndex = 6;
            this.UserFullNameRadio.TabStop = true;
            this.UserFullNameRadio.Text = "نام و نام خانوادگی";
            this.UserFullNameRadio.UseVisualStyleBackColor = true;
            // 
            // UsernameRadio
            // 
            this.UsernameRadio.AutoSize = true;
            this.UsernameRadio.Location = new System.Drawing.Point(32, 3);
            this.UsernameRadio.Name = "UsernameRadio";
            this.UsernameRadio.Size = new System.Drawing.Size(96, 30);
            this.UsernameRadio.TabIndex = 7;
            this.UsernameRadio.TabStop = true;
            this.UsernameRadio.Text = "نام کاربری";
            this.UsernameRadio.UseVisualStyleBackColor = true;
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.AddOrUpdateButton);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.FullNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUserManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم مدیریت کاربران";
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Button AddOrUpdateButton;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton UsernameRadio;
        private System.Windows.Forms.RadioButton UserFullNameRadio;
    }
}