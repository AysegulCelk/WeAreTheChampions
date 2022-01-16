using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class EditedMatchForm : Form
    {
        private readonly AppDbContext db;
        private readonly Match match;

        public EditedMatchForm(AppDbContext db,Match _match)
        {
            InitializeComponent();
            this.db = db;
            match = _match;
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();

            match.Team1 = (Team)cboTeam1.SelectedItem;
            match.Team2 = (Team)cboTeam2.SelectedItem;
            match.Score1 = (int)nudScore1.Value;
            match.Score2 = (int)nudScore2.Value;


        }

       

        private void btnMatchEdit_Click(object sender, EventArgs e)
        {
            
            if (dtpMatchTime.Value < DateTime.Now)
            {
                MessageBox.Show("The date is invalid.");
                return;
            }
           match.MatchTime = dtpMatchTime.Value;
            if (cboTeam1.SelectedItem == cboTeam2.SelectedItem)
            {
                MessageBox.Show("The same 2 teams cannot play a match.");
                return;
            }
            match.Team1 = (Team)cboTeam1.SelectedItem;
          match.Team2 = (Team)cboTeam2.SelectedItem;
            match.Score1 = (int)nudScore1.Value;
            match.Score2 = (int)nudScore2.Value;
            db.SaveChanges();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
