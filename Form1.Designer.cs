
namespace Big_Project_practice
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
            this.Income_Const_Box = new System.Windows.Forms.CheckBox();
            this.Income_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cost_Rent_Text = new System.Windows.Forms.TextBox();
            this.CostRentTextbox = new System.Windows.Forms.Label();
            this.Cost_Rent_Const = new System.Windows.Forms.CheckBox();
            this.Cost_Food_Text = new System.Windows.Forms.TextBox();
            this.Cost_Food_Const = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cost_Trans_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cost_Trans_Const = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calc_Savings_Text = new System.Windows.Forms.TextBox();
            this.Current_Savings_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tot_Savings_Text = new System.Windows.Forms.TextBox();
            this.Calc_Savings_Const = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.Tax_Textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Transferbutton = new System.Windows.Forms.Button();
            this.TransferBox = new System.Windows.Forms.ComboBox();
            this.TransferText = new System.Windows.Forms.TextBox();
            this.Transfer = new System.Windows.Forms.Label();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawBox = new System.Windows.Forms.ComboBox();
            this.DepositBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Withdraw = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SavingsTotal = new System.Windows.Forms.TextBox();
            this.DepositText = new System.Windows.Forms.TextBox();
            this.WithdrawText = new System.Windows.Forms.TextBox();
            this.CheckingTotal = new System.Windows.Forms.TextBox();
            this.Time_Calc_Button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Income_Const_Box
            // 
            this.Income_Const_Box.AutoSize = true;
            this.Income_Const_Box.Location = new System.Drawing.Point(136, 53);
            this.Income_Const_Box.Name = "Income_Const_Box";
            this.Income_Const_Box.Size = new System.Drawing.Size(103, 19);
            this.Income_Const_Box.TabIndex = 0;
            this.Income_Const_Box.Text = "Keep Constant";
            this.Income_Const_Box.UseVisualStyleBackColor = true;
            // 
            // Income_Text
            // 
            this.Income_Text.Location = new System.Drawing.Point(30, 49);
            this.Income_Text.Name = "Income_Text";
            this.Income_Text.Size = new System.Drawing.Size(100, 23);
            this.Income_Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Income:";
            // 
            // ComboBoxState
            // 
            this.ComboBoxState.FormattingEnabled = true;
            this.ComboBoxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.ComboBoxState.Location = new System.Drawing.Point(276, 51);
            this.ComboBoxState.Name = "ComboBoxState";
            this.ComboBoxState.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxState.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select State:";
            // 
            // Cost_Rent_Text
            // 
            this.Cost_Rent_Text.Location = new System.Drawing.Point(28, 164);
            this.Cost_Rent_Text.Name = "Cost_Rent_Text";
            this.Cost_Rent_Text.Size = new System.Drawing.Size(100, 23);
            this.Cost_Rent_Text.TabIndex = 5;
            // 
            // CostRentTextbox
            // 
            this.CostRentTextbox.AutoSize = true;
            this.CostRentTextbox.Location = new System.Drawing.Point(27, 142);
            this.CostRentTextbox.Name = "CostRentTextbox";
            this.CostRentTextbox.Size = new System.Drawing.Size(75, 15);
            this.CostRentTextbox.TabIndex = 6;
            this.CostRentTextbox.Text = "Cost of Rent:";
            // 
            // Cost_Rent_Const
            // 
            this.Cost_Rent_Const.AutoSize = true;
            this.Cost_Rent_Const.Location = new System.Drawing.Point(145, 167);
            this.Cost_Rent_Const.Name = "Cost_Rent_Const";
            this.Cost_Rent_Const.Size = new System.Drawing.Size(103, 19);
            this.Cost_Rent_Const.TabIndex = 7;
            this.Cost_Rent_Const.Text = "Keep Constant";
            this.Cost_Rent_Const.UseVisualStyleBackColor = true;
            // 
            // Cost_Food_Text
            // 
            this.Cost_Food_Text.Location = new System.Drawing.Point(276, 164);
            this.Cost_Food_Text.Name = "Cost_Food_Text";
            this.Cost_Food_Text.Size = new System.Drawing.Size(100, 23);
            this.Cost_Food_Text.TabIndex = 8;
            // 
            // Cost_Food_Const
            // 
            this.Cost_Food_Const.AutoSize = true;
            this.Cost_Food_Const.Location = new System.Drawing.Point(395, 167);
            this.Cost_Food_Const.Name = "Cost_Food_Const";
            this.Cost_Food_Const.Size = new System.Drawing.Size(103, 19);
            this.Cost_Food_Const.TabIndex = 9;
            this.Cost_Food_Const.Text = "Keep Constant";
            this.Cost_Food_Const.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost of Food:";
            // 
            // Cost_Trans_Text
            // 
            this.Cost_Trans_Text.Location = new System.Drawing.Point(515, 164);
            this.Cost_Trans_Text.Name = "Cost_Trans_Text";
            this.Cost_Trans_Text.Size = new System.Drawing.Size(127, 23);
            this.Cost_Trans_Text.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cost of Transportation:";
            // 
            // Cost_Trans_Const
            // 
            this.Cost_Trans_Const.AutoSize = true;
            this.Cost_Trans_Const.Location = new System.Drawing.Point(661, 166);
            this.Cost_Trans_Const.Name = "Cost_Trans_Const";
            this.Cost_Trans_Const.Size = new System.Drawing.Size(103, 19);
            this.Cost_Trans_Const.TabIndex = 13;
            this.Cost_Trans_Const.Text = "Keep Constant";
            this.Cost_Trans_Const.UseVisualStyleBackColor = true;
            this.Cost_Trans_Const.CheckedChanged += new System.EventHandler(this.Cost_Trans_Const_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter Current Savings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Calculated Savings:";
            // 
            // Calc_Savings_Text
            // 
            this.Calc_Savings_Text.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Calc_Savings_Text.Location = new System.Drawing.Point(28, 287);
            this.Calc_Savings_Text.Name = "Calc_Savings_Text";
            this.Calc_Savings_Text.Size = new System.Drawing.Size(100, 23);
            this.Calc_Savings_Text.TabIndex = 16;
            // 
            // Current_Savings_Text
            // 
            this.Current_Savings_Text.Location = new System.Drawing.Point(276, 287);
            this.Current_Savings_Text.Name = "Current_Savings_Text";
            this.Current_Savings_Text.Size = new System.Drawing.Size(100, 23);
            this.Current_Savings_Text.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Savings:";
            // 
            // Tot_Savings_Text
            // 
            this.Tot_Savings_Text.Location = new System.Drawing.Point(515, 285);
            this.Tot_Savings_Text.Name = "Tot_Savings_Text";
            this.Tot_Savings_Text.ReadOnly = true;
            this.Tot_Savings_Text.Size = new System.Drawing.Size(100, 23);
            this.Tot_Savings_Text.TabIndex = 19;
            // 
            // Calc_Savings_Const
            // 
            this.Calc_Savings_Const.AutoSize = true;
            this.Calc_Savings_Const.Location = new System.Drawing.Point(145, 287);
            this.Calc_Savings_Const.Name = "Calc_Savings_Const";
            this.Calc_Savings_Const.Size = new System.Drawing.Size(103, 19);
            this.Calc_Savings_Const.TabIndex = 20;
            this.Calc_Savings_Const.Text = "Keep Constant";
            this.Calc_Savings_Const.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 21;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(612, 343);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(103, 23);
            this.Calculate_Button.TabIndex = 26;
            this.Calculate_Button.Text = "Calculate";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // Tax_Textbox
            // 
            this.Tax_Textbox.Location = new System.Drawing.Point(515, 51);
            this.Tax_Textbox.Name = "Tax_Textbox";
            this.Tax_Textbox.ReadOnly = true;
            this.Tax_Textbox.Size = new System.Drawing.Size(100, 23);
            this.Tax_Textbox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(515, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Income Tax:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 406);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Calculate_Button);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.Calc_Savings_Const);
            this.tabPage1.Controls.Add(this.Income_Text);
            this.tabPage1.Controls.Add(this.Tot_Savings_Text);
            this.tabPage1.Controls.Add(this.Tax_Textbox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Income_Const_Box);
            this.tabPage1.Controls.Add(this.Current_Savings_Text);
            this.tabPage1.Controls.Add(this.CostRentTextbox);
            this.tabPage1.Controls.Add(this.Calc_Savings_Text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Cost_Rent_Text);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Cost_Rent_Const);
            this.tabPage1.Controls.Add(this.Cost_Food_Text);
            this.tabPage1.Controls.Add(this.Cost_Food_Const);
            this.tabPage1.Controls.Add(this.Cost_Trans_Text);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ComboBoxState);
            this.tabPage1.Controls.Add(this.Cost_Trans_Const);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Budgeting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Transferbutton);
            this.tabPage2.Controls.Add(this.TransferBox);
            this.tabPage2.Controls.Add(this.TransferText);
            this.tabPage2.Controls.Add(this.Transfer);
            this.tabPage2.Controls.Add(this.WithdrawButton);
            this.tabPage2.Controls.Add(this.DepositButton);
            this.tabPage2.Controls.Add(this.WithdrawBox);
            this.tabPage2.Controls.Add(this.DepositBox);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.Withdraw);
            this.tabPage2.Controls.Add(this.Deposit);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.SavingsTotal);
            this.tabPage2.Controls.Add(this.DepositText);
            this.tabPage2.Controls.Add(this.WithdrawText);
            this.tabPage2.Controls.Add(this.CheckingTotal);
            this.tabPage2.Controls.Add(this.Time_Calc_Button);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Checkings and Savings";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Transferbutton
            // 
            this.Transferbutton.Location = new System.Drawing.Point(385, 86);
            this.Transferbutton.Name = "Transferbutton";
            this.Transferbutton.Size = new System.Drawing.Size(75, 23);
            this.Transferbutton.TabIndex = 46;
            this.Transferbutton.Text = "Transfer";
            this.Transferbutton.UseVisualStyleBackColor = true;
            this.Transferbutton.Click += new System.EventHandler(this.Transferbutton_Click);
            // 
            // TransferBox
            // 
            this.TransferBox.FormattingEnabled = true;
            this.TransferBox.Items.AddRange(new object[] {
            "From Savings To Checking",
            "From Checking To Savings"});
            this.TransferBox.Location = new System.Drawing.Point(527, 58);
            this.TransferBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferBox.Name = "TransferBox";
            this.TransferBox.Size = new System.Drawing.Size(133, 23);
            this.TransferBox.TabIndex = 45;
            this.TransferBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // TransferText
            // 
            this.TransferText.Location = new System.Drawing.Point(385, 58);
            this.TransferText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferText.Name = "TransferText";
            this.TransferText.Size = new System.Drawing.Size(136, 23);
            this.TransferText.TabIndex = 44;
            // 
            // Transfer
            // 
            this.Transfer.AutoSize = true;
            this.Transfer.Location = new System.Drawing.Point(385, 35);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(48, 15);
            this.Transfer.TabIndex = 43;
            this.Transfer.Text = "Transfer";
            this.Transfer.Click += new System.EventHandler(this.label16_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(385, 189);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(75, 23);
            this.WithdrawButton.TabIndex = 42;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(46, 189);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 41;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawBox
            // 
            this.WithdrawBox.FormattingEnabled = true;
            this.WithdrawBox.Items.AddRange(new object[] {
            "Savings",
            "Checking"});
            this.WithdrawBox.Location = new System.Drawing.Point(526, 160);
            this.WithdrawBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawBox.Name = "WithdrawBox";
            this.WithdrawBox.Size = new System.Drawing.Size(133, 23);
            this.WithdrawBox.TabIndex = 40;
            // 
            // DepositBox
            // 
            this.DepositBox.FormattingEnabled = true;
            this.DepositBox.Items.AddRange(new object[] {
            "Savings",
            "Checking"});
            this.DepositBox.Location = new System.Drawing.Point(191, 160);
            this.DepositBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(133, 23);
            this.DepositBox.TabIndex = 39;
            this.DepositBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "How Long It Will Take";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "Amount You Want To Save";
            // 
            // Withdraw
            // 
            this.Withdraw.AutoSize = true;
            this.Withdraw.Location = new System.Drawing.Point(385, 137);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(58, 15);
            this.Withdraw.TabIndex = 36;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.Click += new System.EventHandler(this.label13_Click);
            // 
            // Deposit
            // 
            this.Deposit.AutoSize = true;
            this.Deposit.Location = new System.Drawing.Point(46, 137);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(47, 15);
            this.Deposit.TabIndex = 35;
            this.Deposit.Text = "Deposit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Savings Account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Checking Account";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(46, 265);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 23);
            this.textBox6.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(385, 265);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 23);
            this.textBox5.TabIndex = 31;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // SavingsTotal
            // 
            this.SavingsTotal.Location = new System.Drawing.Point(188, 58);
            this.SavingsTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavingsTotal.Name = "SavingsTotal";
            this.SavingsTotal.ReadOnly = true;
            this.SavingsTotal.Size = new System.Drawing.Size(136, 23);
            this.SavingsTotal.TabIndex = 30;
            // 
            // DepositText
            // 
            this.DepositText.Location = new System.Drawing.Point(46, 160);
            this.DepositText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepositText.Name = "DepositText";
            this.DepositText.Size = new System.Drawing.Size(136, 23);
            this.DepositText.TabIndex = 29;
            // 
            // WithdrawText
            // 
            this.WithdrawText.Location = new System.Drawing.Point(385, 160);
            this.WithdrawText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawText.Name = "WithdrawText";
            this.WithdrawText.Size = new System.Drawing.Size(136, 23);
            this.WithdrawText.TabIndex = 28;
            // 
            // CheckingTotal
            // 
            this.CheckingTotal.Location = new System.Drawing.Point(46, 58);
            this.CheckingTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckingTotal.Name = "CheckingTotal";
            this.CheckingTotal.ReadOnly = true;
            this.CheckingTotal.Size = new System.Drawing.Size(136, 23);
            this.CheckingTotal.TabIndex = 27;
            // 
            // Time_Calc_Button
            // 
            this.Time_Calc_Button.Location = new System.Drawing.Point(385, 293);
            this.Time_Calc_Button.Name = "Time_Calc_Button";
            this.Time_Calc_Button.Size = new System.Drawing.Size(75, 23);
            this.Time_Calc_Button.TabIndex = 26;
            this.Time_Calc_Button.Text = "Calculate";
            this.Time_Calc_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Income_Const_Box;
        private System.Windows.Forms.TextBox Income_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cost_Rent_Text;
        private System.Windows.Forms.Label CostRentTextbox;
        private System.Windows.Forms.CheckBox Cost_Rent_Const;
        private System.Windows.Forms.TextBox Cost_Food_Text;
        private System.Windows.Forms.CheckBox Cost_Food_Const;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cost_Trans_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Cost_Trans_Const;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Calc_Savings_Text;
        private System.Windows.Forms.TextBox Current_Savings_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tot_Savings_Text;
        private System.Windows.Forms.CheckBox Calc_Savings_Const;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.TextBox Tax_Textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Time_Calc_Button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox SavingsTotal;
        private System.Windows.Forms.TextBox DepositText;
        private System.Windows.Forms.TextBox WithdrawText;
        private System.Windows.Forms.TextBox CheckingTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Withdraw;
        private System.Windows.Forms.Label Deposit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DepositBox;
        private System.Windows.Forms.ComboBox WithdrawBox;
        private System.Windows.Forms.ComboBox TransferBox;
        private System.Windows.Forms.TextBox TransferText;
        private System.Windows.Forms.Label Transfer;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button Transferbutton;
        private System.Windows.Forms.Label oith;
    }
}

