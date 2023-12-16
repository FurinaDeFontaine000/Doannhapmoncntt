/*Pham Thanh Hung
 * CD23TT10
 * 23211TT2523
 * bai tong hop
 */
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tong_hop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cho ma char t la default de co the tiep tuc bai hay ko
            char tieptuc = default;
            //khai bao bien de lua chon bai
            int tongbai;
            do
            {
                Console.Clear();
                do
                {
                    Console.Clear();
                    //hien ra menu
                    Console.WriteLine(" menu");
                    Console.WriteLine("chon bai 1 : nhan 1");
                    Console.WriteLine("chon bai 2 : nhan 2");
                    Console.WriteLine("chon bai 3 : nhan 3");
                    Console.WriteLine("chon bai 4 : nhan 4");
                    Console.WriteLine("chon bai 5 : nhan 5");
                    Console.WriteLine("chon bai 6 : nhan 6");
                    Console.WriteLine("chon bai 7 : nhan 7");
                    Console.WriteLine("chon bai 8 : nhan 8");
                    Console.WriteLine("chon bai 9 : nhan 9");
                    Console.WriteLine("chon bai 10: nhan 10");
                    Console.WriteLine("chon bai 11: nhan 11");
                    Console.WriteLine("chon bai 12: nhan 12");
                    Console.WriteLine("nhap dung ko thi se lap lai");
                    //nhap den khi dung ma so
                    bai = int.Parse(Console.ReadLine());
                    if (tongbai >= 13 || bai <= 0)
                    {
                        Console.WriteLine("vui long nhap lai tu 1 den 12");
                        tongbai = int.Parse(Console.ReadLine());
                    }
                    
                }while (tongbai >= 13||bai <= 0);
                // tao cau truc lua chon
                Console.WriteLine("nhap so nguyen n :");
                int n = int.Parse(Console.ReadLine());
                switch (tongbai)
                {

                    case 1://bai 1
                        //cho ham soduong in ra ket o ham main
                        int c = n;
                        c = soduong(c);
                        Console.WriteLine("so nguyen vua nhap la : {0}",c);
                        Console.ReadKey();
                        break;
                    case 2://bai 2
                        Console.WriteLine("nhap mot so nguyen :");
                        //tao bang menu de lua chon
                        Console.WriteLine("--------------menu-----------------");
                        Console.WriteLine("a:tong cac so le cua 3 nho hon bang n");
                        Console.WriteLine("b:tich cac boi so cua 3 nho hon bang n ");
                        Console.WriteLine("c:1+1/2+1/3+...+1/n-1");
                        Console.WriteLine("d:2*4*6*..*2n");
                        Console.WriteLine("e:1*2*3*...*n");
                        //nhap de lua chon
                        char choie = char.Parse(Console.ReadLine());
                        //luc chon va in ket qua
                        switch (choie)
                        {
                            case 'a': Console.WriteLine("tong cac so le cua 3 nho hon bang n la {0}", tongsole(n)); break;
                            case 'b': Console.WriteLine("tich cac boi so cua 3 nho hon bang n la {0}", tongtich(n)); break;
                            case 'c': Console.WriteLine("1+1/2+1/3...+1/n-1 la {0}", tongchia(n)); break;
                            case 'd': Console.WriteLine("2*4*6*...*2n la {0}", tongnhan2(n)); break;
                            case 'e': Console.WriteLine("1*2*3*...*n la {0}", luythua(n)); break;
                        }
                        Console.ReadKey();
                        break;
                    case 3://bai 3
                        //su dung cac ham de in ket qua
                        Console.WriteLine("tong uoc so:{0} ", uocso(n));
                        Console.WriteLine("cac uoc so :{0}", dem(n));
                        Console.ReadKey();
                        break;
                    case 4://bai 4
                        //su dung ham de co thi in ra ket qua tru false
                        bool Lasonguyento = lasonguyento(n);
                        //neu la tru thi se la so nguyen ko thi ko phai so nguyen to
                        if (Lasonguyento)
                        {
                            Console.WriteLine("la so nguyen to");
                        }
                        else
                        {
                            Console.WriteLine("la ko phai so nguyen to");
                        }
                        Console.ReadKey();
                        break;
                    case 5://bai 5
                        //neu ham lasochinhphuong true thi ket qua la so chinhphuong
                        //false thi la ko phai so chinh phuong
                        if (lasochinhphuong(n))
                        {
                            Console.WriteLine("so {0} la so chinh phuong ", n);
                        }
                        else
                        {
                            Console.WriteLine("so {0} khong phai la so chinh phuong", n);
                        }
                        Console.ReadKey();
                        break;
                    case 6://bai 6
                        // neu lasohoanhao tru thi la ket qua so hoan hao
                        //false thi ra ket qua ko phai so hoan hao
                        if (lasohoanhao(n))
                        {
                            Console.WriteLine("so do la so hoan hao :{0}", n);

                        }
                        else
                        {
                            Console.WriteLine("so do ko phai la so hoan hao : {0}", n);
                        }
                        Console.ReadKey();
                        //theo de bai thi liet ke cac so hoan hao tu 1 den 1000
                        Console.WriteLine("liet ke cac so hoan hao tu 1 den 1000");
                        for (int j = 1; j <= 1000; j++)
                        {
                            //su dung ham den liet ke
                            if (lasohoanhao(j))
                            {
                                Console.WriteLine(j);
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 7://bai 7
                        //dua vao ham lasodoixung thi du lieu true thi ra ket qua la so doi xung 
                        // false thi ra ket ko phai so doi xung
                        if (lasodoixung(n))
                        {
                            Console.WriteLine("la so doi xung : {0}", n);
                        }
                        else
                        {
                            Console.WriteLine("ko phai so doi xung : {0}", n);
                        }
                        Console.ReadKey();
                        //theo de bai liet ke cac so doi xung tu 1 den 500
                        Console.WriteLine("liet cac so doi xung tu 1 den 500");
                        for (int k = 1; k <= 500; k++)
                        {
                            if (lasodoixung(k))
                            {
                                Console.WriteLine(k);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 8://bai 8
                        //neu n gia tri am thi sai so voi so fibonaci
                        if (n < 0)
                        {
                            Console.WriteLine("vui long nhap lai");
                            return;
                        }
                        //cho sofibanci = ham fibonaci va in ket qua dua tren tinh toan cua ham fibaoonci
                        int sofibonaci = fibonaci(n);
                        Console.WriteLine("so hang cua {0} cua fibonaci {1}", n, sofibonaci);
                        Console.ReadKey();
                        break;
                    case 9://bai 9
                        //khai bao kieu du lieu
                        int b; int gcd; int lcm;
                        //nhac nhap du lieu
                        Console.WriteLine("cho gia tri n la a");
                        Console.WriteLine("nhap them gia tri b");
                        b = Convert.ToInt32(Console.ReadLine());
                        //dua vao ham thi in ra ket qua
                        (gcd, lcm) = uscln_bscnn(n, b);
                        Console.WriteLine("USCLN cua {0} va {1} la {2}.", n, b, gcd);
                        Console.WriteLine("BSCNN cua {0} va {1} la {2}.", n, b, lcm);
                        Console.ReadKey();
                        break;
                    case 10://bai 10
                        // khai bao bien cho count = 1
                        int count = 1;

                        // Duyet so tu 1 den n
                        for (int l = 1; l <= n; l++)
                        {
                            // Kiem tra i co phai so hoan hao ko
                            if (lasohoanhao1(l))
                            {
                                count++;
                            }
                        }
                        // In ra ket qua
                        Console.WriteLine(" so hoan hao nho hon hoac bang N la {0}.", count);
                        Console.ReadKey();
                        break;
                    case 11://bai 11
                        // Khoi tao bien dem
                        int i = 1;

                        // Duyet tu 1 den n
                        while (i <= n)
                        {
                            // Kiem tra i co phai la so chinh phuong kok
                            if (lasochinhphuong1(i))
                            {
                                Console.WriteLine(i);
                            }
                            i++;
                        }
                        Console.ReadKey();
                        break;
                    case 12://bai 12
                        // Nhac nhap
                        Console.WriteLine("!!khong nen dung qua nhieu so vi day la ham de quy!! ");
                        Console.WriteLine("!!vo cung hai may!!");
                        Console.WriteLine("in day tu 0 den n");
                        // Duyet cac so tu 0 den n
                        for (int z = 0; z <= n; z++)
                        {
                            // In ra so fibonacci thu i
                            Console.WriteLine(Fibonacci(z));
                        }
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("ban co muon tiep tuc ko Y/N ?");
                 t = char.Parse(Console.ReadLine());
            } while (t == 'Y' || t == 'y');
        }
        //ham bai 1 
        static int soduong(int c)
        {
            //nhap so nguyen duong,neu la so nguyen am thi nhap lai
            do
            {
                //Nhap den khi nao so do lon hon 0 thi dung
                if (c <= 0)
                { 
                    Console.WriteLine("vui long nhap lai");
                    c = int.Parse(Console.ReadLine());
                }
                
            } while (c <= 0);return c;
        }
        //ham bai 2 
        //ham bai a
        static int tongsole(int n)
        {
            //khai bao bien
            int sole = 0;
            //duyet tu 1 den n va cong 2 moi lan
            for (int i = 1; i <= n; i += 2)
            {
                sole += i;//so le se cong len voi i
            }
            return sole;
        }
        //ham bai b
        static int tongtich(int n)
        {
            //khai bao boi
            int boi = 1;
            //duyet tu 1 den n mot moi lan len thi cong 3
            for (int i = 1; i <= n; i += 3)
            {
                //boi se nhan den i
                boi *= i;
            }
            return boi;
        }
        //ham bai c
        static double tongchia(int n)
        {
            //khai bao kieu du lieu
            double chia = 0.0;
            //duyet tu 1 den n moi lan len thi cong 1
            for (int i = 1; i <= n; i++)
            {
                //moi lan cong thi cong 1/i
                chia += 1 / (float)i;
            }
            return chia;
        }
        //ham bai d
        static int tongnhan2(int n)
        {
            //khai bao kieu du lieu
            int sonhan = 1;
            //tu 1 den n moi lan cong them 2 
            for (int i = 1; i <= n; i += 2)
            {
                //moi lan len thi cong nhan i
                sonhan *= i;
            }
            return sonhan;
        }
        //ham bai e 
        static int luythua(int n)
        {
            //khai bao du lieu
            int luythua = 1;
            //tu 1 den n moi len thi cong 1
            for (int i = 1; i <= n; i += 1)
            {
                //moi lan len thi cong nhan i
                luythua *= i;
            }
            return luythua;
        }
        //ham bai 3 
        //ham uoc so
        public static int uocso(int n)
        {
            //khai bao kieu du lieu
            int sum = 0;
            //duyet tu 1 den so mot lan cong them 1 
            for (int i = 1; i <= n; i++)
            {
                //neu so chi ko du thi cong them i
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        //ham dem
        public static int dem(int n)
        {
            //khai bao kieu du lieu
            int dem = 0;
            //duyet tu 1 den so mot lan cong them 1 
            for (int i = 1; i <= n; i++)
            {
                //neu thi so ko du thi dem se cong them 1
                if (n % i == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        //ham bai 4 
        //su dung ham bool
        public static bool lasonguyento(int n)
        {
            //neu n am thi ko phai so nguyen to
            if (n < 0)
            {
                return false;
            }
            //duyet tu 2 den i*i =n mot lan cong them 1
            for (int i = 2; i * i <= n; i++)
            {
                //neu n chia 1 ko du thi ko phai so nguyen to
                if (n % i == 0)
                {
                    return false;

                }
            }
            //neu n chia i du thi la so nguyen to
            return true;
        }
        //ham bai 5 
        //dung ham bool de so sanh
        public static bool lasochinhphuong(int n)
        {
            //neu n ko du thi false
            if (n % 2 == 0)
            {
                return false;
            }
            //dung toan can bac bac
            double canbac = Math.Sqrt(n);
            //neu toan bac bac bang chinh no thi dung
            if (Math.Round(canbac) == canbac)
            {
                return true;
            }
            //ko thi ra ket qua sai
            return false;
        }
        //ham bai 6 
        //su dung ham bool 
        public static bool lasohoanhao(int n)
        {
            //khai bao kieu du lieu
            int sohoanhao = 0;
            //tu 1 den n/2 mot lan cong hem 1 
            for (int i = 1; i <= n / 2; i++)
            {
                //neu n ko du cong them i
                if (n % i == 0)
                {
                    sohoanhao += i;
                }
            }
            //cho den sohaohao == n thi dung ko thi sai
            if (sohoanhao == n) return true;
            return false;
        }
        //ham bai 7 
        //su dung ham bool 
        public static bool lasodoixung(int n)
        {
            //neu gia tri duoi 10 thi luon la so doi xung 
            if (n < 10)
            {
                return true;
            }
            //khai bao kieu du lieu
            int sodoixung = 0;
            //tu 1 den i>0 moi lan thi cong them i/10
            for (int i = 1; i > 0; i /= 10)
            {
                //so doixung nhan 10
                sodoixung *= 10;
                //moi lan len thi cong them i%10
                sodoixung += i % 10;
            }
            // cho so doi xung % 10 == n %10
            return sodoixung % 10 == n % 10;
        }
        //ham bai 8
        //ham int fibonaci
        public static int fibonaci(int n)
        {
            //gia n = 0 hoac 1 thi ra ket qua luon
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                //neu gia tri lon hon 1 thi tinh toan fibonaci
                return fibonaci(n - 1) + fibonaci(n - 2);
            }
        }
        //ham bai 9 
        //ham uscln va bscnn
        public static (int gcd, int lcm) uscln_bscnn(int n, int b)
        {
            //neu gia a hoac b = 0 thi in ra ket qua luon 
            if (n == 0 || b == 0)
            {
                return (n, b);
            }
            //khai bao du lieu
            int gcd = 0;
            //cho den khi b ko = 0
            while (b != 0)
            {
                //lay gia tri temp la so du cua a va b
                int temp = n % b;
                //cho a - b
                n = b;
                //cho b bang temp
                b = temp;
                //cho gcd = a
                gcd = n;
            }
            //va tinh gai lcm bang a*b / gcd
            int lcm = n * b / gcd;
            return (gcd, lcm);//chuyen ket qua len ham main
        }
        //ham bai 10
        //su dung ham bool
        private static bool lasohoanhao1(int n)
        {
            // Neu nho hon 6 thi ko phai so hoan hao
            if (n < 6)
            {
                return false;
            }

            // Khoi tao bien
            int sum = 1;

            // Duyet tu 2 den gia tri can bac hai cua n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                // Neu n ko du thi lay sum i+n/i
                if (n % i == 0)
                {
                    sum += i + n / i;
                }
            }

            // Neu tong chinh bang n thi chay dieu kien
            return sum == n;
        }       
        //ham bai 11 
        //ham bool
        private static bool lasochinhphuong1(int n)
        {
            // Neu n gia tri am thi ko phai la so chinh phuong
            if (n < 0)
            {
                return false;
            }

            // Tinh can bac hai cua n
            double sqrt = Math.Sqrt(n);

            // neu can bac hai binh phuong do thì bang chinh no thi la so chinh phuong
            return Math.Round(sqrt) == sqrt;
        }      
        // ham bai 12 
        // ham den tinh phuong fibonacci de quy
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        
    }
}
