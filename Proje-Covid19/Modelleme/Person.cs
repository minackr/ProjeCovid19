using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_Covid19
{
    public class Person
    {
        private string ad;
        private string soyad;
        private string email;
        private string cinsiyet;
        private string sifre;
        private string tc;

        public string Ad { get { return ad; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Ad bilgisi girilmemiş.");
                }
                ad = value;
            }

        }
        public string Soyad { get { return soyad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Soyad bilgisi girilmemiş.");
                }
                soyad = value;
            }
        }
        public string Email { get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Email bilgisi girilmemiş.");
                }
                email = value;
            }
        }
        public string Cinsiyet { get { return cinsiyet; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Cinsiyet bilgisi girilmemiş.");
                }
                cinsiyet = value;
            }
        }
        public string Sifre { get { return sifre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Sifre bilgisi girilmemiş.");
                }
                sifre = value;
            }
        }
        public string TC { get { return tc; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("TC. bilgisi girilmemiş.");
                }
                tc = value;
            }
        }

        public virtual Person Login(string email, string sifre)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}