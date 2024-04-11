
#region bir stringteki en uzun palindromik değeri bulma

static bool PalindromikMi(string st, int alt, int ust)
{

  int flag = 1;
  while (alt <= ust)
  {
    if (st[alt] != st[ust])
    {
      flag = 0;
      break;

    }
    alt++;
    ust--;
  }

  if (flag == 1)
  {
    return true;
  }
  else return false;

}

static string EnUzunPalindrom(string st)
{

  int alt = 0, ust = 0, max = 0, zincir = 0;
  for (int i = 0; i < st.Length; i++)
  {
    for (int j = st.Length - 1; j >= 0; j--)
    {

      if (st[i] == st[j])
      {
        if (PalindromikMi(st, i, j))
        {
          zincir = j - i + 1;
          if (max < zincir)
          {
            max = zincir;
            alt = i;
            ust = j;
          }
        }
      }

    }
  }
  string st2 = "";
  for (int i = alt; i <= ust; i++)
  {
    st2 += st[i];
  }

  return st2;

}

System.Console.WriteLine(EnUzunPalindrom("abxycyxbaasdasd123321sdfss"));
#endregion
#region palindrom mu

static bool PalindromMu(string st)
{
  int flag = 1;
  for (int i = 0; i < st.Length / 2; i++)
  {
    //kazak
    if (st[i] != st[st.Length - 1 - i])
    {
      flag = 0;
      break;
    }
  }

  if (flag == 1)
  {
    return true;
  }

  else return false;
}
System.Console.WriteLine(PalindromMu("kazak"));
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

// uint a = 0x10001811; //000010000000000=080001811
// uint b = a & 0xf8000000; //00000000000000000xxxxx+1
// b = b >> 27;
// b = b + 1;
// b = b << 27;//xxxxx0000000000000
// Console.WriteLine("B: " +Convert.ToString(b, toBase: 2));
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



uint esasSayi = 0xABCD1234; // 32 bitlik orijinal sayı
Console.WriteLine(Convert.ToString(esasSayi, toBase: 2));
uint ilkDortlu = esasSayi & 0xF0000000; // İlk dört biti maskeleme
uint sonuc = ilkDortlu >> 28; // Son dört bitine kaydırma
sonuc |= esasSayi & 0xFFFFFFF0; // Orijinal sayının son 28 bitini kopyalama

Console.WriteLine(Convert.ToString(sonuc, toBase: 2));
#endregion
#region 32 bitlik sayının En yüksek seviyeli 5 bitini 1 artıralım
// uint a = 0x00080080;
// uint b = a & 0xf8000000;
// b = b >> 27;
// b = b++;
// b = b << 27;
// a = 0x07ffffff;
// a = a | b;
// Console.WriteLine(Convert.ToString(a, toBase: 2));
#endregion
#region içeride uzun bir soru yazıyor
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
/*
int[] a = { 1, 4, 5, 6, 77, 88, 9 };
int[] b = { 1, 4, 5, 6 };

if (IceriyorMu(a, b))
{
  Console.WriteLine("evet mevcut");
}
else Console.WriteLine("hayır degil.");
static bool IceriyorMu(int[] Dizi, int[] altDizi)
{
  if (altDizi.Length == 0 || Dizi.Length == 0 || altDizi.Length > Dizi.Length)
  {
    return false;
  }

  for (int i = 0; i < Dizi.Length - altDizi.Length; i++)
  {
    if (Dizi[i] == altDizi[0])
    {
      int j = 0;
      for (; j < altDizi.Length; j++)
      {
        if (Dizi[i + j] != altDizi[j])
        {
          break;
        }
      }

      if (j == altDizi.Length)
      {
        return true;
      }
    }
  }
  return false;
}
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
//         if (ustDizi[i + j] != (altDizi[j]))
//           break;
//       }

//       if (j == altDizi.Length)
//         return true;
//     }
//   }
//   return false;
// }
*/
#endregion
#region Integer Diziyi 1 Pozisyon Saga Kaydir
//1,3,4,5,6
//6,1,3,4,5

static void BirSagaKaydir(int[] x)
{
  int diziB = x.Length;
  int sonEl = x[diziB - 1];
  for (int i = diziB - 1; i >= 1; i--)
  {
    x[i] = x[i - 1];
  }

  x[0] = sonEl;


}
//Diziyi n pozisyon sağa kaydıran metod

static void NPozisyon(int[] x, int n)
{
  int diziB = x.Length;
  if (n % diziB != 0)
  {
    for (int i = 0; i < n; i++)
    {
      BirSagaKaydir(x);
    }
  }
}

#endregion
#region Aritmetik Dizi Kontrolü
//1,3,5,7,9,11
//1,3
// 2,3,4,5,6,

static int AritmetikMi(int[] x)
{
  int sonuc = 1;
  int ortakF = x[1] - x[0];
  if (x.Length >= 3)
  {
    for (int i = x.Length - 1; i >= 2; i--)
    {
      if (x[i] - x[i - 1] != ortakF)//aksine örnek metodu
      {
        sonuc = 0;
        break;
      }
    }
  }

  return sonuc;

}
#endregion
#region En Uzun Aritmetik Diziyi Bul
static int AritmetikDiziIceriyorMu(int[] x, int alt, int ust)
{

  int sonuc = 1;
  if ((alt >= 0) && (ust < x.Length) && ((ust - alt + 1) >= 3))
  {
    int ortak = x[alt + 1] - x[alt];
    for (int i = alt + 2; i < ust; i++)
    {
      if (x[i + 1] - x[i] != ortak)
      {
        sonuc = 0;
        break;
      }
    }
    return sonuc;
  }

  else { sonuc = 0; }

  return sonuc;

}

static void EnUzunAritmetikDiziyiBul(int[] A, int alt, int ust)
{
  int max = 1;
  int zincir = 0;
  int diziB = A.Length;

  for (int i = 0; i < diziB; i++)
  {
    for (int j = i + 2; j < diziB - 2; j++)
    {
      //if (AritmetikDiziIceriyorMu(A,i,j)!=0)
      //{
      //    break;
      //}

      if (AritmetikDiziIceriyorMu(A, i, j) == 1)
      {
        zincir = j - i + 1;
        if (zincir > max)
        {
          max = zincir;
          alt = i;
          ust = j;
        }
      }


    }


  }
  if (max != 1)
  {
    for (int i = alt; i <= ust; i++)
    {
      Console.Write(A[i] + " ");
    }
  }
  else
  {
    Console.WriteLine("Aritmetik Dizi Yok!");
  }
}
//SON SORUYA ÖĞRENCİNİN CEVABI (ARİF SEFA BÖLÜKBAŞI)
static void AritmetikEnUzun(int[] x)
{
  int uzunluk = 1;
  int başlangıç = 0;
  int enUzunBoyut = 0;
  int enUzunBaşlangıç = 0;
  int fark = x[1] - x[0];
  //1,2,11,13,15,17
  for (int i = 0; i < x.Length - 1; i++)
  {
    if (x[i + 1] - x[i] == fark)
    {
      uzunluk++;
    }
    else
    {
      fark = x[i + 1] - x[i];
      uzunluk = 1;
      başlangıç = i;
    }
    if (enUzunBoyut < uzunluk)
    {
      enUzunBoyut = uzunluk;
      enUzunBaşlangıç = başlangıç;
    }
  }
  if (enUzunBoyut <= uzunluk)
  {
    enUzunBoyut = uzunluk;
    enUzunBaşlangıç = başlangıç;

  }
  for (int i = enUzunBaşlangıç; i <= enUzunBoyut + enUzunBaşlangıç; i++)
  {
    Console.WriteLine(x[i]);
  }
}

//Öğrencinin Cevabı (Kemal ÖZtürk)
//int dizinin en uzun aritmetik diziyi ekraya bastıran program

static void enUzunAritmetikDizi(int[] arr)
{
  int fark, indis;
  List<int> enuzunDizi = new List<int>();


  for (int i = 0; i < arr.Length - 1; i++)
  {
    List<int> geciciDizi = new List<int>();

    fark = arr[i] - arr[i + 1];
    if (fark == 0) continue;
    indis = 0;
    for (int j = i; j < arr.Length - 1; j++)
    {
      if (fark == (arr[j] - arr[j + 1]))
      {
        geciciDizi.Add(arr[j]);
        indis++;
      }
    }

    if (enuzunDizi.Count < geciciDizi.Count)
      enuzunDizi = geciciDizi;
  }

  foreach (int el in enuzunDizi)
  {
    Console.Write(el + " ");
  }
  Console.WriteLine();

}
#endregion













