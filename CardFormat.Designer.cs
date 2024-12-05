namespace Assignment3
{
    partial class CardFormat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlayerName = new Label();
            Position = new Label();
            Goal = new Label();
            Assist = new Label();
            Pts = new Label();
            Team = new Label();
            GamePlayed = new Label();
            SuspendLayout();
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.BackColor = SystemColors.Control;
            PlayerName.Location = new Point(79, 0);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(49, 20);
            PlayerName.TabIndex = 0;
            PlayerName.Text = "Name";
            PlayerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.BackColor = SystemColors.Control;
            Position.Location = new Point(79, 32);
            Position.Name = "Position";
            Position.Size = new Size(36, 20);
            Position.TabIndex = 1;
            Position.Text = "POS";
            Position.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Goal
            // 
            Goal.AutoSize = true;
            Goal.BackColor = SystemColors.Control;
            Goal.Location = new Point(3, 205);
            Goal.Name = "Goal";
            Goal.Size = new Size(19, 20);
            Goal.TabIndex = 2;
            Goal.Text = "G";
            Goal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Assist
            // 
            Assist.AutoSize = true;
            Assist.BackColor = SystemColors.Control;
            Assist.Location = new Point(3, 234);
            Assist.Name = "Assist";
            Assist.RightToLeft = RightToLeft.No;
            Assist.Size = new Size(19, 20);
            Assist.TabIndex = 3;
            Assist.Text = "A";
            Assist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pts
            // 
            Pts.AutoSize = true;
            Pts.BackColor = SystemColors.Control;
            Pts.Location = new Point(3, 264);
            Pts.Name = "Pts";
            Pts.Size = new Size(17, 20);
            Pts.TabIndex = 4;
            Pts.Text = "P";
            Pts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Team
            // 
            Team.AutoSize = true;
            Team.BackColor = SystemColors.Control;
            Team.Location = new Point(79, 145);
            Team.Name = "Team";
            Team.Size = new Size(45, 20);
            Team.TabIndex = 5;
            Team.Text = "Team";
            Team.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GamePlayed
            // 
            GamePlayed.AutoSize = true;
            GamePlayed.BackColor = SystemColors.Control;
            GamePlayed.Location = new Point(3, 176);
            GamePlayed.Name = "GamePlayed";
            GamePlayed.Size = new Size(27, 20);
            GamePlayed.TabIndex = 6;
            GamePlayed.Text = "GP";
            GamePlayed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CardFormat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(GamePlayed);
            Controls.Add(Team);
            Controls.Add(Pts);
            Controls.Add(Assist);
            Controls.Add(Goal);
            Controls.Add(Position);
            Controls.Add(PlayerName);
            Name = "CardFormat";
            Size = new Size(200, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerName;
        private Label Position;
        private Label Goal;
        private Label Assist;
        private Label Pts;
        private Label Team;
        private Label GamePlayed;
    }
}
