using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_Covid19.Modelleme
{
    public class Info
    {
        private string ad;
        private string il;
        private string ilce;
        private int yoneticiID;

        public string Ad { get => ad; set => ad = value; }
        public string Il { get => il; set => il = value; }
        public string Ilce { get => ilce; set => ilce = value; }
        public int YoneticiID { get => yoneticiID; set => yoneticiID = value; }
    }
}
