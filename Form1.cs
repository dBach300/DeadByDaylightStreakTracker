using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbdStreakAndDataApp
{
    public partial class dbdStreakTracker : Form
    {
        public dbdStreakTracker()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void killerSelectionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string killer;
            killer = KillerSelectionCB.SelectedItem.ToString();
            pictureBox1.Image = Image.FromFile(string.Format(@"C:\Users\Mystify\source\repos\dbdStreakAndDataApp\Resources\{0}.png", killer));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KillerSelectionCB.Items.AddRange(new string[] { "Trapper", "Wraith", "Hillbilly", "Nurse", "Michael Myers", "Hag", "Doctor", "Huntress", "Bubba", "Freddy Krueger", "Pig", "Clown", "Spirit", "Legion", "Plague", "Ghost Face", "Demogorgon", "Oni", "Deathslinger", "Pyramid Head", "Blight", "Twins", "Trickster", "Nemesis", "Cenobite", "Artist", "Onryo", "Dredge", "Wesker", "Knight", "Skull Merchant", "Singularity", "Xenomorph", "Chucky", "Unknown", "Vecna", "Dracula", "Houndmaster" });
            KillerSelectionCB.SelectedIndex = 0;
        }

        private void SurvivedBTN_Click(object sender, EventArgs e)
        {
            string killer;
            killer = KillerSelectionCB.SelectedItem.ToString();
            FullStreakList.Items.Add(killer);
            //if (!FullStreakList.Items.Contains(killer)) // case sensitive is not important
            //    FullStreakList.Items.Add(killer);
            if (!UniqueStreakList.Items.Contains(killer)) // case sensitive is not important
                UniqueStreakList.Items.Add(killer);
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            FullStreakList.Items.Clear();
        }

        private void ResetUniqueBTN_Click(object sender, EventArgs e)
        {
            UniqueStreakList.Items.Clear();
        }
    }
}
