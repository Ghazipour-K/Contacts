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
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (var DB = new ContactsDBEntities())
            {
                ContactsDataView.DataSource = DB.tblContacts.ToList();
            }
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
            }
        }
    }
}
