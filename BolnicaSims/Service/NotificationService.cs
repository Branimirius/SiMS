using BolnicaSims.Model;
using BolnicaSims.Storage;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BolnicaSims.Service
{
    class NotificationService
    {
        private static NotificationService instance = null;
        public static NotificationService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationService();
                }
                return instance;
            }
        }

        public void sendAppointmentNotification(String title, String sender, String text, Termin termin)
        {
            Notifikacija n1 = new Notifikacija(title, sender, text);
            if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Pacijent")
            {               
                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if (k.Zvanje == "Sekretar")
                    {
                        k.Notifikacije.Add(n1);
                    }
                    if ((k.Ime + " " + k.Prezime) == termin.ImePrezimeDoktora)
                    {
                        k.Notifikacije.Add(n1);
                    }
                }
            }
            else if (KorisniciStorage.Instance.ulogovaniKorisnik.Zvanje == "Sekretar")
            {
               // Notifikacija n1 = new Notifikacija(title, sender, text);

                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if ((k.Ime + " " + k.Prezime) == termin.ImePrezimePacijenta)
                    {
                        k.Notifikacije.Add(n1);
                    }
                    if ((k.Ime + " " + k.Prezime) == termin.ImePrezimeDoktora)
                    {
                        k.Notifikacije.Add(n1);
                    }
                }

            }
            else
            {
                //Notifikacija n1 = new Notifikacija(title, sender, text);

                foreach (Korisnik k in KorisniciStorage.Instance.korisnici)
                {
                    if ((k.Ime + " " + k.Prezime) == termin.ImePrezimePacijenta)
                    {
                        k.Notifikacije.Add(n1);
                    }
                    if (k.Zvanje == "Sekretar")
                    {
                        k.Notifikacije.Add(n1);
                    }
                }

            }
        }



    }
}
