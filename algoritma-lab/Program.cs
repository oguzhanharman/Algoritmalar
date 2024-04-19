
#region bir stringteki en uzun palindromik değeri bulma

// static bool PalindromikMi(string st, int alt, int ust)
// {

//   int flag = 1;
//   while (alt <= ust)
//   {
//     if (st[alt] != st[ust])
//     {
//       flag = 0;
//       break;

//     }
//     alt++;
//     ust--;
//   }

//   if (flag == 1)
//   {
//     return true;
//   }
//   else return false;

// }

// static string EnUzunPalindrom(string st)
// {

//   int alt = 0, ust = 0, max = 0, zincir = 0;
//   for (int i = 0; i < st.Length; i++)
//   {
//     for (int j = st.Length - 1; j >= 0; j--)
//     {

//       if (st[i] == st[j])
//       {
//         if (PalindromikMi(st, i, j))
//         {
//           zincir = j - i + 1;
//           if (max < zincir)
//           {
//             max = zincir;
//             alt = i;
//             ust = j;
//           }
//         }
//       }

//     }
//   }
//   string st2 = "";
//   for (int i = alt; i <= ust; i++)
//   {
//     st2 += st[i];
//   }

//   return st2;

// }

// System.Console.WriteLine(EnUzunPalindrom("abxycyxbaasdasd123321sdfss"));
#endregion
#region palindrom mu

// static bool PalindromMu(string st)
// {
//   int flag = 1;
//   for (int i = 0; i < st.Length / 2; i++)
//   {
//     //kazak
//     if (st[i] != st[st.Length - 1 - i])
//     {
//       flag = 0;
//       break;
//     }
//   }

//   if (flag == 1)
//   {
//     return true;
//   }

//   else return false;
// }
// System.Console.WriteLine(PalindromMu("kazak"));
#endregion
#region 32bitlik sayıyı tersine cevirme
/*
uint a = 0x00001000;  //     0000 0000 0000 0000 0000 0000 0000 1000
uint b = 0x80000000; //maske 0010 0000 0000 0000 0000 0000 0000 0000

for (int i = 0; i < 32; i++)
{
  if ((a & b) != 0)
  {
    Console.Write("0");
  }
  else
  {
    Console.Write("1");
  }

  b = b >> 1;
}

Console.WriteLine(Convert.ToString(a, toBase: 2));
*/

//Aynı sorunun farklı çözümü
/*
uint a = 0x10000000; // 10000001 -> 10000001
Console.WriteLine("A: " + Convert.ToString(a, toBase: 2));
uint b = 0x00000001;
uint c = 0x00000001;
uint d = 0xfffffffe;//1111 111 .. 1111 1110 +1
for (int i = 0; i < 32; i++)
{
  if ((a & b) != 0)
  {
    Console.WriteLine("A: " + Convert.ToString(a, toBase: 2));
    Console.WriteLine("D: " + Convert.ToString(d, toBase: 2));
    a = a & d;
  }

  else a = a | c;
  b = b << 1;
  c = c << 1;
  d = d << 1;
  d++; //11101111111111111111111111111111
}

Console.WriteLine("A: " + Convert.ToString(a, toBase: 2));
*/
#endregion
#region a sayısını b ye aktarma
/*
uint a = 0x01001100; //0000 0001 0000 0000 0001 0001 0000 0000
                     //0000 0001 0000 0000 0001 0001 0000 0000
uint c = 0x00000001; //maske
uint b = 0x00000000;

for (int i = 0; i < 32; i++)
{
    if ((a & c) != 0)
    {
        b = b | c;
    }
    c = c << 1;
}
Console.WriteLine("B: " + Convert.ToString(b, 2));
*/
#endregion
#region 32 bitlik sayının En yüksek seviyeli 5 bitini 1 artıralım
// uint a = 0x00001811; //000010000000000=080001811
// uint b = a & 0xfe000000; //00000000000000000xxxxx+1  1111 1 110 0..00
// b = b >> 27;
// b = b + 1;
// b = b << 27;//xxxxx0000000000000
// Console.WriteLine("B: " +Convert.ToString(b, toBase: 2));
// a = a | b;

// Console.WriteLine(Convert.ToString(a, toBase: 2));

// uint a = 0xf8001811;     //1111 1000 0000 0000 0001 1000 0001 0001
// uint b = a & 0xf8000000; //1111 1000 0000 0000 0000 0000 0000 0000
// Console.WriteLine("B: " +Convert.ToString(b, toBase: 2));
// Console.WriteLine("c: " +Convert.ToString(0xf8000000, toBase: 2)); //32 görebilmek için

// b = b >> 27;
// b = b + 1;
// Console.WriteLine("B: " +Convert.ToString(b, toBase: 2));
// b = b << 27;//xxxxx0000000000000
// a = a | b;

// Console.WriteLine(Convert.ToString(a, toBase: 2));

#endregion
#region 9 Pozisyon Sola Doğru Rotate
//1000000001== 00800100

// uint a = 0x10000000;
// uint b = 0x80000000;
// for (int i = 0; i < 9; i++)
// {
//   if ((a & b) != 0)
//   {
//     a <<= 1; //a yı bir birim sola kaydır ve a ya ata
//     a++; //a|1;
//   }

//   else a <<= 1;
// }

// Console.WriteLine(Convert.ToString(a, toBase: 2));


//100000000000   00000000001 a+1
//0000000000010  a yı kaydırmıs

// uint a = 0x10000000;
// uint b = 0x80000000;
// Console.WriteLine("A: "+Convert.ToString(a, toBase: 2));
// for (int i = 0; i < 9; i++)
// {
//   if ((a & b) != 0)
//   {
//     a <<= 1;
//     a++; //a|1;
//   }

//   else a <<= 1;
// }

// Console.WriteLine(Convert.ToString(a, toBase: 2));

#endregion
#region İlk 4 biti son 4 bite kopyalama
// uint a = 0xABCD1234;
// uint ilkDortlu = (a & 0xf0000000) >> 28 ;
// System.Console.WriteLine(" İlkDortlu: "+Convert.ToString(ilkDortlu,toBase:2));
// a&=0xfffffff0;
// uint sonuc=a|ilkDortlu;
// Console.WriteLine(Convert.ToString(sonuc, toBase: 2));



// uint esasSayi = 0xABCD1234;
// uint ilkDortlu = esasSayi & 0xf0000000;
// uint sonuc=0;
// ilkDortlu >>= 28;//xxxx000000000 -> //00000xxxx
// esasSayi=esasSayi&0xfffffff0;
// sonuc |= esasSayi | ilkDortlu;
// Console.WriteLine(Convert.ToString(sonuc,toBase:2));



// uint esasSayi = 0xABCD1234; // 32 bitlik orijinal sayı
// Console.WriteLine(Convert.ToString(esasSayi, toBase: 2));
// uint ilkDortlu = esasSayi & 0xF0000000; // İlk dört biti maskeleme
// uint sonuc = ilkDortlu >> 28; // Son dört bitine kaydırma
// sonuc |= esasSayi & 0xFFFFFFF0; // Orijinal sayının son 28 bitini kopyalama

// Console.WriteLine(Convert.ToString(sonuc, toBase: 2));
#endregion
#region 32 bitlik sayının En yüksek seviyeli 5 bitini 1 artıralım
// uint a = 0x00080080;
// uint b = a & 0xf8000000;
// Console.WriteLine("B: "+Convert.ToString(b, toBase: 2));
// b = b >> 27;
// b = b++;
// b = b << 27;
// a = a | b;
// Console.WriteLine(Convert.ToString(a, toBase: 2));
#endregion
#region içeride uzun bir soru yazıyor --> sanırım bu çıkmış sınav sorusu **
/*Soru
A1 ve A2 32’şer bitlik unsigned integer sayılardır.
Bu ikisi 64 bitlik bir sayıyı oluşturmaktadır. A1,
sayının en yüksek değerlikli bitlerini, A2 ise en düşük
değerlikli bitlerini temsil etmektedir. Bu 64 bit’lik
sayının içinde sadece yan yana 1’lerden oluşmuş en
uzun sayı grubunun uzunluğunu ekrana yazan c# programını yazınız.
Örneğin 1110101111000110 16 bitlik sayısı için en uzun 1 uzunluğu 4’tür.*/
// uint a = 0xffffffff;
// uint b = 0x00000000;
// ulong sonuc = ((ulong)a << 32) | b;
// int max = 0;
// int zincir = 0;
// for (int i = 63; i > 0; i--)
// {
//   if (((sonuc >> i) & 1) != 0)
//   {
//     zincir++;
//     if (max < zincir)
//     {
//       max = zincir;
//     }
//   }

//   else zincir = 0;
// }

// Console.WriteLine("1'lerin uzunlugu: {0}", max);


// a dizisinin icinde b dizisi arayın


// uint a = 0xffffffff;
// uint b = 0xf0000000;
// ulong yeni = ((ulong)a << 32) | b;
// int max = 0;
// int zincir = 0;
// for (int i = 63; i > 0; i--)
// {
//   if (((yeni >> i) & 1) != 0)
//   {
//     zincir++;

//     if (zincir > max)
//     {
//       max = zincir;

//     }
//   }

//   else zincir = 0;
// }
// Console.WriteLine("en uzun 1 zinciri:{0}", max);
// Console.ReadKey();


// a dizisinin icerisinde b dizisinin
// varlıgını arastırıyoruz.
// a={4,6,77,12,45};
// b ={ 4,6,12}; false
// b ={ 6,77,12}; true;



// uint A1 = 0xffffffff;
// uint A2 = 0x1;
// ulong num = ((ulong)A1 << 32) | A2;
// uint maxLen = 0;
// uint currentLen = 0;
// for (int i = 63; i >= 0; i--)
// {
//   if (((num >> i) & 1) == 1)
//   {
//     currentLen++;
//     if (currentLen > maxLen)
//     {
//       maxLen = currentLen;
//     }
//   }
//   else { currentLen = 0; }
// }
// Console.WriteLine("En uzun sayı grubunun uzunluğu: " + maxLen);
// Console.ReadKey();
#endregion
#region Dizi içerisinde dizi mevcut mu?

// int[] a = { 1, 4, 5, 6, 77, 88, 9 };
// int[] b = { 1, 4, 5, 6 };

// if (IceriyorMu(a, b))
// {
//   Console.WriteLine("evet mevcut");
// }
// else Console.WriteLine("hayır degil.");
// static bool IceriyorMu(int[] Dizi, int[] altDizi)
// {
//   if (altDizi.Length == 0 || Dizi.Length == 0 || altDizi.Length > Dizi.Length)
//   {
//     return false;
//   }

//   for (int i = 0; i < Dizi.Length - altDizi.Length; i++)
//   {
//     if (Dizi[i] == altDizi[0])
//     {
//       int j = 0;
//       for (; j < altDizi.Length; j++)
//       {
//         if (Dizi[i + j] != altDizi[j])
//         {
//           break;
//         }
//       }

//       if (j == altDizi.Length)
//       {
//         return true;
//       }
//     }
//   }
//   return false;
// }


// static bool IceriyorMu(int[] ustDizi, int[] altDizi)
// {
//   if (ustDizi.Length == 0 || altDizi.Length == 0 || altDizi.Length > ustDizi.Length)
//     return false;

//   for (int i = 0; i <= ustDizi.Length - altDizi.Length; i++)
//   {
//     if (ustDizi[i] == altDizi[0])
//     {
//       int j = 0;
//       for (; j < altDizi.Length; j++)
//       {
//         if (ustDizi[i + j] != altDizi[j])
//           break;
//       }

//       if (j == altDizi.Length)
//         return true;
//     }
//   }
//   return false;
// }

#endregion
#region Integer Diziyi 1 Pozisyon Saga Kaydir
//1,3,4,5,6
//6,1,3,4,5


// static void BirSagaKaydir(int[] x)
// {
//   int diziB = x.Length;
//   int sonEl = x[diziB - 1];
//   for (int i = diziB - 1; i >= 1; i--)
//   {
//     x[i] = x[i - 1];
//   }

//   x[0] = sonEl;


// }
// //Diziyi n pozisyon sağa kaydıran metod

// static void NPozisyon(int[] x, int n)
// {
//   int diziUzunluk = x.Length;
//   if (n % diziUzunluk != 0)// tam bölündüğünde  zaten başa dönmüş oluyor
//   {
//     for (int i = 0; i < n; i++)
//     {
//       BirSagaKaydir(x);
//     }
//   }
// }

#endregion
#region Aritmetik Dizi Kontrolü
//1,3,5,7,9,11
//1,3
// 2,3,4,5,6,

// static int AritmetikMi(int[] x)
// {
//   int sonuc = 1;
//   int ortakF = x[1] - x[0];
//   if (x.Length >= 3)
//   {
//     for (int i = x.Length - 1; i >= 2; i--)
//     {
//       if (x[i] - x[i - 1] != ortakF)//aksine örnek metodu
//       {
//         sonuc = 0;
//         break;
//       }
//     }
//   }

//   return sonuc;

// }
#endregion
#region En Uzun Aritmetik Diziyi Bul
// int[] dizi = { 1, 2, 3, 5, 7, 9, 11, 13, 14, 15,16, 17,18,19};
// int altIndex = 0;
// int ustIndex = 0;

// EnUzunAritmetikDiziyiBul(dizi, ref altIndex, ref ustIndex);

// static int AritmetikDiziIceriyorMu(int[] x, int alt, int ust)
// {
//   int sonuc = 1;
//   if ((alt >= 0) && (ust < x.Length) && ((ust - alt + 1) >= 3)) // minumum 3 karakter olması gerektiği için son kontrolü yapıyoruz
//   {
//     int ortak = x[alt + 1] - x[alt];
//     for (int i = alt + 2; i <= ust; i++) // 
//     {
//       if (x[i] - x[i - 1] != ortak)
//       {
//         sonuc = 0;
//         break;
//       }
//     }
//     return sonuc;
//   }
//   else 
//   {
//     sonuc = 0; 
//     return sonuc; // Sonucun dönüşünü buraya aldık
//   }
// }

// static void EnUzunAritmetikDiziyiBul(int[] A, ref int alt, ref int ust) 
// {
//   int max = 1;
//   int zincir = 0;
//   int diziUzunluk = A.Length;

//   for (int i = 0; i < diziUzunluk; i++)
//   {
//     for (int j = i + 2; j < diziUzunluk; j++) 
//     {
//       if (AritmetikDiziIceriyorMu(A, i, j) == 1)
//       {
//         zincir = j - i + 1; // Bulduğumuz uzunluğu tutuyoruz
//         if (zincir > max)
//         {
//           max = zincir;
//           alt = i;
//           ust = j;
//         }
//       }
//     }
//   }

//   if (max != 1)
//   {
//     for (int i = alt; i <= ust; i++)
//     {
//       Console.Write(A[i] + " ");
//     }
//   }
//   else
//   {
//     Console.WriteLine("Aritmetik Dizi Yok!");
//   }
// }



//SON SORUYA ÖĞRENCİNİN CEVABI (ARİF SEFA BÖLÜKBAŞI)
// int[] dizi = { 1, 2, 3, 5, 7, 9, 11, 13, 14, 15, 16, 18, 19 };
// AritmetikEnUzun(dizi);
// AritmetikEnUzun(dizi);
// static void AritmetikEnUzun(int[] x)
// {
//   int uzunluk = 1;
//   int başlangıç = 0;
//   int enUzunBoyut = 0;
//   int enUzunBaşlangıç = 0;
//   int fark = x[1] - x[0];
//   //1,2,11,13,15,17
//   for (int i = 0; i < x.Length - 1; i++)
//   {
//     if (x[i + 1] - x[i] == fark)
//     {
//       uzunluk++;
//     }
//     else
//     {
//       fark = x[i + 1] - x[i];
//       uzunluk = 1;
//       başlangıç = i;
//     }
//     if (enUzunBoyut < uzunluk)
//     {
//       enUzunBoyut = uzunluk;
//       enUzunBaşlangıç = başlangıç;
//     }
//   }
//   if (enUzunBoyut <= uzunluk)
//   {
//     enUzunBoyut = uzunluk;
//     enUzunBaşlangıç = başlangıç;

//   }
//   for (int i = enUzunBaşlangıç; i <= enUzunBoyut + enUzunBaşlangıç; i++)
//   {
//     Console.WriteLine(x[i]);
//   }

// }

// //Öğrencinin Cevabı (Kemal ÖZtürk)
// //int dizinin en uzun aritmetik diziyi ekraya bastıran program
// enUzunAritmetikDizi(dizi);
// static void enUzunAritmetikDizi(int[] arr)
// {
//   int fark, indis;
//   List<int> enuzunDizi = new List<int>();


//   for (int i = 0; i < arr.Length - 1; i++)
//   {
//     List<int> geciciDizi = new List<int>();

//     fark = arr[i] - arr[i + 1];
//     if (fark == 0) continue;
//     indis = 0;
//     for (int j = i; j < arr.Length - 1; j++)
//     {
//       if (fark == (arr[j] - arr[j + 1]))
//       {
//         geciciDizi.Add(arr[j]);
//         indis++;
//       }
//     }

//     if (enuzunDizi.Count < geciciDizi.Count)
//       enuzunDizi = geciciDizi;
//   }

//   foreach (int el in enuzunDizi)
//   {
//     Console.Write(el + " ");
//   }
//   Console.WriteLine();

// }
#endregion
#region ileri seviye birkaç soru
//peki ya 128 değilde 256,512,1024 bitlik bir sayı deseydik ne yapacaktık?
// bunun çözümü sayı kaç bitlik olursa olsun otomatik çözüm üretmek
// bence aşağıdaki çözüm baya
// uint[] X = { 1, 2, 3, 4, 5, 6 };
// uint a = 0;
// uint h = X[a];
// X[a]++;
// while (h > X[a])
// {
//   a++;
//   h = X[a];
//   X[a]++;

// }
// --------------------------------------------------------------------------------------------------------------------------------------------
// uint[] X = new uint[4] { 0x80000000, 0x10000000, 0x20000000, 0x30000000 }; // X dizisini farklı değerlerle başlatılmış
// ulong sonuc = 0;

// for (int i = 0; i < X.Length; i++)
// {
//   sonuc <<= 32; // Sonucu 32 bit sola kaydır
//   System.Console.WriteLine(Convert.ToString((long)sonuc, 2));
//   sonuc |= X[i]; // Sonuca X dizisinin i. elemanını ekle
//   System.Console.WriteLine(Convert.ToString((long)sonuc, 2));
// }
// string binaryString = Convert.ToString((long)sonuc, 2);
// string binaryString2 = Convert.ToString((long)0x30000000, 2);

// Console.WriteLine(binaryString);
// Console.WriteLine(binaryString2);


// #region 2023 sınav sorusu
/*
--------------------------------------------------------------------------------------------------------------------------------------------

2 adet uint tipinden değişkenler yanyana olsun 
yani 
            uint a1 = 0x00000000;
            uint a2 = 0x0000ffff;
bunlardan 64 bit olur
en fazla yanyana 1 lerin sayısını recursive metodunu
*/
// uint[] X = new uint[4] { 0x80000000, 0x10000000, 0x20000000, 0x30000000 }; // X dizisini farklı değerlerle başlatılmış
// ulong sonuc = 0;

// for (int i = 0; i < X.Length; i++)
// {
//   sonuc <<= 32; // Sonucu 32 bit sola kaydır
//   sonuc |= X[i]; // Sonuca X dizisinin i. elemanını ekle
// }
// string binaryString = ConvertToBinary(sonuc);
// Console.WriteLine(binaryString);

// static string ConvertToBinary(ulong number)
// {
//   const int bits = 128;
//   char[] binary = new char[bits];
//   for (int i = bits - 1; i >= 0; i--)
//   {
//     binary[i] = ((number & 1) == 1) ? '1' : '0';
//     number >>= 1;
//   }
//   return new string(binary);
// }


// static int enuzunBirler(ulong X, int max, int adet)
// {
//   if (X == 0) return max;

//   if ((X & 1) != 0)
//   {
//     adet++;
//     if (adet > max) max = adet;
//   }
//   else
//   {
//     adet = 0;
//   }

//   return enuzunBirler(X >> 1, max, adet);
// }

// ulong a = 0xf0f8;
// ulong b = 0;
// ulong sonuc = (a << 32) | b;

// System.Console.WriteLine(enuzunBirler(sonuc, 0, 0));

// --------------------------------------------------------------------------------------------------------------------------------------------

// //bir dizinin tüm alt kümlerini yazan script


// int[] x = { 1, 2, 3, 8, 5 };
// uint b = 1;
// for (int i = 0; i < 32; i++)
// {
//   b = 1;
//   for (int j = 0; j < 5; j++)
//   {


//     long sonuc = i & b;

//     if ( sonuc != 0)
//     {
//       Console.Write(" " + x[j]);
//     }
//     b = b << 1;
//   }
//   Console.WriteLine();
// }

// RECURSİVE --- BASARILI


// static void altKumeRecursive(int[] dizi, int altKumeSayısı, uint altKumeSayacı, uint bit, long b)
// {
//   if (altKumeSayacı >= altKumeSayısı) return;

//   if (bit > dizi.Length)
//   {
//     // burada tekrar bir kontrol yapmamızın sebebi son aşamada küme sayacı 1 artmış olabilir
//     if (altKumeSayacı < altKumeSayısı)
//     {
//       Console.Write("\nAlt küme {0}: ", altKumeSayacı + 1);
//       altKumeRecursive(dizi, altKumeSayısı, altKumeSayacı + 1, 0, 1);
//     }
//     return;
//   }

//   if ((altKumeSayacı & b) != 0 && bit < dizi.Length)
//   {

//     Console.Write("[{0}]", dizi[bit]);
//   }

//   altKumeRecursive(dizi, altKumeSayısı, altKumeSayacı, bit + 1, b << 1);
// }

// altKumeRecursive(x, 32, 0, 0, 1);


// RECURSİVE --- HATALI

// int[] x = { 1, 2, 3, 8, 5 };
// FindSubsets(x, 0, new int[x.Length], 0);

// static void FindSubsets(int[] x, int index, int[] subset, int subsetIndex)
// {
//   if (index == x.Length)
//   {
//     // Subset'i yazdır
//     Console.Write("{ ");
//     for (int i = 0; i < subsetIndex; i++)
//     {
//       Console.Write(subset[i] + " ");
//     }
//     Console.WriteLine("}");
//     return;
//   }

//   // Elemanı eklememe durumu
//   FindSubsets(x, index + 1, subset, subsetIndex);

//   // Elemanı ekleyerek devam etme durumu
//   subset[subsetIndex] = x[index];
//   FindSubsets(x, index + 1, subset, subsetIndex + 1);
// }

// int[] a = { 1, 2, 3, 8, 5 };
// FindSubsets(a, 0, new int[a.Length], 0);


// --------------------------------------------------------------------------------------------------------------------------------------------
// alt kümelerin toplamı 10 olan kaç alt küme vardır

// static int altKumeRecursive(int[] dizi, int altKumeSayısı, int altKumeSayacı, int bit, int b,   int adet, int toplam)
// {
//   if (altKumeSayacı >= altKumeSayısı) return (int)adet;

//   if (bit >= dizi.Length)
//   {
//     if (altKumeSayacı < altKumeSayısı)
//     {
//       if (toplam == 5) adet++;
//       return altKumeRecursive(dizi, altKumeSayısı, altKumeSayacı + 1, 0, 1, adet, 0);
//     }
//     return adet;
//   }

//   if ((altKumeSayacı & b) != 0 && bit < dizi.Length)
//   {
//     toplam += dizi[bit];
//     return altKumeRecursive(dizi, altKumeSayısı, altKumeSayacı, bit + 1, b << 1, adet, toplam);
//   }

//   return altKumeRecursive(dizi, altKumeSayısı, altKumeSayacı, bit + 1, b << 1, adet, toplam);
// }


// int[] x = { 1, 2, 3, 8, 5, 5 };
// Console.WriteLine(altKumeRecursive(x, 32, 0, 0, 1, 0, 0));


#endregion
#region 128 bitlik binary sayıyı 10 luk sisteme dönüştürmek
// uint a1 = 0x00000001;
// uint a2 = 0x00000001;
// uint a3 = 0x00000001;
// uint a4 = 0x00000001;
// uint aktif = a1;
// ulong basamak = 1;
// ulong sayı = 0;
// uint maske = 1;

// for (int i = 0; i < 128; i++)
// {
//   if (i == 32)
//   {
//     aktif = a2;
//     maske = 1;
//   }
//   if (i == 64)
//   {
//     aktif = a3;
//     maske = 1;
//   }
//   if (i == 96)
//   {
//     aktif = a4;
//     maske = 1;
//   }
//   uint bit = aktif & maske; // 0 mı 1 mi ?
//   if (bit != 0)
//     sayı = sayı + basamak;
//   else
//     basamak = basamak * 2;
//   maske = maske << 1;
// }
// Console.WriteLine(sayı);

#endregion
#region dizilerle çarpmak


// İlk diziyi tanımla ve değerlerini ata
int[] dizi1 = { 1, 2, 5 };

// İkinci diziyi tanımla ve değerlerini ata
int[] dizi2 = { 3, 4, 6 };

// İki dizinin boyutunu kontrol et
if (dizi1.Length != dizi2.Length)
{
  Console.WriteLine("Dizilerin boyutları eşit olmalıdır.");
  return;
}

// Sonucu tutacak değişkeni tanımla ve 1 olarak başlat
int sonuc = 1;

// Dizilerin her bir elemanını çarp
for (int i = 0; i < dizi1.Length; i++)
{
  sonuc *= dizi1[i] * dizi2[i];
}

// Sonucu ekrana yazdır
Console.WriteLine("Çarpım sonucu: " + sonuc);


#endregion









