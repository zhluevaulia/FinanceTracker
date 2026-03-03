namespace FinanceTracker_Lab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.lblFIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(16, 11);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(154, 25);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Баланс: 0 руб.";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(21, 62);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(199, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(21, 94);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(332, 22);
            this.txtDesc.TabIndex = 2;
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(21, 135);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(133, 37);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "Доход";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.Location = new System.Drawing.Point(163, 135);
            this.btnExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(133, 37);
            this.btnExpense.TabIndex = 4;
            this.btnExpense.Text = "Расход";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 16;
            this.lstHistory.Location = new System.Drawing.Point(21, 185);
            this.lstHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(465, 196);
            this.lstHistory.TabIndex = 5;
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.Location = new System.Drawing.Point(267, 11);
            this.lblFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(248, 20);
            this.lblFIO.TabIndex = 6;
            this.lblFIO.Text = "Жлюева Юлия Вадимовна";
            this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFIO.Click += new System.EventHandler(this.lblFIO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 395);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblBalance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Finance Tracker v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label lblFIO;
    }
}