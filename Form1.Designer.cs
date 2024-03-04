
namespace DBStudentApp_1218645
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCourses = new ComboBox();
            dg1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            SuspendLayout();
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(96, 101);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(151, 28);
            cmbCourses.TabIndex = 0;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged_1;
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Location = new Point(462, 136);
            dg1.Name = "dg1";
            dg1.RowHeadersWidth = 51;
            dg1.Size = new Size(300, 188);
            dg1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 654);
            Controls.Add(dg1);
            Controls.Add(cmbCourses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            ResumeLayout(false);
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox cmbCourses;
        private DataGridView dg1;
    }
}
