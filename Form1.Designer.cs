

namespace สร้างคลาส_GPACalculator__ให้สมบูรณ์
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
            this.addName = new System.Windows.Forms.Label();
            this.addScore = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.addName2 = new System.Windows.Forms.Label();
            this.addScore2 = new System.Windows.Forms.Label();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.tbScore2 = new System.Windows.Forms.TextBox();
            this.tbName3 = new System.Windows.Forms.TextBox();
            this.tbScore3 = new System.Windows.Forms.TextBox();
            this.addKon = new System.Windows.Forms.Label();
            this.addHighest = new System.Windows.Forms.Label();
            this.addLowest = new System.Windows.Forms.Label();
            this.addGpax = new System.Windows.Forms.Label();
            this.tbKon = new System.Windows.Forms.TextBox();
            this.tbHighest = new System.Windows.Forms.TextBox();
            this.tbLowest = new System.Windows.Forms.TextBox();
            this.tbGpax = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addName
            // 
            this.addName.AutoSize = true;
            this.addName.Location = new System.Drawing.Point(70, 42);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(26, 16);
            this.addName.TabIndex = 0;
            this.addName.Text = "ชื่อ :";
            this.addName.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // addScore
            // 
            this.addScore.AutoSize = true;
            this.addScore.Location = new System.Drawing.Point(70, 89);
            this.addScore.Name = "addScore";
            this.addScore.Size = new System.Drawing.Size(46, 16);
            this.addScore.TabIndex = 1;
            this.addScore.Text = "คะแนน :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "เพิ่มข้อมูล";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(139, 86);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(100, 22);
            this.tbScore.TabIndex = 4;
            // 
            // addName2
            // 
            this.addName2.AutoSize = true;
            this.addName2.Location = new System.Drawing.Point(319, 39);
            this.addName2.Name = "addName2";
            this.addName2.Size = new System.Drawing.Size(26, 16);
            this.addName2.TabIndex = 5;
            this.addName2.Text = "ชื่อ :";
            // 
            // addScore2
            // 
            this.addScore2.AutoSize = true;
            this.addScore2.Location = new System.Drawing.Point(470, 39);
            this.addScore2.Name = "addScore2";
            this.addScore2.Size = new System.Drawing.Size(46, 16);
            this.addScore2.TabIndex = 6;
            this.addScore2.Text = "คะแนน :";
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(322, 67);
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(100, 22);
            this.tbName2.TabIndex = 11;
            // 
            // tbScore2
            // 
            this.tbScore2.Location = new System.Drawing.Point(473, 67);
            this.tbScore2.Name = "tbScore2";
            this.tbScore2.Size = new System.Drawing.Size(100, 22);
            this.tbScore2.TabIndex = 12;
            // 
            // tbName3
            // 
            this.tbName3.Location = new System.Drawing.Point(322, 105);
            this.tbName3.Name = "tbName3";
            this.tbName3.Size = new System.Drawing.Size(100, 22);
            this.tbName3.TabIndex = 13;
            // 
            // tbScore3
            // 
            this.tbScore3.Location = new System.Drawing.Point(473, 105);
            this.tbScore3.Name = "tbScore3";
            this.tbScore3.Size = new System.Drawing.Size(100, 22);
            this.tbScore3.TabIndex = 14;
            // 
            // addKon
            // 
            this.addKon.AutoSize = true;
            this.addKon.Location = new System.Drawing.Point(592, 39);
            this.addKon.Name = "addKon";
            this.addKon.Size = new System.Drawing.Size(58, 16);
            this.addKon.TabIndex = 7;
            this.addKon.Text = "จำนวนคน :";
            // 
            // addHighest
            // 
            this.addHighest.AutoSize = true;
            this.addHighest.Location = new System.Drawing.Point(592, 74);
            this.addHighest.Name = "addHighest";
            this.addHighest.Size = new System.Drawing.Size(73, 16);
            this.addHighest.TabIndex = 8;
            this.addHighest.Text = "คะแนนสูงสุด :";
            // 
            // addLowest
            // 
            this.addLowest.AutoSize = true;
            this.addLowest.Location = new System.Drawing.Point(593, 114);
            this.addLowest.Name = "addLowest";
            this.addLowest.Size = new System.Drawing.Size(72, 16);
            this.addLowest.TabIndex = 9;
            this.addLowest.Text = "คะแนนต่ำสุด :";
            // 
            // addGpax
            // 
            this.addGpax.AutoSize = true;
            this.addGpax.Location = new System.Drawing.Point(593, 152);
            this.addGpax.Name = "addGpax";
            this.addGpax.Size = new System.Drawing.Size(47, 16);
            this.addGpax.TabIndex = 10;
            this.addGpax.Text = "GPAx :";
            // 
            // tbKon
            // 
            this.tbKon.Location = new System.Drawing.Point(668, 39);
            this.tbKon.Name = "tbKon";
            this.tbKon.Size = new System.Drawing.Size(100, 22);
            this.tbKon.TabIndex = 15;
            // 
            // tbHighest
            // 
            this.tbHighest.Location = new System.Drawing.Point(668, 74);
            this.tbHighest.Name = "tbHighest";
            this.tbHighest.Size = new System.Drawing.Size(100, 22);
            this.tbHighest.TabIndex = 16;
            // 
            // tbLowest
            // 
            this.tbLowest.Location = new System.Drawing.Point(668, 114);
            this.tbLowest.Name = "tbLowest";
            this.tbLowest.Size = new System.Drawing.Size(100, 22);
            this.tbLowest.TabIndex = 17;
            // 
            // tbGpax
            // 
            this.tbGpax.Location = new System.Drawing.Point(668, 152);
            this.tbGpax.Name = "tbGpax";
            this.tbGpax.Size = new System.Drawing.Size(100, 22);
            this.tbGpax.TabIndex = 18;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridView.Location = new System.Drawing.Point(73, 179);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(500, 245);
            this.DataGridView.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ชื่อ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "จำนวนคน";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "คะแนนสูงสุด";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "คะแนนต่ำสุด";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GPAx";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.tbGpax);
            this.Controls.Add(this.tbLowest);
            this.Controls.Add(this.tbHighest);
            this.Controls.Add(this.tbKon);
            this.Controls.Add(this.tbScore3);
            this.Controls.Add(this.tbName3);
            this.Controls.Add(this.tbScore2);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.addGpax);
            this.Controls.Add(this.addLowest);
            this.Controls.Add(this.addHighest);
            this.Controls.Add(this.addKon);
            this.Controls.Add(this.addScore2);
            this.Controls.Add(this.addName2);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addScore);
            this.Controls.Add(this.addName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addName;
        private System.Windows.Forms.Label addScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Label addName2;
        private System.Windows.Forms.Label addScore2;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.TextBox tbScore2;
        private System.Windows.Forms.TextBox tbName3;
        private System.Windows.Forms.TextBox tbScore3;
        private System.Windows.Forms.Label addKon;
        private System.Windows.Forms.Label addHighest;
        private System.Windows.Forms.Label addLowest;
        private System.Windows.Forms.Label addGpax;
        private System.Windows.Forms.TextBox tbKon;
        private System.Windows.Forms.TextBox tbHighest;
        private System.Windows.Forms.TextBox tbLowest;
        private System.Windows.Forms.TextBox tbGpax;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

