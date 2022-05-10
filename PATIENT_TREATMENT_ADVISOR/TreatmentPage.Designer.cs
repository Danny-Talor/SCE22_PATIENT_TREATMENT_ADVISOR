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
            this.ListView = new System.Windows.Forms.ListView();
            this.FirstNameColumn = new System.Windows.Forms.ColumnHeader();
            this.LastNameColumn = new System.Windows.Forms.ColumnHeader();
            this.IDColumn = new System.Windows.Forms.ColumnHeader();
            this.GenderColumn = new System.Windows.Forms.ColumnHeader();
            this.WBCColumn = new System.Windows.Forms.ColumnHeader();
            this.NeutColumn = new System.Windows.Forms.ColumnHeader();
            this.LymphColumn = new System.Windows.Forms.ColumnHeader();
            this.RBColumn = new System.Windows.Forms.ColumnHeader();
            this.HCTColumn = new System.Windows.Forms.ColumnHeader();
            this.UreaColumn = new System.Windows.Forms.ColumnHeader();
            this.HbColumn = new System.Windows.Forms.ColumnHeader();
            this.CrtnColumn = new System.Windows.Forms.ColumnHeader();
            this.IronColumn = new System.Windows.Forms.ColumnHeader();
            this.HDLColumn = new System.Windows.Forms.ColumnHeader();
            this.APColumn = new System.Windows.Forms.ColumnHeader();
            this.DiagnosisColumn = new System.Windows.Forms.ColumnHeader();
            this.RecommendationColumn = new System.Windows.Forms.ColumnHeader();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Location = new System.Drawing.Point(49, 351);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPatientButton.Size = new System.Drawing.Size(302, 74);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "הוסף מטופל";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // DiagnosisAndRecommendationButton
            // 
            this.DiagnosisAndRecommendationButton.Location = new System.Drawing.Point(362, 351);
            this.DiagnosisAndRecommendationButton.Name = "DiagnosisAndRecommendationButton";
            this.DiagnosisAndRecommendationButton.Size = new System.Drawing.Size(302, 74);
            this.DiagnosisAndRecommendationButton.TabIndex = 0;
            this.DiagnosisAndRecommendationButton.Text = "אבחון והמלצות";
            this.DiagnosisAndRecommendationButton.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.IDColumn,
            this.GenderColumn,
            this.WBCColumn,
            this.NeutColumn,
            this.LymphColumn,
            this.RBColumn,
            this.HCTColumn,
            this.UreaColumn,
            this.HbColumn,
            this.CrtnColumn,
            this.IronColumn,
            this.HDLColumn,
            this.APColumn,
            this.DiagnosisColumn,
            this.RecommendationColumn});
            this.ListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListView.Location = new System.Drawing.Point(49, 65);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(615, 267);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "שם פרטי";
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "שם משפחה";
            this.LastNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "תז";
            this.IDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GenderColumn
            // 
            this.GenderColumn.Text = "מין";
            this.GenderColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WBCColumn
            // 
            this.WBCColumn.Text = "WBC";
            this.WBCColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NeutColumn
            // 
            this.NeutColumn.Text = "Neut";
            this.NeutColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LymphColumn
            // 
            this.LymphColumn.Text = "Lymph";
            this.LymphColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RBColumn
            // 
            this.RBColumn.Text = "RBC";
            this.RBColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HCTColumn
            // 
            this.HCTColumn.Text = "HCT";
            this.HCTColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UreaColumn
            // 
            this.UreaColumn.Text = "Urea";
            this.UreaColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HbColumn
            // 
            this.HbColumn.Text = "Hb\r\n";
            this.HbColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CrtnColumn
            // 
            this.CrtnColumn.Text = "Crtn";
            this.CrtnColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IronColumn
            // 
            this.IronColumn.Text = "Iron";
            this.IronColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HDLColumn
            // 
            this.HDLColumn.Text = "HDL";
            this.HDLColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // APColumn
            // 
            this.APColumn.Text = "AP";
            this.APColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DiagnosisColumn
            // 
            this.DiagnosisColumn.Text = "אבחנה";
            this.DiagnosisColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RecommendationColumn
            // 
            this.RecommendationColumn.Text = "המלצות";
            this.RecommendationColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(645, 7);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(82, 22);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "התנתק";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "מחובר כ";
            // 
            // TreatmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.DiagnosisAndRecommendationButton);
            this.Controls.Add(this.AddPatientButton);
            this.Name = "TreatmentPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "TreatmentPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreatmentPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource bindingSource1;
        private Button AddPatientButton;
        private Button DiagnosisAndRecommendationButton;
        private ListView ListView;
        private ColumnHeader FirstNameColumn;
        private Button LogoutBtn;
        private Label label1;
        private Label label2;
        private ColumnHeader LastNameColumn;
        private ColumnHeader IDColumn;
        private ColumnHeader GenderColumn;
        private ColumnHeader WBCColumn;
        private ColumnHeader NeutColumn;
        private ColumnHeader LymphColumn;
        private ColumnHeader RBColumn;
        private ColumnHeader HCTColumn;
        private ColumnHeader UreaColumn;
        private ColumnHeader HbColumn;
        private ColumnHeader CrtnColumn;
        private ColumnHeader IronColumn;
        private ColumnHeader HDLColumn;
        private ColumnHeader APColumn;
        private ColumnHeader DiagnosisColumn;
        private ColumnHeader RecommendationColumn;
    }
}