using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv7
{
    [Serializable]
    public class Contact
    {
        private float weight;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                StateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool IsMerried { get; set; }

        [field: NonSerialized]
        public event EventHandler StateChanged;

        public override string ToString()
        {
            return Name + ";" + Age + ";" + Email + ";" + Weight + ";" + IsMerried;
        }
    }
}
