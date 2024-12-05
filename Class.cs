using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
{
    static class GlobalData
    {
        public static List<PlayerStats> PlayerList = new List<PlayerStats>();
        public static string NextValue(string csv, ref int index)
        {
            string result = "";
            if (index < csv.Length)
            {
                if (csv[index] == ',')
                {
                    index++;
                }
                else if (csv[index] == '"')
                {
                    int endIndex = csv.IndexOf('"', index + 1);
                    result = csv.Substring(index + 1, endIndex - (index + 1));
                    index = endIndex + 2;
                }
                else
                {
                    int endIndex = csv.IndexOf(',', index);
                    if (endIndex == -1) result = csv.Substring(index);
                    else result = csv.Substring(index, endIndex - index);
                    index = endIndex + 1;
                }
            }
            return result;
        }
        public static void LoadCSV<T>(string filePath, List<T> list, Func<string,T>createObject)
        {
            //string filePath = @"NHL Player Stats.csv";
            try
            {
                using (var reader = File.OpenText(filePath))
                {
                    string input = reader.ReadLine();
                    while ((input = reader.ReadLine()) != null)
                    {
                        T obj = createObject(input);
                        list.Add(obj);
                    }
                }
                MessageBox.Show("Data Loaded Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
            }
        }
        public static void centerControl(params Control[] e)
        {
            foreach (Control c in e)
            {
                c.Left = (c.Parent.ClientSize.Width - c.Width) / 2;
                c.Top = (c.Parent.ClientSize.Height - c.Height) / 2;
            }
        }
    }
    public class PlayerStats
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Pos { get; set; }
        public int GP { get; set; }
        public int G { get; set; }
        public int A { get; set; }
        public int P { get; set; }
        public int PM { get; set; }
        public int PIM { get; set; }
        public double PGP { get; set; }
        public int PPG { get; set; }
        public int PPP { get; set; }
        public int SHG { get; set; }
        public int SHP { get; set; }
        public int GWG { get; set; }
        public int OTG { get; set; }
        public int S { get; set; }
        public double SPercent { get; set; }
        public string TOIGP { get; set; }
        public double ShiftsGP { get; set; }
        public double FOW { get; set; }
        
        public PlayerStats(string csv)
        {
            int index = 0;
            int i;
            double d;
            Name = GlobalData.NextValue(csv, ref index);
            Team = GlobalData.NextValue(csv, ref index);
            do
            {
                Pos = GlobalData.NextValue(csv, ref index);
            }while (Pos.Length > 1);
            GP = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            G = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            A = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            P = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            PM = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            PIM = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            PGP = double.TryParse(GlobalData.NextValue(csv, ref index), out d) ? d : 0;
            PPG = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            PPP = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            SHG = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            SHP = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            GWG = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            OTG = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            S = int.TryParse(GlobalData.NextValue(csv, ref index), out i) ? i : 0;
            SPercent = double.TryParse(GlobalData.NextValue(csv, ref index), out d) ? d : 0;
            TOIGP = GlobalData.NextValue(csv, ref index);
            ShiftsGP = double.TryParse(GlobalData.NextValue(csv, ref index), out d) ? d : 0;
            FOW = double.TryParse(GlobalData.NextValue(csv, ref index), out d) ? d : 0;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
