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
            panel1 = new Panel();
            flpCard = new FlowLayoutPanel();
            cardFormat1 = new CardFormat();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            flpCard.SuspendLayout();
            SuspendLayout();
            // 
            // lstPlayer
            // 
            lstPlayer.FormattingEnabled = true;
            lstPlayer.Location = new Point(3, 43);
            lstPlayer.Name = "lstPlayer";
            lstPlayer.Size = new Size(150, 304);
            lstPlayer.TabIndex = 0;
            lstPlayer.SelectedIndexChanged += lstPlayer_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(flpCard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstPlayer);
            panel1.Location = new Point(25, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 353);
            panel1.TabIndex = 2;
            // 
            // flpCard
            // 
            flpCard.AutoSize = true;
            flpCard.Controls.Add(cardFormat1);
            flpCard.Location = new Point(191, 43);
            flpCard.Name = "flpCard";
            flpCard.Size = new Size(207, 307);
            flpCard.TabIndex = 4;
            // 
            // cardFormat1
            // 
            cardFormat1.BackColor = SystemColors.ActiveCaption;
            cardFormat1.BorderStyle = BorderStyle.FixedSingle;
            cardFormat1.Location = new Point(3, 3);
            cardFormat1.Name = "cardFormat1";
            cardFormat1.Size = new Size(200, 300);
            cardFormat1.TabIndex = 0;
            cardFormat1.Click += Card_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Trading Cards";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPlayer;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flpCard;
        private CardFormat cardFormat1;
    }
}
