using System;

namespace Tema2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ok;
            int a, b, c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,x,w,y,z,id = 0;
            a=b=c=d=e=f=g=h=i=j=k=l=m=n=o=p=q=r=s=t=u=v=x=w=y=z=id;

            int ind;
            string[][] cuvinted = new string[24][];
            
            for (int index = 0; index < 24; index++)
                cuvinted[index] = new string[6];
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                for(ind=0;ind<args.Length;ind++)
                {
                    string param = (string)args.GetValue(ind);
                    string first = param.ToLower();
                    switch (first[0])
                    {
                        case 'a':
                            cuvinted[0][a] = param;
                            a++;
                            break;
                        case 'b':
                            cuvinted[1][b] = param;
                            b++;
                            break;
                        case 'c':
                            cuvinted[2][c] = param;
                            c++;
                            break;
                        case 'd':
                            cuvinted[3][d] = param;
                            d++;
                            break;
                        case 'e':
                            cuvinted[4][e] = param;
                            e++;
                            break;
                        case 'f':
                            cuvinted[5][f] = param;
                            f++;
                            break;
                        case 'g':
                            cuvinted[6][h] = param;
                            h++;
                            break;
                        case 'i':
                            cuvinted[7][i] = param;
                            i++;
                            break;
                        case 'j':
                            cuvinted[8][j] = param;
                            j++;
                            break;
                        case 'k':
                            cuvinted[9][k] = param;
                            k++;
                            break;
                        case 'l':
                            cuvinted[10][l] = param;
                            l++;
                            break;
                        case 'm':
                            cuvinted[11][m] = param;
                            m++;
                            break;
                        case 'n':
                            cuvinted[12][n] = param;
                            n++;
                            break;
                        case 'o':
                            cuvinted[13][o] = param;
                            o++;
                            break;
                        case 'p':
                            cuvinted[14][q] = param;
                            q++;
                            break;
                        case 'r':
                            cuvinted[15][r] = param;
                            r++;
                            break;
                        case 's':
                            cuvinted[16][s] = param;
                            s++;
                            break;
                        case 't':
                            cuvinted[17][t] = param;
                            t++;
                            break;
                        case 'u':
                            cuvinted[18][u] = param;
                            u++;
                            break;
                        case 'v':
                            cuvinted[19][v] = param;
                            v++;
                            break;
                        case 'w':
                            cuvinted[20][w] = param;
                            w++;
                            break;
                        case 'x':
                            cuvinted[21][x] = param;
                            x++;
                            break;
                        case 'y':
                            cuvinted[22][y] = param;
                            y++;
                            break;
                        case 'z':
                            cuvinted[23][z] = param;
                            z++;
                            break;
                    }

                    
                }
                for(int linie = 0;linie < 24; linie++)
                {
                    ok = 0;
                    for (int coloana = 0; coloana < 6; coloana++)
                        if (cuvinted[linie][coloana] != null)
                        { Console.Write(cuvinted[linie][coloana] + " "); ok = 1; }
                    if(ok==1)
                        Console.WriteLine();
                }
                
            }
            Console.ReadKey();
        }
    }
}
