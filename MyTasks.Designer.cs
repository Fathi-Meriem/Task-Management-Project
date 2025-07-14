namespace PracticeProject
{
    partial class MyTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnAddTask = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            btnDeleteTask = new Button();
            btnSearch = new Button();
            btnClearALL = new Button();
            btnMarkComplete = new Button();
            progressBarTasks = new ProgressBar();
            labelStartDate = new Label();
            dateTimePickertask = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = " ";
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Green;
            btnAddTask.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = SystemColors.ButtonHighlight;
            btnAddTask.Location = new Point(646, 106);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(170, 40);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = " Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(282, 209);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 229);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(159, 116);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 3;
            label1.Text = " Task Name:";
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.Green;
            btnDeleteTask.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(646, 151);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(170, 34);
            btnDeleteTask.TabIndex = 4;
            btnDeleteTask.Text = "Delete ";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Green;
            btnSearch.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(822, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 40);
            btnSearch.TabIndex = 5;
            btnSearch.Text = " Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearALL
            // 
            btnClearALL.BackColor = Color.Green;
            btnClearALL.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearALL.ForeColor = Color.White;
            btnClearALL.Location = new Point(822, 152);
            btnClearALL.Name = "btnClearALL";
            btnClearALL.Size = new Size(151, 34);
            btnClearALL.TabIndex = 6;
            btnClearALL.Text = "Clear All Tasks";
            btnClearALL.UseVisualStyleBackColor = false;
            btnClearALL.Click += btnClearALL_Click;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.BackColor = Color.Green;
            btnMarkComplete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkComplete.ForeColor = Color.White;
            btnMarkComplete.Location = new Point(640, 458);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(176, 44);
            btnMarkComplete.TabIndex = 10;
            btnMarkComplete.Text = "Mark as complete";
            btnMarkComplete.UseVisualStyleBackColor = false;
            btnMarkComplete.Click += button1_Click;
            // 
            // progressBarTasks
            // 
            progressBarTasks.Location = new Point(282, 458);
            progressBarTasks.Name = "progressBarTasks";
            progressBarTasks.Size = new Size(352, 44);
            progressBarTasks.TabIndex = 11;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(237, 95);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(0, 25);
            labelStartDate.TabIndex = 12;
            // 
            // dateTimePickertask
            // 
            dateTimePickertask.Location = new Point(282, 146);
            dateTimePickertask.Name = "dateTimePickertask";
            dateTimePickertask.Size = new Size(352, 31);
            dateTimePickertask.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(158, 151);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 15;
            label2.Text = " Deadline:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 24);
            label3.Name = "label3";
            label3.Size = new Size(153, 56);
            label3.TabIndex = 16;
            label3.Text = "Tasks";
            // 
            // MyTasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1330, 698);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickertask);
            Controls.Add(labelStartDate);
            Controls.Add(progressBarTasks);
            Controls.Add(btnMarkComplete);
            Controls.Add(btnClearALL);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteTask);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnAddTask);
            Controls.Add(textBox1);
            Name = "MyTasks";
            Text = " ";
            Load += MyTasks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnAddTask;
        private ListBox listBox1;
        private Label label1;
        private Button btnDeleteTask;
        private Button btnSearch;
        private Button btnClearALL;
        private Button btnMarkComplete;
        private ProgressBar progressBarTasks;
        private Label labelStartDate;
        private DateTimePicker dateTimePickertask;
        private Label label2;
        private Label label3;
    }
}