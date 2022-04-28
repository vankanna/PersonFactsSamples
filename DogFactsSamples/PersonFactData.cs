using System;
using System.Collections.Generic;


namespace DogFactsSamples
{
    public class PersonFactData 
    {
        public PersonFactData()
        {
        }

        public static IEnumerable<PersonFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Image { get; set; }
        static PersonFactData()
        {
            List<PersonFactData> all = new List<PersonFactData>();
            all.Add(new PersonFactData() { TheFact = "Notebook", ShortFact = "Favorite movie", Image = "notebook.jpg" });
            all.Add(new PersonFactData() { TheFact = "Hiking", ShortFact = "hobby", Image = "mountain.jpg" });
            all.Add(new PersonFactData() { TheFact = "Green", ShortFact = "Favorite color", Image = "green.jpg" });
            all.Add(new PersonFactData() { TheFact = "Korean Food", ShortFact = "Favorite food", Image = "food.jpg" });
            all.Add(new PersonFactData() { TheFact = "BTS", ShortFact = "Favorite idol", Image = "bts.jpg" });
            All = all;

        }
    }
    
}