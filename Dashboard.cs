using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracticeProject.Form1;


namespace PracticeProject
{
    public partial class Dashboard : Form
    {
        int total= TaskData.TotalTasks;
        int completed= TaskData.CompletedTasks;
        public Dashboard()
        {
            
            InitializeComponent();
         
        }


        private void Form2_Load(object sender, EventArgs e)
        {
          
            lblTotalTasks.Text = total.ToString();
            lblCompletedTasks.Text = completed.ToString();
            int progress = total> 0 ? (int)(((double)completed / total) * 100) : 0;
            progressBarSummary.Minimum = 0;
            progressBarSummary.Maximum = 100;
            progressBarSummary.Value = progress;
            labelSummary.Text = $"You completed {completed} out of {total} tasks today.";

            // Set quote
            string[] quotes = {
        "Success is the sum of small efforts repeated daily.",
        "Start now. Not tomorrow.",
        "Every task you finish is a step forward.",
        "Discipline is doing it even when you don’t feel like it."
    };

            // Pick a random quote
            Random rand = new Random();
            labelQuote.Text = quotes[rand.Next(quotes.Length)];
        }

    }
        
}
