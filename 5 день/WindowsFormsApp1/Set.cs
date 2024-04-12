using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Set
    {
        private HashSet<string> elements;

        public Owner OwnerInfo { get; private set; }
        public Date CreationDate { get; private set; }

        public Set(Owner owner, Date creationDate)
        {
            elements = new HashSet<string>();
            OwnerInfo = owner;
            CreationDate = creationDate;
        }

        public void Add(string item)
        {
            elements.Add(item);
        }

        public bool Contains(string item)
        {
            return elements.Contains(item);
        }

        public void Remove(string item)
        {
            elements.Remove(item);
        }

        public bool IsSubsetOf(Set otherSet)
        {
            return elements.IsSubsetOf(otherSet.elements);
        }

        public static bool operator ==(Set set1, Set set2)
        {
            if (ReferenceEquals(set1, set2))
                return true;

            if (set1 is null || set2 is null)
                return false;

            return set1.elements.SetEquals(set2.elements);
        }

        public static bool operator !=(Set set1, Set set2)
        {
            return !(set1 == set2);
        }

        public static Set operator +(Set set, string item)
        {
            set.Add(item);
            return set;
        }


        public static Set operator -(Set set, string item)
        {
            set.Remove(item);
            return set;
        }

        public static Set operator %(Set set1, Set set2)
        {
            Set intersection = new Set(set1.OwnerInfo, set1.CreationDate);
            foreach (string item in set1.elements)
            {
                if (set2.Contains(item))
                    intersection.Add(item);
            }
            return intersection;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Set otherSet = (Set)obj;

            return elements.SetEquals(otherSet.elements);
        }

        public override int GetHashCode()
        {
            return elements.GetHashCode();
        }

        public string FindShortestWord()
        {
            string shortestWord = null;
            foreach (string item in elements)
            {
                if (shortestWord == null || item.Length < shortestWord.Length)
                    shortestWord = item;
            }

            return shortestWord;
        }

        public IEnumerable<string> Sort()
        {
            return elements.OrderBy(item => item);
        }

        public override string ToString()
        {
            string ownerInfo = $"Owner: {OwnerInfo.Name}, Organization: {OwnerInfo.Organization}";
            string creationDate = $"Creation Date: {CreationDate.Day}/{CreationDate.Month}/{CreationDate.Year}";
            string elements = string.Join(", ", Sort());

            return $"{ownerInfo}\n{creationDate}\nElements: {elements}";
        }

        public class Owner
        {
            public int Id { get; private set; }
            public string Name { get; private set; }
            public string Organization { get; private set; }

            public Owner(int id, string name, string organization)
            {
                Id = id;
                Name = name;
                Organization = organization;
            }
        }

        public class Date
        {
            public int Day { get; private set; }
            public int Month { get; private set; }
            public int Year { get; private set; }

            public Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }
    }
}
