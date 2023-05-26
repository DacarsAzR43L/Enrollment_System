
namespace EnrollmentSystem
{
    partial class Sections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sections));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgSections = new System.Windows.Forms.DataGridView();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.textBoxSecDesc = new System.Windows.Forms.TextBox();
            this.textBoxSecID = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSections)).BeginInit();
            this.SuspendLayout();
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgSections);
            this.panel1.Controls.Add(this.fNameLabel);
            this.panel1.Controls.Add(this.studentNumberLabel);
            this.panel1.Controls.Add(this.textBoxSecDesc);
            this.panel1.Controls.Add(this.textBoxSecID);
            this.panel1.Controls.Add(this.add);
            this.panel1.Location = new System.Drawing.Point(73, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 404);
            this.panel1.TabIndex = 12;
            // 
            // dgSections
            // 
            this.dgSections.AllowUserToAddRows = false;
            this.dgSections.AllowUserToDeleteRows = false;
            this.dgSections.AllowUserToResizeColumns = false;
            this.dgSections.AllowUserToResizeRows = false;
            this.dgSections.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgSections.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSections.EnableHeadersVisualStyles = false;
            this.dgSections.Location = new System.Drawing.Point(357, 37);
            this.dgSections.Name = "dgSections";
            this.dgSections.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSections.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgSections.RowHeadersVisible = false;
            this.dgSections.Size = new System.Drawing.Size(540, 331);
            this.dgSections.TabIndex = 9;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(35, 93);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(120, 17);
            this.fNameLabel.TabIndex = 7;
            this.fNameLabel.Text = "Section Description";
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.AutoSize = true;
            this.studentNumberLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberLabel.Location = new System.Drawing.Point(35, 66);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(66, 17);
            this.studentNumberLabel.TabIndex = 5;
            this.studentNumberLabel.Text = "Section ID";
            // 
            // textBoxSecDesc
            // 
            this.textBoxSecDesc.Location = new System.Drawing.Point(161, 90);
            this.textBoxSecDesc.Name = "textBoxSecDesc";
            this.textBoxSecDesc.Size = new System.Drawing.Size(175, 20);
            this.textBoxSecDesc.TabIndex = 4;
            // 
            // textBoxSecID
            // 
            this.textBoxSecID.Enabled = false;
            this.textBoxSecID.Location = new System.Drawing.Point(161, 63);
            this.textBoxSecID.Name = "textBoxSecID";
            this.textBoxSecID.Size = new System.Drawing.Size(175, 20);
            this.textBoxSecID.TabIndex = 3;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(278, 128);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(58, 28);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Sections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sections_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgSections;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.TextBox textBoxSecDesc;
        private System.Windows.Forms.TextBox textBoxSecID;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}