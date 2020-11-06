using System;
using System.Collections.Generic;
using System.Text;

namespace BlomsterSortTusindFryd
{
    public class Repository
    {
        public List<BlomsterSort> blomster = new List<BlomsterSort>()
        {
            new BlomsterSort("Tusindfryd", "den ligger her", 10, 10, 10),
            new BlomsterSort("Lilje","Herovre", 11,11,11),
            new BlomsterSort("Rose","Måske der", 12,12,12),

        };

        public void AddFlower(BlomsterSort flower)
        {
            blomster.Add(flower);
        }

        public BlomsterSort GetFlower(string name)
        {
            for (int i = 0; i < blomster.Count; i++)
            {
                if (blomster[i].Name == name)
                {
                    return blomster[i];
                }
            }
            return null;
        }

        public void UpdateFlower(BlomsterSort flower)
        {
            for (int i = 0; i < blomster.Count; i++)
            {
                if (blomster[i].Name == flower.Name)
                {
                    blomster[i] = flower;
                }
            }
        }

        public void DeleteFlower(BlomsterSort flower)
        {
            blomster.Remove(flower);
        }

    }
}
