namespace dayOne
{
    partial class comboxShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdClasses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdClass = new System.Windows.Forms.TextBox();
            this.btnClassName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnReomve = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addLibrary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(109, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your class";
            // 
            // cmdClasses
            // 
            this.cmdClasses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmdClasses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmdClasses.FormattingEnabled = true;
            this.cmdClasses.Items.AddRange(new object[] {
            "Primary",
            "nursary",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve"});
            this.cmdClasses.Location = new System.Drawing.Point(318, 96);
            this.cmdClasses.Name = "cmdClasses";
            this.cmdClasses.Size = new System.Drawing.Size(152, 21);
            this.cmdClasses.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(318, 148);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(152, 28);
            this.cmbGender.TabIndex = 4;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.CmbGender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your class";
            // 
            // cmdClass
            // 
            this.cmdClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClass.Location = new System.Drawing.Point(318, 22);
            this.cmdClass.Name = "cmdClass";
            this.cmdClass.Size = new System.Drawing.Size(144, 26);
            this.cmdClass.TabIndex = 0;
            this.cmdClass.DragEnter += new System.Windows.Forms.DragEventHandler(this.CmdClass_DragEnter);
            // 
            // btnClassName
            // 
            this.btnClassName.Location = new System.Drawing.Point(518, 25);
            this.btnClassName.Name = "btnClassName";
            this.btnClassName.Size = new System.Drawing.Size(75, 23);
            this.btnClassName.TabIndex = 1;
            this.btnClassName.Text = "Add Class";
            this.btnClassName.UseVisualStyleBackColor = true;
            this.btnClassName.Click += new System.EventHandler(this.BtnClassName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(300, 210);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // btnReomve
            // 
            this.btnReomve.Location = new System.Drawing.Point(395, 210);
            this.btnReomve.Name = "btnReomve";
            this.btnReomve.Size = new System.Drawing.Size(75, 23);
            this.btnReomve.TabIndex = 6;
            this.btnReomve.Text = "Remove";
            this.btnReomve.UseVisualStyleBackColor = true;
            this.btnReomve.Click += new System.EventHandler(this.BtnReomve_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "the number of books availlabel";
            // 
            // cmbBook
            // 
            this.cmbBook.AutoCompleteCustomSource.AddRange(new string[] {
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbBook.Location = new System.Drawing.Point(318, 307);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(152, 21);
            this.cmbBook.Sorted = true;
            this.cmbBook.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add Numbers to library";
            // 
            // addLibrary
            // 
            this.addLibrary.Location = new System.Drawing.Point(318, 256);
            this.addLibrary.Name = "addLibrary";
            this.addLibrary.Size = new System.Drawing.Size(144, 20);
            this.addLibrary.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(518, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(185, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "click to log into facebook";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(518, 305);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // comboxShow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addLibrary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReomve);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClassName);
            this.Controls.Add(this.cmdClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdClasses);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "comboxShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "comboxShow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ComboxShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmdClass;
        private System.Windows.Forms.Button btnClassName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnReomve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addLibrary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnTotal;
    }
}