using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracticeProject.Form1;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticeProject
{
    public partial class MyTasks : Form
    {
        public static int total=0;
        public static int completed = 0;


        string saveFilePath = "tasks.txt";

        public MyTasks()
        {
            InitializeComponent();
            dateTimePickertask.Value = DateTime.Now.AddDays(-1);

        }
        private void LoadTasksFromFile()
        {
            if (File.Exists(saveFilePath))
            {
                string[] taskLines = File.ReadAllLines(saveFilePath);
                foreach (var line in taskLines)
                {
                    listBox1.Items.Add(line);
                }
            }
        }
        private void MyTasks_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
            UpdateProgressBar();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a task name!", "Error");
                return;
            }


            if (dateTimePickertask.Value.Date == DateTime.Now.AddDays(-1).Date)
            {
                MessageBox.Show("Please select a due date!", "Error");
                return;
            }


            string taskWithDate = $"{textBox1.Text.Trim()} (Due: {dateTimePickertask.Value:MM/dd/yyyy})";
            listBox1.Items.Add(taskWithDate);
            textBox1.Clear();


            dateTimePickertask.Value = DateTime.Now.AddDays(-1);
            SaveTasksToFile();
            UpdateProgressBar();

        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)

            {
                var result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                SaveTasksToFile();
                UpdateProgressBar();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnClearALL_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            SaveTasksToFile();
            UpdateProgressBar();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            string searchText = textBox1.Text.Trim();
            foreach (var item in listBox1.Items)
            {
                string taskName = item.ToString().Split(new[] { " (Due: " }, StringSplitOptions.None)[0];
                if(taskName.Contains(searchText)) 
              {
                    found = true; // Highlight match
                    break;
                }
            }
            if (found)
            {
                MessageBox.Show($"Task \"{searchText}\" found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Task \"{searchText}\" not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;

            if (index >= 0)
            {
                string task = listBox1.Items[index].ToString();

                // If already marked as complete, don't do it again
                if (!task.StartsWith("✔️ "))
                {
                    listBox1.Items[index] = "✔️ " + task;
                    SaveTasksToFile();
                    UpdateProgressBar();


                }
                else
                {
                    MessageBox.Show("This task is already marked as complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateProgressBar()
        {
            progressBarTasks.Minimum = 0;
            progressBarTasks.Maximum = 100;

            int totalTasks = listBox1.Items.Count;
            int completeTasks = 0;
            foreach (var item in listBox1.Items)
            {
                if (item.ToString().StartsWith("✔️"))

                {
                    completeTasks++;
                }

            }
            if (totalTasks > 0)
            {
                int progress = (int)(((double)completeTasks / totalTasks) * 100);

                progressBarTasks.Value = progress;
            }
            else
            {
                progressBarTasks.Value = 0;
            }
        }
        public void UpdateTaskStats()
        {
            TaskData.TotalTasks = listBox1.Items.Count;
            TaskData.CompletedTasks = listBox1.Items.Cast<string>()
                                           .Count(item => item.StartsWith("✔️ "));
        }

        private void SaveTasksToFile()
        {
            List<string> taskLines = new List<string>();
            foreach (var item in listBox1.Items)
            {
                taskLines.Add(item.ToString());
            }
            File.WriteAllLines(saveFilePath, taskLines);
            UpdateTaskStats();
        }



    }


}
  



