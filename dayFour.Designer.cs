namespace dayOne
{
    partial class dayFour
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
            this.listLanguage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtindex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemovebySelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLanguage
            // 
            this.listLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLanguage.FormattingEnabled = true;
            this.listLanguage.HorizontalScrollbar = true;
            this.listLanguage.ItemHeight = 20;
            this.listLanguage.Items.AddRange(new object[] {
            "Nepali",
            "English",
            "French",
            "Spanish",
            "Hindi",
            "Tamil",
            "Urdu"});
            this.listLanguage.Location = new System.Drawing.Point(174, 111);
            this.listLanguage.Name = "listLanguage";
            this.listLanguage.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listLanguage.Size = new System.Drawing.Size(197, 264);
            this.listLanguage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(171, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select your language";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(644, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Enter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnLanguage_Click);
            // 
            // languageBox
            // 
            this.languageBox.Location = new System.Drawing.Point(559, 111);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(160, 20);
            this.languageBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Write an item to add";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(559, 200);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(160, 20);
            this.txtRemove.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Write an item to remove";
            // 
            // txtindex
            // 
            this.txtindex.Location = new System.Drawing.Point(559, 302);
            this.txtindex.Name = "txtindex";
            this.txtindex.Size = new System.Drawing.Size(160, 20);
            this.txtindex.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Write an index to add";
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(644, 352);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 5;
            this.btnIndex.Text = "Enter";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(644, 245);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Enter";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(504, 391);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(97, 29);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(634, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnRemovebySelected
            // 
            this.btnRemovebySelected.Location = new System.Drawing.Point(175, 397);
            this.btnRemovebySelected.Name = "btnRemovebySelected";
            this.btnRemovebySelected.Size = new System.Drawing.Size(196, 23);
            this.btnRemovebySelected.TabIndex = 9;
            this.btnRemovebySelected.Text = "Remove selected item";
            this.btnRemovebySelected.UseVisualStyleBackColor = true;
            this.btnRemovebySelected.Click += new System.EventHandler(this.BtnRemovebySelected_Click);
            // 
            // dayFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemovebySelected);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtindex);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listLanguage);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dayFour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dayFourListBoxDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtindex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemovebySelected;
    }
}