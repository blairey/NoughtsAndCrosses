namespace NoughtsAndCrosses
{
    partial class gamewindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(469, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.newGameToolStripMenuItem.Text = "new game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.FloralWhite;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(17, 68);
            this.x1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(137, 125);
            this.x1.TabIndex = 1;
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.buttonPress);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.FloralWhite;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(162, 68);
            this.x2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(137, 125);
            this.x2.TabIndex = 2;
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.buttonPress);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.FloralWhite;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x3.Location = new System.Drawing.Point(308, 68);
            this.x3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(137, 125);
            this.x3.TabIndex = 3;
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.buttonPress);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.Color.FloralWhite;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1.Location = new System.Drawing.Point(17, 200);
            this.y1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(137, 125);
            this.y1.TabIndex = 4;
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.buttonPress);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.Color.FloralWhite;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.Location = new System.Drawing.Point(162, 200);
            this.y2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(137, 125);
            this.y2.TabIndex = 5;
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.buttonPress);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.Color.FloralWhite;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y3.Location = new System.Drawing.Point(308, 200);
            this.y3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(137, 125);
            this.y3.TabIndex = 6;
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.buttonPress);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.FloralWhite;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z1.Location = new System.Drawing.Point(17, 332);
            this.z1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(137, 125);
            this.z1.TabIndex = 7;
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.buttonPress);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.FloralWhite;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z2.Location = new System.Drawing.Point(162, 332);
            this.z2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(137, 125);
            this.z2.TabIndex = 8;
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.buttonPress);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.FloralWhite;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z3.Location = new System.Drawing.Point(308, 332);
            this.z3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(137, 125);
            this.z3.TabIndex = 9;
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.buttonPress);
            // 
            // gamewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(469, 483);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "gamewindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noughts And Crosses";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
    }
}

