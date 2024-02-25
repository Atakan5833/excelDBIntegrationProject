namespace excelDBIntegrationProject
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
            btnVTReading = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnVTReading
            // 
            btnVTReading.Location = new Point(483, 39);
            btnVTReading.Name = "btnVTReading";
            btnVTReading.Size = new Size(129, 49);
            btnVTReading.TabIndex = 0;
            btnVTReading.Text = "DB Veri Oku ve Excele Yazdır";
            btnVTReading.UseVisualStyleBackColor = true;
            btnVTReading.Click += btnVTReading_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 39);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(398, 120);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnVTReading);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVTReading;
        private RichTextBox richTextBox1;
    }
}
