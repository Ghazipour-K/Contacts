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
            this.ContactItemsGoupBox = new System.Windows.Forms.GroupBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CriteriaTextBox = new System.Windows.Forms.TextBox();
            this.ContactsDataView = new System.Windows.Forms.DataGridView();
            this.tblContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContactItemsGoupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactItemsGoupBox
            // 
            this.ContactItemsGoupBox.Controls.Add(this.MobileTextBox);
            this.ContactItemsGoupBox.Controls.Add(this.LastNameTextBox);
            this.ContactItemsGoupBox.Controls.Add(this.FirstNameTextBox);
            this.ContactItemsGoupBox.Controls.Add(this.label3);
            this.ContactItemsGoupBox.Controls.Add(this.label2);
            this.ContactItemsGoupBox.Controls.Add(this.label1);
            this.ContactItemsGoupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactItemsGoupBox.Location = new System.Drawing.Point(12, 12);
            this.ContactItemsGoupBox.Name = "ContactItemsGoupBox";
            this.ContactItemsGoupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContactItemsGoupBox.Size = new System.Drawing.Size(599, 130);
            this.ContactItemsGoupBox.TabIndex = 0;
            this.ContactItemsGoupBox.TabStop = false;
            this.ContactItemsGoupBox.Text = "مشخصات";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileTextBox.Location = new System.Drawing.Point(338, 89);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MobileTextBox.Size = new System.Drawing.Size(170, 21);
            this.MobileTextBox.TabIndex = 2;
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
            this.FirstNameTextBox.TabIndex = 0;
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
            this.SaveButton.Location = new System.Drawing.Point(544, 325);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(67, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "ذخیره";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(477, 325);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(67, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "بروز رسانی";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(410, 325);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(67, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CriteriaTextBox
            // 
            this.CriteriaTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaTextBox.Location = new System.Drawing.Point(234, 327);
            this.CriteriaTextBox.Name = "CriteriaTextBox";
            this.CriteriaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CriteriaTextBox.Size = new System.Drawing.Size(170, 21);
            this.CriteriaTextBox.TabIndex = 7;
            this.CriteriaTextBox.TextChanged += new System.EventHandler(this.CriteriaTextBox_TextChanged);
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
            this.ContactsDataView.TabIndex = 9;
            this.ContactsDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactsDataView_CellClick);
            this.ContactsDataView.Click += new System.EventHandler(this.ContactsDataView_Click);
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
            this.Controls.Add(this.CriteriaTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ContactItemsGoupBox);
            this.Name = "Main";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ContactItemsGoupBox.ResumeLayout(false);
            this.ContactItemsGoupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ContactItemsGoupBox;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox CriteriaTextBox;
        private System.Windows.Forms.DataGridView ContactsDataView;
        private System.Windows.Forms.BindingSource tblContactBindingSource;
    }
}

