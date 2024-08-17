using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeTask3
{
    public class Phonebook
    {
        private static readonly Lazy<Phonebook> instance = new Lazy<Phonebook>(() => new Phonebook());
        private readonly List<Abonent> abonents;
        private readonly string filePath = "phonebook.txt";

        private Phonebook()
        {
            abonents = new List<Abonent>();
            LoadFromFile();
        }

        public static Phonebook Instance => instance.Value;

        public bool AddAbonent(Abonent abonent)
        {
            if (abonents.Any(a => a.Equals(abonent) && a.Name == abonent.Name))
            {
                return false;
            }
            abonents.Add(abonent);
            SaveToFile();
            return true;
        }

        public bool DeleteAbonent(string phoneNumber)
        {
            var abonent = abonents.FirstOrDefault(a => a.PhoneNumber == phoneNumber);
            if (abonent != null)
            {
                abonents.Remove(abonent);
                SaveToFile();
                return true;
            }
            return false;
        }

        public Abonent GetAbonentPhoneNumber(string phoneNumber)
        {
            return abonents.FirstOrDefault(a => a.PhoneNumber == phoneNumber);
        }

        public string GetPhoneNumber(string name)
        {
            var abonent = abonents.FirstOrDefault(a => a.Name == name);
            return abonent?.PhoneNumber;
        }

        private void LoadFromFile()
        {
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    abonents.Add(new Abonent(parts[0], parts[1]));
                }
            }
        }

        private void SaveToFile()
        {
            var lines = abonents.Select(a => $"{a.Name},{a.PhoneNumber}");
            File.WriteAllLines(filePath, lines);
        }





    }
}
