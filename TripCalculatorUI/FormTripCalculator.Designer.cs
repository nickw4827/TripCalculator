namespace TripCalculatorUI
{
    partial class FormTripCalculator
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
            this.lstTripMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTripMember = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPayouts = new System.Windows.Forms.ListBox();
            this.btnCalculatePayouts = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTripMember = new System.Windows.Forms.TextBox();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTripMembers
            // 
            this.lstTripMembers.FormattingEnabled = true;
            this.lstTripMembers.Location = new System.Drawing.Point(26, 61);
            this.lstTripMembers.Name = "lstTripMembers";
            this.lstTripMembers.Size = new System.Drawing.Size(120, 134);
            this.lstTripMembers.TabIndex = 3;
            this.lstTripMembers.SelectedIndexChanged += new System.EventHandler(this.lstTripMembers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trip Members";
            // 
            // btnAddTripMember
            // 
            this.btnAddTripMember.Location = new System.Drawing.Point(152, 36);
            this.btnAddTripMember.Name = "btnAddTripMember";
            this.btnAddTripMember.Size = new System.Drawing.Size(46, 23);
            this.btnAddTripMember.TabIndex = 2;
            this.btnAddTripMember.Text = "Add...";
            this.btnAddTripMember.UseVisualStyleBackColor = true;
            this.btnAddTripMember.Click += new System.EventHandler(this.btnAddTripMember_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Enabled = false;
            this.btnAddExpense.Location = new System.Drawing.Point(152, 237);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(46, 23);
            this.btnAddExpense.TabIndex = 5;
            this.btnAddExpense.Text = "Add...";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expenses";
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.Location = new System.Drawing.Point(26, 262);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(120, 108);
            this.lstExpenses.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payouts";
            // 
            // lstPayouts
            // 
            this.lstPayouts.FormattingEnabled = true;
            this.lstPayouts.Location = new System.Drawing.Point(267, 262);
            this.lstPayouts.Name = "lstPayouts";
            this.lstPayouts.Size = new System.Drawing.Size(191, 108);
            this.lstPayouts.TabIndex = 8;
            // 
            // btnCalculatePayouts
            // 
            this.btnCalculatePayouts.Location = new System.Drawing.Point(267, 172);
            this.btnCalculatePayouts.Name = "btnCalculatePayouts";
            this.btnCalculatePayouts.Size = new System.Drawing.Size(191, 23);
            this.btnCalculatePayouts.TabIndex = 7;
            this.btnCalculatePayouts.Text = "Calculate Payouts";
            this.btnCalculatePayouts.UseVisualStyleBackColor = true;
            this.btnCalculatePayouts.Click += new System.EventHandler(this.btnCalculatePayouts_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(267, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 51);
            this.label5.TabIndex = 1;
            this.label5.Text = "When ready, calculate payouts and then select trip members to see payment details" +
    ".";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add a new Trip Member, then select them to add expenses.";
            // 
            // txtTripMember
            // 
            this.txtTripMember.Location = new System.Drawing.Point(26, 38);
            this.txtTripMember.Name = "txtTripMember";
            this.txtTripMember.Size = new System.Drawing.Size(120, 20);
            this.txtTripMember.TabIndex = 1;
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(26, 239);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(120, 20);
            this.txtExpense.TabIndex = 4;
            // 
            // FormTripCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 424);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.txtTripMember);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculatePayouts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPayouts);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstExpenses);
            this.Controls.Add(this.btnAddTripMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTripMembers);
            this.Name = "FormTripCalculator";
            this.Text = "Trip Calculator";
            this.Load += new System.EventHandler(this.FormTripCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTripMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTripMember;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPayouts;
        private System.Windows.Forms.Button btnCalculatePayouts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTripMember;
        private System.Windows.Forms.TextBox txtExpense;
    }
}

