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
using Color = WeAreTheChampions.Models.Color;

namespace WeAreTheChampions
{
    public partial class TeamsForm : Form
    {
        private readonly AppDbContext db;
        Team editedTeam, deletedTeam;

        public TeamsForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            ListTeam();
            LoadColor();
            
            

        }

        private void FormClear()
        {
            txtTeamName.Text = "";
        }

        private void LoadColor()
        {
            clbTeamColor.DataSource = db.Colors.ToList();
        }

        private void ListTeam()
        {

            lstTeams.DataSource = db.Teams.ToList();
        }
        #region Takım Olusturma


        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (btnAddTeam.Text == "Add Team")
            {
                if (txtTeamName.Text == "")
                {
                    MessageBox.Show("Please enter team name");
                    return;
                }
                if (db.Teams.Any(x => x.TeamName == txtTeamName.Text.Trim()))
                {
                    MessageBox.Show("Team name is used");
                    return;
                }
                Team teams = new Team()
                {
                    TeamName = txtTeamName.Text.Trim()
                };
                if (clbTeamColor.SelectedIndex == -1) return;
                else
                {
                    foreach (Models.Color color in clbTeamColor.CheckedItems)
                    {
                        teams.Colors.Add(color);
                    }
                }

                db.Teams.Add(teams);
            }
            else if (btnAddTeam.Text == "Edit")
            {
                editedTeam.TeamName = txtTeamName.Text;
                if (clbTeamColor.SelectedIndex == -1) return;
                else
                {
                    foreach (Models.Color color in clbTeamColor.CheckedItems)
                    {
                        editedTeam.Colors.Add(color);
                    }
                }
                btnAddTeam.Text = "Add";
                btnTeamEdit.Text = "Edit";
               


            }
            db.SaveChanges();
            ListTeam();
            FormClear();
            #endregion
        }


        private void btnTeamEdit_Click(object sender, EventArgs e)
        {
            if (btnTeamEdit.Text == "Edit")
            {
                if (lstTeams.SelectedItems.Count == 0) return;
                editedTeam = (Team)lstTeams.SelectedItem;
                txtTeamName.Text = editedTeam.TeamName;

                

                if (clbTeamColor.SelectedIndex == -1) return;
                else
                {
                    foreach (Models.Color color in clbTeamColor.CheckedItems)
                    {
                        editedTeam.Colors.Add(color);
                        
                    }
                }

                for (int i = 0; i < clbTeamColor.Items.Count; i++)
                {
                    if (editedTeam.Colors.Contains(clbTeamColor.Items[i]))
                    {
                        clbTeamColor.SetItemChecked(i, true);

                    }
                }
                btnAddTeam.Text = "Edit";
                btnTeamEdit.Text = "Cancel";
                
                
            }
            else if (btnTeamEdit.Text == "Cancel")
            {
                for (int i = 0; i < editedTeam.Colors.Count; i++)
                {
                    clbTeamColor.SetItemChecked(i, false);
                }
                btnTeamEdit.Text = "Edit";
                btnAddTeam.Text = "Add";
                txtTeamName.Text = "";
                return;
            }
        }
        private void lstTeams_KeyDown(object sender, KeyEventArgs e)
        {
            //Oyuncusu olan takımı sılerken db.SaveChanges hata veriyor 
            //Maping yapıldı.
            if (e.KeyCode == Keys.Delete)
            {
                deletedTeam = (Team)lstTeams.SelectedItem;
                db.Teams.Remove(deletedTeam);
                db.SaveChanges();
            }
            ListTeam();
        }
    }
}