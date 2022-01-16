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
    public partial class PlayersForm : Form
    {
        private readonly AppDbContext db;
        Player editedPlayer,deletedPlayer;

        public PlayersForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadTeams();
            LoadPlayer();
            cboPlayerTeams.SelectedIndex = -1;

        }

        private void LoadPlayer()
        {
            dgvPlayer.DataSource = db.Players
                .Select(x => new
                {
                    Id=x.PlayerId,
                    Name = x.PlayerName,
                    TeamName = x.Team.TeamName
                })
                .ToList();
            dgvPlayer.Columns[0].Visible = false;
            
        }
        private void LoadTeams()
        {
            cboPlayerTeams.SelectedIndex = -1;
            cboPlayerTeams.DataSource = db.Teams.ToList();
        }



        private void txtPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerSearch.Text.Trim() == "")
            {
                LoadPlayer();
            }
            else
            {
                dgvPlayer.DataSource = db.Players.Where(x => x.Team.TeamName.Contains(txtPlayerSearch.Text.Trim())).Select(x => new
                {
                    Name = x.PlayerName,
                    TeamName = x.Team.TeamName
                }).ToList();
            }
        }

        private void btnPlayerEdit_Click(object sender, EventArgs e)
        {
            if (btnPlayerEdit.Text == "Edit")
            {
                if (dgvPlayer.SelectedRows.Count == 0) return;
                int playerId=(int)dgvPlayer.SelectedRows[0].Cells[0].Value;
                editedPlayer = db.Players.ToList().FirstOrDefault(x => x.PlayerId == playerId);               
                txtPlayerName.Text = editedPlayer.PlayerName;
                cboPlayerTeams.SelectedItem = editedPlayer.Team;
                btnAddPlayer.Text = "EditAdd";

                btnPlayerEdit.Text = "Cancel";
            }

            else if (btnPlayerEdit.Text == "Cancel")
            {
                btnPlayerEdit.Text = "Edit";
                btnAddPlayer.Text = "Add";
                txtPlayerName.Text = "";
                cboPlayerTeams.SelectedIndex = -1;

                return;
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (btnAddPlayer.Text == "Add Player")
            {
                if (txtPlayerName.Text.Trim() == "")
                {
                    MessageBox.Show("Please create player name");
                    return;
                }
                Player player = new Player();
                player.PlayerName = txtPlayerName.Text.Trim();
                if (cboPlayerTeams.SelectedIndex != 1)
                {

                    player.Team = (Team)cboPlayerTeams.SelectedItem;

                }
                db.Players.Add(player);

            }
            else if (btnAddPlayer.Text == "EditAdd")
            {
               
                editedPlayer.PlayerName = txtPlayerName.Text.Trim();
                if (cboPlayerTeams.SelectedIndex != -1)
                {
                    editedPlayer.Team = (Team)cboPlayerTeams.SelectedItem;
                }
            }
            db.SaveChanges();
            LoadPlayer();
            LoadTeams();
        }

        private void dgvPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int id = (int)dgvPlayer.SelectedRows[0].Cells[0].Value;
                deletedPlayer = db.Players.Find(id);
                db.Players.Remove(deletedPlayer);
                db.SaveChanges();
            }
            LoadPlayer();
        }
    }
}
