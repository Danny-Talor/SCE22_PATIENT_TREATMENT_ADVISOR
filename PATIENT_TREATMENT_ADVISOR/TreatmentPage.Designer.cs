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
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.PatientListView = new System.Windows.Forms.ListView();
            this.FirstNameColumn = new System.Windows.Forms.ColumnHeader();
            this.LastNameColumn = new System.Windows.Forms.ColumnHeader();
            this.IDColumn = new System.Windows.Forms.ColumnHeader();
            this.AgeColumn = new System.Windows.Forms.ColumnHeader();
            this.GenderColumn = new System.Windows.Forms.ColumnHeader();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ExportPatientsBtn = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddPatientButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPatientButton.Location = new System.Drawing.Point(641, 59);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPatientButton.Size = new System.Drawing.Size(120, 64);
            this.AddPatientButton.TabIndex = 0;
            this.AddPatientButton.Text = "הוסף מטופל";
            this.AddPatientButton.UseVisualStyleBackColor = false;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // PatientListView
            // 
            this.PatientListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PatientListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PatientListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.IDColumn,
            this.AgeColumn,
            this.GenderColumn});
            this.PatientListView.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientListView.FullRowSelect = true;
            this.PatientListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PatientListView.HoverSelection = true;
            this.PatientListView.Location = new System.Drawing.Point(41, 130);
            this.PatientListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientListView.MultiSelect = false;
            this.PatientListView.Name = "PatientListView";
            this.PatientListView.RightToLeftLayout = true;
            this.PatientListView.ShowGroups = false;
            this.PatientListView.ShowItemToolTips = true;
            this.PatientListView.Size = new System.Drawing.Size(779, 502);
            this.PatientListView.TabIndex = 1;
            this.PatientListView.TabStop = false;
            this.PatientListView.UseCompatibleStateImageBehavior = false;
            this.PatientListView.View = System.Windows.Forms.View.Details;
            this.PatientListView.ItemActivate += new System.EventHandler(this.PatientListView_ItemActivate);
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "שם פרטי";
            this.FirstNameColumn.Width = 130;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "שם משפחה";
            this.LastNameColumn.Width = 180;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "תז";
            this.IDColumn.Width = 180;
            // 
            // AgeColumn
            // 
            this.AgeColumn.Text = "גיל";
            this.AgeColumn.Width = 100;
            // 
            // GenderColumn
            // 
            this.GenderColumn.Text = "מין";
            this.GenderColumn.Width = 100;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.Location = new System.Drawing.Point(97, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(116, 41);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "התנתקות";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CLabel
            // 
            this.CLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CLabel.BackColor = System.Drawing.Color.Transparent;
            this.CLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CLabel.Location = new System.Drawing.Point(461, 8);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(382, 38);
            this.CLabel.TabIndex = 4;
            this.CLabel.Text = "מחובר כ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(8, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zikit";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.ExitBtn.Location = new System.Drawing.Point(11, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 39);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Text = "יציאה";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ExportPatientsBtn
            // 
            this.ExportPatientsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExportPatientsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExportPatientsBtn.Location = new System.Drawing.Point(393, 59);
            this.ExportPatientsBtn.Name = "ExportPatientsBtn";
            this.ExportPatientsBtn.Size = new System.Drawing.Size(174, 64);
            this.ExportPatientsBtn.TabIndex = 0;
            this.ExportPatientsBtn.TabStop = false;
            this.ExportPatientsBtn.Text = "ייצא קובץ מטופלים";
            this.ExportPatientsBtn.UseVisualStyleBackColor = false;
            this.ExportPatientsBtn.Click += new System.EventHandler(this.ExportPatientsBtn_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "excel files (*.xlsx)|*.xlsx";
            this.SaveFileDialog.InitialDirectory = "C:\\";
            this.SaveFileDialog.RestoreDirectory = true;
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.xl_icon;
            this.pictureBox1.Location = new System.Drawing.Point(555, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ExportPatientsBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.Button_Add_icon;
            this.pictureBox2.Location = new System.Drawing.Point(754, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.InstructionsLabel.Location = new System.Drawing.Point(142, 659);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InstructionsLabel.Size = new System.Drawing.Size(701, 62);
            this.InstructionsLabel.TabIndex = 17;
            this.InstructionsLabel.Text = "⦿בחרו מטופל מהרשימה על ידי לחיצה על השורה עם פרטי המטופל\r\n⦿עבור כל מטופל חדש שהוס" +
    "פתם, יש ליייצא קובץ אקסל חדש ";
            this.InstructionsLabel.Visible = false;
            // 
            // TreatmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 730);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddPatientButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExportPatientsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.PatientListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TreatmentPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "זיקית - מסך ראשי";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreatmentPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TreatmentPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreatmentPage_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddPatientButton;
        private ListView PatientListView;
        private ColumnHeader FirstNameColumn;
        private Button LogoutBtn;
        private Label CLabel;
        private ColumnHeader LastNameColumn;
        private ColumnHeader IDColumn;
        private ColumnHeader GenderColumn;
        private ColumnHeader AgeColumn;
        private Label label3;
        private Button ExitBtn;
        private Button ExportPatientsBtn;
        private SaveFileDialog SaveFileDialog;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label InstructionsLabel;
    }
}