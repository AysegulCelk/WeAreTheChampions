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
    public partial class MatchForm : Form
    {
        private readonly AppDbContext db;
        
        

        public MatchForm(AppDbContext db)
        {
            InitializeComponent();
            dtpMatchTime.Format = DateTimePickerFormat.Custom;
            dtpMatchTime.CustomFormat = "MM/dd/yyyy hh:mm";
            this.db = db;
            
            LoadTeams();
            ListMatches();
            ClearForm();
        }

        private void ListMatches()
        {
            lstMatch.DataSource = db.Matches
                .Select(x => new
                {
                    x.MatchTime,
                    x.Team1,
                    x.Team2,
                    x.Score1,
                    x.Score2
                }).ToList();
        }

        private void LoadTeams()
        {
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                Match newMatch = new Match();
                if (dtpMatchTime.Value < DateTime.Now)
                {
                    MessageBox.Show("The date is invalid.");
                    return;
                }
                newMatch.MatchTime = dtpMatchTime.Value;
                if (cboTeam1.SelectedItem == cboTeam2.SelectedItem)
                {
                    MessageBox.Show("The same 2 teams cannot play a match.");
                    return;
                }
                newMatch.Team1 = (Team)cboTeam1.SelectedItem;
                newMatch.Team2 = (Team)cboTeam2.SelectedItem;
                newMatch.Score1 = (int)nudScore1.Value;
                newMatch.Score2 = (int)nudScore2.Value;
                db.Matches.Add(newMatch);
               

            }
         
            db.SaveChanges();
            ListMatches();

            ClearForm();

        }

        private void ClearForm()
        {
            cboTeam1.SelectedIndex =-1;
            cboTeam2.SelectedIndex =-1;
            nudScore1.Value = 0;
            nudScore2.Value = 0;    
            dtpMatchTime.Value = DateTime.Now;
        }

        

     

       

       

     
       
        

       

        

       
    }
}
