namespace PracticeProject
{
    partial class Dashboard
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
            progressBarSummary = new ProgressBar();
            labelQuote = new Label();
            lblTotalTasks = new Label();
            lblCompletedTasks = new Label();
            labelSummary = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // progressBarSummary
            // 
            progressBarSummary.Location = new Point(190, 299);
            progressBarSummary.Name = "progressBarSummary";
            progressBarSummary.Size = new Size(612, 54);
            progressBarSummary.TabIndex = 1;
            // 
            // labelQuote
            // 
            labelQuote.AutoSize = true;
            labelQuote.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelQuote.ForeColor = Color.Green;
            labelQuote.Location = new Point(12, 417);
            labelQuote.Name = "labelQuote";
            labelQuote.Size = new Size(189, 60);
            labelQuote.TabIndex = 2;
            labelQuote.Text = "lbQuote";
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Location = new Point(556, 129);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(62, 21);
            lblTotalTasks.TabIndex = 3;
            lblTotalTasks.Text = "label1";
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.AutoSize = true;
            lblCompletedTasks.Location = new Point(556, 167);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(62, 21);
            lblCompletedTasks.TabIndex = 4;
            lblCompletedTasks.Text = "label2";
            // 
            // labelSummary
            // 
            labelSummary.AutoSize = true;
            labelSummary.Location = new Point(556, 205);
            labelSummary.Name = "labelSummary";
            labelSummary.Size = new Size(62, 21);
            labelSummary.TabIndex = 5;
            labelSummary.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(335, 167);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 6;
            label1.Text = "Completed Tasks:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(335, 129);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 7;
            label2.Text = "Total Tasks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(335, 205);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 8;
            label3.Text = " Summary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(345, 25);
            label4.Name = "label4";
            label4.Size = new Size(273, 56);
            label4.TabIndex = 9;
            label4.Text = " Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1070, 569);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelSummary);
            Controls.Add(lblCompletedTasks);
            Controls.Add(lblTotalTasks);
            Controls.Add(labelQuote);
            Controls.Add(progressBarSummary);
            Font = new Font("Arial", 9F, FontStyle.Bold);
            ForeColor = Color.Green;
            Name = "Dashboard";
            Text = "   ";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBarSummary;
        private Label labelQuote;
        private Label lblTotalTasks;
        private Label lblCompletedTasks;
        private Label labelSummary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}