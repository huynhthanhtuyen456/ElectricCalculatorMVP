using ElectricCalculator.Enums;

namespace ElectricCalculator.Forms
{
    partial class CustomerForm
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
            LblCustomerForm = new Label();
            LblName = new Label();
            LblDOB = new Label();
            LblGender = new Label();
            LblOccupation = new Label();
            TxbName = new TextBox();
            RadioBtnMale = new RadioButton();
            RadioBtnFemale = new RadioButton();
            RadioBtnUnknown = new RadioButton();
            ComboBoxOccupation = new ComboBox();
            PanelGender = new Panel();
            DatetimePickerDOB = new DateTimePicker();
            LstViewCustomers = new ListView();
            BtnSubmit = new Button();
            PanelGender.SuspendLayout();
            SuspendLayout();
            // 
            // LblCustomerForm
            // 
            LblCustomerForm.AutoSize = true;
            LblCustomerForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCustomerForm.Location = new Point(127, 48);
            LblCustomerForm.Name = "LblCustomerForm";
            LblCustomerForm.Size = new Size(164, 30);
            LblCustomerForm.TabIndex = 1;
            LblCustomerForm.Text = "Customer Form";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblName.Location = new Point(29, 94);
            LblName.Name = "LblName";
            LblName.Size = new Size(40, 15);
            LblName.TabIndex = 2;
            LblName.Text = "Name";
            // 
            // LblDOB
            // 
            LblDOB.AutoSize = true;
            LblDOB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDOB.Location = new Point(29, 136);
            LblDOB.Name = "LblDOB";
            LblDOB.Size = new Size(82, 15);
            LblDOB.TabIndex = 3;
            LblDOB.Text = "Date Of Birth";
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGender.Location = new Point(29, 186);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(49, 15);
            LblGender.TabIndex = 4;
            LblGender.Text = "Gender";
            // 
            // LblOccupation
            // 
            LblOccupation.AutoSize = true;
            LblOccupation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblOccupation.Location = new Point(29, 229);
            LblOccupation.Name = "LblOccupation";
            LblOccupation.Size = new Size(70, 15);
            LblOccupation.TabIndex = 5;
            LblOccupation.Text = "Occupation";
            // 
            // TxbName
            // 
            TxbName.Location = new Point(117, 91);
            TxbName.Name = "TxbName";
            TxbName.Size = new Size(215, 23);
            TxbName.TabIndex = 6;
            TxbName.TextChanged += TxbName_TextChanged;
            // 
            // RadioBtnMale
            // 
            RadioBtnMale.AutoSize = true;
            RadioBtnMale.Location = new Point(3, 8);
            RadioBtnMale.Name = "RadioBtnMale";
            RadioBtnMale.Size = new Size(51, 19);
            RadioBtnMale.TabIndex = 8;
            RadioBtnMale.TabStop = true;
            RadioBtnMale.Text = "Male";
            RadioBtnMale.UseVisualStyleBackColor = true;
            // 
            // RadioBtnFemale
            // 
            RadioBtnFemale.AutoSize = true;
            RadioBtnFemale.Location = new Point(60, 8);
            RadioBtnFemale.Name = "RadioBtnFemale";
            RadioBtnFemale.Size = new Size(63, 19);
            RadioBtnFemale.TabIndex = 9;
            RadioBtnFemale.TabStop = true;
            RadioBtnFemale.Text = "Female";
            RadioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // RadioBtnUnknown
            // 
            RadioBtnUnknown.AutoSize = true;
            RadioBtnUnknown.Location = new Point(129, 8);
            RadioBtnUnknown.Name = "RadioBtnUnknown";
            RadioBtnUnknown.Size = new Size(76, 19);
            RadioBtnUnknown.TabIndex = 10;
            RadioBtnUnknown.TabStop = true;
            RadioBtnUnknown.Text = "Unknown";
            RadioBtnUnknown.UseVisualStyleBackColor = true;
            // 
            // ComboBoxOccupation
            // 
            ComboBoxOccupation.FormattingEnabled = true;
            ComboBoxOccupation.Location = new Point(117, 226);
            ComboBoxOccupation.Name = "ComboBoxOccupation";
            ComboBoxOccupation.Size = new Size(215, 23);
            ComboBoxOccupation.TabIndex = 11;
            // 
            // PanelGender
            // 
            PanelGender.Controls.Add(RadioBtnMale);
            PanelGender.Controls.Add(RadioBtnFemale);
            PanelGender.Controls.Add(RadioBtnUnknown);
            PanelGender.Location = new Point(117, 175);
            PanelGender.Name = "PanelGender";
            PanelGender.Size = new Size(215, 36);
            PanelGender.TabIndex = 12;
            // 
            // DatetimePickerDOB
            // 
            DatetimePickerDOB.Location = new Point(117, 130);
            DatetimePickerDOB.Name = "DatetimePickerDOB";
            DatetimePickerDOB.Size = new Size(215, 23);
            DatetimePickerDOB.TabIndex = 13;
            // 
            // LstViewCustomers
            // 
            LstViewCustomers.FullRowSelect = true;
            LstViewCustomers.GridLines = true;
            LstViewCustomers.Location = new Point(463, 12);
            LstViewCustomers.Name = "LstViewCustomers";
            LstViewCustomers.Size = new Size(325, 426);
            LstViewCustomers.TabIndex = 14;
            LstViewCustomers.UseCompatibleStateImageBehavior = false;
            LstViewCustomers.View = View.Details;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(117, 279);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(215, 23);
            BtnSubmit.TabIndex = 15;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSubmit);
            Controls.Add(LstViewCustomers);
            Controls.Add(DatetimePickerDOB);
            Controls.Add(PanelGender);
            Controls.Add(ComboBoxOccupation);
            Controls.Add(TxbName);
            Controls.Add(LblOccupation);
            Controls.Add(LblGender);
            Controls.Add(LblDOB);
            Controls.Add(LblName);
            Controls.Add(LblCustomerForm);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            PanelGender.ResumeLayout(false);
            PanelGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblCustomerForm;
        private Label LblName;
        private Label LblDOB;
        private Label LblGender;
        private Label LblOccupation;
        private TextBox TxbName;
        private RadioButton RadioBtnMale;
        private RadioButton RadioBtnFemale;
        private RadioButton RadioBtnUnknown;
        private ComboBox ComboBoxOccupation;
        private Panel PanelGender;
        private DateTimePicker DatetimePickerDOB;
        private ListView LstViewCustomers;
        private Button BtnSubmit;
    }
}