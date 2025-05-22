namespace ExpenseTrackerGUI
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
            lblAmount = new Label();
            lblDesc = new Label();
            txtDesc = new TextBox();
            txtAmount = new TextBox();
            Ａｄｄｂｔｎ = new Button();
            lstExpenses = new ListBox();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(203, 112);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(81, 25);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(203, 54);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(106, 25);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Description:";
            lblDesc.Click += label2_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(315, 54);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(150, 31);
            txtDesc.TabIndex = 2;
            txtDesc.TextChanged += textBox1_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(315, 112);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 3;
            // 
            // Ａｄｄｂｔｎ
            // 
            Ａｄｄｂｔｎ.Location = new Point(203, 185);
            Ａｄｄｂｔｎ.Name = "Ａｄｄｂｔｎ";
            Ａｄｄｂｔｎ.Size = new Size(112, 34);
            Ａｄｄｂｔｎ.TabIndex = 4;
            Ａｄｄｂｔｎ.UseVisualStyleBackColor = true;
            Ａｄｄｂｔｎ.Click += btnAdd_Click;
            // 
            // lstExpenses
            // 
            lstExpenses.FormattingEnabled = true;
            lstExpenses.ItemHeight = 25;
            lstExpenses.Location = new Point(359, 185);
            lstExpenses.Name = "lstExpenses";
            lstExpenses.Size = new Size(180, 129);
            lstExpenses.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 563);
            Controls.Add(lstExpenses);
            Controls.Add(Ａｄｄｂｔｎ);
            Controls.Add(txtAmount);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Controls.Add(lblAmount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblDesc;
        private TextBox txtDesc;
        private TextBox txtAmount;
        private Button Ａｄｄｂｔｎ;
        private ListBox lstExpenses;
    }
}
