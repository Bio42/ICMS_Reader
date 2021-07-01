namespace ICMS_Reader
{
    partial class Form1
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
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWebPage = new System.Windows.Forms.TextBox();
            this.rbMEC = new System.Windows.Forms.RadioButton();
            this.rbEIT = new System.Windows.Forms.RadioButton();
            this.rbFirefox = new System.Windows.Forms.RadioButton();
            this.rbChrome = new System.Windows.Forms.RadioButton();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tcTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbDistinct = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvFiltered = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvAll = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tcTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(809, 614);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webseite:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbWebPage
            // 
            this.tbWebPage.Location = new System.Drawing.Point(6, 23);
            this.tbWebPage.Name = "tbWebPage";
            this.tbWebPage.Size = new System.Drawing.Size(199, 22);
            this.tbWebPage.TabIndex = 2;
            // 
            // rbMEC
            // 
            this.rbMEC.AutoSize = true;
            this.rbMEC.Checked = true;
            this.rbMEC.Location = new System.Drawing.Point(6, 21);
            this.rbMEC.Name = "rbMEC";
            this.rbMEC.Size = new System.Drawing.Size(106, 21);
            this.rbMEC.TabIndex = 3;
            this.rbMEC.TabStop = true;
            this.rbMEC.Text = "Mechatronik";
            this.rbMEC.UseVisualStyleBackColor = true;
            // 
            // rbEIT
            // 
            this.rbEIT.AutoSize = true;
            this.rbEIT.Location = new System.Drawing.Point(6, 48);
            this.rbEIT.Name = "rbEIT";
            this.rbEIT.Size = new System.Drawing.Size(211, 21);
            this.rbEIT.TabIndex = 5;
            this.rbEIT.Text = "Elektrotechnik und Informatik";
            this.rbEIT.UseVisualStyleBackColor = true;
            this.rbEIT.CheckedChanged += new System.EventHandler(this.rbEIT_CheckedChanged);
            // 
            // rbFirefox
            // 
            this.rbFirefox.AutoSize = true;
            this.rbFirefox.Checked = true;
            this.rbFirefox.Location = new System.Drawing.Point(6, 21);
            this.rbFirefox.Name = "rbFirefox";
            this.rbFirefox.Size = new System.Drawing.Size(71, 21);
            this.rbFirefox.TabIndex = 7;
            this.rbFirefox.TabStop = true;
            this.rbFirefox.Text = "Firefox";
            this.rbFirefox.UseVisualStyleBackColor = true;
            // 
            // rbChrome
            // 
            this.rbChrome.AutoSize = true;
            this.rbChrome.Location = new System.Drawing.Point(6, 48);
            this.rbChrome.Name = "rbChrome";
            this.rbChrome.Size = new System.Drawing.Size(78, 21);
            this.rbChrome.TabIndex = 8;
            this.rbChrome.Text = "Chrome";
            this.rbChrome.UseVisualStyleBackColor = true;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Enabled = false;
            this.lblErrorTitle.Location = new System.Drawing.Point(242, 26);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(44, 17);
            this.lblErrorTitle.TabIndex = 9;
            this.lblErrorTitle.Text = "Error:";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(3, 614);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(800, 23);
            this.pbProgress.TabIndex = 10;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(3, 594);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(56, 17);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = "Status: ";
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.Location = new System.Drawing.Point(57, 594);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(55, 17);
            this.lblProgressText.TabIndex = 12;
            this.lblProgressText.Text = "READY";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.Location = new System.Drawing.Point(292, 26);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(44, 17);
            this.lblErrorText.TabIndex = 13;
            this.lblErrorText.Text = "Keine";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFirefox);
            this.groupBox1.Controls.Add(this.rbChrome);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bevorzugter Browser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEIT);
            this.groupBox2.Controls.Add(this.rbMEC);
            this.groupBox2.Location = new System.Drawing.Point(6, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Studiengang";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(6, 38);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 16;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(6, 83);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Benutzername:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbUsername);
            this.groupBox3.Location = new System.Drawing.Point(6, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 119);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Anmelde-Daten";
            // 
            // tcTab
            // 
            this.tcTab.Controls.Add(this.tabPage1);
            this.tcTab.Controls.Add(this.tabPage2);
            this.tcTab.Location = new System.Drawing.Point(12, 12);
            this.tcTab.Name = "tcTab";
            this.tcTab.SelectedIndex = 0;
            this.tcTab.Size = new System.Drawing.Size(898, 672);
            this.tcTab.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.lblErrorTitle);
            this.tabPage1.Controls.Add(this.lblErrorText);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tbWebPage);
            this.tabPage1.Controls.Add(this.btnGo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblProgress);
            this.tabPage1.Controls.Add(this.lblProgressText);
            this.tabPage1.Controls.Add(this.pbProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abfrage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbDistinct);
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notenspiegel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbDistinct
            // 
            this.cbDistinct.AutoSize = true;
            this.cbDistinct.Checked = true;
            this.cbDistinct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDistinct.Location = new System.Drawing.Point(6, 6);
            this.cbDistinct.Name = "cbDistinct";
            this.cbDistinct.Size = new System.Drawing.Size(126, 21);
            this.cbDistinct.TabIndex = 2;
            this.cbDistinct.Text = "Nur beste Note";
            this.cbDistinct.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 608);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvFiltered);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 579);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Gefiltert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvFiltered
            // 
            this.lvFiltered.GridLines = true;
            this.lvFiltered.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFiltered.HideSelection = false;
            this.lvFiltered.Location = new System.Drawing.Point(10, 4);
            this.lvFiltered.Name = "lvFiltered";
            this.lvFiltered.Size = new System.Drawing.Size(868, 570);
            this.lvFiltered.TabIndex = 1;
            this.lvFiltered.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvAll);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(889, 579);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Alle";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvAll
            // 
            this.lvAll.GridLines = true;
            this.lvAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAll.HideSelection = false;
            this.lvAll.Location = new System.Drawing.Point(10, 4);
            this.lvAll.Name = "lvAll";
            this.lvAll.Size = new System.Drawing.Size(868, 570);
            this.lvAll.TabIndex = 1;
            this.lvAll.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 696);
            this.Controls.Add(this.tcTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tcTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWebPage;
        private System.Windows.Forms.RadioButton rbMEC;
        private System.Windows.Forms.RadioButton rbEIT;
        private System.Windows.Forms.RadioButton rbFirefox;
        private System.Windows.Forms.RadioButton rbChrome;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tcTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbDistinct;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvFiltered;
        private System.Windows.Forms.ListView lvAll;
    }
}

