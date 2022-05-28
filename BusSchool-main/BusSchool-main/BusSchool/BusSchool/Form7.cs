using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusSchool.Classes;

namespace BusSchool
{
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
            public void ChangeStyle()
            {
                 dataGridView1.BackgroundColor = Color.White;
                dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 204);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 98, 26); ;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 98, 26); ;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bradley Hand ITC", 18, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.Font = new Font("Bradley Hand ITC", 14, FontStyle.Bold ^ FontStyle.Italic);
                dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 98, 26);
                // dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(103, 125, 224);


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ChangeStyle();
            button1.BackColor = Color.FromArgb(255, 98, 26);
            button1.ForeColor = Color.White;
            long HighestScore = (from gi in Game.playerList select gi).Max(g => g.Highest_Score);
                long LowestScore = (from gi in Game.playerList select gi).Min(g => g.Lowest_Score);
                long MinimumDuration = (from gi in Game.playerList select gi).Min(g => g.Lowest_Dur);
                long MaximumDuration = (from gi in Game.playerList select gi).Max(g => g.Highest_Dur);
                long TotalDuration = (from gi in Game.playerList select gi).Sum(g => g.Total_Dur);
                dataGridView1.Rows.Add("Number of games", Game.NOG);
                dataGridView1.Rows.Add("Number of profiles", Game.playerList.Count());
                dataGridView1.Rows.Add("Highest score", HighestScore);
                dataGridView1.Rows.Add("Lowest score", LowestScore);
                dataGridView1.Rows.Add("Minimum duration", MinimumDuration+"S");
                dataGridView1.Rows.Add("Maximum duration", MaximumDuration+"S");
                dataGridView1.Rows.Add("Total duration", TotalDuration+"S");

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
