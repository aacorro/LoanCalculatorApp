namespace LoanCalculatorApp
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_loanAmount = new System.Windows.Forms.TextBox();
			this.txt_numberOfMonths = new System.Windows.Forms.TextBox();
			this.txt_interestRate = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btn_calculate = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_finalValue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Loan Amount";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(106, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number of Months";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(106, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Interest Rate";
			// 
			// txt_loanAmount
			// 
			this.txt_loanAmount.Location = new System.Drawing.Point(206, 47);
			this.txt_loanAmount.Name = "txt_loanAmount";
			this.txt_loanAmount.Size = new System.Drawing.Size(89, 20);
			this.txt_loanAmount.TabIndex = 3;
			// 
			// txt_numberOfMonths
			// 
			this.txt_numberOfMonths.Location = new System.Drawing.Point(206, 86);
			this.txt_numberOfMonths.Name = "txt_numberOfMonths";
			this.txt_numberOfMonths.Size = new System.Drawing.Size(89, 20);
			this.txt_numberOfMonths.TabIndex = 4;
			// 
			// txt_interestRate
			// 
			this.txt_interestRate.Location = new System.Drawing.Point(206, 125);
			this.txt_interestRate.Name = "txt_interestRate";
			this.txt_interestRate.Size = new System.Drawing.Size(89, 20);
			this.txt_interestRate.TabIndex = 5;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(109, 168);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(292, 238);
			this.listBox1.TabIndex = 6;
			// 
			// btn_calculate
			// 
			this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_calculate.Location = new System.Drawing.Point(109, 502);
			this.btn_calculate.Name = "btn_calculate";
			this.btn_calculate.Size = new System.Drawing.Size(75, 39);
			this.btn_calculate.TabIndex = 7;
			this.btn_calculate.Text = "Calculate";
			this.btn_calculate.UseVisualStyleBackColor = true;
			this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.Location = new System.Drawing.Point(220, 502);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(75, 39);
			this.btn_clear.TabIndex = 8;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_exit
			// 
			this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_exit.Location = new System.Drawing.Point(326, 502);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 39);
			this.btn_exit.TabIndex = 9;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(109, 452);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Final Value:";
			// 
			// txt_finalValue
			// 
			this.txt_finalValue.Location = new System.Drawing.Point(189, 452);
			this.txt_finalValue.Name = "txt_finalValue";
			this.txt_finalValue.ReadOnly = true;
			this.txt_finalValue.Size = new System.Drawing.Size(106, 20);
			this.txt_finalValue.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(500, 650);
			this.Controls.Add(this.txt_finalValue);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_calculate);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.txt_interestRate);
			this.Controls.Add(this.txt_numberOfMonths);
			this.Controls.Add(this.txt_loanAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Loan Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_loanAmount;
		private System.Windows.Forms.TextBox txt_numberOfMonths;
		private System.Windows.Forms.TextBox txt_interestRate;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btn_calculate;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_finalValue;
	}
}

