namespace Ch03_SplitCost
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nonTax = new System.Windows.Forms.Label();
            this.people = new System.Windows.Forms.Label();
            this.nonTaxBox = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.yen = new System.Windows.Forms.Label();
            this.peopleUnit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.perOne = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.surplus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nonTax
            // 
            this.nonTax.AutoSize = true;
            this.nonTax.Location = new System.Drawing.Point(33, 28);
            this.nonTax.Name = "nonTax";
            this.nonTax.Size = new System.Drawing.Size(62, 12);
            this.nonTax.TabIndex = 0;
            this.nonTax.Text = "税抜き金額";
            // 
            // people
            // 
            this.people.AutoSize = true;
            this.people.Location = new System.Drawing.Point(217, 28);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(29, 12);
            this.people.TabIndex = 1;
            this.people.Text = "人数";
            // 
            // nonTaxBox
            // 
            this.nonTaxBox.Location = new System.Drawing.Point(33, 54);
            this.nonTaxBox.Name = "nonTaxBox";
            this.nonTaxBox.Size = new System.Drawing.Size(81, 19);
            this.nonTaxBox.TabIndex = 2;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(219, 54);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 19);
            this.num.TabIndex = 3;
            // 
            // yen
            // 
            this.yen.AutoSize = true;
            this.yen.Location = new System.Drawing.Point(120, 57);
            this.yen.Name = "yen";
            this.yen.Size = new System.Drawing.Size(17, 12);
            this.yen.TabIndex = 4;
            this.yen.Text = "円";
            // 
            // peopleUnit
            // 
            this.peopleUnit.AutoSize = true;
            this.peopleUnit.Location = new System.Drawing.Point(325, 57);
            this.peopleUnit.Name = "peopleUnit";
            this.peopleUnit.Size = new System.Drawing.Size(17, 12);
            this.peopleUnit.TabIndex = 5;
            this.peopleUnit.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人あたり";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "余り";
            // 
            // perOne
            // 
            this.perOne.AutoSize = true;
            this.perOne.Location = new System.Drawing.Point(33, 165);
            this.perOne.Name = "perOne";
            this.perOne.Size = new System.Drawing.Size(35, 12);
            this.perOne.TabIndex = 8;
            this.perOne.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // surplus
            // 
            this.surplus.AutoSize = true;
            this.surplus.Location = new System.Drawing.Point(219, 165);
            this.surplus.Name = "surplus";
            this.surplus.Size = new System.Drawing.Size(35, 12);
            this.surplus.TabIndex = 11;
            this.surplus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 267);
            this.Controls.Add(this.surplus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.perOne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.peopleUnit);
            this.Controls.Add(this.yen);
            this.Controls.Add(this.num);
            this.Controls.Add(this.nonTaxBox);
            this.Controls.Add(this.people);
            this.Controls.Add(this.nonTax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nonTax;
        private System.Windows.Forms.Label people;
        private System.Windows.Forms.TextBox nonTaxBox;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label yen;
        private System.Windows.Forms.Label peopleUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label perOne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label surplus;
    }
}

