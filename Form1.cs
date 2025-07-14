namespace PracticeProject
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        public static class TaskData
        {
            public static int TotalTasks = 0;
            public static int CompletedTasks = 0;
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existing = Application.OpenForms["MyTasks"];
            if (existing == null)
            {
                MyTasks myTasks = new MyTasks();
                myTasks.Show();
            }
            else
            {
                existing.BringToFront();
            }
        }

        private void remindersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form existing = Application.OpenForms["Dashboard"];
            if (existing == null)
            {
                Dashboard dashboard = new Dashboard();

                dashboard.Show();
            }
            else
            {
                existing.BringToFront();
            }

           
            
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
