namespace Contacts
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LastRecordButton = new System.Windows.Forms.Button();
            this.NextRecordButton = new System.Windows.Forms.Button();
            this.PreviousRecordButton = new System.Windows.Forms.Button();
            this.FirstRecordButton = new System.Windows.Forms.Button();
            this.CriteriaTextBox = new System.Windows.Forms.TextBox();
            this.FieldToSearchComboBox = new System.Windows.Forms.ComboBox();
            this.ContactsDataView = new System.Windows.Forms.DataGridView();
            this.tblContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MobileTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(599, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileTextBox.Location = new System.Drawing.Point(338, 89);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MobileTextBox.Size = new System.Drawing.Size(170, 21);
            this.MobileTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(338, 62);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LastNameTextBox.Size = new System.Drawing.Size(170, 21);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(338, 35);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FirstNameTextBox.Size = new System.Drawing.Size(170, 21);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 92);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "شماره موبایل :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 65);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(581, 329);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(30, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "+";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(550, 329);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(30, 23);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "*";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(519, 329);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "-";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LastRecordButton
            // 
            this.LastRecordButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastRecordButton.Location = new System.Drawing.Point(488, 329);
            this.LastRecordButton.Name = "LastRecordButton";
            this.LastRecordButton.Size = new System.Drawing.Size(30, 23);
            this.LastRecordButton.TabIndex = 2;
            this.LastRecordButton.Text = ">|";
            this.LastRecordButton.UseVisualStyleBackColor = true;
            // 
            // NextRecordButton
            // 
            this.NextRecordButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextRecordButton.Location = new System.Drawing.Point(457, 329);
            this.NextRecordButton.Name = "NextRecordButton";
            this.NextRecordButton.Size = new System.Drawing.Size(30, 23);
            this.NextRecordButton.TabIndex = 2;
            this.NextRecordButton.Text = ">";
            this.NextRecordButton.UseVisualStyleBackColor = true;
            // 
            // PreviousRecordButton
            // 
            this.PreviousRecordButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousRecordButton.Location = new System.Drawing.Point(426, 329);
            this.PreviousRecordButton.Name = "PreviousRecordButton";
            this.PreviousRecordButton.Size = new System.Drawing.Size(30, 23);
            this.PreviousRecordButton.TabIndex = 2;
            this.PreviousRecordButton.Text = "<";
            this.PreviousRecordButton.UseVisualStyleBackColor = true;
            // 
            // FirstRecordButton
            // 
            this.FirstRecordButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstRecordButton.Location = new System.Drawing.Point(395, 329);
            this.FirstRecordButton.Name = "FirstRecordButton";
            this.FirstRecordButton.Size = new System.Drawing.Size(30, 23);
            this.FirstRecordButton.TabIndex = 2;
            this.FirstRecordButton.Text = "|<";
            this.FirstRecordButton.UseVisualStyleBackColor = true;
            // 
            // CriteriaTextBox
            // 
            this.CriteriaTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaTextBox.Location = new System.Drawing.Point(221, 331);
            this.CriteriaTextBox.Name = "CriteriaTextBox";
            this.CriteriaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CriteriaTextBox.Size = new System.Drawing.Size(170, 21);
            this.CriteriaTextBox.TabIndex = 1;
            // 
            // FieldToSearchComboBox
            // 
            this.FieldToSearchComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldToSearchComboBox.FormattingEnabled = true;
            this.FieldToSearchComboBox.Items.AddRange(new object[] {
            "نام",
            "نام خانوادگی",
            "شماره موبایل"});
            this.FieldToSearchComboBox.Location = new System.Drawing.Point(94, 329);
            this.FieldToSearchComboBox.Name = "FieldToSearchComboBox";
            this.FieldToSearchComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FieldToSearchComboBox.Size = new System.Drawing.Size(121, 21);
            this.FieldToSearchComboBox.TabIndex = 3;
            this.FieldToSearchComboBox.Text = "انتخاب کنید";
            // 
            // ContactsDataView
            // 
            this.ContactsDataView.AllowUserToAddRows = false;
            this.ContactsDataView.AllowUserToDeleteRows = false;
            this.ContactsDataView.AllowUserToOrderColumns = true;
            this.ContactsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsDataView.Location = new System.Drawing.Point(12, 148);
            this.ContactsDataView.Name = "ContactsDataView";
            this.ContactsDataView.ReadOnly = true;
            this.ContactsDataView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContactsDataView.Size = new System.Drawing.Size(599, 164);
            this.ContactsDataView.TabIndex = 4;
            // 
            // tblContactBindingSource
            // 
            this.tblContactBindingSource.DataSource = typeof(Contacts.tblContact);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 360);
            this.Controls.Add(this.ContactsDataView);
            this.Controls.Add(this.FieldToSearchComboBox);
            this.Controls.Add(this.FirstRecordButton);
            this.Controls.Add(this.PreviousRecordButton);
            this.Controls.Add(this.CriteriaTextBox);
            this.Controls.Add(this.NextRecordButton);
            this.Controls.Add(this.LastRecordButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LastRecordButton;
        private System.Windows.Forms.Button NextRecordButton;
        private System.Windows.Forms.Button PreviousRecordButton;
        private System.Windows.Forms.Button FirstRecordButton;
        private System.Windows.Forms.TextBox CriteriaTextBox;
        private System.Windows.Forms.ComboBox FieldToSearchComboBox;
        private System.Windows.Forms.DataGridView ContactsDataView;
        private System.Windows.Forms.BindingSource tblContactBindingSource;
    }
}

