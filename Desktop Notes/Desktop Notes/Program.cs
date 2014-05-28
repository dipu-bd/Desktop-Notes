using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Notes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            components = new Component1();
            components.SetIconVisible(true);
            ShowAllNotes();
            
            Application.Run();
        }
        
        public static Component1 components;

        public static void ShowAllNotes()
        {
            List<FormData> data = new List<FormData>();
            foreach (string id in REGISTRY.OPENED_NOTES)
            {
                object val = REGISTRY.GetData(id);
                if (val != null) data.Add((FormData)val);
            }

            REGISTRY.DeleteAll();

            foreach (FormData dat in data) AddNewNote(dat);           
            if (CUR_ID == 1) AddNewNote();
        }

        public static int CUR_ID = 1;
        public static void AddNewNote(FormData dat = null)
        {
            MainForm form = new MainForm(CUR_ID, dat);            
            form.Show();
            ++CUR_ID;
        }

        public static void SaveAllOnExit()
        {
            foreach (MainForm f in Application.OpenForms) f.Save();
        }
    }
}
