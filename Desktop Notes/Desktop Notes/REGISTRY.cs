using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Desktop_Notes
{
    public static class REGISTRY
    {

        public static RegistryKey REG_PATH = Registry.CurrentUser.CreateSubKey("Software")
                                    .CreateSubKey("Sand Soft").CreateSubKey("Desktop Notes");

        public static string[] OPENED_NOTES
        {
            get
            {
                return REG_PATH.GetValueNames();
            }
        }

        public static void SetData(string id, FormData data)
        {
            string dat = JsonConvert.SerializeObject(data);
            REG_PATH.SetValue(id, dat);
        }

        public static FormData GetData(string id)
        {
            object dat = REG_PATH.GetValue(id, null);
            if (dat == null) return null;
            return JsonConvert.DeserializeObject<FormData>((string)dat);
        }

        public static void Delete(string id)
        {
            try { REG_PATH.DeleteValue(id); }
            catch { }
        }

        public static void DeleteAll()
        {
            foreach (string val in OPENED_NOTES)
            {
                REG_PATH.DeleteValue(val);
            }
        }

        public static RegistryKey START_KEY = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static bool StartWithWindows
        {
            get
            {
                object obj = START_KEY.GetValue("Desktop Notes", null);
                if (obj == null) return false;

                try
                {
                    START_KEY.DeleteValue("Desktop Notes", false);
                    return true;
                }
                catch { return false; }
            }
            set
            {
                if (value) { START_KEY.SetValue("Desktop Notes", Application.ExecutablePath); }
                else try { START_KEY.DeleteValue("Desktop Notes", false); }
                    catch { }
            }
        }
    }
}
