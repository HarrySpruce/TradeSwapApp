namespace Trade_Entry_Application
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Notional = new System.Windows.Forms.Label();
            this.notionalEntry = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.floatEntry = new System.Windows.Forms.TextBox();
            this.rateType = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 428);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(997, 23);
            this.progressBar.TabIndex = 0;
            // 
            // Notional
            // 
            this.Notional.AutoSize = true;
            this.Notional.Location = new System.Drawing.Point(12, 9);
            this.Notional.Name = "Notional";
            this.Notional.Size = new System.Drawing.Size(46, 13);
            this.Notional.TabIndex = 1;
            this.Notional.Text = "Notional";
            // 
            // notionalEntry
            // 
            this.notionalEntry.Location = new System.Drawing.Point(12, 25);
            this.notionalEntry.Name = "notionalEntry";
            this.notionalEntry.Size = new System.Drawing.Size(100, 20);
            this.notionalEntry.TabIndex = 2;
            this.notionalEntry.TextChanged += new System.EventHandler(this.notionalEntry_TextChanged);
            this.notionalEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notionalEntry_KeyDown);
            this.notionalEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notionalEntry_KeyPress);
            this.notionalEntry.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.notionalEntry_PreviewKeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(12, 87);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 7;
            this.Result.Text = "output";
            // 
            // floatEntry
            // 
            this.floatEntry.Location = new System.Drawing.Point(12, 64);
            this.floatEntry.Name = "floatEntry";
            this.floatEntry.Size = new System.Drawing.Size(100, 20);
            this.floatEntry.TabIndex = 10;
            this.floatEntry.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // rateType
            // 
            this.rateType.AutoSize = true;
            this.rateType.Location = new System.Drawing.Point(12, 48);
            this.rateType.Name = "rateType";
            this.rateType.Size = new System.Drawing.Size(58, 13);
            this.rateType.TabIndex = 9;
            this.rateType.Text = "Fixed Rate";
            this.rateType.Click += new System.EventHandler(this.label5_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(119, 64);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 103);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 451);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.floatEntry);
            this.Controls.Add(this.rateType);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notionalEntry);
            this.Controls.Add(this.Notional);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Notional;
        private System.Windows.Forms.TextBox notionalEntry;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox floatEntry;
        private System.Windows.Forms.Label rateType;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox resultBox;
    }
}

