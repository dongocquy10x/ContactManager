using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Models;
using System.Windows.Forms;

namespace App.ContactsViewModel
{
    public class ContactsViewModel
    {
        public BindingSource ContactBindingSource { get; set; }

        public void Load()
        {
            List<Contact> contacts;
            var formatter = new BinaryFormatter();

            if (!File.Exists("data.dat"))
            {
                contacts = new List<Contact>();
                var stream = File.Create("data.dat");
                formatter.Serialize(stream, contacts);
                stream.Close();
            }
            else
            {
                using (var stream = File.OpenRead("data.dat"))
                {
                    contacts = formatter.Deserialize(stream) as List<Contact>;
                }
            }

            ContactBindingSource.ResetBindings(false);
            ContactBindingSource.DataSource = contacts;
        }

        public void Save()
        {
            using (var stream = File.OpenWrite("data.dat"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, ContactBindingSource.DataSource);
            }
        }

    }

}
