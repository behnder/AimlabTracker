
namespace AimlabDataManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.comboTasks = new System.Windows.Forms.ComboBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblLast100 = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.TxtLast100 = new System.Windows.Forms.TextBox();
            this.txtDeviation = new System.Windows.Forms.TextBox();
            this.lvlDeviation = new System.Windows.Forms.Label();
            this.lblShowAvg = new System.Windows.Forms.Label();
            this.lblShowRecord = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboTasks
            // 
            this.comboTasks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboTasks.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTasks.FormattingEnabled = true;
            this.comboTasks.Items.AddRange(new object[] {
            "Spidershot FLICKING",
            "Linetrace FLICKING",
            "Gridshot FLICKING",
            "Microshot FLICKING",
            "Motionshot FLICKING",
            "Reactivetrack TRACKING",
            "Strafebot TRACKING",
            "Motionshot SPEED",
            "Gridshot SPEED",
            "Motionshot PRECISION",
            "Spidershot PRECISION",
            "Microshot PRECIISON",
            "Headshot PRECISION"});
            this.comboTasks.Location = new System.Drawing.Point(30, 84);
            this.comboTasks.Name = "comboTasks";
            this.comboTasks.Size = new System.Drawing.Size(199, 36);
            this.comboTasks.TabIndex = 0;
            this.comboTasks.SelectedIndexChanged += new System.EventHandler(this.comboTasks_SelectedIndexChanged);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Poppins", 12.25F);
            this.lblTasks.Location = new System.Drawing.Point(25, 52);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(108, 30);
            this.lblTasks.TabIndex = 1;
            this.lblTasks.Text = "Select Task";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(501, 50);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(69, 28);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "Record";
            this.lblRecord.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLast100
            // 
            this.lblLast100.AutoSize = true;
            this.lblLast100.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast100.Location = new System.Drawing.Point(25, 123);
            this.lblLast100.Name = "lblLast100";
            this.lblLast100.Size = new System.Drawing.Size(73, 28);
            this.lblLast100.TabIndex = 3;
            this.lblLast100.Text = "Last 100";
            this.lblLast100.Click += new System.EventHandler(this.lblRecord_Click);
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(344, 50);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(43, 28);
            this.lblAvg.TabIndex = 4;
            this.lblAvg.Text = "Avg";
            // 
            // TxtLast100
            // 
            this.TxtLast100.Font = new System.Drawing.Font("Poppins", 6F);
            this.TxtLast100.Location = new System.Drawing.Point(30, 154);
            this.TxtLast100.Multiline = true;
            this.TxtLast100.Name = "TxtLast100";
            this.TxtLast100.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtLast100.Size = new System.Drawing.Size(68, 472);
            this.TxtLast100.TabIndex = 5;
            // 
            // txtDeviation
            // 
            this.txtDeviation.Font = new System.Drawing.Font("Poppins", 6F);
            this.txtDeviation.Location = new System.Drawing.Point(119, 154);
            this.txtDeviation.Multiline = true;
            this.txtDeviation.Name = "txtDeviation";
            this.txtDeviation.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDeviation.Size = new System.Drawing.Size(68, 472);
            this.txtDeviation.TabIndex = 7;
            this.txtDeviation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lvlDeviation
            // 
            this.lvlDeviation.AutoSize = true;
            this.lvlDeviation.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDeviation.Location = new System.Drawing.Point(114, 123);
            this.lvlDeviation.Name = "lvlDeviation";
            this.lvlDeviation.Size = new System.Drawing.Size(87, 28);
            this.lvlDeviation.TabIndex = 6;
            this.lvlDeviation.Text = "Deviation";
            this.lvlDeviation.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblShowAvg
            // 
            this.lblShowAvg.AutoSize = true;
            this.lblShowAvg.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAvg.Location = new System.Drawing.Point(393, 52);
            this.lblShowAvg.Name = "lblShowAvg";
            this.lblShowAvg.Size = new System.Drawing.Size(89, 28);
            this.lblShowAvg.TabIndex = 8;
            this.lblShowAvg.Text = "Show Avg";
            // 
            // lblShowRecord
            // 
            this.lblShowRecord.AutoSize = true;
            this.lblShowRecord.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowRecord.Location = new System.Drawing.Point(576, 50);
            this.lblShowRecord.Name = "lblShowRecord";
            this.lblShowRecord.Size = new System.Drawing.Size(115, 28);
            this.lblShowRecord.TabIndex = 9;
            this.lblShowRecord.Text = "Show Record";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(202, 569);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(185, 57);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(393, 569);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 57);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblShowRecord);
            this.Controls.Add(this.lblShowAvg);
            this.Controls.Add(this.txtDeviation);
            this.Controls.Add(this.lvlDeviation);
            this.Controls.Add(this.TxtLast100);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblLast100);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.comboTasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblLast100;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox TxtLast100;
        private System.Windows.Forms.TextBox txtDeviation;
        private System.Windows.Forms.Label lvlDeviation;
        private System.Windows.Forms.Label lblShowAvg;
        private System.Windows.Forms.Label lblShowRecord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
    }
}

