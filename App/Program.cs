using System;
using System.Windows.Forms;
using Unity;
using ViewModels;
using Interfaces;


namespace App
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();
        public static void Register()
        {
            Container.RegisterType<IContactsViewModel, ContactsViewModel>();
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Contacts());
        }
    }
}
