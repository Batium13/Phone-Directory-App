using System.Collections.Generic;

namespace Telefon_Rehber_Uygulaması
{
    public class People
    {
        public List<Person> persons = new List<Person>();
        public void people()
        {
            persons.Add(new Person("Batuhan", "ALTINEL", "05321212121"));
            persons.Add(new Person("Sefa", "İŞLEK", "05331313131"));
            persons.Add(new Person("Semih", "ABACILAR", "053434343434"));
        }
    }



}
