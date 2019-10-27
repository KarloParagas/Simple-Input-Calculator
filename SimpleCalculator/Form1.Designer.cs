namespace SimpleCalculator
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
            this.operand1TextBox = new System.Windows.Forms.TextBox();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.operand2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.Label();
            this.operand1Error = new System.Windows.Forms.Label();
            this.operatorError = new System.Windows.Forms.Label();
            this.operand2Error = new System.Windows.Forms.Label();
            this.resultError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand 2:";
            // 
            // operand1TextBox
            // 
            this.operand1TextBox.Location = new System.Drawing.Point(117, 34);
            this.operand1TextBox.Name = "operand1TextBox";
            this.operand1TextBox.Size = new System.Drawing.Size(100, 20);
            this.operand1TextBox.TabIndex = 3;
            this.operand1TextBox.TextChanged += new System.EventHandler(this.inputChange_TextChanged);
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.Location = new System.Drawing.Point(117, 74);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(100, 20);
            this.operatorTextBox.TabIndex = 4;
            this.operatorTextBox.TextChanged += new System.EventHandler(this.inputChange_TextChanged);
            // 
            // operand2TextBox
            // 
            this.operand2TextBox.Location = new System.Drawing.Point(117, 115);
            this.operand2TextBox.Name = "operand2TextBox";
            this.operand2TextBox.Size = new System.Drawing.Size(100, 20);
            this.operand2TextBox.TabIndex = 5;
            this.operand2TextBox.TextChanged += new System.EventHandler(this.inputChange_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(142, 206);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultBox.Location = new System.Drawing.Point(117, 163);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 23);
            this.resultBox.TabIndex = 10;
            // 
            // operand1Error
            // 
            this.operand1Error.AutoSize = true;
            this.operand1Error.Location = new System.Drawing.Point(223, 34);
            this.operand1Error.Name = "operand1Error";
            this.operand1Error.Size = new System.Drawing.Size(0, 13);
            this.operand1Error.TabIndex = 11;
            // 
            // operatorError
            // 
            this.operatorError.AutoSize = true;
            this.operatorError.Location = new System.Drawing.Point(223, 74);
            this.operatorError.Name = "operatorError";
            this.operatorError.Size = new System.Drawing.Size(0, 13);
            this.operatorError.TabIndex = 12;
            // 
            // operand2Error
            // 
            this.operand2Error.AutoSize = true;
            this.operand2Error.Location = new System.Drawing.Point(223, 115);
            this.operand2Error.Name = "operand2Error";
            this.operand2Error.Size = new System.Drawing.Size(0, 13);
            this.operand2Error.TabIndex = 13;
            // 
            // resultError
            // 
            this.resultError.AutoSize = true;
            this.resultError.Location = new System.Drawing.Point(226, 163);
            this.resultError.Name = "resultError";
            this.resultError.Size = new System.Drawing.Size(0, 13);
            this.resultError.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 279);
            this.Controls.Add(this.resultError);
            this.Controls.Add(this.operand2Error);
            this.Controls.Add(this.operatorError);
            this.Controls.Add(this.operand1Error);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operand2TextBox);
            this.Controls.Add(this.operatorTextBox);
            this.Controls.Add(this.operand1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox operand1TextBox;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.TextBox operand2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.Label operand1Error;
        private System.Windows.Forms.Label operatorError;
        private System.Windows.Forms.Label operand2Error;
        private System.Windows.Forms.Label resultError;
    }
}

