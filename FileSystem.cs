using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ICMS_Reader
{
    internal class FileSystem
    {
        private const string FileNameNoten = "Noten.cv";
        private const string FileNameSettings = "Settings.cv";

        private const char Seperator = ';';
        public static UserSettings Settings { get; private set; }

        internal static void LoadSettings(string savePath)
        {
            string savedSettings = File.ReadAllText(savePath + FileNameSettings);
            Settings = new UserSettings(savedSettings);
        }

        internal static void SaveSettings(UserSettings newSettings, string savePath)
        {
            File.WriteAllText(savePath + FileNameSettings, newSettings.ToString());
        }

        internal static bool SettingsChanged(UserSettings newSettings, string savePath)
        {
            if (newSettings.BrowserIsChrome != Settings.BrowserIsChrome)
            {
                return true;
            }
            if (newSettings.Password == Settings.Password)
            {
                return true;
            }
            if (newSettings.Username == Settings.Username)
            {
                return true;
            }
            if(newSettings.Website == Settings.Website)
            {
                return true;
            }
            if (newSettings.Study == Settings.Study)
            {
                return true;
            }

            return false;
        }

        internal static IEnumerable<Benotung> LoadNoten(string savePath)
        {
            foreach (string line in File.ReadAllLines(savePath + FileNameNoten))
            {
                var split = line.Split(Seperator);
                var dateSplit = split[(int) BenotungPropertyOrder.SaveDate].Split('.');
                yield return new Benotung
                {
                    Fach = split[(int)BenotungPropertyOrder.Fach],
                    Credits = split[(int)BenotungPropertyOrder.Credits],
                    Note = split[(int)BenotungPropertyOrder.Note],
                    SaveDate = new DateTime(Convert.ToInt32(dateSplit[2]), Convert.ToInt32(dateSplit[1]), Convert.ToInt32(dateSplit[0])),
                    Semester = split[(int)BenotungPropertyOrder.Semester]
                };
            }
        }

        internal static void SaveNoten(List<Benotung> fachListe, string savePath)
        {
            File.WriteAllLines(savePath + FileNameNoten, fachListe.Select(o => o.ToString()).ToArray());
        }
    }
}