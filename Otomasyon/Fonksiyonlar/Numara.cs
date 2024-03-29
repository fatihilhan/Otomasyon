﻿using System;
using System.Linq;

namespace Otomasyon.Fonksiyonlar
{
    class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();

        public string StokKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_STOKLAR
                                        orderby s.ID descending
                                        select s).First().STOKKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

        public string CariKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_CARILER
                                        orderby s.ID descending
                                        select s).First().CARIKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

        public string KasaKodNumarası()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_KASALAR
                                        orderby s.ID descending
                                        select s).First().KASAKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

    }
}
