namespace Assignment3
{
    public partial class MainForm : Form
    {
        string filePath = @"NHL Player Stats 2017-18.csv";
        string player = "";
        List<PlayerStats> list = new List<PlayerStats>();
        public MainForm()
        {
            InitializeComponent();
            GlobalData.centerControl(panel1);
            GlobalData.LoadCSV(filePath, GlobalData.PlayerList, input => new PlayerStats(input));
            PopulatePlayerList();
            DisplayPlayerInfo(player);
        }
        private void DisplayPlayerInfo(string player)
        {
            lstPlayerStats.Items.Clear();
            var e = GetPlayer(player);
            if (e == null)
            {
                MessageBox.Show("Player not found.");
                return;
            }

            List<string> display = new List<string>();

            string name = $"Name: {e.Name}";
            string team = $"Team: {e.Team}";
            string pos = $"Position: {e.Pos}";
            string gp = $"Gameplayed: {e.GP}";
            string g = $"Goals: {e.G}";
            string a = $"Assists: {e.A}";
            string p = $"Points: {e.P}";
            display.Add(name);
            display.Add(team);
            display.Add(pos);
            display.Add(gp);
            display.Add(g);
            display.Add(a);
            display.Add(p);

            foreach (var item in display)
            {
                lstPlayerStats.Items.Add(item);
            }
        }
        private PlayerStats GetPlayer(string player)
        {
            return list.FirstOrDefault(p => p.Name == player);
        }
        private void PopulatePlayerList()
        {
            list = GlobalData.PlayerList;
            var sortedList = list.OrderBy(p => p.Name).ToList();
            foreach (var p in sortedList)
            {
                lstPlayer.Items.Add(p);
            }
            player = sortedList.Count() > 0 ? sortedList[0].Name : "";
        }
        private void lstPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayer.SelectedItem != null)
            {
                player = lstPlayer.SelectedItem.ToString();
                DisplayPlayerInfo(player);
            }
        }
    }
}
