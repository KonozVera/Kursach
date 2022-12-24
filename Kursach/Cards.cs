using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Kursach
{
    [Serializable]
    class Cards
    {
        private string number;
        private List<Recordings> recording;
        public Cards(string number, List<Recordings> recording) 
        {
            this.number = number;
            this.recording = recording;
        }

        public Cards(string number)
        {
            this.number = number;
            recording = new List<Recordings>();
        }

        public List<Recordings> Recordings
        {
            get { return recording; }
            set { recording = value; }
        }

        public string Number
        {
            get { return number; }
        }

        public override string ToString()
        {
            return string.Format("Запись: {0}", recording);
        }
    }
}