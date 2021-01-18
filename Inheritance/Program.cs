using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalıtım_
{
    class Program
    {
        static void Main(string[] args)
        {
       
       
        }
    }

}

//ÖNEMLİ NOT: İNTERFACE VE ABSTRACT ARASINDAKİ ANA FARK
/* 
ABSTRACT CLASSLARDA BİR PROPERTY FİELD VEYA METOD TANIMLADIĞIMIZDA(O TANIMLADIĞIMIZ ÖGREYİ ABSTRACT YAZMADIĞIMIZ
SÜRECE NORMAL OLARAK KALITIM ALABİLİRİZ FAKAT ABSTRACT ÖZELLİĞİ TAŞIYAN BİR PROPERTY FİELD VEYA METOD YAZIYORSAK ONU
KESİNLİKLE OVVERİDE ETMEK ZORUNDAYIZ. BU YÜZDEN İNTERFACEYE GÖRE BİRAZ DAHA KULLANIŞLIDIRLAR.
İNTERFACELERDE PROPERTY FİELD VEYA METODLARDA PUBLİC PRİVATE GİBİ ERİŞİM BELİRLEYİCİ KULLANMAYIZ.İNTERFACELERİN ANA 
AMACI İÇİNE YAZDIĞIMIZ BÜTÜN ELEMANLARI İMPLEMENT ETMEYE ZORUNLU TUTAR. 
İNTERFACE VE ABSTRACT CLASS ARASINDAKİ EN ÖNEMLİ FARK-- ABSTRACT CLASSLARDA VİRTUAL YANİ ABSTRACT OLAN VERİLERİ 
KALITIM YAPTIĞIMIZ CLASSTA İMPLEMENT ETMEMİZ GEREKİRKEN İNTERFACEDE BÜTÜN VERİLERİ İMPLEMENT ETMEMİZ GEREKİR
*/



// ----------------------------------------İNTERFACELER İÇİN ÖNEMLİ NOT--------------------------------------
/*
2 TANE İNTERFACEDE AYNI ÖZELLİKLERİ TAŞIYAN METODLAR PROPERTYLER FİELDLER OLABİLİR. BU DURUMDA İMPLEMENT EDERKEN DİREK 
İMLEMENT EDERSEK "NAME HİDİNG" YANİ İSİM SAKLAMA HATASIYLA KARŞILAŞIRIZ. BU YÜZDEN İMPLEMENT İNTERFACE EXPLİCİTLY YANİ
TÜM ÖGELERİ AÇIKÇA UYGULA BUTONUNDA FAYDALANMAMIZ GEREKİR!!!
FAKAT BU DURUMDA ŞÖYLE BİR SORUNLA KARŞILAŞIYORUZ. İMPLEMENT İNTERFACE EXPLİCİTLY YAZDIĞIMIZ DURUMDA ERİŞİM BELİRLEYİCİ 
KULLANILMADIĞI İÇİN MAİN METHODUMUZUN İÇİNDE ANA CLASSTAN REFERANS ALIP NESNE ÜRETTİĞİMİZ ZAMAN KARŞIMIZA MANTIK OLARAK
HİÇ BİR VERİ GELMEMEKTEDİR. HATIRLARSANIZ İNTERFACELER SOYUT SINIFLAR OLDUĞU İÇİN REFERANS ALINIR FAKAT NESNE ÜRETİLEMEZDİ
BU DURUMDA BİZ İNTERFACELERİMİZİN REFERANS ALMA ÖZELLEĞİNİ KULLANIP ANA CLASSTAN NESNE ÜRET ŞARTINI YAZMAK ZORUNDAYIZ.
BİNEVİ ÇOK BİÇİMLİLİK YAPMAK ZORUNDA OLUYORUZ.
*/


//-------------------------------------İNTERFACE CLASS ÖRNEĞİ-----------------------------------------

class örnek : Iörnek, Iörnek2
{
    int Iörnek.Id { get; set; }
    string Iörnek.Ad { get; set; }

    void Iörnek.işlem()
    {
       
    }
    void Iörnek2.işlem()
    {
     
    }
}
interface Iörnek
{
    int Id { get; set; }
    string Ad { get; set; }
    void işlem();
}
interface Iörnek2
{   
    void işlem();
}










//-------------------------------------ABSTRACT CLASS ÖRNEĞİ-----------------------------------------
//class anaornek : ornek
//{
//    public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public override string MyProperty2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//}
//abstract class ornek
//{
//    public int Ornek { get; set; }
//    public abstract int MyProperty { get; set; }
//    public abstract string MyProperty2 { get; set; }

//}


