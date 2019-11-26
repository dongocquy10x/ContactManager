using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*=========================================================
 * Phần code behind của form chỉ còn thực hiện:
 * Binding (dữ liệu)
 * Delegate (sự kiện)
 * 
 * Nhờ cơ chế DataBinding, sự thay đổi dữ liệu ở giao diện => phản hồi ngay về kho dữ liệu ở ViewModel và ngược lại
 * 
 * Quy trình rõ ràng hơn:
 * (1) Xây dựng các lớp Model (lớp Contact, Phone, Email) thể hiện các thực thể cần quản lí
 * (2) Xây dựng các lớp ViewModel để thực hiện việc xử lí dữ liệu, logic, sự kiện
 * (3) Thiết kế giao diện
 * (4) Ghép nối giao diện với lớp ViewModel tương ứng
=========================================================*/


namespace App
{
    public partial class Contacts : Form
    {

        private ContactsViewModel.ContactsViewModel _vm = new ContactsViewModel.ContactsViewModel();
        public Contacts()
        {
            InitializeComponent();

            _vm.ContactBindingSource = contactBindingSource;
            _vm.EmailBindingSource = emailsBindingSource;
            _vm.PhoneBindingSource = phonesBindingSource;

            _vm.Initialize();

            Load += delegate { _vm.Load(); };

            NewBtn.Click += delegate { _vm.New(); };
            DeleteBtn.Click += delegate { _vm.Delete(); };
            SaveBtn.Click += delegate { _vm.Save(); };
            FirstBtn.Click += delegate { _vm.First(); };
            LastBtn.Click += delegate { _vm.Last(); };
            NextBtn.Click += delegate { _vm.Next(); };
            PreviousBtn.Click += delegate { _vm.Previous(); };

            NewEmailBtn.Click += delegate { _vm.NewEmail(); };
            DeleteEmailBtn.Click += delegate { _vm.DeleteEmail(); };
            NewPhoneBtn.Click += delegate { _vm.NewPhone(); };
            DeletePhoneBtn.Click += delegate { _vm.DeletePhone(); };

            DataBindings.Add("Text", _vm, "Title");
        }
    }
}
