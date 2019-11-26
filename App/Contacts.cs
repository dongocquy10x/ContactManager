using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Contacts : Form
    {

        private ContactsViewModel.ContactsViewModel _vm = new ContactsViewModel.ContactsViewModel();
        public Contacts()
        {
            InitializeComponent();

            _vm.ContactBindingSource = contactBindingSource;
            contactBindingNavigatorSaveItem.Click += delegate { _vm.Save(); };
            Load += delegate { _vm.Load(); };
        }
    }
}
