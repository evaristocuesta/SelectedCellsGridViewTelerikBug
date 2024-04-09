using SelectedCellsGridViewTelerikBug.Models;
using System.Collections.Generic;
using System;

namespace SelectedCellsGridViewTelerikBug
{
    internal static class Seeder
    {
        public static IEnumerable<Person> GetPeople(int num)
        {
            for (int i = 0; i < num; i++)
            {
                var person = new Person
                {
                    Id = i,
                    Name = $"Name {i}",
                    Surname = $"Surname {i}",
                    Birthday = new System.DateTime(1900 + i % 100, 1 + i % 12, 1 + i % 28, 0, 0, 0, DateTimeKind.Local),
                    Married = i % 2 == 0
                };

                yield return person;
            }
        }
    }
}
