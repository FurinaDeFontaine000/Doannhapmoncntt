using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_14__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n nhap dung theo cac truong hop ");
            Console.WriteLine("          | K B K |              ");
            Console.WriteLine("          | K B B |              ");
            Console.WriteLine("          | K K K |              ");
            Console.WriteLine("          | B G B |              ");
            Console.WriteLine("          | B G G |              ");
            Console.WriteLine("          | B B B |              ");
            Console.WriteLine("          | G K G |              ");
            Console.WriteLine("          | G K K |              ");
            Console.WriteLine("          | G G G |              ");
            Console.WriteLine("          | K B G |              ");
            Console.WriteLine(" nhap dung theo cac truong hop \n");

            char K, B, G, chon1, chon2, chon3;
            Console.WriteLine("nhap keo bam K");
            Console.WriteLine("nhap bua bam B");
            Console.WriteLine("nhap giay bam G");
            chon1 = char.Parse(Console.ReadLine());
            Console.WriteLine("nhap keo bam K");
            Console.WriteLine("nhap bua bam B");
            Console.WriteLine("nhap giay bam G");
            chon2 = char.Parse(Console.ReadLine());
            Console.WriteLine("nhap keo bam K");
            Console.WriteLine("nhap bua bam B");
            Console.WriteLine("nhap giay bam G");
            chon3 = char.Parse(Console.ReadLine());
            switch (chon1)
            {
                case 'K':
                    {
                        switch (chon2)
                        {
                            case 'K':
                                {
                                    switch (chon3)
                                    {
                                        case 'K':
                                            {
                                                Console.WriteLine("ket qua hoa");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                        switch (chon2)
                        {
                            case 'B':
                                {
                                    switch (chon3)
                                    {
                                        case 'K':
                                            {
                                                Console.WriteLine("ket qua mot bua an hai keo thua");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                        switch (chon2)
                        {
                            case 'B':
                                {
                                    switch (chon3)
                                    {
                                        case 'B':
                                            {
                                                Console.WriteLine("ket qua hai bua an mot keo thua");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                    }
                    break;
            }
            switch (chon1)
            {
                case 'B':
                    {
                        switch (chon2)
                        {
                            case 'B':
                                {
                                    switch (chon3)
                                    {
                                        case 'B':
                                            {
                                                Console.WriteLine("ket qua hoa");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                        switch (chon2)
                        {
                            case 'G':
                                {
                                    switch (chon3)
                                    {
                                        case 'B':
                                            {
                                                Console.WriteLine("ket qua mot giay an hai bua thua");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                        switch (chon2)
                        {
                            case 'G':
                                {
                                    switch (chon3)
                                    {
                                        case 'G':
                                            {
                                                Console.WriteLine("ket qua hai giay an mot bua thua");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                    }
                    break;
            }
            switch (chon1)
            {
                case 'G':
                    {
                        switch (chon2)
                        {
                            case 'G':
                                {
                                    switch (chon3)
                                    {
                                        case 'G':
                                            {
                                                Console.WriteLine("ket qua hoa");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                        switch (chon2)
                        {
                            case 'K':
                                {
                                    switch (chon3)
                                    {
                                        case 'G':
                                            {
                                                Console.WriteLine("ket qua mot keo an hai giay thua");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                        switch (chon2)
                        {
                            case 'K':
                                {
                                    switch (chon3)
                                    {
                                        case 'K':
                                            {
                                                Console.WriteLine("ket qua hai keo an mot giay thua");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                    }
                    break;
            }
            switch (chon1)
            {
                case 'K':
                    {
                        switch (chon2)
                        {
                            case 'B':
                                {
                                    switch (chon3)
                                    {
                                        case 'G':
                                            {
                                                Console.WriteLine("ket qua hoa");
                                                break;
                                            }
                                    }
                                }
                                break;
                        }
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
