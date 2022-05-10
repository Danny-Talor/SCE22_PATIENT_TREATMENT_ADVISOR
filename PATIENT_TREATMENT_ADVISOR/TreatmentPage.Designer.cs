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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.DiagnosisAndRecommendationButton = new System.Windows.Forms.Button();
            this.PatientListView = new System.Windows.Forms.ListView();
            this.FirstNameColumn = new System.Windows.Forms.ColumnHeader();
            this.LastNameColumn = new System.Windows.Forms.ColumnHeader();
            this.IDColumn = new System.Windows.Forms.ColumnHeader();
            this.AgeColumn = new System.Windows.Forms.ColumnHeader();
            this.GenderColumn = new System.Windows.Forms.ColumnHeader();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(26, 429);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPatientButton.Size = new System.Drawing.Size(215, 68);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "הוסף מטופל";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // DiagnosisAndRecommendationButton
            // 
            this.DiagnosisAndRecommendationButton.Location = new System.Drawing.Point(278, 429);
            this.DiagnosisAndRecommendationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiagnosisAndRecommendationButton.Name = "DiagnosisAndRecommendationButton";
            this.DiagnosisAndRecommendationButton.Size = new System.Drawing.Size(215, 68);
            this.DiagnosisAndRecommendationButton.TabIndex = 0;
            this.DiagnosisAndRecommendationButton.Text = "אבחון והמלצות";
            this.DiagnosisAndRecommendationButton.UseVisualStyleBackColor = true;
            // 
            // PatientListView
            // 
            this.PatientListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.IDColumn,
            this.AgeColumn,
            this.GenderColumn});
            this.PatientListView.FullRowSelect = true;
            this.PatientListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PatientListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.PatientListView.Location = new System.Drawing.Point(26, 48);
            this.PatientListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientListView.Name = "PatientListView";
            this.PatientListView.RightToLeftLayout = true;
            this.PatientListView.Size = new System.Drawing.Size(467, 355);
            this.PatientListView.TabIndex = 1;
            this.PatientListView.TabStop = false;
            this.PatientListView.UseCompatibleStateImageBehavior = false;
            this.PatientListView.View = System.Windows.Forms.View.Details;
            this.PatientListView.ItemActivate += new System.EventHandler(this.PatientListView_ItemActivate);
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "שם פרטי";
            this.FirstNameColumn.Width = 80;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "שם משפחה";
            this.LastNameColumn.Width = 90;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "תז";
            this.IDColumn.Width = 120;
            // 
            // AgeColumn
            // 
            this.AgeColumn.Text = "גיל";
            // 
            // GenderColumn
            // 
            this.GenderColumn.Text = "מין";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(257, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(94, 29);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "התנתקות";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "מחובר כ";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(357, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "יציאה";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TreatmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 523);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.PatientListView);
            this.Controls.Add(this.DiagnosisAndRecommendationButton);
            this.Controls.Add(this.AddPatientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TreatmentPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreatmentPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreatmentPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TreatmentPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreatmentPage_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource bindingSource1;
        private Button AddPatientButton;
        private Button DiagnosisAndRecommendationButton;
        private ListView PatientListView;
        private ColumnHeader FirstNameColumn;
        private Button LogoutBtn;
        private Label label1;
        private Label label2;
        private ColumnHeader LastNameColumn;
        private ColumnHeader IDColumn;
        private ColumnHeader GenderColumn;
        private Button ExitBtn;
        private ColumnHeader AgeColumn;
    }
}