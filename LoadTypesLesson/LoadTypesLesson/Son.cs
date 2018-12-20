using System.Collections.Generic;

namespace LoadTypesLesson
{
    public class Son : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFoster { get; set; } // типа приемный или нет
        public string SchoolName { get; set; }
        virtual public ICollection<Mother> Carts { get; set; } = new List<Mother>();
    }
}
