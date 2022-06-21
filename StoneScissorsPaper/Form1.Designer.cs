namespace StoneScissorsPaper
{
    enum Choise
    {
        Камень,
        Ножницы,
        Бумага
    }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStone = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblUnuse = new System.Windows.Forms.Label();
            this.lblScoreUser = new System.Windows.Forms.Label();
            this.lblScoreComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStone
            // 
            resources.ApplyResources(this.btnStone, "btnStone");
            this.btnStone.Name = "btnStone";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnScissors
            // 
            resources.ApplyResources(this.btnScissors, "btnScissors");
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnPaper, "btnPaper");
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblOut
            // 
            resources.ApplyResources(this.lblOut, "lblOut");
            this.lblOut.Name = "lblOut";
            // 
            // lblUnuse
            // 
            resources.ApplyResources(this.lblUnuse, "lblUnuse");
            this.lblUnuse.Name = "lblUnuse";
            // 
            // lblScoreUser
            // 
            resources.ApplyResources(this.lblScoreUser, "lblScoreUser");
            this.lblScoreUser.Name = "lblScoreUser";
            this.lblScoreUser.Text = scoreUser.ToString();
            // 
            // lblScoreComp
            // 
            resources.ApplyResources(this.lblScoreComp, "lblScoreComp");
            this.lblScoreComp.Name = "lblScoreComp";
            this.lblScoreComp.Text = scoreComp.ToString();
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblScoreComp);
            this.Controls.Add(this.lblScoreUser);
            this.Controls.Add(this.lblUnuse);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnStone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStone;
        private Button btnScissors;
        private Button btnPaper;
        private Label lblOut;
        private Label lblUnuse;
        private Label lblScoreUser;
        private Label lblScoreComp;
        int scoreUser;
        int scoreComp;
    }
}