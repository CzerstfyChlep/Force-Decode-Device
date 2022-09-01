namespace Force_Decode_Device
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ForceButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(260, 85);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "Input";
            // 
            // ForceButton
            // 
            this.ForceButton.Location = new System.Drawing.Point(12, 103);
            this.ForceButton.Name = "ForceButton";
            this.ForceButton.Size = new System.Drawing.Size(260, 29);
            this.ForceButton.TabIndex = 1;
            this.ForceButton.Text = "Use the FORCE, Luke!";
            this.ForceButton.UseVisualStyleBackColor = true;
            this.ForceButton.Click += new System.EventHandler(this.ForceButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 138);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(260, 30);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Code used:";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(79, 181);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(0, 13);
            this.Code.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(200, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Spacebar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 203);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ForceButton);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "Force Decode Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ForceButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

