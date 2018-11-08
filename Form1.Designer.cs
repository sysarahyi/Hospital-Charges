namespace Hospital_Charges
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DaysSpentTxt = new System.Windows.Forms.TextBox();
            this.MedChargesTxt = new System.Windows.Forms.TextBox();
            this.SurgicalChargesTxt = new System.Windows.Forms.TextBox();
            this.LabFeesTxt = new System.Windows.Forms.TextBox();
            this.RehabChargesTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days spent in hospital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication Charges: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical Charges: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab Fees: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rehab Charges: $ ";
            // 
            // DaysSpentTxt
            // 
            this.DaysSpentTxt.Location = new System.Drawing.Point(208, 53);
            this.DaysSpentTxt.Name = "DaysSpentTxt";
            this.DaysSpentTxt.Size = new System.Drawing.Size(100, 26);
            this.DaysSpentTxt.TabIndex = 5;
            // 
            // MedChargesTxt
            // 
            this.MedChargesTxt.Location = new System.Drawing.Point(207, 109);
            this.MedChargesTxt.Name = "MedChargesTxt";
            this.MedChargesTxt.Size = new System.Drawing.Size(100, 26);
            this.MedChargesTxt.TabIndex = 6;
            // 
            // SurgicalChargesTxt
            // 
            this.SurgicalChargesTxt.Location = new System.Drawing.Point(178, 177);
            this.SurgicalChargesTxt.Name = "SurgicalChargesTxt";
            this.SurgicalChargesTxt.Size = new System.Drawing.Size(100, 26);
            this.SurgicalChargesTxt.TabIndex = 7;
            // 
            // LabFeesTxt
            // 
            this.LabFeesTxt.Location = new System.Drawing.Point(122, 238);
            this.LabFeesTxt.Name = "LabFeesTxt";
            this.LabFeesTxt.Size = new System.Drawing.Size(100, 26);
            this.LabFeesTxt.TabIndex = 8;
            // 
            // RehabChargesTxt
            // 
            this.RehabChargesTxt.Location = new System.Drawing.Point(169, 299);
            this.RehabChargesTxt.Name = "RehabChargesTxt";
            this.RehabChargesTxt.Size = new System.Drawing.Size(100, 26);
            this.RehabChargesTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total cost:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCostLabel.Location = new System.Drawing.Point(122, 397);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(131, 22);
            this.TotalCostLabel.TabIndex = 11;
            this.TotalCostLabel.Text = "                              ";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(29, 484);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(130, 46);
            this.calcBtn.TabIndex = 12;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(194, 484);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(124, 46);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(358, 484);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(130, 46);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 601);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RehabChargesTxt);
            this.Controls.Add(this.LabFeesTxt);
            this.Controls.Add(this.SurgicalChargesTxt);
            this.Controls.Add(this.MedChargesTxt);
            this.Controls.Add(this.DaysSpentTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DaysSpentTxt;
        private System.Windows.Forms.TextBox MedChargesTxt;
        private System.Windows.Forms.TextBox SurgicalChargesTxt;
        private System.Windows.Forms.TextBox LabFeesTxt;
        private System.Windows.Forms.TextBox RehabChargesTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

