namespace App9Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IntervalValue = new System.Windows.Forms.TextBox();
            TimeValue = new System.Windows.Forms.TextBox();
            Interval = new System.Windows.Forms.Label();
            Time = new System.Windows.Forms.Label();
            Start = new System.Windows.Forms.Button();
            Stop = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // IntervalValue
            // 
            IntervalValue.Location = new System.Drawing.Point(45, 125);
            IntervalValue.Name = "IntervalValue";
            IntervalValue.Size = new System.Drawing.Size(245, 27);
            IntervalValue.TabIndex = 0;
            // 
            // TimeValue
            // 
            TimeValue.Location = new System.Drawing.Point(45, 277);
            TimeValue.Name = "TimeValue";
            TimeValue.Size = new System.Drawing.Size(245, 27);
            TimeValue.TabIndex = 1;
            // 
            // Interval
            // 
            Interval.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Interval.Location = new System.Drawing.Point(45, 40);
            Interval.Name = "Interval";
            Interval.Size = new System.Drawing.Size(199, 58);
            Interval.TabIndex = 2;
            Interval.Text = "Interval";
            // 
            // Time
            // 
            Time.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Time.Location = new System.Drawing.Point(45, 190);
            Time.Name = "Time";
            Time.Size = new System.Drawing.Size(109, 58);
            Time.TabIndex = 3;
            Time.Text = "Time";
            // 
            // Start
            // 
            Start.Location = new System.Drawing.Point(427, 40);
            Start.Name = "Start";
            Start.Size = new System.Drawing.Size(289, 86);
            Start.TabIndex = 4;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new System.Drawing.Point(427, 162);
            Stop.Name = "Stop";
            Stop.Size = new System.Drawing.Size(289, 86);
            Stop.TabIndex = 5;
            Stop.Text = "button1";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(427, 277);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(289, 244);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(815, 549);
            Controls.Add(listBox1);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(Time);
            Controls.Add(Interval);
            Controls.Add(TimeValue);
            Controls.Add(IntervalValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox IntervalValue;
        private System.Windows.Forms.TextBox TimeValue;
        private System.Windows.Forms.Label Interval;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ListBox listBox1;
    }
}
