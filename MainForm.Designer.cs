namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPlayer = new ListBox();
            lstPlayerStats = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstPlayer
            // 
            lstPlayer.FormattingEnabled = true;
            lstPlayer.Location = new Point(3, 43);
            lstPlayer.Name = "lstPlayer";
            lstPlayer.Size = new Size(150, 324);
            lstPlayer.TabIndex = 0;
            lstPlayer.SelectedIndexChanged += lstPlayer_SelectedIndexChanged;
            // 
            // lstPlayerStats
            // 
            lstPlayerStats.FormattingEnabled = true;
            lstPlayerStats.Location = new Point(191, 43);
            lstPlayerStats.Name = "lstPlayerStats";
            lstPlayerStats.Size = new Size(408, 324);
            lstPlayerStats.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstPlayer);
            panel1.Controls.Add(lstPlayerStats);
            panel1.Location = new Point(108, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 379);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 2;
            label1.Text = "Players:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Stats:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Trading Cards";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPlayer;
        private ListBox lstPlayerStats;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
