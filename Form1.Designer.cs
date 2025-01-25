namespace dbdStreakAndDataApp
{
    partial class dbdStreakTracker
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
            this.KillerSelectionCB = new System.Windows.Forms.ComboBox();
            this.SurvivedBTN = new System.Windows.Forms.Button();
            this.DiedBTN = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.FullStreakList = new System.Windows.Forms.ListBox();
            this.UniqueStreakList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResetUniqueBTN = new System.Windows.Forms.Button();
            this.fullStreakCounterLabel = new System.Windows.Forms.Label();
            this.uniqueStreakCounterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KillerSelectionCB
            // 
            this.KillerSelectionCB.BackColor = System.Drawing.SystemColors.Desktop;
            this.KillerSelectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KillerSelectionCB.ForeColor = System.Drawing.Color.Red;
            this.KillerSelectionCB.FormattingEnabled = true;
            this.KillerSelectionCB.Location = new System.Drawing.Point(47, 356);
            this.KillerSelectionCB.Name = "KillerSelectionCB";
            this.KillerSelectionCB.Size = new System.Drawing.Size(211, 21);
            this.KillerSelectionCB.TabIndex = 1;
            this.KillerSelectionCB.SelectedIndexChanged += new System.EventHandler(this.killerSelectionCB_SelectedIndexChanged);
            // 
            // SurvivedBTN
            // 
            this.SurvivedBTN.Location = new System.Drawing.Point(64, 412);
            this.SurvivedBTN.Name = "SurvivedBTN";
            this.SurvivedBTN.Size = new System.Drawing.Size(75, 23);
            this.SurvivedBTN.TabIndex = 2;
            this.SurvivedBTN.Text = "Survived";
            this.SurvivedBTN.UseVisualStyleBackColor = true;
            this.SurvivedBTN.Click += new System.EventHandler(this.SurvivedBTN_Click);
            // 
            // DiedBTN
            // 
            this.DiedBTN.Location = new System.Drawing.Point(165, 412);
            this.DiedBTN.Name = "DiedBTN";
            this.DiedBTN.Size = new System.Drawing.Size(75, 23);
            this.DiedBTN.TabIndex = 3;
            this.DiedBTN.Text = "Died";
            this.DiedBTN.UseVisualStyleBackColor = true;
            this.DiedBTN.Click += new System.EventHandler(this.DiedBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(330, 533);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(107, 23);
            this.ResetBTN.TabIndex = 4;
            this.ResetBTN.Text = "Reset Full Streak";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // FullStreakList
            // 
            this.FullStreakList.BackColor = System.Drawing.SystemColors.Desktop;
            this.FullStreakList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullStreakList.ForeColor = System.Drawing.Color.Red;
            this.FullStreakList.FormattingEnabled = true;
            this.FullStreakList.Location = new System.Drawing.Point(332, 50);
            this.FullStreakList.Name = "FullStreakList";
            this.FullStreakList.Size = new System.Drawing.Size(156, 325);
            this.FullStreakList.TabIndex = 5;
            // 
            // UniqueStreakList
            // 
            this.UniqueStreakList.BackColor = System.Drawing.SystemColors.Desktop;
            this.UniqueStreakList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UniqueStreakList.ForeColor = System.Drawing.Color.Red;
            this.UniqueStreakList.FormattingEnabled = true;
            this.UniqueStreakList.Location = new System.Drawing.Point(544, 50);
            this.UniqueStreakList.Name = "UniqueStreakList";
            this.UniqueStreakList.Size = new System.Drawing.Size(156, 325);
            this.UniqueStreakList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(380, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Streak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(585, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unique Streak";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dbdStreakAndDataApp.Properties.Resources.trapper;
            this.pictureBox1.Location = new System.Drawing.Point(47, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResetUniqueBTN
            // 
            this.ResetUniqueBTN.Location = new System.Drawing.Point(545, 533);
            this.ResetUniqueBTN.Name = "ResetUniqueBTN";
            this.ResetUniqueBTN.Size = new System.Drawing.Size(115, 23);
            this.ResetUniqueBTN.TabIndex = 9;
            this.ResetUniqueBTN.Text = "Reset Unique Streak";
            this.ResetUniqueBTN.UseVisualStyleBackColor = true;
            this.ResetUniqueBTN.Click += new System.EventHandler(this.ResetUniqueBTN_Click);
            // 
            // fullStreakCounterLabel
            // 
            this.fullStreakCounterLabel.AutoSize = true;
            this.fullStreakCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullStreakCounterLabel.ForeColor = System.Drawing.Color.Red;
            this.fullStreakCounterLabel.Location = new System.Drawing.Point(372, 460);
            this.fullStreakCounterLabel.Name = "fullStreakCounterLabel";
            this.fullStreakCounterLabel.Size = new System.Drawing.Size(29, 31);
            this.fullStreakCounterLabel.TabIndex = 10;
            this.fullStreakCounterLabel.Text = "0";
            // 
            // uniqueStreakCounterLabel
            // 
            this.uniqueStreakCounterLabel.AutoSize = true;
            this.uniqueStreakCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueStreakCounterLabel.ForeColor = System.Drawing.Color.Red;
            this.uniqueStreakCounterLabel.Location = new System.Drawing.Point(591, 460);
            this.uniqueStreakCounterLabel.Name = "uniqueStreakCounterLabel";
            this.uniqueStreakCounterLabel.Size = new System.Drawing.Size(29, 31);
            this.uniqueStreakCounterLabel.TabIndex = 11;
            this.uniqueStreakCounterLabel.Text = "0";
            // 
            // dbdStreakTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.uniqueStreakCounterLabel);
            this.Controls.Add(this.fullStreakCounterLabel);
            this.Controls.Add(this.ResetUniqueBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UniqueStreakList);
            this.Controls.Add(this.FullStreakList);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.DiedBTN);
            this.Controls.Add(this.SurvivedBTN);
            this.Controls.Add(this.KillerSelectionCB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dbdStreakTracker";
            this.ShowIcon = false;
            this.Text = "Dead By Daylight Streak";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox KillerSelectionCB;
        private System.Windows.Forms.Button SurvivedBTN;
        private System.Windows.Forms.Button DiedBTN;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.ListBox FullStreakList;
        private System.Windows.Forms.ListBox UniqueStreakList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetUniqueBTN;
        private System.Windows.Forms.Label fullStreakCounterLabel;
        private System.Windows.Forms.Label uniqueStreakCounterLabel;
    }
}

