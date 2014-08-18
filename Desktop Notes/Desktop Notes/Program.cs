using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EmptySlots = new Queue<int>();
            Themes = new List<Theme>();
            LoadThemes();

            components = new Component1();
            components.SetIconVisible(true);
            ShowAllNotes();

            Application.Run();
        }

        public static int CUR_ID = 1;
        public static Queue<int> EmptySlots;
        public static List<Theme> Themes;
        public static Component1 components;
        public static event EventHandler newNoteAddedEvent;

        public static void LoadThemes()
        {
            List<List<string>> dat =
                Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<string>>>
                (Desktop_Notes.Properties.Resources.Themes);

            foreach (List<string> d in dat)
            {
                Theme th = new Theme();
                th.Name = d[0];

                List<List<int>> tdat =
                    Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<int>>>(d[1]);

                th.TextColor = Color.FromArgb(tdat[0][0], tdat[0][1], tdat[0][2]);
                th.BackColor = Color.FromArgb(tdat[1][0], tdat[1][1], tdat[1][2]);
                th.TopBarColor = Color.FromArgb(tdat[2][0], tdat[2][1], tdat[2][2]);

                Themes.Add(th);
            }
        }

        public static void AddNewNote(FormData dat = null)
        {
            int id = CUR_ID;
            if (EmptySlots.Count == 0) ++CUR_ID;
            else id = EmptySlots.Dequeue();
            new MainForm(id, dat);
            if (newNoteAddedEvent != null) newNoteAddedEvent(null, EventArgs.Empty);
        }

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

        public static void SaveAllOnExit()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MainForm)) continue;
                ((MainForm)f).Save();
            }
        }
    }
}
