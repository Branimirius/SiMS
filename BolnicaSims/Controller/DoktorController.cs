using BolnicaSims.DTO;
using BolnicaSims.Model;
using BolnicaSims.Service;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BolnicaSims.Controller
{
    class DoktorController
    {
        private static DoktorController instance = null;
        public static DoktorController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoktorController();
                }
                return instance;
            }
        }

        public void dodajDoktora(String username, String password, String ime, String prezime, String jmbg, String adresa, String telefon, Boolean specijalista, Boolean hirurg, DateTime datumRodjenja, String email, String specijalizacija)
        {
            DoktorService.Instance.dodajDoktora(username, password, ime, prezime, jmbg, adresa, telefon, specijalista, hirurg, datumRodjenja, email, specijalizacija);
        }
        public void izmeniDoktora(DoktorDTO doktor)
        {
            DoktorService.Instance.izmeniDoktora(doktor);
        }
        public Doktor GetDoktor(Korisnik korisnik)
        {
            return DoktorService.Instance.getKorisnikDoktor(korisnik);
        }
        public void dodajLekValidacija(Lek lek, ObservableCollection<Doktor> doktori)
        {
            DoktorService.Instance.dodajNevalidanLek(lek, doktori);
        }
        public ObservableCollection<Doktor> getDoktori()
        {
            return DoktorService.Instance.getDoktori();
        }
        public ObservableCollection<String> getDoktoriImena()
        {
            return DoktorService.Instance.getDoktoriImena();
        }
        public ObservableCollection<String> getDoktoriAnketa()
        {
            return DoktorService.Instance.getDoktoriAnketa();
        }
        public ObservableCollection<Doktor> getSpecijalisti()
        {
            return DoktorService.Instance.getSpecijalisti();
        }
        public Doktor getSelektovaniDoktor()
        {
            return DoktorService.Instance.getSelektovaniDoktor();
        }
        public void setSelektovaniDoktor(Doktor doktor)
        {
            DoktorService.Instance.setSelektovaniDoktor(doktor);
        }

        public void searchTermini(DateTime vreme)
        {
            DoktorService.Instance.searchTermini(vreme);
        }
    }    
}
