public class Class1
    {
        public static int FPB(int x, int y)
        {
            int temp;
           
            while (y > 0)
            {
                temp = x %  y ;
                x = y;
                y = temp;
             
            }
            return x;
        }
        public static int KPK(int a, int b)
        {
            int hasil = a;

            while (hasil % b != 0)
            {
                hasil = hasil + a;
            }

            return hasil;
        }

        public static string turunan(int[] persamaan)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            while(d < 3)
            {
                a = persamaan[0] * 3;
                b = persamaan[1] * 2;
                c = persamaan[2] * 1;

                d = d + 1;

            }
            string tur = a + "x2 + " + b + "x + " + c;
            return tur;

        }

        public static string integral(int[] persamaan)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            while(d < 4) {
                a = persamaan[0] / 4;
                b = persamaan[1] / 3;
                c = persamaan[2] / 2;
                d = persamaan[3] / 1;
                
                e = e + 1;
            }

            string dia = "x" + a + " " + b + "x3 + " + c + "x2 + " + "C";
            return dia;
        }
    }
    
    
int kp = Class1.FPB(60, 45);
Console.WriteLine(kp);

int fp = Class1.KPK(12, 8);
Console.WriteLine(fp);

Console.WriteLine(Class1.turunan( new int[] {1, 4, -12, 9, 1} ));

Console.WriteLine(Class1.integral(new int[] {4, 6, -12, 9 }));
