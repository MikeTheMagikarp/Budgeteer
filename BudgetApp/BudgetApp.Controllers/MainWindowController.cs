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
        public BudgetInformation Information { get; set; } = new BudgetInformation();

        public void Load()
        {
            if (Information.Expenses.Count != 0 || Information.Accounts.Count != 0)
            {
                // Ask for confirmation to overwrite

                // Just clearing for now to be able to load
                Information.Accounts.Clear();
                Information.Expenses.Clear();
            }

            var expensesFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Filenames.InformationFile);

            if (File.Exists(expensesFilename))
            {
                // Load from expected location
                try
                {
                    XmlSerializer serializer = new XmlSerializer(Information.GetType());
                    using (var stream = File.OpenRead(expensesFilename))
                    {
                        var information = serializer.Deserialize(stream) as BudgetInformation;

                        Information = information;
                    }
                }
                catch (Exception ex)
                {
                    //Log exception here
                }
            }
            else
            {
                // Ask for file location
            }
        }

        public void Save()
        {
            if (!Information.IsEmpty())
            {
                var filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Filenames.InformationFile);

                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    XmlSerializer serializer = new XmlSerializer(Information.GetType());
                    using (MemoryStream stream = new MemoryStream())
                    {
                        serializer.Serialize(stream, Information);
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

        public void AddAccount()
        {
            
        }
    }
}
