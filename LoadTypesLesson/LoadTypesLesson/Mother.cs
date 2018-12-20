using System.Collections.Generic;

namespace LoadTypesLesson
{
    public class Mother : Entity
    {
       public string Name { get; set; }
       public string EyesColor { get; set; }
       public int Age { get; set; }
       public double Weight { get; set; }
       public bool IsFat { get; set; }
       virtual public ICollection<Son> Items { get; set; } = new List<Son>();        
    }
}
