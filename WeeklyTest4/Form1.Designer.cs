namespace WeeklyTest4
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
            DayMonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            DayComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // DayMonthComboBox
            // 
            DayMonthComboBox.FormattingEnabled = true;
            DayMonthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayMonthComboBox.Location = new Point(863, 166);
            DayMonthComboBox.Name = "DayMonthComboBox";
            DayMonthComboBox.Size = new Size(212, 38);
            DayMonthComboBox.TabIndex = 0;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(316, 166);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(212, 38);
            YearComboBox.TabIndex = 1;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(584, 166);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(212, 38);
            MonthComboBox.TabIndex = 2;
            // 
            // DayComboBox
            // 
            DayComboBox.FormattingEnabled = true;
            DayComboBox.Items.AddRange(new object[] { "רשאון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayComboBox.Location = new Point(1148, 166);
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(212, 38);
            DayComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1207, 118);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 4;
            label1.Text = "היום השבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 39);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 5;
            label2.Text = "כתיבת תאריך";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 118);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 6;
            label3.Text = "שנה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 118);
            label4.Name = "label4";
            label4.Size = new Size(59, 30);
            label4.TabIndex = 7;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(929, 118);
            label5.Name = "label5";
            label5.Size = new Size(118, 30);
            label5.TabIndex = 8;
            label5.Text = "היום בחודש";
            // 
            // button1
            // 
            button1.Location = new Point(113, 62);
            button1.Name = "button1";
            button1.Size = new Size(131, 142);
            button1.TabIndex = 9;
            button1.Text = "שלחחחחחחחחחחחחחחחחחחחחחחחחחחחחחחחחחחח";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 719);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DayComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(YearComboBox);
            Controls.Add(DayMonthComboBox);
            Name = "Form1";
            Text = "כתיבת תאריך";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DayMonthComboBox;
        private ComboBox YearComboBox;
        private ComboBox MonthComboBox;
        private ComboBox DayComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
