namespace AIApplicationTools
{
    partial class MainForm
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
            label1 = new Label();
            TextBox_SelectedFile = new TextBox();
            Button_ChangeFile = new Button();
            Button_ReadPDF = new Button();
            Button_Country = new Button();
            Label_Country = new Label();
            Button_EditFields = new Button();
            Label_City = new Label();
            Button_City = new Button();
            Label_State = new Label();
            Button_State = new Button();
            Label_PostalCode = new Label();
            Button_PostalCode = new Button();
            Label_County = new Label();
            Button_County = new Button();
            Label_AddressLine = new Label();
            Button_AddressLine = new Button();
            Label_MiddleName = new Label();
            Button_MiddleName = new Button();
            Label_FirstName = new Label();
            Button_FirstName = new Button();
            Label_LastName = new Label();
            Button_LastName = new Button();
            Label_PhoneNumber = new Label();
            Button_PhoneNumber = new Button();
            Label_Email = new Label();
            Button_Email = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 7);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "AI Application Tool";
            // 
            // TextBox_SelectedFile
            // 
            TextBox_SelectedFile.Location = new Point(342, 25);
            TextBox_SelectedFile.Name = "TextBox_SelectedFile";
            TextBox_SelectedFile.ReadOnly = true;
            TextBox_SelectedFile.Size = new Size(359, 23);
            TextBox_SelectedFile.TabIndex = 1;
            // 
            // Button_ChangeFile
            // 
            Button_ChangeFile.Location = new Point(707, 25);
            Button_ChangeFile.Name = "Button_ChangeFile";
            Button_ChangeFile.Size = new Size(27, 23);
            Button_ChangeFile.TabIndex = 2;
            Button_ChangeFile.Text = "...";
            Button_ChangeFile.UseVisualStyleBackColor = true;
            Button_ChangeFile.Click += Button_ChangeFile_Click;
            // 
            // Button_ReadPDF
            // 
            Button_ReadPDF.Location = new Point(485, 61);
            Button_ReadPDF.Name = "Button_ReadPDF";
            Button_ReadPDF.Size = new Size(107, 32);
            Button_ReadPDF.TabIndex = 4;
            Button_ReadPDF.Text = "Read PDF";
            Button_ReadPDF.UseVisualStyleBackColor = true;
            Button_ReadPDF.Click += Button_ReadPDF_Click;
            // 
            // Button_Country
            // 
            Button_Country.Location = new Point(119, 184);
            Button_Country.Name = "Button_Country";
            Button_Country.Size = new Size(210, 24);
            Button_Country.TabIndex = 6;
            Button_Country.Text = "[Country]";
            Button_Country.UseVisualStyleBackColor = true;
            // 
            // Label_Country
            // 
            Label_Country.AutoSize = true;
            Label_Country.Location = new Point(60, 189);
            Label_Country.Name = "Label_Country";
            Label_Country.Size = new Size(53, 15);
            Label_Country.TabIndex = 7;
            Label_Country.Text = "Country:";
            // 
            // Button_EditFields
            // 
            Button_EditFields.Location = new Point(62, 73);
            Button_EditFields.Name = "Button_EditFields";
            Button_EditFields.Size = new Size(116, 31);
            Button_EditFields.TabIndex = 8;
            Button_EditFields.Text = "Edit Fields";
            Button_EditFields.UseVisualStyleBackColor = true;
            // 
            // Label_City
            // 
            Label_City.AutoSize = true;
            Label_City.Location = new Point(699, 189);
            Label_City.Name = "Label_City";
            Label_City.Size = new Size(31, 15);
            Label_City.TabIndex = 10;
            Label_City.Text = "City:";
            // 
            // Button_City
            // 
            Button_City.Location = new Point(736, 184);
            Button_City.Name = "Button_City";
            Button_City.Size = new Size(210, 24);
            Button_City.TabIndex = 9;
            Button_City.Text = "[City]";
            Button_City.UseVisualStyleBackColor = true;
            // 
            // Label_State
            // 
            Label_State.AutoSize = true;
            Label_State.Location = new Point(77, 239);
            Label_State.Name = "Label_State";
            Label_State.Size = new Size(36, 15);
            Label_State.TabIndex = 12;
            Label_State.Text = "State:";
            Label_State.Click += Label_State_Click;
            // 
            // Button_State
            // 
            Button_State.Location = new Point(119, 234);
            Button_State.Name = "Button_State";
            Button_State.Size = new Size(210, 24);
            Button_State.TabIndex = 11;
            Button_State.Text = "[State]";
            Button_State.UseVisualStyleBackColor = true;
            // 
            // Label_PostalCode
            // 
            Label_PostalCode.AutoSize = true;
            Label_PostalCode.Location = new Point(354, 239);
            Label_PostalCode.Name = "Label_PostalCode";
            Label_PostalCode.Size = new Size(73, 15);
            Label_PostalCode.TabIndex = 16;
            Label_PostalCode.Text = "Postal Code:";
            // 
            // Button_PostalCode
            // 
            Button_PostalCode.Location = new Point(433, 234);
            Button_PostalCode.Name = "Button_PostalCode";
            Button_PostalCode.Size = new Size(210, 24);
            Button_PostalCode.TabIndex = 15;
            Button_PostalCode.Text = "[Postal Code]";
            Button_PostalCode.UseVisualStyleBackColor = true;
            // 
            // Label_County
            // 
            Label_County.AutoSize = true;
            Label_County.Location = new Point(681, 239);
            Label_County.Name = "Label_County";
            Label_County.Size = new Size(49, 15);
            Label_County.TabIndex = 14;
            Label_County.Text = "County:";
            // 
            // Button_County
            // 
            Button_County.Location = new Point(736, 234);
            Button_County.Name = "Button_County";
            Button_County.Size = new Size(210, 24);
            Button_County.TabIndex = 13;
            Button_County.Text = "[County]";
            Button_County.UseVisualStyleBackColor = true;
            // 
            // Label_AddressLine
            // 
            Label_AddressLine.AutoSize = true;
            Label_AddressLine.Location = new Point(354, 189);
            Label_AddressLine.Name = "Label_AddressLine";
            Label_AddressLine.Size = new Size(77, 15);
            Label_AddressLine.TabIndex = 18;
            Label_AddressLine.Text = "Address Line:";
            // 
            // Button_AddressLine
            // 
            Button_AddressLine.Location = new Point(433, 184);
            Button_AddressLine.Name = "Button_AddressLine";
            Button_AddressLine.Size = new Size(210, 24);
            Button_AddressLine.TabIndex = 17;
            Button_AddressLine.Text = "[Address Line]";
            Button_AddressLine.UseVisualStyleBackColor = true;
            // 
            // Label_MiddleName
            // 
            Label_MiddleName.AutoSize = true;
            Label_MiddleName.Location = new Point(345, 138);
            Label_MiddleName.Name = "Label_MiddleName";
            Label_MiddleName.Size = new Size(82, 15);
            Label_MiddleName.TabIndex = 22;
            Label_MiddleName.Text = "Middle Name:";
            // 
            // Button_MiddleName
            // 
            Button_MiddleName.Location = new Point(433, 133);
            Button_MiddleName.Name = "Button_MiddleName";
            Button_MiddleName.Size = new Size(210, 24);
            Button_MiddleName.TabIndex = 21;
            Button_MiddleName.Text = "[Middle Name]";
            Button_MiddleName.UseVisualStyleBackColor = true;
            // 
            // Label_FirstName
            // 
            Label_FirstName.AutoSize = true;
            Label_FirstName.Location = new Point(46, 138);
            Label_FirstName.Name = "Label_FirstName";
            Label_FirstName.Size = new Size(67, 15);
            Label_FirstName.TabIndex = 20;
            Label_FirstName.Text = "First Name:";
            // 
            // Button_FirstName
            // 
            Button_FirstName.Location = new Point(119, 133);
            Button_FirstName.Name = "Button_FirstName";
            Button_FirstName.Size = new Size(210, 24);
            Button_FirstName.TabIndex = 19;
            Button_FirstName.Text = "[First Name]";
            Button_FirstName.UseVisualStyleBackColor = true;
            // 
            // Label_LastName
            // 
            Label_LastName.AutoSize = true;
            Label_LastName.Location = new Point(664, 138);
            Label_LastName.Name = "Label_LastName";
            Label_LastName.Size = new Size(66, 15);
            Label_LastName.TabIndex = 24;
            Label_LastName.Text = "Last Name:";
            // 
            // Button_LastName
            // 
            Button_LastName.Location = new Point(736, 133);
            Button_LastName.Name = "Button_LastName";
            Button_LastName.Size = new Size(210, 24);
            Button_LastName.TabIndex = 23;
            Button_LastName.Text = "[Last Name]";
            Button_LastName.UseVisualStyleBackColor = true;
            // 
            // Label_PhoneNumber
            // 
            Label_PhoneNumber.AutoSize = true;
            Label_PhoneNumber.Location = new Point(473, 287);
            Label_PhoneNumber.Name = "Label_PhoneNumber";
            Label_PhoneNumber.Size = new Size(91, 15);
            Label_PhoneNumber.TabIndex = 30;
            Label_PhoneNumber.Text = "Phone Number:";
            // 
            // Button_PhoneNumber
            // 
            Button_PhoneNumber.Location = new Point(566, 282);
            Button_PhoneNumber.Name = "Button_PhoneNumber";
            Button_PhoneNumber.Size = new Size(210, 24);
            Button_PhoneNumber.TabIndex = 29;
            Button_PhoneNumber.Text = "[Phone Number]";
            Button_PhoneNumber.UseVisualStyleBackColor = true;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Location = new Point(210, 287);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(39, 15);
            Label_Email.TabIndex = 26;
            Label_Email.Text = "Email:";
            // 
            // Button_Email
            // 
            Button_Email.Location = new Point(252, 282);
            Button_Email.Name = "Button_Email";
            Button_Email.Size = new Size(210, 24);
            Button_Email.TabIndex = 25;
            Button_Email.Text = "[Email]";
            Button_Email.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 688);
            Controls.Add(Label_PhoneNumber);
            Controls.Add(Button_PhoneNumber);
            Controls.Add(Label_Email);
            Controls.Add(Button_Email);
            Controls.Add(Label_LastName);
            Controls.Add(Button_LastName);
            Controls.Add(Label_MiddleName);
            Controls.Add(Button_MiddleName);
            Controls.Add(Label_FirstName);
            Controls.Add(Button_FirstName);
            Controls.Add(Label_AddressLine);
            Controls.Add(Button_AddressLine);
            Controls.Add(Label_PostalCode);
            Controls.Add(Button_PostalCode);
            Controls.Add(Label_County);
            Controls.Add(Button_County);
            Controls.Add(Label_State);
            Controls.Add(Button_State);
            Controls.Add(Label_City);
            Controls.Add(Button_City);
            Controls.Add(Button_EditFields);
            Controls.Add(Label_Country);
            Controls.Add(Button_Country);
            Controls.Add(Button_ReadPDF);
            Controls.Add(Button_ChangeFile);
            Controls.Add(TextBox_SelectedFile);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBox_SelectedFile;
        private Button Button_ChangeFile;
        private DataGridView dataGridView1;
        private Button Button_ReadPDF;
        private Button Button_Country;
        private Label Label_Country;
        private Button Button_EditFields;
        private Label Label_City;
        private Button Button_City;
        private Label Label_State;
        private Button Button_State;
        private Label Label_PostalCode;
        private Button Button_PostalCode;
        private Label Label_County;
        private Button Button_County;
        private Label Label_AddressLine;
        private Button Button_AddressLine;
        private Label Label_MiddleName;
        private Button Button_MiddleName;
        private Label Label_FirstName;
        private Button Button_FirstName;
        private Label Label_LastName;
        private Button Button_LastName;
        private Label Label_PhoneNumber;
        private Button Button_PhoneNumber;
        private Label Label_Email;
        private Button Button_Email;
    }
}
