using System;
using System.Collections.Generic;
using System.Text;

namespace BlomsterSortTusindFryd
{
    class Controller
    {
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Controller();

                return _instance;
            }
            set
            {

            }
        }
        private Controller()
        {

        }

        
        public Repository repo = new Repository();


        public void UpdateFlowerInformation(string name, string picturepath, int produktionstid, int halveringstid, int størrelse)
        {
            BlomsterSort b1 = new BlomsterSort(name, picturepath, produktionstid, halveringstid,størrelse);

            repo.UpdateFlower(b1);
        }
     

    }
}
