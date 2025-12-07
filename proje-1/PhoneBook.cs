using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje1
{
  public class PhoneBook
  {
    public List<Person> People { get; set; } = new List<Person>();

    public PhoneBook()
    {
      // Varsayılan 5 kişi
      People.Add(new Person("Mehmet Duran", "Kaya", "5551112233"));
      People.Add(new Person("Fatma", "Kaya", "5552223344"));
      People.Add(new Person("Nizamettin", "Kaya", "5553334455"));
      People.Add(new Person("Atahan", "Şahinbaş", "5554445566"));
      People.Add(new Person("İrem", "Şahinbaş", "5555556677"));
    }
  }
}
