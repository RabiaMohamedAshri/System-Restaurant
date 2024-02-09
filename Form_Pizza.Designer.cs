namespace MyFirstWindowsForm
{
    partial class the_list
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
            this.labMakeyourpizza = new System.Windows.Forms.Label();
            this.btOrderpizza = new System.Windows.Forms.Button();
            this.botResetForm = new System.Windows.Forms.Button();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.grbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grbCustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.grbTotalToppings = new System.Windows.Forms.GroupBox();
            this.grbOrSummary = new System.Windows.Forms.GroupBox();
            this.lbWheretoeat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.lbtotalprice = new System.Windows.Forms.Label();
            this.labClose = new System.Windows.Forms.Label();
            this.grbToppings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbWhereToEat.SuspendLayout();
            this.grbSize.SuspendLayout();
            this.grbCustType.SuspendLayout();
            this.grbOrSummary.SuspendLayout();
            this.grbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMakeyourpizza
            // 
            this.labMakeyourpizza.AutoSize = true;
            this.labMakeyourpizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMakeyourpizza.ForeColor = System.Drawing.Color.Red;
            this.labMakeyourpizza.Location = new System.Drawing.Point(419, 31);
            this.labMakeyourpizza.Name = "labMakeyourpizza";
            this.labMakeyourpizza.Size = new System.Drawing.Size(436, 52);
            this.labMakeyourpizza.TabIndex = 1;
            this.labMakeyourpizza.Text = "MAKE YOUR PIZZA";
            // 
            // btOrderpizza
            // 
            this.btOrderpizza.Location = new System.Drawing.Point(473, 564);
            this.btOrderpizza.Name = "btOrderpizza";
            this.btOrderpizza.Size = new System.Drawing.Size(150, 78);
            this.btOrderpizza.TabIndex = 7;
            this.btOrderpizza.Text = "Order Pizza";
            this.btOrderpizza.UseVisualStyleBackColor = true;
            this.btOrderpizza.Click += new System.EventHandler(this.btOrderpizza_Click);
            // 
            // botResetForm
            // 
            this.botResetForm.Location = new System.Drawing.Point(664, 564);
            this.botResetForm.Name = "botResetForm";
            this.botResetForm.Size = new System.Drawing.Size(150, 78);
            this.botResetForm.TabIndex = 21;
            this.botResetForm.Text = "Reset Form";
            this.botResetForm.UseVisualStyleBackColor = true;
            this.botResetForm.Click += new System.EventHandler(this.botResetForm_Click);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.groupBox2);
            this.grbToppings.Controls.Add(this.groupBox1);
            this.grbToppings.Controls.Add(this.chkOlives);
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkTomatoes);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkExtraChees);
            this.grbToppings.Location = new System.Drawing.Point(294, 120);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(329, 252);
            this.grbToppings.TabIndex = 22;
            this.grbToppings.TabStop = false;
            this.grbToppings.Tag = "5";
            this.grbToppings.Text = "Toppings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(329, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 170);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cust Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(35, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 24);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "50";
            this.radioButton3.Text = "Think Crust";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "0";
            this.radioButton4.Text = "Thin Crust";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(335, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 198);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cust Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "50";
            this.radioButton1.Text = "Think Crust";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 24);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "0";
            this.radioButton2.Text = "Thin Crust";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(167, 119);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(83, 24);
            this.chkOlives.TabIndex = 24;
            this.chkOlives.Tag = "20";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(167, 183);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(155, 24);
            this.chkGreenPeppers.TabIndex = 23;
            this.chkGreenPeppers.Tag = "20";
            this.chkGreenPeppers.Text = "Green peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(170, 57);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(82, 24);
            this.chkOnion.TabIndex = 22;
            this.chkOnion.Tag = "20";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(13, 184);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(114, 24);
            this.chkTomatoes.TabIndex = 21;
            this.chkTomatoes.Tag = "20";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(13, 116);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(127, 24);
            this.chkMushrooms.TabIndex = 20;
            this.chkMushrooms.Tag = "20";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(13, 57);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(133, 24);
            this.chkExtraChees.TabIndex = 19;
            this.chkExtraChees.Tag = "20";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // grbWhereToEat
            // 
            this.grbWhereToEat.Controls.Add(this.rbTakeOut);
            this.grbWhereToEat.Controls.Add(this.rbEatin);
            this.grbWhereToEat.Location = new System.Drawing.Point(664, 401);
            this.grbWhereToEat.Name = "grbWhereToEat";
            this.grbWhereToEat.Size = new System.Drawing.Size(309, 110);
            this.grbWhereToEat.TabIndex = 26;
            this.grbWhereToEat.TabStop = false;
            this.grbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(170, 39);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(107, 24);
            this.rbTakeOut.TabIndex = 22;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Location = new System.Drawing.Point(52, 39);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(81, 24);
            this.rbEatin.TabIndex = 21;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.rbLarg);
            this.grbSize.Controls.Add(this.rbMeduim);
            this.grbSize.Controls.Add(this.rbSmall);
            this.grbSize.Location = new System.Drawing.Point(73, 120);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(194, 252);
            this.grbSize.TabIndex = 27;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(17, 182);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(70, 24);
            this.rbLarg.TabIndex = 13;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "140";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(17, 114);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(106, 24);
            this.rbMeduim.TabIndex = 12;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "110";
            this.rbMeduim.Text = "Medouim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(17, 47);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(78, 24);
            this.rbSmall.TabIndex = 11;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "80";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // grbCustType
            // 
            this.grbCustType.Controls.Add(this.rbThinkCrust);
            this.grbCustType.Controls.Add(this.rbThinCrust);
            this.grbCustType.Location = new System.Drawing.Point(73, 401);
            this.grbCustType.Name = "grbCustType";
            this.grbCustType.Size = new System.Drawing.Size(550, 110);
            this.grbCustType.TabIndex = 28;
            this.grbCustType.TabStop = false;
            this.grbCustType.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(305, 44);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(125, 24);
            this.rbThinkCrust.TabIndex = 16;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Tag = "50";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(52, 44);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(116, 24);
            this.rbThinCrust.TabIndex = 15;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // grbTotalToppings
            // 
            this.grbTotalToppings.Location = new System.Drawing.Point(997, 130);
            this.grbTotalToppings.Name = "grbTotalToppings";
            this.grbTotalToppings.Size = new System.Drawing.Size(194, 247);
            this.grbTotalToppings.TabIndex = 29;
            this.grbTotalToppings.TabStop = false;
            this.grbTotalToppings.Text = "Total Toppings";
            // 
            // grbOrSummary
            // 
            this.grbOrSummary.Controls.Add(this.lbWheretoeat);
            this.grbOrSummary.Controls.Add(this.label3);
            this.grbOrSummary.Controls.Add(this.lbCrustType);
            this.grbOrSummary.Controls.Add(this.label2);
            this.grbOrSummary.Controls.Add(this.lbSize);
            this.grbOrSummary.Controls.Add(this.lb);
            this.grbOrSummary.Location = new System.Drawing.Point(664, 125);
            this.grbOrSummary.Name = "grbOrSummary";
            this.grbOrSummary.Size = new System.Drawing.Size(309, 252);
            this.grbOrSummary.TabIndex = 30;
            this.grbOrSummary.TabStop = false;
            this.grbOrSummary.Text = "Order Summary";
            // 
            // lbWheretoeat
            // 
            this.lbWheretoeat.AutoSize = true;
            this.lbWheretoeat.Location = new System.Drawing.Point(159, 181);
            this.lbWheretoeat.Name = "lbWheretoeat";
            this.lbWheretoeat.Size = new System.Drawing.Size(14, 20);
            this.lbWheretoeat.TabIndex = 5;
            this.lbWheretoeat.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Where To Eat :";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Location = new System.Drawing.Point(141, 115);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(14, 20);
            this.lbCrustType.TabIndex = 3;
            this.lbCrustType.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crust Type :";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(93, 52);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(14, 20);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = ".";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(17, 52);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(54, 20);
            this.lb.TabIndex = 0;
            this.lb.Text = "Size :";
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.lbtotalprice);
            this.grbTotal.Location = new System.Drawing.Point(997, 401);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(194, 110);
            this.grbTotal.TabIndex = 31;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Total";
            // 
            // lbtotalprice
            // 
            this.lbtotalprice.AutoSize = true;
            this.lbtotalprice.BackColor = System.Drawing.Color.Transparent;
            this.lbtotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalprice.ForeColor = System.Drawing.Color.Green;
            this.lbtotalprice.Location = new System.Drawing.Point(47, 52);
            this.lbtotalprice.Name = "lbtotalprice";
            this.lbtotalprice.Size = new System.Drawing.Size(18, 25);
            this.lbtotalprice.TabIndex = 1;
            this.lbtotalprice.Text = ".";
            // 
            // labClose
            // 
            this.labClose.AutoSize = true;
            this.labClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClose.Location = new System.Drawing.Point(-2, -1);
            this.labClose.Name = "labClose";
            this.labClose.Size = new System.Drawing.Size(45, 20);
            this.labClose.TabIndex = 2;
            this.labClose.Text = "Back";
            this.labClose.Click += new System.EventHandler(this.labClose_Click);
            // 
            // the_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyFirstWindowsForm.Properties.Resources.pexels_athena_2180876;
            this.ClientSize = new System.Drawing.Size(1309, 682);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.grbOrSummary);
            this.Controls.Add(this.grbTotalToppings);
            this.Controls.Add(this.grbCustType);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.grbWhereToEat);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.botResetForm);
            this.Controls.Add(this.btOrderpizza);
            this.Controls.Add(this.labClose);
            this.Controls.Add(this.labMakeyourpizza);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "the_list";
            this.Text = "the_list";
            this.Load += new System.EventHandler(this.the_list_Load);
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbWhereToEat.ResumeLayout(false);
            this.grbWhereToEat.PerformLayout();
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbCustType.ResumeLayout(false);
            this.grbCustType.PerformLayout();
            this.grbOrSummary.ResumeLayout(false);
            this.grbOrSummary.PerformLayout();
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labMakeyourpizza;
        private System.Windows.Forms.Button btOrderpizza;
        private System.Windows.Forms.Button botResetForm;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox grbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox grbCustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox grbTotalToppings;
        private System.Windows.Forms.GroupBox grbOrSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.Label lbWheretoeat;
        private System.Windows.Forms.Label lbtotalprice;
        private System.Windows.Forms.Label labClose;
    }
}