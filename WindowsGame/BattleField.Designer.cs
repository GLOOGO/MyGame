namespace WindowsGame
{
    partial class BattleField
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardCollection = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoosePlayersPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TwoPlayersButton = new System.Windows.Forms.Button();
            this.ThreePlayersButton = new System.Windows.Forms.Button();
            this.FourPlayersButton = new System.Windows.Forms.Button();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.HandButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.BattleField3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BattleField2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BattleField4 = new System.Windows.Forms.FlowLayoutPanel();
            this.BattleField1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CardCollectionPanel = new System.Windows.Forms.Panel();
            this.CardCollectionLabel = new System.Windows.Forms.Label();
            this.ChoosePlayersPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.CardCollectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardCollection
            // 
            this.CardCollection.AutoScroll = true;
            this.CardCollection.BackColor = System.Drawing.Color.White;
            this.CardCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardCollection.Location = new System.Drawing.Point(0, 24);
            this.CardCollection.Name = "CardCollection";
            this.CardCollection.Padding = new System.Windows.Forms.Padding(5);
            this.CardCollection.Size = new System.Drawing.Size(1009, 164);
            this.CardCollection.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "How Many Players?";
            // 
            // ChoosePlayersPanel
            // 
            this.ChoosePlayersPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ChoosePlayersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChoosePlayersPanel.Controls.Add(this.flowLayoutPanel1);
            this.ChoosePlayersPanel.Controls.Add(this.label1);
            this.ChoosePlayersPanel.Location = new System.Drawing.Point(414, 216);
            this.ChoosePlayersPanel.Name = "ChoosePlayersPanel";
            this.ChoosePlayersPanel.Size = new System.Drawing.Size(321, 160);
            this.ChoosePlayersPanel.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.TwoPlayersButton);
            this.flowLayoutPanel1.Controls.Add(this.ThreePlayersButton);
            this.flowLayoutPanel1.Controls.Add(this.FourPlayersButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 132);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // TwoPlayersButton
            // 
            this.TwoPlayersButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayersButton.Location = new System.Drawing.Point(3, 3);
            this.TwoPlayersButton.Name = "TwoPlayersButton";
            this.TwoPlayersButton.Size = new System.Drawing.Size(100, 126);
            this.TwoPlayersButton.TabIndex = 1;
            this.TwoPlayersButton.Text = "Two";
            this.TwoPlayersButton.UseVisualStyleBackColor = true;
            this.TwoPlayersButton.Click += new System.EventHandler(this.TwoPlayersButton_Click);
            // 
            // ThreePlayersButton
            // 
            this.ThreePlayersButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreePlayersButton.Location = new System.Drawing.Point(109, 3);
            this.ThreePlayersButton.Name = "ThreePlayersButton";
            this.ThreePlayersButton.Size = new System.Drawing.Size(100, 126);
            this.ThreePlayersButton.TabIndex = 2;
            this.ThreePlayersButton.Text = "Three";
            this.ThreePlayersButton.UseVisualStyleBackColor = true;
            this.ThreePlayersButton.Click += new System.EventHandler(this.ThreePlayersButton_Click);
            // 
            // FourPlayersButton
            // 
            this.FourPlayersButton.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourPlayersButton.Location = new System.Drawing.Point(215, 3);
            this.FourPlayersButton.Name = "FourPlayersButton";
            this.FourPlayersButton.Size = new System.Drawing.Size(100, 126);
            this.FourPlayersButton.TabIndex = 3;
            this.FourPlayersButton.Text = "Four";
            this.FourPlayersButton.UseVisualStyleBackColor = true;
            this.FourPlayersButton.Click += new System.EventHandler(this.FourPlayersButton_Click);
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTurnButton.Location = new System.Drawing.Point(958, 768);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(150, 45);
            this.EndTurnButton.TabIndex = 10;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // HandButton
            // 
            this.HandButton.Image = global::WindowsGame.Properties.Resources.Hand;
            this.HandButton.Location = new System.Drawing.Point(685, 471);
            this.HandButton.Name = "HandButton";
            this.HandButton.Size = new System.Drawing.Size(120, 135);
            this.HandButton.TabIndex = 12;
            this.HandButton.UseVisualStyleBackColor = true;
            this.HandButton.Click += new System.EventHandler(this.HandButton_Click);
            // 
            // DiscardButton
            // 
            this.DiscardButton.Image = global::WindowsGame.Properties.Resources.Discard;
            this.DiscardButton.Location = new System.Drawing.Point(817, 472);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(120, 135);
            this.DiscardButton.TabIndex = 11;
            this.DiscardButton.UseVisualStyleBackColor = true;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // BattleField3
            // 
            this.BattleField3.AutoScroll = true;
            this.BattleField3.BackgroundImage = global::WindowsGame.Properties.Resources.BattleField;
            this.BattleField3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BattleField3.Location = new System.Drawing.Point(188, 612);
            this.BattleField3.Name = "BattleField3";
            this.BattleField3.Padding = new System.Windows.Forms.Padding(5);
            this.BattleField3.Size = new System.Drawing.Size(750, 150);
            this.BattleField3.TabIndex = 5;
            // 
            // BattleField2
            // 
            this.BattleField2.AutoScroll = true;
            this.BattleField2.BackgroundImage = global::WindowsGame.Properties.Resources.BattleFieldRight;
            this.BattleField2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BattleField2.Location = new System.Drawing.Point(958, 12);
            this.BattleField2.Name = "BattleField2";
            this.BattleField2.Padding = new System.Windows.Forms.Padding(5);
            this.BattleField2.Size = new System.Drawing.Size(150, 750);
            this.BattleField2.TabIndex = 4;
            // 
            // BattleField4
            // 
            this.BattleField4.AutoScroll = true;
            this.BattleField4.BackgroundImage = global::WindowsGame.Properties.Resources.BattleFieldLeft;
            this.BattleField4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BattleField4.Location = new System.Drawing.Point(12, 12);
            this.BattleField4.Name = "BattleField4";
            this.BattleField4.Padding = new System.Windows.Forms.Padding(5);
            this.BattleField4.Size = new System.Drawing.Size(150, 750);
            this.BattleField4.TabIndex = 3;
            // 
            // BattleField1
            // 
            this.BattleField1.AutoScroll = true;
            this.BattleField1.BackgroundImage = global::WindowsGame.Properties.Resources.BattleField;
            this.BattleField1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BattleField1.Location = new System.Drawing.Point(188, 12);
            this.BattleField1.Name = "BattleField1";
            this.BattleField1.Padding = new System.Windows.Forms.Padding(5);
            this.BattleField1.Size = new System.Drawing.Size(750, 150);
            this.BattleField1.TabIndex = 1;
            // 
            // CardCollectionPanel
            // 
            this.CardCollectionPanel.BackColor = System.Drawing.Color.Silver;
            this.CardCollectionPanel.Controls.Add(this.CardCollection);
            this.CardCollectionPanel.Controls.Add(this.CardCollectionLabel);
            this.CardCollectionPanel.Location = new System.Drawing.Point(61, 266);
            this.CardCollectionPanel.Name = "CardCollectionPanel";
            this.CardCollectionPanel.Size = new System.Drawing.Size(1009, 189);
            this.CardCollectionPanel.TabIndex = 13;
            this.CardCollectionPanel.Visible = false;
            // 
            // CardCollectionLabel
            // 
            this.CardCollectionLabel.AutoSize = true;
            this.CardCollectionLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCollectionLabel.Location = new System.Drawing.Point(467, 2);
            this.CardCollectionLabel.Name = "CardCollectionLabel";
            this.CardCollectionLabel.Size = new System.Drawing.Size(57, 25);
            this.CardCollectionLabel.TabIndex = 7;
            this.CardCollectionLabel.Text = "Hand";
            // 
            // BattleField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 821);
            this.Controls.Add(this.CardCollectionPanel);
            this.Controls.Add(this.HandButton);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.BattleField3);
            this.Controls.Add(this.BattleField2);
            this.Controls.Add(this.BattleField4);
            this.Controls.Add(this.BattleField1);
            this.Controls.Add(this.ChoosePlayersPanel);
            this.Name = "BattleField";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BattleField_Load);
            this.ChoosePlayersPanel.ResumeLayout(false);
            this.ChoosePlayersPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.CardCollectionPanel.ResumeLayout(false);
            this.CardCollectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BattleField1;
        private System.Windows.Forms.FlowLayoutPanel BattleField4;
        private System.Windows.Forms.FlowLayoutPanel BattleField2;
        private System.Windows.Forms.FlowLayoutPanel BattleField3;
        private System.Windows.Forms.FlowLayoutPanel CardCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ChoosePlayersPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TwoPlayersButton;
        private System.Windows.Forms.Button ThreePlayersButton;
        private System.Windows.Forms.Button FourPlayersButton;
        private System.Windows.Forms.Button EndTurnButton;
        private System.Windows.Forms.Button DiscardButton;
        private System.Windows.Forms.Button HandButton;
        private System.Windows.Forms.Panel CardCollectionPanel;
        private System.Windows.Forms.Label CardCollectionLabel;
    }
}

