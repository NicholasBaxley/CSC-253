
namespace WinFormUI
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChar = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.buttonTelephone = new System.Windows.Forms.Button();
            this.buttonBackwards = new System.Windows.Forms.Button();
            this.buttonWordCount = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInputBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(329, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 42);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonChar
            // 
            this.buttonChar.Location = new System.Drawing.Point(12, 81);
            this.buttonChar.Name = "buttonChar";
            this.buttonChar.Size = new System.Drawing.Size(115, 23);
            this.buttonChar.TabIndex = 1;
            this.buttonChar.Text = "Char Array";
            this.buttonChar.UseVisualStyleBackColor = true;
            this.buttonChar.Click += new System.EventHandler(this.buttonChar_Click);
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(12, 131);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(115, 23);
            this.buttonDate.TabIndex = 2;
            this.buttonDate.Text = "Date Array";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonTelephone
            // 
            this.buttonTelephone.Location = new System.Drawing.Point(12, 181);
            this.buttonTelephone.Name = "buttonTelephone";
            this.buttonTelephone.Size = new System.Drawing.Size(115, 23);
            this.buttonTelephone.TabIndex = 3;
            this.buttonTelephone.Text = "Telephone Number";
            this.buttonTelephone.UseVisualStyleBackColor = true;
            this.buttonTelephone.Click += new System.EventHandler(this.buttonTelephone_Click);
            // 
            // buttonBackwards
            // 
            this.buttonBackwards.Location = new System.Drawing.Point(12, 231);
            this.buttonBackwards.Name = "buttonBackwards";
            this.buttonBackwards.Size = new System.Drawing.Size(115, 23);
            this.buttonBackwards.TabIndex = 4;
            this.buttonBackwards.Text = "Backwards";
            this.buttonBackwards.UseVisualStyleBackColor = true;
            this.buttonBackwards.Click += new System.EventHandler(this.buttonBackwards_Click);
            // 
            // buttonWordCount
            // 
            this.buttonWordCount.Location = new System.Drawing.Point(12, 281);
            this.buttonWordCount.Name = "buttonWordCount";
            this.buttonWordCount.Size = new System.Drawing.Size(115, 23);
            this.buttonWordCount.TabIndex = 5;
            this.buttonWordCount.Text = "Word Count";
            this.buttonWordCount.UseVisualStyleBackColor = true;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(145, 81);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(271, 225);
            this.listBoxOutput.TabIndex = 6;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(24, 34);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(274, 20);
            this.textBoxInput.TabIndex = 7;
            // 
            // labelInputBox
            // 
            this.labelInputBox.AutoSize = true;
            this.labelInputBox.Location = new System.Drawing.Point(21, 18);
            this.labelInputBox.Name = "labelInputBox";
            this.labelInputBox.Size = new System.Drawing.Size(83, 13);
            this.labelInputBox.TabIndex = 8;
            this.labelInputBox.Text = "Insert Text Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Format: MM/DD/YYYY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInputBox);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonWordCount);
            this.Controls.Add(this.buttonBackwards);
            this.Controls.Add(this.buttonTelephone);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.buttonChar);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChar;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.Button buttonTelephone;
        private System.Windows.Forms.Button buttonBackwards;
        private System.Windows.Forms.Button buttonWordCount;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInputBox;
        private System.Windows.Forms.Label label1;
    }
}

