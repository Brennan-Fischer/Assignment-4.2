namespace Assignment_4._2
{
    partial class StudentInformation
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
            groupBox1 = new GroupBox();
            AddButton = new Button();
            GPABox = new TextBox();
            StudentNameBox = new TextBox();
            StudentIdBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            StudentsListBox = new DataGridView();
            DeleteButton = new Button();
            SortButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsListBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(GPABox);
            groupBox1.Controls.Add(StudentNameBox);
            groupBox1.Controls.Add(StudentIdBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(195, 168);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add Student";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // GPABox
            // 
            GPABox.Location = new Point(186, 118);
            GPABox.Name = "GPABox";
            GPABox.Size = new Size(125, 27);
            GPABox.TabIndex = 5;
            // 
            // StudentNameBox
            // 
            StudentNameBox.Location = new Point(186, 80);
            StudentNameBox.Name = "StudentNameBox";
            StudentNameBox.Size = new Size(125, 27);
            StudentNameBox.TabIndex = 4;
            // 
            // StudentIdBox
            // 
            StudentIdBox.Location = new Point(186, 47);
            StudentIdBox.Name = "StudentIdBox";
            StudentIdBox.Size = new Size(125, 27);
            StudentIdBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 118);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 9);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 1;
            label4.Text = "Impressive User Interface";
            // 
            // StudentsListBox
            // 
            StudentsListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsListBox.Location = new Point(423, 58);
            StudentsListBox.Name = "StudentsListBox";
            StudentsListBox.RowHeadersWidth = 51;
            StudentsListBox.Size = new Size(638, 243);
            StudentsListBox.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(641, 318);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(168, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "DeleteStudent";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(523, 318);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(94, 29);
            SortButton.TabIndex = 4;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // StudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 386);
            Controls.Add(SortButton);
            Controls.Add(DeleteButton);
            Controls.Add(StudentsListBox);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "StudentInformation";
            Text = "StudentInformation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsListBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button AddButton;
        private TextBox GPABox;
        private TextBox StudentNameBox;
        private TextBox StudentIdBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridView StudentsListBox;
        private Button DeleteButton;
        private Button SortButton;
    }
}