namespace MyFirstWindowsForm
{
    partial class Form_Crepe
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
            this.gbgropyCrepe = new System.Windows.Forms.GroupBox();
            this.rbMixChicken = new System.Windows.Forms.RadioButton();
            this.rbCrepeBurger = new System.Windows.Forms.RadioButton();
            this.rbChickenFajita = new System.Windows.Forms.RadioButton();
            this.rbCrepeFries = new System.Windows.Forms.RadioButton();
            this.rbChickenShawarma = new System.Windows.Forms.RadioButton();
            this.rbchickenZinger = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkMozzarella = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.grbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCrepeis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotelToppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.grbTotelPrice = new System.Windows.Forms.GroupBox();
            this.lbTotelPrice = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.btRestorForm = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Label();
            this.gbgropyCrepe.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.grbOrderSummary.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.grbTotelPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbgropyCrepe
            // 
            this.gbgropyCrepe.Controls.Add(this.rbMixChicken);
            this.gbgropyCrepe.Controls.Add(this.rbCrepeBurger);
            this.gbgropyCrepe.Controls.Add(this.rbChickenFajita);
            this.gbgropyCrepe.Controls.Add(this.rbCrepeFries);
            this.gbgropyCrepe.Controls.Add(this.rbChickenShawarma);
            this.gbgropyCrepe.Controls.Add(this.rbchickenZinger);
            this.gbgropyCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbgropyCrepe.ForeColor = System.Drawing.Color.Black;
            this.gbgropyCrepe.Location = new System.Drawing.Point(12, 130);
            this.gbgropyCrepe.Name = "gbgropyCrepe";
            this.gbgropyCrepe.Size = new System.Drawing.Size(456, 366);
            this.gbgropyCrepe.TabIndex = 0;
            this.gbgropyCrepe.TabStop = false;
            this.gbgropyCrepe.Text = "Gropy Crepe";
            // 
            // rbMixChicken
            // 
            this.rbMixChicken.AutoSize = true;
            this.rbMixChicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMixChicken.Location = new System.Drawing.Point(273, 291);
            this.rbMixChicken.Name = "rbMixChicken";
            this.rbMixChicken.Size = new System.Drawing.Size(156, 29);
            this.rbMixChicken.TabIndex = 7;
            this.rbMixChicken.TabStop = true;
            this.rbMixChicken.Tag = "80";
            this.rbMixChicken.Text = "Mix Chicken";
            this.rbMixChicken.UseVisualStyleBackColor = true;
            this.rbMixChicken.CheckedChanged += new System.EventHandler(this.rbMixChicken_CheckedChanged);
            // 
            // rbCrepeBurger
            // 
            this.rbCrepeBurger.AutoSize = true;
            this.rbCrepeBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrepeBurger.Location = new System.Drawing.Point(257, 187);
            this.rbCrepeBurger.Name = "rbCrepeBurger";
            this.rbCrepeBurger.Size = new System.Drawing.Size(166, 29);
            this.rbCrepeBurger.TabIndex = 6;
            this.rbCrepeBurger.TabStop = true;
            this.rbCrepeBurger.Tag = "50";
            this.rbCrepeBurger.Text = "Crepe Burger";
            this.rbCrepeBurger.UseVisualStyleBackColor = true;
            this.rbCrepeBurger.CheckedChanged += new System.EventHandler(this.rbCrepeBurger_CheckedChanged);
            // 
            // rbChickenFajita
            // 
            this.rbChickenFajita.AutoSize = true;
            this.rbChickenFajita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChickenFajita.Location = new System.Drawing.Point(22, 187);
            this.rbChickenFajita.Name = "rbChickenFajita";
            this.rbChickenFajita.Size = new System.Drawing.Size(175, 29);
            this.rbChickenFajita.TabIndex = 5;
            this.rbChickenFajita.TabStop = true;
            this.rbChickenFajita.Tag = "55";
            this.rbChickenFajita.Text = "Chicken Fajita";
            this.rbChickenFajita.UseVisualStyleBackColor = true;
            this.rbChickenFajita.CheckedChanged += new System.EventHandler(this.rbChickenFajita_CheckedChanged);
            // 
            // rbCrepeFries
            // 
            this.rbCrepeFries.AutoSize = true;
            this.rbCrepeFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrepeFries.Location = new System.Drawing.Point(257, 73);
            this.rbCrepeFries.Name = "rbCrepeFries";
            this.rbCrepeFries.Size = new System.Drawing.Size(150, 29);
            this.rbCrepeFries.TabIndex = 4;
            this.rbCrepeFries.TabStop = true;
            this.rbCrepeFries.Tag = "40";
            this.rbCrepeFries.Text = "Crepe Fries";
            this.rbCrepeFries.UseVisualStyleBackColor = true;
            this.rbCrepeFries.CheckedChanged += new System.EventHandler(this.rbCrepeFries_CheckedChanged);
            // 
            // rbChickenShawarma
            // 
            this.rbChickenShawarma.AutoSize = true;
            this.rbChickenShawarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChickenShawarma.Location = new System.Drawing.Point(22, 293);
            this.rbChickenShawarma.Name = "rbChickenShawarma";
            this.rbChickenShawarma.Size = new System.Drawing.Size(224, 29);
            this.rbChickenShawarma.TabIndex = 3;
            this.rbChickenShawarma.TabStop = true;
            this.rbChickenShawarma.Tag = "60";
            this.rbChickenShawarma.Text = "Chicken Shawarma";
            this.rbChickenShawarma.UseVisualStyleBackColor = true;
            this.rbChickenShawarma.CheckedChanged += new System.EventHandler(this.rbChickenShawarma_CheckedChanged);
            // 
            // rbchickenZinger
            // 
            this.rbchickenZinger.AutoSize = true;
            this.rbchickenZinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchickenZinger.Location = new System.Drawing.Point(22, 73);
            this.rbchickenZinger.Name = "rbchickenZinger";
            this.rbchickenZinger.Size = new System.Drawing.Size(183, 29);
            this.rbchickenZinger.TabIndex = 2;
            this.rbchickenZinger.TabStop = true;
            this.rbchickenZinger.Tag = "60";
            this.rbchickenZinger.Text = "Chicken Zinger";
            this.rbchickenZinger.UseVisualStyleBackColor = true;
            this.rbchickenZinger.CheckedChanged += new System.EventHandler(this.rbchickenZinger_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(401, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department is Crepe";
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkMozzarella);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(514, 130);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(281, 366);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkMozzarella
            // 
            this.chkMozzarella.AutoSize = true;
            this.chkMozzarella.Location = new System.Drawing.Point(22, 291);
            this.chkMozzarella.Name = "chkMozzarella";
            this.chkMozzarella.Size = new System.Drawing.Size(154, 30);
            this.chkMozzarella.TabIndex = 5;
            this.chkMozzarella.Tag = "15";
            this.chkMozzarella.Text = "Mozzarela ";
            this.chkMozzarella.UseVisualStyleBackColor = true;
            this.chkMozzarella.CheckedChanged += new System.EventHandler(this.chkMozzarellaCheese_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(22, 183);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(101, 30);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Tag = "10";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(22, 73);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(105, 30);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "10";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // grbOrderSummary
            // 
            this.grbOrderSummary.Controls.Add(this.lbWhereToEat);
            this.grbOrderSummary.Controls.Add(this.label4);
            this.grbOrderSummary.Controls.Add(this.lbCrepeis);
            this.grbOrderSummary.Controls.Add(this.label3);
            this.grbOrderSummary.Controls.Add(this.lbTotelToppings);
            this.grbOrderSummary.Controls.Add(this.label2);
            this.grbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrderSummary.Location = new System.Drawing.Point(838, 130);
            this.grbOrderSummary.Name = "grbOrderSummary";
            this.grbOrderSummary.Size = new System.Drawing.Size(381, 366);
            this.grbOrderSummary.TabIndex = 4;
            this.grbOrderSummary.TabStop = false;
            this.grbOrderSummary.Text = "Order Summary";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Location = new System.Drawing.Point(205, 292);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(19, 26);
            this.lbWhereToEat.TabIndex = 5;
            this.lbWhereToEat.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Where To Eat :";
            // 
            // lbCrepeis
            // 
            this.lbCrepeis.AutoSize = true;
            this.lbCrepeis.Location = new System.Drawing.Point(162, 189);
            this.lbCrepeis.Name = "lbCrepeis";
            this.lbCrepeis.Size = new System.Drawing.Size(19, 26);
            this.lbCrepeis.TabIndex = 3;
            this.lbCrepeis.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crepe is :";
            // 
            // lbTotelToppings
            // 
            this.lbTotelToppings.AutoSize = true;
            this.lbTotelToppings.Location = new System.Drawing.Point(205, 77);
            this.lbTotelToppings.Name = "lbTotelToppings";
            this.lbTotelToppings.Size = new System.Drawing.Size(19, 26);
            this.lbTotelToppings.TabIndex = 1;
            this.lbTotelToppings.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Totel Toppings :";
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatin);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(12, 533);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(456, 126);
            this.gbWhereToEat.TabIndex = 27;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(273, 39);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(133, 30);
            this.rbTakeOut.TabIndex = 22;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Location = new System.Drawing.Point(22, 39);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(99, 30);
            this.rbEatin.TabIndex = 21;
            this.rbEatin.TabStop = true;
            this.rbEatin.Tag = "";
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // grbTotelPrice
            // 
            this.grbTotelPrice.Controls.Add(this.lbTotelPrice);
            this.grbTotelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTotelPrice.Location = new System.Drawing.Point(838, 533);
            this.grbTotelPrice.Name = "grbTotelPrice";
            this.grbTotelPrice.Size = new System.Drawing.Size(381, 126);
            this.grbTotelPrice.TabIndex = 28;
            this.grbTotelPrice.TabStop = false;
            this.grbTotelPrice.Text = "Totel Pirce";
            // 
            // lbTotelPrice
            // 
            this.lbTotelPrice.AutoSize = true;
            this.lbTotelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotelPrice.Location = new System.Drawing.Point(84, 61);
            this.lbTotelPrice.Name = "lbTotelPrice";
            this.lbTotelPrice.Size = new System.Drawing.Size(19, 26);
            this.lbTotelPrice.TabIndex = 4;
            this.lbTotelPrice.Text = ".";
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.Green;
            this.btOrder.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOrder.Location = new System.Drawing.Point(558, 514);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(188, 74);
            this.btOrder.TabIndex = 29;
            this.btOrder.Text = "Order ";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btRestorForm
            // 
            this.btRestorForm.BackColor = System.Drawing.Color.Red;
            this.btRestorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestorForm.Location = new System.Drawing.Point(558, 627);
            this.btRestorForm.Name = "btRestorForm";
            this.btRestorForm.Size = new System.Drawing.Size(188, 74);
            this.btRestorForm.TabIndex = 30;
            this.btRestorForm.Text = "Restor Form ";
            this.btRestorForm.UseVisualStyleBackColor = false;
            this.btRestorForm.Click += new System.EventHandler(this.btRestorForm_Click);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.Location = new System.Drawing.Point(8, 9);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(60, 25);
            this.lbBack.TabIndex = 31;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // Form_Crepe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 726);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btRestorForm);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.grbTotelPrice);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.grbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbgropyCrepe);
            this.Name = "Form_Crepe";
            this.Text = "Department_is_Crepe";
            this.Load += new System.EventHandler(this.Department_is_Pizza_Load);
            this.gbgropyCrepe.ResumeLayout(false);
            this.gbgropyCrepe.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.grbOrderSummary.ResumeLayout(false);
            this.grbOrderSummary.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.grbTotelPrice.ResumeLayout(false);
            this.grbTotelPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbgropyCrepe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbchickenZinger;
        private System.Windows.Forms.RadioButton rbChickenFajita;
        private System.Windows.Forms.RadioButton rbCrepeFries;
        private System.Windows.Forms.RadioButton rbChickenShawarma;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkMozzarella;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.RadioButton rbMixChicken;
        private System.Windows.Forms.RadioButton rbCrepeBurger;
        private System.Windows.Forms.GroupBox grbOrderSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotelToppings;
        private System.Windows.Forms.Label lbCrepeis;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.GroupBox grbTotelPrice;
        private System.Windows.Forms.Label lbTotelPrice;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btRestorForm;
        private System.Windows.Forms.Label lbBack;
    }
}