using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp3.Models
{
    public class Repository
    {

        public static IEnumerable<Person> SearchPeople(List<Person> people,  string termFirstName, string termSurname)
        {
            return people.Where(person =>
                person.FirstName.Contains(termFirstName, StringComparison.InvariantCultureIgnoreCase) ||
                person.Surname.Contains(termSurname, StringComparison.InvariantCultureIgnoreCase));
        }

        //public static Person SearchPerson(List<Person> people, int id)
        //{
        //    var PersonObject = new Person();
        //    foreach (var match in people)
        //    {
        //        if (match.Id == id) { PersonObject = people[match.Id]; }
        //    }
        //    return PersonObject;
        //}

        //public static string PersonFullName(List<Person> people, string id)
        //{
        //    var person = SearchPerson(people, Parsing.StringToInt(id)[0]);
        //    return $"{person.FirstName} {person.Surname}";
        //}

        public static string UpdatePerson(List<Person> people, Person person, Person updated)
        {
            return new Func<String>(() =>
            {
                if (CheckContactExistence(people, person))
                {
                    people.Remove(person);
                    people.Add(updated);
                    return $"Contact updated successfully.\nOld data:\n {person.FirstName} " +
                           $"{person.Surname} | Birthday: {person.Birthday}" +
                           $"\nNew data:\n {updated.FirstName} {updated.Surname} " +
                           $"| Birthday: {updated.Birthday}";
                }
                else
                {
                    return "Person doesn't exists.";
                }
            })();
        }

        public static string DeletePerson(List<Person> people, Person person)
        {
            return new Func<String>(() =>
            {
                if (CheckContactExistence(people, person))
                {
                    people.Remove(person);
                    return $"{person.FirstName} {person.Surname} successfully deleted.";
                }
                else
                {
                    return "Person added.";
                }
            })();
        }

        private static Boolean CheckContactExistence(List<Person> people, Person person)
        {
            return new Func<Boolean>(() =>
            {
                foreach (var match in people)
                {
                    if (match.FirstName.Equals(person.FirstName)
                        && match.Surname.Equals(person.Surname)
                        && match.Birthday.Equals(person.Birthday))
                    {
                        return true;
                    }
                }
                return false;
            })();
        }
    }
}
