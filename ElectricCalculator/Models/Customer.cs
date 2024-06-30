using ElectricCalculator.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCalculator.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Occupation { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string GenderText ()
        {
            string genderText = "";
            switch (this.Gender)
            {
                case (int)GenderEnum.Male:
                    genderText = "Male";
                    break;
                case (int)GenderEnum.Female:
                    genderText = "Female";
                    break;
                case (int)GenderEnum.Unknown:
                    genderText = "Unknown";
                    break;
                default: genderText = "Unknown"; break;

            }
            return genderText;
        }

        public string OccupationText()
        {
            string occupationText = "";
            switch (this.Occupation)
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
            return occupationText;
        }

        /// <summary>
        /// Convert Customer instance to a ListViewItem; therefore, it can added to the ListViewItem easily.
        /// </summary>
        /// <returns>string[] lstViewItem</returns>
        public string[] ToListViewItem()
        {
            string[] lstViewItem;
            lstViewItem = new string[] 
            {
                this.Name,
                this.GenderText(),
                this.DateOfBirth.ToShortDateString(),
                this.OccupationText()
            };
            return lstViewItem;
        }
    }
}
