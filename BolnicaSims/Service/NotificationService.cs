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
        public void handleNotificationsAddTermin(Korisnik korisnik, Termin tempTermin)
        {
            switch (korisnik.Zvanje)
            {
                case "Pacijent":
                    sendAppointmentNotification("Zakazan termin", tempTermin.ImePrezimePacijenta, "Zakazan je termin kod doktora" + tempTermin.ImePrezimeDoktora, tempTermin);
                    break;
                case "Sekretar":
                    sendAppointmentNotification("Zakazan termin", "Sekretar", "Zakazan je termin", tempTermin);
                    break;
                case "Doktor":
                    sendAppointmentNotification("Zakazan termin", tempTermin.ImePrezimeDoktora, "Zakazan je termin kod pacijenta" + tempTermin.ImePrezimePacijenta, tempTermin);
                    break;
            }
        }
        public void handleNotificationsRemoveTermin(Korisnik korisnik, Termin tempTermin)
        {
            switch (korisnik.Zvanje)
            {
                case "Pacijent":
                    sendAppointmentNotification("Otkazan termin", tempTermin.ImePrezimePacijenta, "Otkazan je termin kod doktora" + tempTermin.ImePrezimeDoktora, tempTermin);
                    break;
                case "Sekretar":
                    sendAppointmentNotification("Otkazan termin", "Sekretar", "Otkazan je termin", tempTermin);
                    break;
                case "Doktor":
                    sendAppointmentNotification("Otkazan termin", tempTermin.ImePrezimeDoktora, "Otkazan je termin kod pacijenta" + tempTermin.ImePrezimePacijenta, tempTermin);
                    break;
            }
        }
        public void handleNotificationsUpdateTermin(Korisnik korisnik, Termin tempTermin)
        {
            switch (korisnik.Zvanje)
            {
                case "Pacijent":
                    sendAppointmentNotification("Izmenjen termin", tempTermin.ImePrezimePacijenta, "Izmenjen je termin kod doktora" + tempTermin.ImePrezimeDoktora, tempTermin);
                    break;
                case "Sekretar":
                    sendAppointmentNotification("Izmenjen termin", "Sekretar", "Izmenjen je termin", tempTermin);
                    break;
                case "Doktor":
                    sendAppointmentNotification("Izmenjen termin", tempTermin.ImePrezimeDoktora, "Izmenjen je termin kod pacijenta" + tempTermin.ImePrezimePacijenta, tempTermin);
                    break;
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
