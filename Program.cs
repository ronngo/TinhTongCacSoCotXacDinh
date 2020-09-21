using System;

namespace TinhTongCacSoCotXacDinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] A = new int[100, 100];
            int d, c;
            do
            {
                Console.WriteLine("Nhap so dong : ");
                d = int.Parse(Console.ReadLine());
                if (d  <= 0)
                {
                    Console.WriteLine("So dong khong hop le, nhap lai !");
                }
            } while (d <= 0);
            do
            {
                Console.WriteLine("Nhap so cot :");
                c = int.Parse(Console.ReadLine());
                if (c <= 0)
                {
                    Console.WriteLine("So cot khong hop le, nhap lai !");
                }
            } while (c <= 0);

            NhapMang(ref A, ref d, ref c);
            XuatMang(A, d, c);
            TongTrenDong(A, d, c);
            Console.ReadLine();
        }

       static void NhapMang(ref int[,] A, ref int d, ref int c)
        {
          
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("Nhap theo thu tu dong -> cot[{0}][{1}] :", i / c, i % c);
                A[i / c, i % c] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[,] A, int d, int c)
        {
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("{0}    ", A[i % c, i / c]);
                if ((i + 1) % c == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        static void TongTrenDong(int[,] A, int d, int c)
        {
            
            int tong = 0;
            for (int i = 0; i < c * c; i++)
            {
                tong += A[i / c, i % c];
                if ((i + 1) % c == 0)
                {
                    Console.WriteLine("Nhap cot can tinh tong: ");
                    c = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Tong cot {0} la : {1}", i / c, tong);
                    tong = 0;
                    break;
                }
            }
        }

    }
}