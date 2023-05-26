
namespace EnrollmentSystem
{
    partial class tagging
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tagging));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgTagging = new System.Windows.Forms.DataGridView();
            this.courseLabel = new System.Windows.Forms.Label();
            this.sDescLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.tagBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbStudName = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTagging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.cbStudName);
            this.panel1.Controls.Add(this.dgTagging);
            this.panel1.Controls.Add(this.courseLabel);
            this.panel1.Controls.Add(this.sDescLabel);
            this.panel1.Controls.Add(this.studentNameLabel);
            this.panel1.Controls.Add(this.tagBtn);
            this.panel1.Location = new System.Drawing.Point(73, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 404);
            this.panel1.TabIndex = 12;
            // 
            // dgTagging
            // 
            this.dgTagging.AllowUserToAddRows = false;
            this.dgTagging.AllowUserToDeleteRows = false;
            this.dgTagging.AllowUserToResizeColumns = false;
            this.dgTagging.AllowUserToResizeRows = false;
            this.dgTagging.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTagging.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTagging.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgTagging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTagging.EnableHeadersVisualStyles = false;
            this.dgTagging.Location = new System.Drawing.Point(357, 37);
            this.dgTagging.Name = "dgTagging";
            this.dgTagging.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTagging.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgTagging.RowHeadersVisible = false;
            this.dgTagging.Size = new System.Drawing.Size(540, 331);
            this.dgTagging.TabIndex = 9;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(20, 92);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(49, 17);
            this.courseLabel.TabIndex = 8;
            this.courseLabel.Text = "Course";
            // 
            // sDescLabel
            // 
            this.sDescLabel.AutoSize = true;
            this.sDescLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDescLabel.Location = new System.Drawing.Point(20, 66);
            this.sDescLabel.Name = "sDescLabel";
            this.sDescLabel.Size = new System.Drawing.Size(120, 17);
            this.sDescLabel.TabIndex = 7;
            this.sDescLabel.Text = "Section Description";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(20, 40);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(91, 17);
            this.studentNameLabel.TabIndex = 5;
            this.studentNameLabel.Text = "Student Name";
            // 
            // tagBtn
            // 
            this.tagBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tagBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.tagBtn.Location = new System.Drawing.Point(267, 127);
            this.tagBtn.Name = "tagBtn";
            this.tagBtn.Size = new System.Drawing.Size(58, 28);
            this.tagBtn.TabIndex = 0;
            this.tagBtn.Text = "Tag";
            this.tagBtn.UseVisualStyleBackColor = false;
            this.tagBtn.Click += new System.EventHandler(this.tagBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 172);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(849, 609);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 50);
            this.button5.TabIndex = 16;
            this.button5.Text = "Tagging";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(593, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "Sections";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(73, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Student Profile";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(342, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Courses Offered";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbStudName
            // 
            this.cbStudName.FormattingEnabled = true;
            this.cbStudName.Location = new System.Drawing.Point(146, 36);
            this.cbStudName.Name = "cbStudName";
            this.cbStudName.Size = new System.Drawing.Size(179, 21);
            this.cbStudName.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(179, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // tagging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1076, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "tagging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tagging";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tagging_FormClosing);
            this.Load += new System.EventHandler(this.tagging_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTagging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgTagging;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label sDescLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button tagBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbStudName;
    }
}