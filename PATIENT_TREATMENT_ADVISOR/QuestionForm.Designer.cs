namespace PATIENT_TREATMENT_ADVISOR
{
    partial class QuestionForm
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
            this.QDiaVomCV = new System.Windows.Forms.CheckBox();
            this.QLungCB = new System.Windows.Forms.CheckBox();
            this.QFeverCB = new System.Windows.Forms.CheckBox();
            this.QSmokerCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.QVegCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QDiaVomCV
            // 
            this.QDiaVomCV.AutoSize = true;
            this.QDiaVomCV.Location = new System.Drawing.Point(104, 165);
            this.QDiaVomCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QDiaVomCV.Name = "QDiaVomCV";
            this.QDiaVomCV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QDiaVomCV.Size = new System.Drawing.Size(136, 19);
            this.QDiaVomCV.TabIndex = 51;
            this.QDiaVomCV.Text = "שילשולים ו/או הקאות";
            this.QDiaVomCV.UseVisualStyleBackColor = true;
            // 
            // QLungCB
            // 
            this.QLungCB.AutoSize = true;
            this.QLungCB.Location = new System.Drawing.Point(149, 142);
            this.QLungCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QLungCB.Name = "QLungCB";
            this.QLungCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QLungCB.Size = new System.Drawing.Size(91, 19);
            this.QLungCB.TabIndex = 50;
            this.QLungCB.Text = "מחלת ריאות";
            this.QLungCB.UseVisualStyleBackColor = true;
            // 
            // QFeverCB
            // 
            this.QFeverCB.AutoSize = true;
            this.QFeverCB.Location = new System.Drawing.Point(159, 120);
            this.QFeverCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QFeverCB.Name = "QFeverCB";
            this.QFeverCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QFeverCB.Size = new System.Drawing.Size(81, 19);
            this.QFeverCB.TabIndex = 49;
            this.QFeverCB.Text = "סובל מחום";
            this.QFeverCB.UseVisualStyleBackColor = true;
            // 
            // QSmokerCB
            // 
            this.QSmokerCB.AutoSize = true;
            this.QSmokerCB.Location = new System.Drawing.Point(187, 98);
            this.QSmokerCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QSmokerCB.Name = "QSmokerCB";
            this.QSmokerCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QSmokerCB.Size = new System.Drawing.Size(53, 19);
            this.QSmokerCB.TabIndex = 48;
            this.QSmokerCB.Text = "מעשן";
            this.QSmokerCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 55;
            this.label2.Text = "יש לסמן את את התשובות\r\n:האם המטופל\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 56;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QVegCB
            // 
            this.QVegCB.AutoSize = true;
            this.QVegCB.Location = new System.Drawing.Point(130, 188);
            this.QVegCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QVegCB.Name = "QVegCB";
            this.QVegCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QVegCB.Size = new System.Drawing.Size(110, 19);
            this.QVegCB.TabIndex = 52;
            this.QVegCB.Text = "צמחוני או טבעוני";
            this.QVegCB.UseVisualStyleBackColor = true;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QVegCB);
            this.Controls.Add(this.QDiaVomCV);
            this.Controls.Add(this.QLungCB);
            this.Controls.Add(this.QFeverCB);
            this.Controls.Add(this.QSmokerCB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox QDiaVomCV;
        private CheckBox QLungCB;
        private CheckBox QFeverCB;
        private CheckBox QSmokerCB;
        private Label label2;
        private Button button1;
        private CheckBox QVegCB;
    }
}