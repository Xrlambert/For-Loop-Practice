namespace For_Loop_Practice
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // UI Controls
        private System.Windows.Forms.Button btnPractice1;
        private System.Windows.Forms.Button btnPractice2;
        private System.Windows.Forms.Button btnPractice3;
        private System.Windows.Forms.Button btnPractice4;
        private System.Windows.Forms.Button btnPractice5;
        private System.Windows.Forms.Button btnPractice6;

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtSumLimit;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;

        private System.Windows.Forms.Label lblSumLimit;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnPractice1 = new System.Windows.Forms.Button();
            this.btnPractice2 = new System.Windows.Forms.Button();
            this.btnPractice3 = new System.Windows.Forms.Button();
            this.btnPractice4 = new System.Windows.Forms.Button();
            this.btnPractice5 = new System.Windows.Forms.Button();
            this.btnPractice6 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtSumLimit = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.lblSumLimit = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPractice1
            // 
            this.btnPractice1.Location = new System.Drawing.Point(30, 30);
            this.btnPractice1.Name = "btnPractice1";
            this.btnPractice1.Size = new System.Drawing.Size(120, 30);
            this.btnPractice1.TabIndex = 3;
            this.btnPractice1.Text = "Practice 1";
            this.btnPractice1.Click += new System.EventHandler(this.btnPractice1_Click);
            // 
            // btnPractice2
            // 
            this.btnPractice2.Location = new System.Drawing.Point(160, 30);
            this.btnPractice2.Name = "btnPractice2";
            this.btnPractice2.Size = new System.Drawing.Size(120, 30);
            this.btnPractice2.TabIndex = 4;
            this.btnPractice2.Text = "Practice 2";
            this.btnPractice2.Click += new System.EventHandler(this.btnPractice2_Click);
            // 
            // btnPractice3
            // 
            this.btnPractice3.Location = new System.Drawing.Point(290, 30);
            this.btnPractice3.Name = "btnPractice3";
            this.btnPractice3.Size = new System.Drawing.Size(120, 30);
            this.btnPractice3.TabIndex = 5;
            this.btnPractice3.Text = "Practice 3";
            this.btnPractice3.Click += new System.EventHandler(this.btnPractice3_Click);
            // 
            // btnPractice4
            // 
            this.btnPractice4.Location = new System.Drawing.Point(420, 30);
            this.btnPractice4.Name = "btnPractice4";
            this.btnPractice4.Size = new System.Drawing.Size(120, 30);
            this.btnPractice4.TabIndex = 6;
            this.btnPractice4.Text = "Practice 4";
            this.btnPractice4.Click += new System.EventHandler(this.btnPractice4_Click);
            // 
            // btnPractice5
            // 
            this.btnPractice5.Location = new System.Drawing.Point(550, 30);
            this.btnPractice5.Name = "btnPractice5";
            this.btnPractice5.Size = new System.Drawing.Size(120, 30);
            this.btnPractice5.TabIndex = 7;
            this.btnPractice5.Text = "Practice 5";
            this.btnPractice5.Click += new System.EventHandler(this.btnPractice5_Click);
            // 
            // btnPractice6
            // 
            this.btnPractice6.Location = new System.Drawing.Point(680, 30);
            this.btnPractice6.Name = "btnPractice6";
            this.btnPractice6.Size = new System.Drawing.Size(120, 30);
            this.btnPractice6.TabIndex = 8;
            this.btnPractice6.Text = "Practice 6";
            this.btnPractice6.Click += new System.EventHandler(this.btnPractice6_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtOutput.Location = new System.Drawing.Point(30, 80);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(770, 300);
            this.txtOutput.TabIndex = 9;
            // 
            // txtSumLimit
            // 
            this.txtSumLimit.Location = new System.Drawing.Point(30, 404);
            this.txtSumLimit.Name = "txtSumLimit";
            this.txtSumLimit.Size = new System.Drawing.Size(101, 20);
            this.txtSumLimit.TabIndex = 10;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(140, 404);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(50, 20);
            this.txtRows.TabIndex = 11;
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(200, 404);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(50, 20);
            this.txtCols.TabIndex = 12;
            // 
            // lblSumLimit
            // 
            this.lblSumLimit.Location = new System.Drawing.Point(30, 386);
            this.lblSumLimit.Name = "lblSumLimit";
            this.lblSumLimit.Size = new System.Drawing.Size(100, 20);
            this.lblSumLimit.TabIndex = 0;
            this.lblSumLimit.Text = "Sum to (Practice 4):";
            // 
            // lblRows
            // 
            this.lblRows.Location = new System.Drawing.Point(140, 386);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(50, 20);
            this.lblRows.TabIndex = 1;
            this.lblRows.Text = "Rows:";
            // 
            // lblCols
            // 
            this.lblCols.Location = new System.Drawing.Point(200, 386);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(50, 20);
            this.lblCols.TabIndex = 2;
            this.lblCols.Text = "Cols:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.btnPractice1);
            this.Controls.Add(this.btnPractice2);
            this.Controls.Add(this.btnPractice3);
            this.Controls.Add(this.btnPractice4);
            this.Controls.Add(this.btnPractice5);
            this.Controls.Add(this.btnPractice6);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSumLimit);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.lblSumLimit);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblCols);
            this.Name = "Form1";
            this.Text = "For Loop Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
