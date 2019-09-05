namespace mswanson1c1
{
    partial class rfmFoodTruck
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
            this.txtHotDogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHotDogsSubtotal = new System.Windows.Forms.TextBox();
            this.txtHamburgersSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHamburgers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPretaxtTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCLear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hot dogs:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtHotDogs
            // 
            this.txtHotDogs.Location = new System.Drawing.Point(142, 33);
            this.txtHotDogs.Name = "txtHotDogs";
            this.txtHotDogs.Size = new System.Drawing.Size(44, 20);
            this.txtHotDogs.TabIndex = 2;
            this.txtHotDogs.Text = "0";
            this.txtHotDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x $4.00 = ";
            // 
            // txtHotDogsSubtotal
            // 
            this.txtHotDogsSubtotal.Location = new System.Drawing.Point(252, 33);
            this.txtHotDogsSubtotal.Name = "txtHotDogsSubtotal";
            this.txtHotDogsSubtotal.ReadOnly = true;
            this.txtHotDogsSubtotal.Size = new System.Drawing.Size(56, 20);
            this.txtHotDogsSubtotal.TabIndex = 4;
            this.txtHotDogsSubtotal.TabStop = false;
            this.txtHotDogsSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHamburgersSubtotal
            // 
            this.txtHamburgersSubtotal.Location = new System.Drawing.Point(252, 59);
            this.txtHamburgersSubtotal.Name = "txtHamburgersSubtotal";
            this.txtHamburgersSubtotal.ReadOnly = true;
            this.txtHamburgersSubtotal.Size = new System.Drawing.Size(56, 20);
            this.txtHamburgersSubtotal.TabIndex = 8;
            this.txtHamburgersSubtotal.TabStop = false;
            this.txtHamburgersSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHamburgersSubtotal.TextChanged += new System.EventHandler(this.TxtHamburgersSubtotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "x $5.00 = ";
            // 
            // txtHamburgers
            // 
            this.txtHamburgers.Location = new System.Drawing.Point(142, 59);
            this.txtHamburgers.Name = "txtHamburgers";
            this.txtHamburgers.Size = new System.Drawing.Size(44, 20);
            this.txtHamburgers.TabIndex = 6;
            this.txtHamburgers.Text = "0";
            this.txtHamburgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hamburgers:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(68, 177);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtPretaxtTotal
            // 
            this.txtPretaxtTotal.Location = new System.Drawing.Point(252, 86);
            this.txtPretaxtTotal.Name = "txtPretaxtTotal";
            this.txtPretaxtTotal.ReadOnly = true;
            this.txtPretaxtTotal.Size = new System.Drawing.Size(56, 20);
            this.txtPretaxtTotal.TabIndex = 10;
            this.txtPretaxtTotal.TabStop = false;
            this.txtPretaxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(252, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(56, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(252, 112);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(56, 20);
            this.txtTax.TabIndex = 12;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pretax total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:";
            // 
            // btnCLear
            // 
            this.btnCLear.Location = new System.Drawing.Point(152, 177);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(75, 23);
            this.btnCLear.TabIndex = 16;
            this.btnCLear.Text = "C&lear";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // rfmFoodTruck
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 212);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCLear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPretaxtTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHamburgersSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHamburgers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotDogsSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotDogs);
            this.Controls.Add(this.label1);
            this.Name = "rfmFoodTruck";
            this.Text = "mswanson1c1: Food Truck";
            this.Load += new System.EventHandler(this.RfmFoodTruck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotDogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotDogsSubtotal;
        private System.Windows.Forms.TextBox txtHamburgersSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHamburgers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPretaxtTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.Button btnExit;
    }
}

