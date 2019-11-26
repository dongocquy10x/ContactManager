using System.ComponentModel;
using System.Windows.Forms;
namespace ViewModels
{
    public interface IContactsViewModel
    {
        BindingSource ContactBindingSource { get; set; }
        BindingSource EmailBindingSource { get; set; }
        BindingSource PhoneBindingSource { get; set; }
        string Title { get; }
        event PropertyChangedEventHandler PropertyChanged;
        void Delete();
        void DeleteEmail();
        void DeletePhone();
        void First();
        void Initialize();
        void Last();
        void Load();
        void New();
        void NewEmail();
        void NewPhone();
        void Next();
        void Previous();
        void Save();
    }
}