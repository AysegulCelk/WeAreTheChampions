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
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();


        public MainForm()
        {
            InitializeComponent();

            LoadMatch();
        }

        private void LoadMatch()
        {
            var matches = db.Matches.ToList();

            foreach (Match match in matches)
            {
                if (match.Score1 > match.Score2)
                    match.Result = Result.team1win;
                else if (match.Score1 < match.Score2)
                    match.Result = Result.team2win;
                else
                    match.Result = Result.draw;
            }
            db.SaveChanges();
            dgvMatches.DataSource = db.Matches
               .Select(x => new
               {
                   matchesId = x.MatchId,
                   Team1 = x.Team1,
                   Team2 = x.Team2,
                   Date = x.MatchTime,
                   Result = x.Result,

               }).ToList();
            dgvMatches.Columns[0].Visible = false;
        }



        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm(db);
            teamsForm.Show();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.Show();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm(db);
            playersForm.Show();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            MatchForm matchForm = new MatchForm(db);
            matchForm.Show();

            LoadMatch();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0) return;
            int matchesId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match editedMatch=db.Matches.ToList().FirstOrDefault(x => x.MatchId == matchesId);
            EditedMatchForm editedMatchForm = new EditedMatchForm(db,editedMatch);
            editedMatchForm.ShowDialog();
            LoadMatch();
        }

        private void dgvMatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int id = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
                Match deleted = db.Matches.Find(id);
                db.Matches.Remove(deleted);
                db.SaveChanges();
            }
            LoadMatch();
        }
    }
}
