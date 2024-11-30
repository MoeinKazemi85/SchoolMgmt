namespace UI
{
    partial class FrmCourseRegitration
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColStudentName,
            this.ColCourseName,
            this.colSemester});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 485);
            this.dataGridView1.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "CourseRegisterationID";
            this.colID.HeaderText = "id";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // ColStudentName
            // 
            this.ColStudentName.DataPropertyName = "STDName";
            this.ColStudentName.HeaderText = "StudentName";
            this.ColStudentName.MinimumWidth = 6;
            this.ColStudentName.Name = "ColStudentName";
            this.ColStudentName.ReadOnly = true;
            this.ColStudentName.Width = 125;
            // 
            // ColCourseName
            // 
            this.ColCourseName.DataPropertyName = "CourseName";
            this.ColCourseName.HeaderText = "CourseName";
            this.ColCourseName.MinimumWidth = 6;
            this.ColCourseName.Name = "ColCourseName";
            this.ColCourseName.ReadOnly = true;
            this.ColCourseName.Width = 125;
            // 
            // colSemester
            // 
            this.colSemester.DataPropertyName = "SemesterName";
            this.colSemester.HeaderText = "Semester";
            this.colSemester.MinimumWidth = 6;
            this.colSemester.Name = "colSemester";
            this.colSemester.ReadOnly = true;
            this.colSemester.Width = 125;
            // 
            // FrmCourseRegitration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 485);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCourseRegitration";
            this.Text = "FrmCourseRegitration";
            this.Load += new System.EventHandler(this.FrmCourseRegitration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemester;
    }
}