//-----------------------------------------------------------------------------
// 04.03.2024
// 5 basamaklı sayılardan 10000..99999 rakamları toplamı 25 olan kaç adet sayı vardır ?
//1.çözüm


// int abc1 = 0;
// for (int i = 10000; i < 100000; i++)
// {
//     // 10000
//     int c = 0;
//     int b = i;
//     while (b!=0)
//     {
//         c = c + b - (b / 10) * 10;              // 12380
//         b = b / 10;
//     }
//     if (c == 25) abc1++;
// }
// System.Console.WriteLine(abc1);


// //2.çözüm
// int abc = 0;
// for (int i = 1; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         for (int k = 0; k < 10; k++)
//         {
//             for (int m = 0; m < 10; m++)
//             {
//                 for (int n = 0; n < 10; n++)
//                 {
//                     if (i + j + k + m + n == 25) abc++;
//                 }
//             }
//         }
//     }
// }


//-----------------------------------------------------------------------------
// 0 dan 8 e kadar olan sayıların binary karşılıklarını yazalım
//00000 0
//00001 1 
//00010 2
//00011 3
//00100 4

// for (int k = 0; k < 2; k++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         for (int i = 0; i < 2; i++)
//         {
//             Console.Write(k); // msb --> lsb gidiyor
//             Console.Write(j);
//             Console.Write(i);
//             Console.WriteLine();
//         }
//     }
// }
//------------------------------------------------------------------------------
// ÖDEV!! 20 basamaklı tüm binary sayıları yazdır








//------------------------------------------------------------------------------
// 123 -->  "123"  int sayıyı string yapma

// int b = 123;
// string st = "";
// int c = 0;

// while (b != 0)
// {
//     c = b - (b / 10) * 10; // mod                                        // ----> bu özelliğe takitiğe daha sonra da bakacağım
//     b = b / 10;
//     st = (char)((byte)'0'+c)+st;
// }
// // 0  21
// // 1  22
// // 2  23
// // 3  24
// Console.WriteLine(st);
//------------------------------------------------------------------------------
// string sayıyı int çevirme "123" --> 123
/*
string st = "123";
int c = 0;
int basamak = 1;
for (int i = st.Length-1; i >= 0 ; i--)                            // ----> bu özelliğe takitiğe daha sonra da bakacağım
{
    c = c + basamak*(st[i]- (byte)'0');
    basamak *= 10;
}
Console.WriteLine(c);
*/
//------------------------------------------------------------------------------
// verilen string i  virgüle göre split yapan metot
/*
string st = "dsfgdfg,dfgdf,dfgdfg,dfgff,fdaf,fd";
string a = "";
for (int i = 0; i < st.Length; i++)
{
    if (st[i]!= ',')
    {
        a += st[i];
    }
    else
    {
        Console.WriteLine(a);
        a = "";

    }
}
Console.WriteLine(a);*/
//------------------------------------------------------------------------------
// ÖDEV!! verilen string te en uzun palindromik stringi bulan kod parçacığı
// string str = "asdmmsnjnsdksmakd";

// static bool PalindromikMi(string st, int alt, int ust)
// {
//   while (alt <= ust)
//   {
//     if (st[alt] != st[ust])
//     {
//       return false;
//     }
//     alt++;
//     ust--;
//   }
//   return true

// }

// static string EnUzunPalindrom(string st)
// {

//   int alt = 0, ust = 0, max = 0, anlıkMax = 0;
//   for (int i = 0; i < st.Length; i++)
//   {
//     for (int j = st.Length - 1; j >= i; j--)
//     {

//       if (st[i] == st[j])
//       {
//         if (PalindromikMi(st, i, j))            //as xlmd dmlx ksmakd
//         {
//           anlıkMax = j - i + 1;
//           if (max < anlıkMax)
//           {
//             max = anlıkMax;
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



//------------------------------------------------------------------------------
// verilen 101011101 şeklinde verilen stringi 10 luk sayıya çeviren kod parçacığı  ****
// string st = "1111010101010101";
// int sayi = 0;
// int basDeger = 1;
// for (int i = st.Length-1; i >= 0; i--)
// {
//     sayi = sayi + basDeger * (st[i] - (byte)'0');
//     basDeger *= 2;
// }
// Console.WriteLine(sayi);
//------------------------------------------------------------------------------
// verilen iki dizinin ortak eleman sayısını bulalım 
// int[] x = { 3, 45, 67, 66, 2, 6, 48, 71, 78,98 };
// int[] y = { 13, 45, 67, 166, 2, 16, 48, 71, 178, 198 };
// int[] z = new int[200];
// //çözüm 1
// int sayi = 0;
// for (int i = 0; i < x.Length; i++)
// {
//     for (int j = 0; j < y.Length; j++)
//     {
//         if (x[i] == y[j])
//         {
//             sayi++;
//         }
//     }
// }
// Console.WriteLine(sayi);
// //çözüm 2

// sayi = 0;
// for (int i = 0; i < x.Length; i++)
// {
//     z[x[i]]++;
// }
// for (int i = 0; i < y.Length; i++)
// {
//     if (z[y[i]] == 1)
//     {
//         sayi++;
//     }
// }
// Console.WriteLine(sayi);
//------------------------------------------------------------------------------
// ÖDEV!! verilen iki  dizideki her elemanı çarpıp çarpılan sayıların indexine çarpım sonucu yazan yeni diziye yazan kod  ----> sınV SORUSU
// int[] x = { 1, 3, 5 };
// int[] y = { 7, 7, 5 }; // Ensure y has the same length as x

// static int[] carpimlarDizisi(int[] x, int[] y)
// {
//     int[] z = new int[x.Length + 1];

//     int sonuc = 0;
//     int elde = 0;
//     for (int i = x.Length - 1; i >= 0; i--)
//     {
//         sonuc = x[i] * y[i] + elde;
//         if (sonuc < 10)
//         {
//             z[i + 1] = sonuc;
//             elde = 0;
//         }
//         else
//         {
//             z[i + 1] = sonuc % 10;
//             elde = sonuc / 10;
//         }
//     }

//     z[0] = elde; // Eldeyi en başa ekle
//     return z;
// }


// foreach (var item in carpimlarDizisi(x, y))
// {
//     System.Console.WriteLine(item);
// }
//------------------------------------------------------------------------------
/* bir dizi bir sayı olarak görmek üzerine işlem yapmak
yani böyle düşün
            int[] x = { 1, 9, 4,4 };
            int[] y = { 4, 9, 1,3 };
bu iki dizi x*2+y denklemin çözümünü istiyor
sonuç 1944*2+4913 = 8801 olacak 
tabi stringe çevirmek yasaktı, elde kalanı göz önüne alarak çözülür
*/
int[] x = { 1, 9, 4, 4 };
int[] y = { 4, 9, 1, 3 };
int[] r = new int[x.Length];
int k = (1944) * 2 + 4913;
for (int i = 0; i < x.Length; i++)
{
    r[i] = x[i];
}
for (int i = x.Length - 1; i >= 0; i--)
{
    int tmp = x[i] + y[i] + r[i];
    int kalan = tmp % 10;
    int elde = (tmp - kalan) / 10;
    r[i] = kalan;
    if (i != 0) r[i - 1] += elde;
}
for (int i = 0; i < 4; i++)
{
    Console.Write(r[i]);
}
Console.WriteLine();
Console.WriteLine(k);
Console.ReadKey();



// 2. çözüm

int[] x = { 1, 9, 4, 4 };
int[] y = { 4, 9, 1, 3 };
int[] r = new int[x.Length];
int elde = 0;
int kalan = 0;
int tmp = 0;
for (int i = x.Length - 1; i >= 0; i--)
{
    tmp = x[i] * 2 + y[i] + elde;
    kalan = tmp % 10;
    elde = tmp / 10;
    r[i] = kalan;
}
Console.WriteLine(string.Join("", r));




// foreach (var item in carpimlarDizisi(x, y))
// {
//     System.Console.WriteLine(item);
// }

//------------------------------------------------------------------------------
// bitwise bitsel işlemler
// 2 lik sayı sistemi
// 16 lık sayı sistemi donüşleri kolaydır
// 1100
// 1010
// and ve or
// sign bit 1 --> -  0 --> +  | negatif sayının değilini al 1 ile topla 
// hexto2
// 2tohex
// 0X hex sayı demek


// int a = 0x42000f00;                     // 1000 0010 0000 0000 0000 1111 0000 0000 
// Console.WriteLine(a);
// a = a << 1;
// uint u = 0x80000000;
// u = 0xa;                    // 00000 0000 .... 1010
// Console.WriteLine("u " + u);
// u = u & 0x40000000;                 //  
// Console.WriteLine("u "+ u);
// u = u | 0x40000000; // 0x40000000
// Console.WriteLine("u " + u);
// Console.WriteLine(a);

// if((u & 0x1) == 1) // 0010 & 0001
// {
//     Console.WriteLine("u tektir");
// }
// else
// {
//     Console.WriteLine("u çifttir");
// }

// sayıların sol yada sağ shift edilmesi 
// rotate   sayılar sağ veya sola shift
//------------------------------------------------------------------------------
//11.03.2024
//bitwise işlemlerden devam
//maske
//uint a = 1;
//a = a & 0x1; // a&1
// bir sayının tek mi çift mi olduğunu anlamaya çalışalım
//2^0 + 2^1 + 2^2...
//en sağdaki bit sıfırsa çift bir ise tektir
//int a = 3;
/*if((a&1) == 1)// sayı tek sayı mı
{
    Console.WriteLine("tek sayı");
}
else
{
    Console.WriteLine("çift sayı");
}*/
//-----------------------------------------------------------------------------
// bir sayının negatif mi pozitif mi olduğunu anlamaya çalışalım
// 1000000000000
// xxxxxxxxxxxxx
// x000000000000
// 1000000000000
// !=0
/*if ((a & 0x80000000)!=0x80000000)
{
    Console.WriteLine("pozitif");
}
else
{
    Console.WriteLine("negatif");
}*/
//-----------------------------------------------------------------------------
// 3. biti 1 yapalım diğer bitlere dokunulmayacak
// 1 or x = 1
// x or 0 = x
// 00000000100
//a = a | 4;
//a = a | 0x4; 
//-----------------------------------------------------------------------------
// 32. biti bir yapmaya çalışalım
// 1000000..000
//long a = 3;
//a = a | 0x80000000;
//Console.WriteLine(a);
//-----------------------------------------------------------------------------
// 9. ve 10. bitleri bir yapalım
// 0000 0011 0000 0000 --> maske --> 0x00000300 --> 0x300                0x300        1100 1111 1111
//int a = 0;
//a = a | 0x300;
//Console.WriteLine(a);
//------------------------------------------------------------------------------
// 9. ve 10. bitleri sıfır yapalım
// 0 and x = 0
// 1 and x = x
// maske --> 1111 1100 1111 1111 --> hex karş. 0xfffffcff
//a = a & 0xfffffcff;
//Console.WriteLine(a);
//------------------------------------------------------------------------------
// 27. biti bir 28. biti sıfır yapalım
// maske --> 0000 0100 0000 0000 0000 0000 0000 0000 --> hex karş. 0x04000000 27.bit 1 or yapılacak
// maske --> 1111 0011 1111 1111 1111 1111 1111 1111 --> hex karş. 0xf7ffffff 28. bit 0 and yapılacak
//------------------------------------------------------------------------------
// 1024 e kadar sayıları binary ekrana bastıralım ---> hatalı
// int[] bin = new int[10]; // Dizinin boyutunu 10 olarak değiştirdik, çünkü 10 basamaklı en büyük binary sayı 1023'dür.
// int adt = 0;

// while (adt < 1024)
// {
//     for (int i = 9; i >= 0; i--) // Diziyi tersten yazdırmak için döngü sırasını değiştirdik.
//     {
//         Console.Write(bin[i]);
//     }ƒ
//     Console.WriteLine("");              
//     adt++;

//     bin[0]++;
//     int lvl = 0;
//     while (lvl < 9 && bin[lvl] == 2) // Döngünün sona ermesi için 'lvl < 9' koşulunu ekledik.
//     {
//         bin[lvl] = 0;
//         lvl++;
//         bin[lvl]++;
//     }
// }
//------------------------------------------------------------------------------
// shift kaydırma
//  (>>) sağa shift (<<) sola shift
// sola shift sayının iki ile çarpımına eşittir
// sağ shift sayının iki ile bölümüne eşittir
//------------------------------------------------------------------------------
// bir sayının binary karşılığında kaç adet bir var
/*
long a = 534534;
uint b = 1; //10000000
int adt = 0;
a = 0xffffffff;
System.Console.WriteLine(a);
for (int i = 0; i < 33; i++)
{
    if ((a&b)!=0)
    {
        adt++;  
    }
    b = b << 1;
}

// 2. çözüm
for (int i = 0; i < 33; i++)
{
    if ((a & 1) == 1)
    {
        adt++;
    }
    a = a >> 1;
}
Console.WriteLine(adt);
*/
//------------------------------------------------------------------------------
// verilen sayıyı binary sayıya çevirelim
//int a = 345345433;
//------------------------------------------------------------------------------     ****** BURADA NE YAPILIYOR TAM ANLAMADIM BİR DAHA BAKACAĞIM
// a=b mi ?

// long a = 0xf0f0f0f0;
// long c = a;
// uint b = 0;
// for (int i = 0; i < 33; i++)
// {
//     if ((a&1) == 1)  
//     {
//         b = b | 1;
//     }
//     else
//     {
//         b = b & 0xfffffffe;
//     }
//     b = b << 1;
//     a = a >> 1;
// }
// Console.WriteLine(b);
// Console.WriteLine(c);

//------------------------------------------------------------------------------
//25.03.2024
// binary search

/*static int bsearch(int[] x, int left,int right, int data)
{
    int indis = left + right;
    indis = indis / 2; // orta değer
    if (left==right)
    {
        if (x[indis]==data)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    if (x[indis]==data)
    {
        return 1;
    }
    else if (x[indis]<data)
    {
        return bsearch(x,indis+1,right,data); // indisi kontrol ettik o yüzden bir arttırdık
    }
    else
    {
        return bsearch(x,left,indis-1,data);
    }
}
int[] x = new int[1000];
for (int i = 0; i < 1000; i++)
{
    x[i] = i;
}
for (int i = 0; i < 1000; i++)
{
    
}*/
//------------------------------------------------------------------------------------
//pi sayısı
//1.ÇÖZÜM
/*double pi = 2;
for (int i = 2; i <100000 ; i=i+2)
{
    pi = pi * (double) i / (i - 1) * i / (i + 1);
}
Console.WriteLine(pi);*/
//2.ÇÖZÜM
/*double pi = 0;
int f = 1;
for (int i = 1; i < 100000; i=i+2)
{
    pi = pi + (double)f * 4 / i;
    f = f * -1;
}*/
//--------------------------------------------------------------------------------
// LONGEST COMMON SUBSTRING 

// string st1 = "zabz123zdefz67890az";
// string st2 = "xxabx123xxdefz6xxx6z90a";
// int eb = 0;
// //1.ÇÖZÜM

// for (int i = 0; i < st1.Length; i++)
// {
//     int ind = 0;
//     int adt = 0;
//     for (int j = 0; j < st2.Length && i + ind < st1.Length; j++)
//     {
//         if (st1[i + ind] == st2[j])
//         {
//             ind++;
//             adt++;
//         }
//         else
//         {
//             ind = 0;
//             if (eb < adt)
//             {
//                 eb = adt;
//             }
//             adt = 0;
//         }
//     }
//     if (eb < adt)
//     {
//         eb = adt;
//     }
// }


// Console.WriteLine("Longest common substring length: " + eb);



string s1 = "abadeghıjklm";
string s2 = "absıaklm";
int[,] lcs = new int[s1.Length, s2.Length];
int eblcs = 0;
for (int i = 0; i < s1.Length; i++)
{
    for (int j = 0; j < s2.Length; j++)
    {
        if (s1[i] == s2[j])
        {
            if (i == 0 || j == 0) { lcs[i, j] = 1; }
            else { lcs[i, j] = lcs[i - 1, j - 1] + 1; }
            if (eblcs < lcs[i, j]) { eblcs = lcs[i, j]; }
        }


    }

}
System.Console.WriteLine("Longest common substring length 'eblcs': " +eblcs);


//2.ÇÖZÜM
/*
int[,] lcss = new int[st1.Length,st2.Length];
for (int i = 0; i < st1.Length; i++)
{
    for (int j = 0; j < st2.Length; j++)
    {
        if (st1[i]==st2[j])
        {
            if (i==0 || j==0)
            {
                lcss[i,j] = 1;
            }else
            {
                lcss[i,j] = lcss[i-1,j-1]+1;
                if (eb<lcss[i,j])
                {
                    eb = lcss[i,j];
                }
            }
        }
        if (eb<lcss[i,j])
        {
            eb = lcss[i,j];
        }
    }
}
System.Console.WriteLine(eb);

*/
// static void Lcss(int[,] lcss,int[,]x,string st1, string st2,int indis)
// {
//     int i = indis / st1.Length;
//     int j = indis % st1.Length;
//     if (indis >= st1.Length*st2.Length)
//     {
//         return;
//     }
//     if (st1[i]==st2[j])
//         {
//             if (i==0 || j==0)
//             {
//                 lcss[i,j] = 1;
//             }else
//             {
//                 lcss[i,j] = lcss[i-1,j-1]+1;
//                 if (eb<lcss[i,j])
//                 {
//                     eb = lcss[i,j];
//                 }
//             }
//         }


// }

// System.Console.WriteLine("hi");
//----------------------------------------------------------------------------------
//LONGEST COMMON SUBSEQUENCE   //LONGEST PALİNDROMİC WORD
// a sayısının 10,11,12,13 ve 14. bitlerden oluşan bit grubunu  1 arttıralım

