namespace PATIENT_TREATMENT_ADVISOR
{
    partial class TreatmentPage
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.ImportPatientButton = new System.Windows.Forms.Button();
            this.DiagnosisAndRecommendationButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.FirstNameColumn = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(529, 451);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPatientButton.Size = new System.Drawing.Size(230, 99);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "הוסף מטופל";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // ImportPatientButton
            // 
            this.ImportPatientButton.Location = new System.Drawing.Point(293, 451);
            this.ImportPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportPatientButton.Name = "ImportPatientButton";
            this.ImportPatientButton.Size = new System.Drawing.Size(230, 99);
            this.ImportPatientButton.TabIndex = 0;
            this.ImportPatientButton.Text = "ייבא מטופל מקובץ אקסל";
            this.ImportPatientButton.UseVisualStyleBackColor = true;
            // 
            // DiagnosisAndRecommendationButton
            // 
            this.DiagnosisAndRecommendationButton.Location = new System.Drawing.Point(56, 451);
            this.DiagnosisAndRecommendationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiagnosisAndRecommendationButton.Name = "DiagnosisAndRecommendationButton";
            this.DiagnosisAndRecommendationButton.Size = new System.Drawing.Size(230, 99);
            this.DiagnosisAndRecommendationButton.TabIndex = 0;
            this.DiagnosisAndRecommendationButton.Text = "אבחון והמלצות";
            this.DiagnosisAndRecommendationButton.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumn});
            this.ListView.Location = new System.Drawing.Point(56, 87);
            this.ListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(702, 355);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "שם פרטי";
            // 
            // TreatmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 600);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.DiagnosisAndRecommendationButton);
            this.Controls.Add(this.ImportPatientButton);
            this.Controls.Add(this.AddPatientButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TreatmentPage";
            this.Text = "TreatmentPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreatmentPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bindingSource1;
        private Button AddPatientButton;
        private Button ImportPatientButton;
        private Button DiagnosisAndRecommendationButton;
        private ListView ListView;
        private ColumnHeader FirstNameColumn;
    }
}