using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13042016_week7
{
    public class KartDestesi
    {
        private Kart[] deste; 
        private int mevcutKart; 
        private const int KART_SAYISI = 52; 
        private Random rastgeleSayilar; 

         public KartDestesi()
         {
            string[] yuzler = { "As", "İkili", "Üçlü", "Dörtlü", "Beşli", "Altılı", "Yedili", "Sekizli", "Dokuzlu", "Onlu", "Vale", "Kız", "Papaz" };
            string[] tipler = { "Kupa", "Karo", "Sinek", "Maça" };

            deste = new Kart[KART_SAYISI]; 
            mevcutKart = 0; 
            rastgeleSayilar = new Random(); 

            
            for (int count = 0; count < deste.Length; count++)
                deste[count] = new Kart(yuzler[count % 13], tipler[count / 13]);
        } 
         
         public void Karma()
         {
             //mevcutKart = 0; 

             for ( int first = 0; first<deste.Length; first++ )
             {
                int second = rastgeleSayilar.Next(KART_SAYISI);

                Kart temp = deste[first];
                deste[first] = deste[second];
                deste[second] = temp;
            } 
         } 

         public Kart KartDagitma()
         {
             if (mevcutKart < deste.Length)
                return deste[mevcutKart++]; 
             else
                return null; 
         } 
    } 
}
