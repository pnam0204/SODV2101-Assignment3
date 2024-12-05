using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class CardFormat : UserControl
    {
        public CardFormat()
        {
            InitializeComponent();
            
        }
        public CardFormat(string playername, string pos,string gameplayed, string goal, string assist, string pts)
        {
            InitializeComponent();
            PlayerName.Text = playername;
            Position.Text = pos;
            GamePlayed.Text = gameplayed;
            Goal.Text = goal;
            Assist.Text = assist;
            Pts.Text = pts;
            Team.Hide();
            adjustLayout(PlayerName, Position);
        }
        public CardFormat(string team)
        {
            InitializeComponent();
            Team.Text = team;
            PlayerName.Hide();
            Position.Hide();
            Goal.Hide();
            GamePlayed.Hide();
            Assist.Hide();
            Pts.Hide();
            adjustLayout(Team);
            this.BackColor= Color.Navy;

        }
        private void adjustLayout(params Control[]e)
        {
            foreach(var c in e)
            {
                c.Left = (c.Parent.ClientSize.Width - c.Width)/2;
            }
        }
    }
}
