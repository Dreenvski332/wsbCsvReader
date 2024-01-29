using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zad3_aplikacja_Stanulewicz_57379
{
    public partial class f2_Body : Form
    {
        public f2_Body()
        {
            InitializeComponent();
        }
        private void AnalizeOneTextbox_Click(object sender, EventArgs e)//FIRST button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Numery telefonów kobiet";

            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {
                var values = from line in streamReader.ReadToEnd().Split('\n')
                             let data = line.Split(',')
                             where data.Length > 8
                             where data[4] == "Female"
                             select $"{data[2]} {data[3]}, {data[6]}"; // Select the second value

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\1.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeTwoTextbox_Click(object sender, EventArgs e)//SECOND button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Numery telefonów mężczyzn";//equality :)

            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {
                var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                             let data = line.Split(',')//splits data by ,
                             where data.Length > 8
                             where data[4] == "Male"//finds data, where "Sex" is set as "Male"
                             select $"{data[2]} {data[3]}, {data[6]}"; //selects first name, last name and phone number

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\2.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeThreeTextbox_Click(object sender, EventArgs e)//THIRD button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Ile jest Jacqueline";

            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {
                var values = (from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                              let data = line.Split(',')//splits data by ,
                              where data.Length > 8
                              where data[2] == "Jacqueline"//finds data, where name is set to "Jacqueline"
                              select line).Count();//counts said data

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }


            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\3.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeFourTextbox_Click(object sender, EventArgs e)//FOURTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "W razie problemów ;)";

            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {
                var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                             let data = line.Split(',')//splits data by ,
                             where data.Length > 8
                             where data[0] == "9"//finds data, where index is set to 9
                             select $"{data[2]} {data[3]}, {data[5]}, {data[6]}, {data[8]}"; //selects first name, last name, email, phone number and proffesion

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\4.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeFiveTextbox_Click(object sender, EventArgs e)//FIFTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Urodzeni po 2000";

            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {

                DateTime startDate = new DateTime(2000, 1, 1);
                var lines = File.ReadAllLines(csvPath);
                var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                             let data = line.Split(',')//splits data by ,
                             where data.Length > 8
                             where DateTime.TryParse(data[7], out var date) && date > startDate
                             select $"{data[2]} {data[3]}, {data[7]}"; //selects first name, last name, email, phone number and proffesion

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\5.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeSixTextbox_Click(object sender, EventArgs e)//SIXTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Ile urodzonych przed 2000";

            //sets path to a CSV file
            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {
                DateTime startDate = new DateTime(2000, 1, 1);
                var lines = File.ReadAllLines(csvPath);
                var values = (from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                             let data = line.Split(',')//splits data by ,
                             where data.Length > 8
                             where DateTime.TryParse(data[7], out var date) && date < startDate
                             select line).Count(); //selects first name, last name, email, phone number and proffesion
                             

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\6.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeSevenTextbox_Click(object sender, EventArgs e)//SEVENTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Wyszukaj osoby po imieniu";

            if (String.IsNullOrEmpty(inputTextbox.Text))
            {
                MessageBox.Show("Wpisz dane do textboxa");
            }
            else
            {
                string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
                using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
                {
                    string inputValue = inputTextbox.Text;
                    var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                                 let data = line.Split(',')//splits data by ,
                                 where data.Length > 8
                                 where data[2] == inputValue//finds data, where name is same as one inputted by user
                                 select $"{data[2]} {data[3]}, {data[6]}"; //selects first name, last name, email, phone number and proffesion

                    string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                    outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
                }

                //saves time and date + displays it into corresponding textbox
                DateTime currentDateTime = DateTime.Now;
                dateTextbox.Text = currentDateTime.ToString();

                string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\7.txt";
                using (StreamWriter writer = new StreamWriter(historySavePath))
                {
                    writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
                }
            }
        }

        private void AnalizeEightTextbox_Click(object sender, EventArgs e)//EIGHTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Osoby z imieniem na A";

            string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
            using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
            {
                string inputValue = inputTextbox.Text;
                var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                             let data = line.Split(',')//splits data by ,
                             where data.Length > 8
                             where data[2].StartsWith("A")//finds data, where name is same as one inputted by user
                             select $"{data[2]} {data[3]}, {data[6]}"; //selects first name, last name, email, phone number and proffesion

                string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\8.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeNineTextbox_Click(object sender, EventArgs e)//NINTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Zakończenie maila";

            string inputValue = inputTextbox.Text;
            if (inputValue == "net" || inputValue == "com" || inputValue == "org")
            {
                string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
                using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
                {
                    var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                                 let data = line.Split(',')//splits data by ,
                                 where data.Length > 8
                                 where data[5].EndsWith(inputValue)//finds data, where name is same as one inputted by user
                                 select $"{data[2]} {data[3]}, {data[5]}"; //selects first name, last name, email, phone number and proffesion

                    string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                    outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
                }
            }
            else
            {
                MessageBox.Show("Maile mogą kończyć się wyłącznie na 'net', 'com' lub ' org'");
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            dateTextbox.Text = currentDateTime.ToString();

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\9.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void AnalizeTenTextbox_Click(object sender, EventArgs e)//TENTH button
        {
            //clears outputTextbox and sets displayAnalizeNameTextbox
            outputTextbox.Text = String.Empty;
            displayAnalizeNameTextbox.Text = "Wyszukaj po dacie";
            if (String.IsNullOrEmpty(inputTextbox.Text) || !inputTextbox.Text.Contains("-"))
            {
                MessageBox.Show("Wpisz poprawną datę");
            }
            else if(inputTextbox.Text.Contains("-"))
            {
                try
                {
                    string inputValue = inputTextbox.Text;
                    DateTime inputDatetime = DateTime.Parse(inputValue);
                    string csvPath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\people.csv";//sets path to a CSV file
                    using (StreamReader streamReader = new StreamReader(csvPath))//reads said file from start to finish
                    {
                        var lines = File.ReadAllLines(csvPath);
                        var values = from line in streamReader.ReadToEnd().Split('\n').Skip(1)//reads CSV file for LINQ, while splitting it on every \n and skips header line
                                     let data = line.Split(',')//splits data by ,
                                     where data.Length > 8
                                     where DateTime.TryParse(data[7], out var date) && date == inputDatetime
                                     select $"{data[2]} {data[3]}, {data[7]}"; //selects first name, last name, email, phone number and proffesion


                        string textboxAdjusted = string.Join(Environment.NewLine, values);//makes data displayable in textbox, with it only first line gets displayed + converts to string
                        outputTextbox.Text = textboxAdjusted;//finally displays data in a textbox
                    }
                }
                catch
                {
                    MessageBox.Show("Data niepoprawna");
                }
                
            }

            //saves time and date + displays it into corresponding textbox
            DateTime currentDateTime = DateTime.Now;
            string currentDateTimeString = currentDateTime.ToString();
            dateTextbox.Text = currentDateTimeString;

            string historySavePath = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad3_aplikacja_Stanulewicz_57379\history\10.txt";
            using (StreamWriter writer = new StreamWriter(historySavePath))
            {
                writer.Write(outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //saves outputTextbox and dateTextbox into one .txt file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Analiza.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, outputTextbox.Text + "\n" + dateTextbox.Text);
            }
        }
    }
}
