namespace Assignment3
{
    public partial class MainForm : Form
    {
        string filePath = @"NHL Player Stats 2017-18.csv";
        string player = "";
        List<PlayerStats> list = new List<PlayerStats>();
        CardFormat card;
        CardFormat cardBack;
        public MainForm()
        {
            InitializeComponent();
            GlobalData.adjustLayout(panel1);
            GlobalData.LoadCSV(filePath, GlobalData.PlayerList, input => new PlayerStats(input));
            PopulatePlayerList();
            DisplayPlayerInfo(player);
        }
        private void DisplayPlayerInfo(string player)
        {
            flpCard.Controls.Clear();
            var e = GetPlayer(player);
            if (e == null)
            {
                MessageBox.Show("Player not found.");
                return;
            }

            string name = $"Name: {e.Name}";
            string team = $"Team: {e.Team}";
            string pos = $"Position: {e.Pos}";
            string gp = $"Games Played: {e.GP}";
            string g = $"Goals: {e.G}";
            string a = $"Assists: {e.A}";
            string p = $"Points: {e.P}";

            card = new CardFormat(name, pos, gp, g, a, p);
            cardBack = new CardFormat(team);
            card.Click += Card_Click;
            cardBack.Click += Card_Click;
            flpCard.Controls.Add(cardBack);
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
        private void Card_Click(object? sender, EventArgs e)
        {
            if (sender != null) flpCard.Controls.Clear();
            else return;

            if (sender == cardBack) flpCard.Controls.Add(card);
            else flpCard.Controls.Add(cardBack);

            
        }
    }
}
