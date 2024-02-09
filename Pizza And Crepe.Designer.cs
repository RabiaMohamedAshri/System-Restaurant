namespace MyFirstWindowsForm
{
    partial class Frm_This_is_my_projects
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
            this.labstore = new System.Windows.Forms.Label();
            this.btnpizaa = new System.Windows.Forms.Button();
            this.btCrepe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labstore
            // 
            this.labstore.AutoSize = true;
            this.labstore.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstore.ForeColor = System.Drawing.Color.Red;
            this.labstore.Location = new System.Drawing.Point(215, 18);
            this.labstore.Name = "labstore";
            this.labstore.Size = new System.Drawing.Size(297, 75);
            this.labstore.TabIndex = 4;
            this.labstore.Text = "Pizaa king";
            // 
            // btnpizaa
            // 
            this.btnpizaa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnpizaa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnpizaa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnpizaa.Location = new System.Drawing.Point(508, 123);
            this.btnpizaa.Name = "btnpizaa";
            this.btnpizaa.Size = new System.Drawing.Size(149, 80);
            this.btnpizaa.TabIndex = 2;
            this.btnpizaa.Text = "pizza";
            this.btnpizaa.UseVisualStyleBackColor = true;
            this.btnpizaa.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btCrepe
            // 
            this.btCrepe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCrepe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btCrepe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btCrepe.Location = new System.Drawing.Point(125, 123);
            this.btCrepe.Name = "btCrepe";
            this.btCrepe.Size = new System.Drawing.Size(149, 80);
            this.btCrepe.TabIndex = 5;
            this.btCrepe.Text = "Crepe";
            this.btCrepe.UseVisualStyleBackColor = true;
            this.btCrepe.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_This_is_my_projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCrepe);
            this.Controls.Add(this.btnpizaa);
            this.Controls.Add(this.labstore);
            this.Name = "Frm_This_is_my_projects";
            this.Text = "Frm_This_is_my_projects";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labstore;
        private System.Windows.Forms.Button btnpizaa;
        private System.Windows.Forms.Button btCrepe;
    }
}