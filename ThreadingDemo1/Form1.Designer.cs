namespace ThreadingDemo1
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
            btnProcess1 = new System.Windows.Forms.Button();
            btnProcess2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnProcess1
            // 
            btnProcess1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProcess1.Location = new System.Drawing.Point(69, 69);
            btnProcess1.Name = "btnProcess1";
            btnProcess1.Size = new System.Drawing.Size(80, 32);
            btnProcess1.TabIndex = 0;
            btnProcess1.Text = "Islem1";
            btnProcess1.UseVisualStyleBackColor = true;
            btnProcess1.Click += btnProcess1_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProcess2.Location = new System.Drawing.Point(247, 69);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new System.Drawing.Size(70, 32);
            btnProcess2.TabIndex = 1;
            btnProcess2.Text = "Islem2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(654, 450);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcess1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.Button btnProcess2;
    }
}
