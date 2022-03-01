namespace OverloadMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.areaOutput = new System.Windows.Forms.Label();
            this.value2Label = new System.Windows.Forms.Label();
            this.value1Label = new System.Windows.Forms.Label();
            this.value2Input = new System.Windows.Forms.TextBox();
            this.value1Input = new System.Windows.Forms.TextBox();
            this.areaButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.value3Label = new System.Windows.Forms.Label();
            this.value3Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // areaOutput
            // 
            this.areaOutput.BackColor = System.Drawing.Color.White;
            this.areaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaOutput.Location = new System.Drawing.Point(41, 300);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(284, 25);
            this.areaOutput.TabIndex = 19;
            this.areaOutput.Text = "...";
            // 
            // value2Label
            // 
            this.value2Label.AutoSize = true;
            this.value2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2Label.Location = new System.Drawing.Point(41, 213);
            this.value2Label.Name = "value2Label";
            this.value2Label.Size = new System.Drawing.Size(85, 25);
            this.value2Label.TabIndex = 18;
            this.value2Label.Text = "Value 2";
            // 
            // value1Label
            // 
            this.value1Label.AutoSize = true;
            this.value1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Label.Location = new System.Drawing.Point(41, 171);
            this.value1Label.Name = "value1Label";
            this.value1Label.Size = new System.Drawing.Size(85, 25);
            this.value1Label.TabIndex = 17;
            this.value1Label.Text = "Value 1";
            // 
            // value2Input
            // 
            this.value2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2Input.Location = new System.Drawing.Point(131, 210);
            this.value2Input.Name = "value2Input";
            this.value2Input.Size = new System.Drawing.Size(63, 31);
            this.value2Input.TabIndex = 16;
            // 
            // value1Input
            // 
            this.value1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Input.Location = new System.Drawing.Point(131, 168);
            this.value1Input.Name = "value1Input";
            this.value1Input.Size = new System.Drawing.Size(63, 31);
            this.value1Input.TabIndex = 15;
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.Location = new System.Drawing.Point(220, 210);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(125, 73);
            this.areaButton.TabIndex = 14;
            this.areaButton.Text = "Perimeter";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(22, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(335, 39);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Perimeter Calculator";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(97, 76);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(121, 20);
            this.instructionLabel.TabIndex = 21;
            this.instructionLabel.Text = "instructionLabel";
            // 
            // value3Label
            // 
            this.value3Label.AutoSize = true;
            this.value3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value3Label.Location = new System.Drawing.Point(41, 255);
            this.value3Label.Name = "value3Label";
            this.value3Label.Size = new System.Drawing.Size(85, 25);
            this.value3Label.TabIndex = 22;
            this.value3Label.Text = "Value 3";
            // 
            // value3Input
            // 
            this.value3Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value3Input.Location = new System.Drawing.Point(131, 252);
            this.value3Input.Name = "value3Input";
            this.value3Input.Size = new System.Drawing.Size(63, 31);
            this.value3Input.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(369, 381);
            this.Controls.Add(this.value3Input);
            this.Controls.Add(this.value3Label);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.areaOutput);
            this.Controls.Add(this.value2Label);
            this.Controls.Add(this.value1Label);
            this.Controls.Add(this.value2Input);
            this.Controls.Add(this.value1Input);
            this.Controls.Add(this.areaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Area Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.Label value2Label;
        private System.Windows.Forms.Label value1Label;
        private System.Windows.Forms.TextBox value2Input;
        private System.Windows.Forms.TextBox value1Input;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label value3Label;
        private System.Windows.Forms.TextBox value3Input;
    }
}

