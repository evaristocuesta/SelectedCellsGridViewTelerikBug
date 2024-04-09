using System;
using System.Globalization;

namespace SelectedCellsGridViewTelerikBug.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Age => double.PositiveInfinity;
        public bool Married { get; set; }

        public string this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        Id = int.Parse(value);
                        break;
                    case 1:
                        Name = value;
                        break;
                    case 2:
                        Surname = value;
                        break;
                    case 3:
                        Birthday = DateTime.Parse(value, new CultureInfo("en-US"));
                        break;
                    case 4:
                        break;
                    case 5:
                        Married = bool.Parse(value);
                        break;
                    default: 
                        break;
                }
            }

            get
            {
                switch (i)
                {
                    case 0: return Id.ToString();
                    case 1: return Name;
                    case 2: return Surname;
                    case 3: return Birthday.ToShortDateString();
                    case 4: return Age.ToString();
                    case 5: return Married.ToString();
                    default: return string.Empty;
                }
            }
        }
    }
}
