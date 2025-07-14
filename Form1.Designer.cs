namespace PracticeProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            remindersToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tasksToolStripMenuItem, remindersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1069, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(69, 29);
            tasksToolStripMenuItem.Text = "Tasks";
            tasksToolStripMenuItem.Click += tasksToolStripMenuItem_Click;
            // 
            // remindersToolStripMenuItem
            // 
            remindersToolStripMenuItem.Name = "remindersToolStripMenuItem";
            remindersToolStripMenuItem.Size = new Size(121, 29);
            remindersToolStripMenuItem.Text = " Dashboard";
            remindersToolStripMenuItem.Click += remindersToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "metrics.png");
            imageList1.Images.SetKeyName(1, "settings.png");
            imageList1.Images.SetKeyName(2, "task.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1069, 685);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = " ";
            UseWaitCursor = true;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem remindersToolStripMenuItem;
        private ImageList imageList1;
    }
}
