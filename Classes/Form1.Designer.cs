
namespace Classes
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgrwStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 21;
            this.lbxStudents.Location = new System.Drawing.Point(32, 86);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(206, 298);
            this.lbxStudents.TabIndex = 0;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudents.Location = new System.Drawing.Point(32, 50);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(88, 21);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "STUDENTS";
            // 
            // dgrwStudents
            // 
            this.dgrwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwStudents.Location = new System.Drawing.Point(261, 86);
            this.dgrwStudents.Name = "dgrwStudents";
            this.dgrwStudents.RowTemplate.Height = 25;
            this.dgrwStudents.Size = new System.Drawing.Size(471, 298);
            this.dgrwStudents.TabIndex = 2;
            //this.dgrwStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrwStudents_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrwStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridView dgrwStudents;
    }
}

