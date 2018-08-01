namespace WinformsUI
{
    partial class frmMain
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
            this.FemaleAll = new System.Windows.Forms.Button();
            this.ListGenerator = new System.Windows.Forms.GroupBox();
            this.All = new System.Windows.Forms.Button();
            this.MaleAll = new System.Windows.Forms.Button();
            this.FemaleCurrent = new System.Windows.Forms.Button();
            this.MaleCurrent = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbnewathlete = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPullUps = new System.Windows.Forms.Label();
            this.lblBench = new System.Windows.Forms.Label();
            this.lblDeadlift = new System.Windows.Forms.Label();
            this.lblSquat = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblOHShot = new System.Windows.Forms.Label();
            this.lblSprint300m = new System.Windows.Forms.Label();
            this.lblSprint30m = new System.Windows.Forms.Label();
            this.txtPullUps = new System.Windows.Forms.TextBox();
            this.lblBroadJump = new System.Windows.Forms.Label();
            this.txtBench = new System.Windows.Forms.TextBox();
            this.txtDeadlift = new System.Windows.Forms.TextBox();
            this.txtSquat = new System.Windows.Forms.TextBox();
            this.txtOHShot = new System.Windows.Forms.TextBox();
            this.txtSprint300 = new System.Windows.Forms.TextBox();
            this.txtSprint30 = new System.Windows.Forms.TextBox();
            this.txtBroad = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.txtFinalScore = new System.Windows.Forms.TextBox();
            this.ListGenerator.SuspendLayout();
            this.gbnewathlete.SuspendLayout();
            this.SuspendLayout();
            // 
            // FemaleAll
            // 
            this.FemaleAll.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleAll.Location = new System.Drawing.Point(64, 84);
            this.FemaleAll.Name = "FemaleAll";
            this.FemaleAll.Size = new System.Drawing.Size(360, 40);
            this.FemaleAll.TabIndex = 0;
            this.FemaleAll.Text = "All Time Female Athlete Scores";
            this.FemaleAll.UseVisualStyleBackColor = true;
            this.FemaleAll.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ListGenerator
            // 
            this.ListGenerator.BackColor = System.Drawing.Color.Firebrick;
            this.ListGenerator.Controls.Add(this.All);
            this.ListGenerator.Controls.Add(this.MaleAll);
            this.ListGenerator.Controls.Add(this.FemaleCurrent);
            this.ListGenerator.Controls.Add(this.FemaleAll);
            this.ListGenerator.Controls.Add(this.MaleCurrent);
            this.ListGenerator.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListGenerator.Location = new System.Drawing.Point(27, 119);
            this.ListGenerator.Name = "ListGenerator";
            this.ListGenerator.Size = new System.Drawing.Size(485, 313);
            this.ListGenerator.TabIndex = 2;
            this.ListGenerator.TabStop = false;
            this.ListGenerator.Text = "Click To See Athlete Scores";
            // 
            // All
            // 
            this.All.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All.Location = new System.Drawing.Point(64, 267);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(360, 40);
            this.All.TabIndex = 8;
            this.All.Text = "All Athlete Scores";
            this.All.UseVisualStyleBackColor = true;
            // 
            // MaleAll
            // 
            this.MaleAll.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleAll.Location = new System.Drawing.Point(64, 26);
            this.MaleAll.Name = "MaleAll";
            this.MaleAll.Size = new System.Drawing.Size(360, 42);
            this.MaleAll.TabIndex = 5;
            this.MaleAll.Text = "All Time Male Athlete Scores";
            this.MaleAll.UseVisualStyleBackColor = true;
            this.MaleAll.Click += new System.EventHandler(this.MaleAll_Click);
            // 
            // FemaleCurrent
            // 
            this.FemaleCurrent.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleCurrent.Location = new System.Drawing.Point(64, 205);
            this.FemaleCurrent.Name = "FemaleCurrent";
            this.FemaleCurrent.Size = new System.Drawing.Size(360, 43);
            this.FemaleCurrent.TabIndex = 7;
            this.FemaleCurrent.Text = "Current Female Athlete Scores";
            this.FemaleCurrent.UseVisualStyleBackColor = true;
            this.FemaleCurrent.Click += new System.EventHandler(this.FemaleCurrent_Click);
            // 
            // MaleCurrent
            // 
            this.MaleCurrent.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCurrent.Location = new System.Drawing.Point(64, 144);
            this.MaleCurrent.Name = "MaleCurrent";
            this.MaleCurrent.Size = new System.Drawing.Size(360, 41);
            this.MaleCurrent.TabIndex = 6;
            this.MaleCurrent.Text = "Current Male Athlete Scores";
            this.MaleCurrent.UseVisualStyleBackColor = true;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(797, 69);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(123, 31);
            this.Searchbtn.TabIndex = 4;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gold;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(321, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(470, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "SEARCH FOR AN ATHLETE";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbnewathlete
            // 
            this.gbnewathlete.BackColor = System.Drawing.Color.Firebrick;
            this.gbnewathlete.Controls.Add(this.txtFinalScore);
            this.gbnewathlete.Controls.Add(this.lblGender);
            this.gbnewathlete.Controls.Add(this.cboGender);
            this.gbnewathlete.Controls.Add(this.lblWeight);
            this.gbnewathlete.Controls.Add(this.txtWeight);
            this.gbnewathlete.Controls.Add(this.lblLastName);
            this.gbnewathlete.Controls.Add(this.lblFirstname);
            this.gbnewathlete.Controls.Add(this.textBox12);
            this.gbnewathlete.Controls.Add(this.txtFirstName);
            this.gbnewathlete.Controls.Add(this.lblPullUps);
            this.gbnewathlete.Controls.Add(this.lblBench);
            this.gbnewathlete.Controls.Add(this.lblDeadlift);
            this.gbnewathlete.Controls.Add(this.lblSquat);
            this.gbnewathlete.Controls.Add(this.btnCalc);
            this.gbnewathlete.Controls.Add(this.lblOHShot);
            this.gbnewathlete.Controls.Add(this.lblSprint300m);
            this.gbnewathlete.Controls.Add(this.lblSprint30m);
            this.gbnewathlete.Controls.Add(this.txtPullUps);
            this.gbnewathlete.Controls.Add(this.lblBroadJump);
            this.gbnewathlete.Controls.Add(this.txtBench);
            this.gbnewathlete.Controls.Add(this.txtDeadlift);
            this.gbnewathlete.Controls.Add(this.txtSquat);
            this.gbnewathlete.Controls.Add(this.txtOHShot);
            this.gbnewathlete.Controls.Add(this.txtSprint300);
            this.gbnewathlete.Controls.Add(this.txtSprint30);
            this.gbnewathlete.Controls.Add(this.txtBroad);
            this.gbnewathlete.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbnewathlete.Location = new System.Drawing.Point(545, 119);
            this.gbnewathlete.Name = "gbnewathlete";
            this.gbnewathlete.Size = new System.Drawing.Size(451, 347);
            this.gbnewathlete.TabIndex = 7;
            this.gbnewathlete.TabStop = false;
            this.gbnewathlete.Text = "Add A New Athlete";
            this.gbnewathlete.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(233, 59);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 41;
            this.lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(312, 59);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 28);
            this.cboGender.TabIndex = 40;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(5, 59);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(51, 16);
            this.lblWeight.TabIndex = 39;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(92, 59);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 27);
            this.txtWeight.TabIndex = 37;
            this.txtWeight.Text = "190";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(233, 26);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(3, 26);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(76, 16);
            this.lblFirstname.TabIndex = 35;
            this.lblFirstname.Text = "First Name";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(312, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(133, 27);
            this.textBox12.TabIndex = 34;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 27);
            this.txtFirstName.TabIndex = 33;
            // 
            // lblPullUps
            // 
            this.lblPullUps.AutoSize = true;
            this.lblPullUps.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPullUps.Location = new System.Drawing.Point(232, 221);
            this.lblPullUps.Name = "lblPullUps";
            this.lblPullUps.Size = new System.Drawing.Size(88, 16);
            this.lblPullUps.TabIndex = 32;
            this.lblPullUps.Text = "Max Pull-Ups";
            this.lblPullUps.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBench
            // 
            this.lblBench.AutoSize = true;
            this.lblBench.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBench.Location = new System.Drawing.Point(232, 185);
            this.lblBench.Name = "lblBench";
            this.lblBench.Size = new System.Drawing.Size(74, 16);
            this.lblBench.TabIndex = 31;
            this.lblBench.Text = "Max Bench";
            // 
            // lblDeadlift
            // 
            this.lblDeadlift.AutoSize = true;
            this.lblDeadlift.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlift.Location = new System.Drawing.Point(233, 150);
            this.lblDeadlift.Name = "lblDeadlift";
            this.lblDeadlift.Size = new System.Drawing.Size(84, 16);
            this.lblDeadlift.TabIndex = 30;
            this.lblDeadlift.Text = "Max Deadlift";
            // 
            // lblSquat
            // 
            this.lblSquat.AutoSize = true;
            this.lblSquat.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquat.Location = new System.Drawing.Point(232, 116);
            this.lblSquat.Name = "lblSquat";
            this.lblSquat.Size = new System.Drawing.Size(71, 16);
            this.lblSquat.TabIndex = 29;
            this.lblSquat.Text = "Max Squat";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(25, 275);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(122, 38);
            this.btnCalc.TabIndex = 28;
            this.btnCalc.Text = "Get Score";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblOHShot
            // 
            this.lblOHShot.AutoSize = true;
            this.lblOHShot.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOHShot.Location = new System.Drawing.Point(3, 221);
            this.lblOHShot.Name = "lblOHShot";
            this.lblOHShot.Size = new System.Drawing.Size(57, 16);
            this.lblOHShot.TabIndex = 27;
            this.lblOHShot.Text = "OH Shot";
            // 
            // lblSprint300m
            // 
            this.lblSprint300m.AutoSize = true;
            this.lblSprint300m.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprint300m.Location = new System.Drawing.Point(5, 185);
            this.lblSprint300m.Name = "lblSprint300m";
            this.lblSprint300m.Size = new System.Drawing.Size(85, 16);
            this.lblSprint300m.TabIndex = 26;
            this.lblSprint300m.Text = "Sprint 300m";
            // 
            // lblSprint30m
            // 
            this.lblSprint30m.AutoSize = true;
            this.lblSprint30m.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprint30m.Location = new System.Drawing.Point(5, 150);
            this.lblSprint30m.Name = "lblSprint30m";
            this.lblSprint30m.Size = new System.Drawing.Size(77, 16);
            this.lblSprint30m.TabIndex = 25;
            this.lblSprint30m.Text = "Sprint 30m";
            this.lblSprint30m.Click += new System.EventHandler(this.Sprint30m_Click);
            // 
            // txtPullUps
            // 
            this.txtPullUps.Location = new System.Drawing.Point(351, 221);
            this.txtPullUps.Name = "txtPullUps";
            this.txtPullUps.Size = new System.Drawing.Size(100, 27);
            this.txtPullUps.TabIndex = 24;
            this.txtPullUps.Text = "22";
            // 
            // lblBroadJump
            // 
            this.lblBroadJump.AutoSize = true;
            this.lblBroadJump.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroadJump.Location = new System.Drawing.Point(3, 116);
            this.lblBroadJump.Name = "lblBroadJump";
            this.lblBroadJump.Size = new System.Drawing.Size(80, 16);
            this.lblBroadJump.TabIndex = 8;
            this.lblBroadJump.Text = "Broad Jump";
            this.lblBroadJump.Click += new System.EventHandler(this.txtBroadJump_Click);
            // 
            // txtBench
            // 
            this.txtBench.Location = new System.Drawing.Point(351, 185);
            this.txtBench.Name = "txtBench";
            this.txtBench.Size = new System.Drawing.Size(100, 27);
            this.txtBench.TabIndex = 23;
            this.txtBench.Text = "275";
            // 
            // txtDeadlift
            // 
            this.txtDeadlift.Location = new System.Drawing.Point(351, 150);
            this.txtDeadlift.Name = "txtDeadlift";
            this.txtDeadlift.Size = new System.Drawing.Size(100, 27);
            this.txtDeadlift.TabIndex = 22;
            this.txtDeadlift.Text = "455";
            // 
            // txtSquat
            // 
            this.txtSquat.Location = new System.Drawing.Point(351, 116);
            this.txtSquat.Name = "txtSquat";
            this.txtSquat.Size = new System.Drawing.Size(100, 27);
            this.txtSquat.TabIndex = 21;
            this.txtSquat.Text = "385";
            // 
            // txtOHShot
            // 
            this.txtOHShot.Location = new System.Drawing.Point(92, 221);
            this.txtOHShot.Name = "txtOHShot";
            this.txtOHShot.Size = new System.Drawing.Size(100, 27);
            this.txtOHShot.TabIndex = 20;
            this.txtOHShot.Text = "16";
            // 
            // txtSprint300
            // 
            this.txtSprint300.Location = new System.Drawing.Point(92, 185);
            this.txtSprint300.Name = "txtSprint300";
            this.txtSprint300.Size = new System.Drawing.Size(100, 27);
            this.txtSprint300.TabIndex = 19;
            this.txtSprint300.Text = "36.1";
            // 
            // txtSprint30
            // 
            this.txtSprint30.Location = new System.Drawing.Point(92, 150);
            this.txtSprint30.Name = "txtSprint30";
            this.txtSprint30.Size = new System.Drawing.Size(100, 27);
            this.txtSprint30.TabIndex = 18;
            this.txtSprint30.Text = "3.8";
            // 
            // txtBroad
            // 
            this.txtBroad.Location = new System.Drawing.Point(92, 116);
            this.txtBroad.Name = "txtBroad";
            this.txtBroad.Size = new System.Drawing.Size(100, 27);
            this.txtBroad.TabIndex = 17;
            this.txtBroad.Text = "3";
            this.txtBroad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Silver;
            this.Title.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(436, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(236, 28);
            this.Title.TabIndex = 9;
            this.Title.Text = "Welcome To Tracker";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFinalScore
            // 
            this.txtFinalScore.Location = new System.Drawing.Point(219, 284);
            this.txtFinalScore.Name = "txtFinalScore";
            this.txtFinalScore.Size = new System.Drawing.Size(100, 27);
            this.txtFinalScore.TabIndex = 42;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1008, 478);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.gbnewathlete);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.ListGenerator);
            this.Name = "frmMain";
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ListGenerator.ResumeLayout(false);
            this.gbnewathlete.ResumeLayout(false);
            this.gbnewathlete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FemaleAll;
        private System.Windows.Forms.GroupBox ListGenerator;
        private System.Windows.Forms.Button MaleAll;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button FemaleCurrent;
        private System.Windows.Forms.Button MaleCurrent;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox gbnewathlete;
        private System.Windows.Forms.TextBox txtPullUps;
        private System.Windows.Forms.TextBox txtBench;
        private System.Windows.Forms.TextBox txtDeadlift;
        private System.Windows.Forms.TextBox txtSquat;
        private System.Windows.Forms.TextBox txtOHShot;
        private System.Windows.Forms.TextBox txtSprint300;
        private System.Windows.Forms.TextBox txtSprint30;
        private System.Windows.Forms.TextBox txtBroad;
        private System.Windows.Forms.Label lblBroadJump;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblOHShot;
        private System.Windows.Forms.Label lblSprint300m;
        private System.Windows.Forms.Label lblSprint30m;
        private System.Windows.Forms.Label lblPullUps;
        private System.Windows.Forms.Label lblBench;
        private System.Windows.Forms.Label lblDeadlift;
        private System.Windows.Forms.Label lblSquat;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtFinalScore;
    }
}

