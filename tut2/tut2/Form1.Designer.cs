namespace tut2
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(72, 252);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(179, 18);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose Parking Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.Controls.Add(this.rbStaff);
            this.groupBox1.Controls.Add(this.rbGeneral);
            this.groupBox1.Location = new System.Drawing.Point(364, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parking Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(28, 184);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(96, 22);
            this.rbStudent.TabIndex = 2;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(28, 114);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(78, 22);
            this.rbStaff.TabIndex = 1;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(28, 40);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(141, 22);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General Type";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter number of hours parked";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(392, 415);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(180, 28);
            this.tbHours.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(351, 461);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(274, 55);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate Change";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(424, 551);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(62, 18);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 72);
            this.label2.TabIndex = 6;
            this.label2.Text = "PARKING AVAILABLE\r\nGeneral Public -$2.00 per hour\r\nStaff - $2.00 for first 10 hou" +
    "rs and $ 2.00per hour thereafter\r\nStudent - $1.00 per hour\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label2;
    }
}

