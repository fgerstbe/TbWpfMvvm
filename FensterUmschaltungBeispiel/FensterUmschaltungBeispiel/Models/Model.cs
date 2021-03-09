using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.Models
{
  public class Model
  {
    public List<Person> Mitarbeiter { get; set; }
    public List<string> Orte { get; set; } = new List<string> { "Wien", "Berlin", "Oslo" };

    public Model()
    {
      Mitarbeiter = new List<Person> { new Person { Name = "Müller", Wohnort = "Köln" }, new Person { Name = "Meier", Wohnort = "Hamburg" } };
    }
  }
}
