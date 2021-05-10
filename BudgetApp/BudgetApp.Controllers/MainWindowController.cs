using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace BudgetApp.Controllers
{
    public class MainWindowController
    {
        public ObservableCollection<Expense> Expenses { get; set; } = new ObservableCollection<Expense>()
        {
            new Expense()
            {
                Name = "Name",
                Account = new Account(){Name = "AccountName"},
                PaymentDate = DateTime.Now,
                Type = AccountType.Persistent,
                Value = 1234,
            }
        };

        public void Save()
        {
            if (Expenses.Count() == 0)
            {
                return;
            }

            var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "budgetApp.xml");

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(Expenses.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, Expenses);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(filename);
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }
    }
}
