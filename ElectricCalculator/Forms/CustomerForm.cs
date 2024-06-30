using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ElectricCalculator.Enums;
using ElectricCalculator.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ElectricCalculator.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly string NameRgxPattern = @"^[A-Za-z\s]+$";
        private readonly string ConnectionString = "Server=TUYENHUYNH\\MSSQLSERVER, 1433;" +
                                                    "Database=ElectricCalculator;" +
                                                    "User ID=electricalculator;" +
                                                    " Password=changeme;" +
                                                    " TrustServerCertificate=True;" +
                                                    "Trusted_Connection=False;" +
                                                    "MultipleActiveResultSets=true";
        public CustomerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fetch the list of customers from DB and add to ListView
        /// </summary>
        private void LoadCustomersFromDB()
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                connection.Open();
                string querySelect = "SELECT Id, Name, Gender, Occupation, DateOfBirth FROM CUSTOMER;";
                SqlCommand command = new SqlCommand(querySelect, connection);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Customer customer = new Customer
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Gender = (byte)reader[2],
                            Occupation = (byte)reader[3],
                            DateOfBirth = reader.GetDateTime(4),
                        };
                        ListViewItem customerListViewItem = new ListViewItem(customer.ToListViewItem());
                        customerListViewItem.Font = new Font(customerListViewItem.Font, FontStyle.Regular);
                        this.LstViewCustomers.Items.Add(customerListViewItem);
                        this.LstViewCustomers.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                        this.LstViewCustomers.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                        this.LstViewCustomers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                        this.LstViewCustomers.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                    reader.Close();
                    command.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cannot fetch list of customers from DB: {ex}");
                }
            }
        }

        private bool InsertCustomer2DB(string name, int gender, int occupation, DateTime dateOfBirth)
        {
            bool isOk = false;
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                connection.Open();
                string queryInsert = "INSERT INTO Customer(Name, Gender, Occupation, DateOfBirth) VALUES(@name, @gender, @occupation, @dateOfBirth)";
                SqlCommand command = new SqlCommand(queryInsert, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@occupation", occupation);
                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                try
                {
                    command.ExecuteNonQuery();
                    command.Dispose();
                    isOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cannot insert data to DB: {ex}");
                }
            }
                return isOk;
        }

        /// <summary>
        /// Reset Form data.
        /// </summary>
        private void ResetForm ()
        {
            TxbName.Text = "";
            DatetimePickerDOB.Value = DateTime.Now;
            RadioBtnFemale.Checked = false;
            RadioBtnMale.Checked = false;
            RadioBtnUnknown.Checked = false;
            ComboBoxOccupation.SelectedIndex = 0;

        }

        /// <summary>
        /// Handle button click event of Customer Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //=== Step 1: Validate Data (Homework) ===//
            //=== Step 2: Get Data from Customer Form ===//
            string name = TxbName.Text.Trim();
            DateTime dob = DatetimePickerDOB.Value;
            var checkedButtonGender =  PanelGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButtonGender == null) {
                MessageBox.Show("You need to choose your gender!"); 
                return; 
            }
            int genderVal = 0;
            string genderText = checkedButtonGender.Text;
            switch (genderText)
            {
                case "Male":
                    genderVal = (int)GenderEnum.Male;
                    break;
                case "Female":
                    genderVal = (int)GenderEnum.Female;
                    break;
                case "Unknown":
                    genderVal = (int)GenderEnum.Unknown;
                    break;
                default: genderVal = 0; break;

            }
            int occupation = ComboBoxOccupation.SelectedIndex;
            //=== Step 3: Insert into Database ===//
            this.InsertCustomer2DB(name, genderVal, occupation, dob);
            //=== Step 4: Announcement + Clear Customer Form ===//
            MessageBox.Show($"Successfully Inserted Customer to DB!");
            List<string> stringList = new List<string>(name.Split(" "));
            List<string> formattedNameList = new List<string>();
            foreach (string s in stringList)
            {
                s.ToLower();
                string newS = char.ToUpper(s.First()) + s.Substring(1).ToLower();
                formattedNameList.Add(newS);
            }

            string formattedName = string.Join(" ", formattedNameList);
            string occupationText = "";
            switch (occupation)
            {
                case (int)OccupationEnum.Student:
                    occupationText = "Student";
                    break;
                case (int)OccupationEnum.Teacher:
                    occupationText = "Teacher";
                    break;
                case (int)OccupationEnum.Plumber:
                    occupationText = "Plumber";
                    break;
                case (int)OccupationEnum.Homeless:
                    occupationText = "Homeless";
                    break;
                case (int)OccupationEnum.LuckyStudent:
                    occupationText = "LuckyStudent";
                    break;
                default: occupationText = "Unknown"; break;

            }
            ListViewItem customerListViewItem = new ListViewItem(
                new string[]
                {
                        formattedName.ToString(),
                        genderText.ToString(),
                        dob.ToShortDateString(),
                        occupationText,
                }
            );
            customerListViewItem.Font = new Font(customerListViewItem.Font, FontStyle.Regular);
            this.LstViewCustomers.Items.Add(customerListViewItem);
            this.LstViewCustomers.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.LstViewCustomers.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.LstViewCustomers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.LstViewCustomers.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.ResetForm();
        }

        private bool IsValidName(string name)
        {
            Regex nameRegex = new(this.NameRgxPattern);
            return true && nameRegex.IsMatch(name);
        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load CustomerForm and Customer data to ListView on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.ComboBoxOccupation.DataSource = Enum.GetValues(typeof(OccupationEnum));
            this.LstViewCustomers.Columns.Add("Name");
            this.LstViewCustomers.Columns.Add("Gender");
            this.LstViewCustomers.Columns.Add("Date Of Birth");
            this.LstViewCustomers.Columns.Add("Occupation");
            this.LstViewCustomers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.LstViewCustomers.Font = new Font(LstViewCustomers.Font, FontStyle.Bold);
            this.LoadCustomersFromDB();
        }
    }
}
