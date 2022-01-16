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
    public partial class ColorsForm : Form
    {
        private readonly AppDbContext db;
        Models.Color colors,deletedColor;




        public ColorsForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;

            ListColor();
        }

        private void ListColor()
        {
            lstColor.DataSource = db.Colors.ToList();
        }
        #region Renk Ekleme/Düzenleme
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter color name");
                return;
            }
            if (btnAddColor.Text == "Add")
            {
                if (db.Colors.Any(x => x.ColorName == txtColorName.Text.Trim()))
                {
                    MessageBox.Show("This Color taken. select another one");
                    return;
                }
                Models.Color colors = new Models.Color()
                {
                    ColorName = txtColorName.Text.Trim(),
                    ColorRed = (int)nudColorRed.Value,
                    ColorGreen = (int)nudColorGreen.Value,
                    ColorBlue = (int)nudColorBlue.Value,
                };
                db.Colors.Add(colors);

            }
            else if (btnAddColor.Text == "EditAdd")
            {
                colors.ColorName = txtColorName.Text;
                colors.ColorBlue = (int)nudColorBlue.Value;
                colors.ColorRed = (int)nudColorRed.Value;
                colors.ColorGreen = (int)nudColorGreen.Value;
                btnAddColor.Text = "Add";
            }

            db.SaveChanges();
            ListColor();
            
            MessageBox.Show("Renk ekleme basarılı");
            Clean();
        }

        private void Clean()
        {
            txtColorName.Text = "";
            nudColorBlue.Value= 0;
            nudColorGreen.Value = 0;
            nudColorBlue.Value = 0;

        }
        #endregion

        private void nudColorRed_ValueChanged(object sender, EventArgs e)
        {
            //şekillerden programından bul yap 
            pbColor.BackColor = System.Drawing.Color.FromArgb((int)nudColorBlue.Value, (int)nudColorRed.Value, (int)nudColorGreen.Value);
        }

        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            if (btnColorEdit.Text == "Edit")
            {
                if (lstColor.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select what you want to change");
                    return;
                }
                colors = (Models.Color)lstColor.SelectedItem;
                txtColorName.Text = colors.ColorName;
                nudColorBlue.Value = (int)colors.ColorBlue;
                nudColorRed.Value = (int)colors.ColorRed;
                nudColorGreen.Value = (int)colors.ColorGreen;
                btnAddColor.Text = "EditAdd";

                btnColorEdit.Text = "Cancel";




            }

            else if(btnColorEdit.Text == "Cancel")
            {
                btnColorEdit.Text = "Edit";
                btnAddColor.Text = "Add";
                txtColorName.Text = "";
                nudColorBlue.Value = 0;
                nudColorRed.Value = 0;
                nudColorGreen.Value = 0;
                return;
            }



        }

        private void lstColor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                 deletedColor = (Models.Color)lstColor.SelectedItem;
                db.Colors.Remove(deletedColor);
                db.SaveChanges();
            }
            ListColor();
        }
    }
}
