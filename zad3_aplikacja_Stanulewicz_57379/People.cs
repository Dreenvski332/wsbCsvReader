using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace zad3_aplikacja_Stanulewicz_57379
{
    public class People
    {
        [Name("Index")]
        public int userIndex { get; set; }

        [Name("User Id")]
        public string userId { get; set; }

        [Name("First Name")]
        public string userFirstName { get; set; }

        [Name("Last Name")]
        public string userLastName { get; set; }

        [Name("Sex")]
        public string userSex { get; set; }

        [Name("Email")]
        public string userEmail { get; set; }

        [Name("Phone")]
        public string userPhone { get; set; }

        [Name("Date of birth")]
        public DateTime userBirthday { get; set; }

        [Name("Job Title")]
        public string userJobTitle { get; set; }
    }
}
