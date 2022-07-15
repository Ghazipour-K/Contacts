using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var DB = new ContactsDBEntities())
            {
                var Contact = new tblContact
                {
                    FisrtName = FirstNameTextBox.Text.Trim(),
                    LastName = LastNameTextBox.Text.Trim(),
                    Mobile = MobileTextBox.Text.Trim()
                };
                DB.tblContacts.Add(Contact);
                DB.SaveChanges();
                ContactsDataView.DataSource = DB.tblContacts.ToList();
                ClearFormItems();
            }

        }

        private void ClearFormItems()
        {
            foreach (Control control in ContactItemsGoupBox.Controls)
            {
                if (control is TextBox) control.Text = String.Empty;
            }
            //FirstNameTextBox.Text = LastNameTextBox.Text = MobileTextBox.Text = string.Empty;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (var DB = new ContactsDBEntities())
            {
                ContactsDataView.DataSource = DB.tblContacts.ToList();
            }
            ContactsDataView.Columns[0].HeaderText = "نام";
            ContactsDataView.Columns[1].HeaderText = "نام خانوادگی";
            ContactsDataView.Columns[2].HeaderText = "موبایل";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(CriteriaTextBox, "عبارت مورد نظر برای جستجو را وارد کنید");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var DB = new ContactsDBEntities())
            {
                //var Contact = (from c in DB.tblContacts where c.Mobile == MobileTextBox.Text.Trim() select c).Single();
                var Contact = DB.tblContacts.Where(c => c.Mobile == MobileTextBox.Text.Trim()).Single();
                DB.tblContacts.Remove(Contact);
                DB.SaveChanges();
                ContactsDataView.DataSource = DB.tblContacts.ToList();
                ClearFormItems();
            }
        }

        //private void LastRecordButton_Click(object sender, EventArgs e)
        //{
        //    using (var DB = new ContactsDBEntities())
        //    {
        //        var Contact = DB.tblContacts.ToList().Last();
        //        FirstNameTextBox.Text = Contact.FisrtName;
        //        LastNameTextBox.Text = Contact.LastName;
        //        MobileTextBox.Text = Contact.Mobile;
        //    }
        //}

        //private void FirstRecordButton_Click(object sender, EventArgs e)
        //{
        //    using (var DB = new ContactsDBEntities())
        //    {
        //        var Contact = DB.tblContacts.ToList().First();
        //        FirstNameTextBox.Text = Contact.FisrtName;
        //        LastNameTextBox.Text = Contact.LastName;
        //        MobileTextBox.Text = Contact.Mobile;
        //    }
        //}

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (MobileTextBox.Text.Trim() != String.Empty)
                using (var DB = new ContactsDBEntities())
                {
                    var Contact = DB.tblContacts.Where(c => c.Mobile == MobileTextBox.Text.Trim()).Single();
                    Contact.FisrtName = FirstNameTextBox.Text;
                    Contact.LastName = LastNameTextBox.Text;
                    Contact.Mobile = MobileTextBox.Text;
                    DB.SaveChanges();
                    ContactsDataView.DataSource = DB.tblContacts.ToList();
                }
        }

        private void CriteriaTextBox_TextChanged(object sender, EventArgs e)
        {
            using (var DB = new ContactsDBEntities())
            {
                if (CriteriaTextBox.Text.Trim() != string.Empty)
                {
                    var Contact = DB.tblContacts.Where(
                        c => c.Mobile.Contains(CriteriaTextBox.Text.Trim()) ||
                        c.FisrtName.Contains(CriteriaTextBox.Text.Trim()) ||
                        c.LastName.Contains(CriteriaTextBox.Text.Trim())).ToList();

                    ContactsDataView.DataSource = Contact.ToList();
                }
                else
                    ContactsDataView.DataSource = DB.tblContacts.ToList();
            }
        }

        private void ContactsDataView_Click(object sender, EventArgs e)
        {
            //string key = ContactsDataView.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void ContactsDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FirstNameTextBox.Text = ContactsDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                LastNameTextBox.Text = ContactsDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                MobileTextBox.Text = ContactsDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }
        }
    }
}
