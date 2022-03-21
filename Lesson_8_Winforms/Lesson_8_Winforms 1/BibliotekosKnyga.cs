using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Winforms_1
{
    internal struct BibliotekosKnyga
    {
        public int ID;
        public string ReaderName;
        public DateTime DateTaken;

        public BibliotekosKnyga(int id, string readername,DateTime datetaken)
        {
            ID = id;
            ReaderName = readername;
            DateTaken = datetaken;
        }

        public int CalculateDays()
        {
            return (DateTime.Now - DateTaken).Days;        
        }
    }
}
