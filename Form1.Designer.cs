
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Time_Calc_Button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Income_Const_Box
            // 
            this.Income_Const_Box.AutoSize = true;
            this.Income_Const_Box.Location = new System.Drawing.Point(155, 71);
            this.Income_Const_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Income_Const_Box.Name = "Income_Const_Box";
            this.Income_Const_Box.Size = new System.Drawing.Size(127, 24);
            this.Income_Const_Box.TabIndex = 0;
            this.Income_Const_Box.Text = "Keep Constant";
            this.Income_Const_Box.UseVisualStyleBackColor = true;
            // 
            // Income_Text
            // 
            this.Income_Text.Location = new System.Drawing.Point(34, 65);
            this.Income_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Income_Text.Name = "Income_Text";
            this.Income_Text.Size = new System.Drawing.Size(114, 27);
            this.Income_Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
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
            this.ComboBoxState.Location = new System.Drawing.Point(315, 68);
            this.ComboBoxState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxState.Name = "ComboBoxState";
            this.ComboBoxState.Size = new System.Drawing.Size(138, 28);
            this.ComboBoxState.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select State:";
            // 
            // Cost_Rent_Text
            // 
            this.Cost_Rent_Text.Location = new System.Drawing.Point(32, 219);
            this.Cost_Rent_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Rent_Text.Name = "Cost_Rent_Text";
            this.Cost_Rent_Text.Size = new System.Drawing.Size(114, 27);
            this.Cost_Rent_Text.TabIndex = 5;
            // 
            // CostRentTextbox
            // 
            this.CostRentTextbox.AutoSize = true;
            this.CostRentTextbox.Location = new System.Drawing.Point(31, 189);
            this.CostRentTextbox.Name = "CostRentTextbox";
            this.CostRentTextbox.Size = new System.Drawing.Size(93, 20);
            this.CostRentTextbox.TabIndex = 6;
            this.CostRentTextbox.Text = "Cost of Rent:";
            // 
            // Cost_Rent_Const
            // 
            this.Cost_Rent_Const.AutoSize = true;
            this.Cost_Rent_Const.Location = new System.Drawing.Point(166, 223);
            this.Cost_Rent_Const.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Rent_Const.Name = "Cost_Rent_Const";
            this.Cost_Rent_Const.Size = new System.Drawing.Size(127, 24);
            this.Cost_Rent_Const.TabIndex = 7;
            this.Cost_Rent_Const.Text = "Keep Constant";
            this.Cost_Rent_Const.UseVisualStyleBackColor = true;
            // 
            // Cost_Food_Text
            // 
            this.Cost_Food_Text.Location = new System.Drawing.Point(315, 219);
            this.Cost_Food_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Food_Text.Name = "Cost_Food_Text";
            this.Cost_Food_Text.Size = new System.Drawing.Size(114, 27);
            this.Cost_Food_Text.TabIndex = 8;
            // 
            // Cost_Food_Const
            // 
            this.Cost_Food_Const.AutoSize = true;
            this.Cost_Food_Const.Location = new System.Drawing.Point(451, 223);
            this.Cost_Food_Const.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Food_Const.Name = "Cost_Food_Const";
            this.Cost_Food_Const.Size = new System.Drawing.Size(127, 24);
            this.Cost_Food_Const.TabIndex = 9;
            this.Cost_Food_Const.Text = "Keep Constant";
            this.Cost_Food_Const.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost of Food:";
            // 
            // Cost_Trans_Text
            // 
            this.Cost_Trans_Text.Location = new System.Drawing.Point(589, 219);
            this.Cost_Trans_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Trans_Text.Name = "Cost_Trans_Text";
            this.Cost_Trans_Text.Size = new System.Drawing.Size(145, 27);
            this.Cost_Trans_Text.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cost of Transportation:";
            // 
            // Cost_Trans_Const
            // 
            this.Cost_Trans_Const.AutoSize = true;
            this.Cost_Trans_Const.Location = new System.Drawing.Point(755, 221);
            this.Cost_Trans_Const.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Trans_Const.Name = "Cost_Trans_Const";
            this.Cost_Trans_Const.Size = new System.Drawing.Size(127, 24);
            this.Cost_Trans_Const.TabIndex = 13;
            this.Cost_Trans_Const.Text = "Keep Constant";
            this.Cost_Trans_Const.UseVisualStyleBackColor = true;
            this.Cost_Trans_Const.CheckedChanged += new System.EventHandler(this.Cost_Trans_Const_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter Current Savings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Calculated Savings:";
            // 
            // Calc_Savings_Text
            // 
            this.Calc_Savings_Text.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Calc_Savings_Text.Location = new System.Drawing.Point(32, 383);
            this.Calc_Savings_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calc_Savings_Text.Name = "Calc_Savings_Text";
            this.Calc_Savings_Text.Size = new System.Drawing.Size(114, 27);
            this.Calc_Savings_Text.TabIndex = 16;
            // 
            // Current_Savings_Text
            // 
            this.Current_Savings_Text.Location = new System.Drawing.Point(315, 383);
            this.Current_Savings_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Current_Savings_Text.Name = "Current_Savings_Text";
            this.Current_Savings_Text.Size = new System.Drawing.Size(114, 27);
            this.Current_Savings_Text.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Savings:";
            // 
            // Tot_Savings_Text
            // 
            this.Tot_Savings_Text.Location = new System.Drawing.Point(589, 380);
            this.Tot_Savings_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tot_Savings_Text.Name = "Tot_Savings_Text";
            this.Tot_Savings_Text.ReadOnly = true;
            this.Tot_Savings_Text.Size = new System.Drawing.Size(114, 27);
            this.Tot_Savings_Text.TabIndex = 19;
            // 
            // Calc_Savings_Const
            // 
            this.Calc_Savings_Const.AutoSize = true;
            this.Calc_Savings_Const.Location = new System.Drawing.Point(166, 383);
            this.Calc_Savings_Const.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calc_Savings_Const.Name = "Calc_Savings_Const";
            this.Calc_Savings_Const.Size = new System.Drawing.Size(127, 24);
            this.Calc_Savings_Const.TabIndex = 20;
            this.Calc_Savings_Const.Text = "Keep Constant";
            this.Calc_Savings_Const.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 21;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(699, 457);
            this.Calculate_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(118, 31);
            this.Calculate_Button.TabIndex = 26;
            this.Calculate_Button.Text = "Calculate";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // Tax_Textbox
            // 
            this.Tax_Textbox.Location = new System.Drawing.Point(589, 68);
            this.Tax_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tax_Textbox.Name = "Tax_Textbox";
            this.Tax_Textbox.ReadOnly = true;
            this.Tax_Textbox.Size = new System.Drawing.Size(114, 27);
            this.Tax_Textbox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Income Tax:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 541);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(879, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Budgeting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.Time_Calc_Button);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(879, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Checkings and Savings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(601, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(440, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Deposit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Savings Account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Checking Account";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(53, 353);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 27);
            this.textBox6.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 353);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 27);
            this.textBox5.TabIndex = 31;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(440, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 27);
            this.textBox4.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 27);
            this.textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 27);
            this.textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 27);
            this.textBox1.TabIndex = 27;
            // 
            // Time_Calc_Button
            // 
            this.Time_Calc_Button.Location = new System.Drawing.Point(747, 457);
            this.Time_Calc_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Time_Calc_Button.Name = "Time_Calc_Button";
            this.Time_Calc_Button.Size = new System.Drawing.Size(86, 31);
            this.Time_Calc_Button.TabIndex = 26;
            this.Time_Calc_Button.Text = "Calculate";
            this.Time_Calc_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

