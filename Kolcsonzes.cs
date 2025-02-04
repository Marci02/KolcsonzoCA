using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoCA
{
    internal class Kolcsonzes
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public int PeopleCount { get; set; }
        public int TakeOutHour { get; set; }
        public int TakeOutMinute { get; set; }
        public int ReturnHour { get; set; }
        public int ReturnMinute { get; set; }

        public Kolcsonzes(string sor)
        {
            var v = sor.Split(';');
            Name = v[0];
            Id = int.Parse(v[1]);
            Type = v[2];
            PeopleCount = int.Parse(v[3]);
            TakeOutHour = int.Parse(v[4]);
            TakeOutMinute = int.Parse(v[5]);
            ReturnHour = int.Parse(v[6]);
            ReturnMinute = int.Parse(v[7]);
        }
    }
}
