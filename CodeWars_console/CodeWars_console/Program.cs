using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace CodeWars_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DuplicateCount("aabBcdeb"));
            // Console.WriteLine(DuplicadoLetra("191184196199193185184170198182179189182184195191170171181198"));
            //Console.WriteLine("Cuadrado Perfecto" + IsSquare2(25));
            //Console.WriteLine("Invirtiendo palabras : " + SpinWords("Hey fellow warriors"));
            //Console.WriteLine("Ordenando Numero de mayor a menor : " + DescendingOrder(25587849));
            //Console.WriteLine("Posicion de alfabeto : " + AlphabetPosition(">E\u00019DwI2\u0002C>U%[ XGx\u001fR.4"));      

            Console.WriteLine("Conversion hexadecimal : " + Rgb(255,255,255));
            Console.Read();
        }

        public static int[] ArregloDiff(int[] a,int[] b)
        {
            int x = 0;
            int[] c = new int[a.Length + b.Length];
            bool verdad = false;
            for(int i = 0; i<a.Length; i++)
            {
                for(int j = 0; j<b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        verdad = true;
                        
                    }
                }

                if (!verdad)
                {
                    c[x] = a[i];                  
                }

                verdad = false;
            }
            return c;
        }

        public static int DuplicateCount(string str)
        {

            int cont = 0;
            bool verdad = false;
            Console.WriteLine("Palabra : " + str);
            Console.WriteLine("Tamaño de Palabra : " + str.Length);
            string word = str.ToLower();
            Console.WriteLine("Palabra en minuscula: " + word);
            int y = 1;
            for(int i = 0; i<word.Length; i++)
            {
                for(int j = y; j < word.Length; j++)
                {
                    Console.WriteLine("Letra verificadora : " + word[i]);
                    Console.WriteLine("Letra evaluada : " + word[j]);
                    if (word[i].Equals(word[j]))
                    {
                        verdad = true;
                        break;
                    }
                }
                Console.WriteLine("------------------------------------------");
                if (verdad)
                {
                    y = 1;
                    i = 0;
                    cont++;
                    Console.WriteLine("Contador : " + cont);

                    word = word.Replace(Convert.ToString(word[i]),"");
                    Console.WriteLine("Nueva Palabra : " + word);
                }
                else
                {
                    y++;
                }
               
            }

            return cont;
        }

        public static int DuplicadoLetra(string palabra)
        {
            Console.WriteLine("Palabra =======> " + palabra);

            int tamaño = palabra.Length;
            Console.WriteLine("Tamaño =======> " + tamaño);

            string minuscula = palabra.ToLower();
            Console.WriteLine("Minuscula =======> " + minuscula);
            int contador = 0;
            int x = 0;
            int y = 1;
            bool verdad = false;
            while (x < tamaño)
            {
              
                for(int j = y;j<tamaño; j++)
                {
                    Console.WriteLine("Letras a verificar : " + "[" +minuscula[x] + "]" + "[" + minuscula[j] + "]");
                    //Console.WriteLine("Letra evaluada : " + minuscula[j]);
                    if(minuscula[x].Equals(minuscula[j]))
                    {
                        verdad = true;
                        break;
                    }
                }

                if (verdad)
                {
                    minuscula = minuscula.Replace(Convert.ToString(minuscula[x]), "");
                    Console.WriteLine("Nueva Palabra =======> " + minuscula);
                    x = 0;
                    y = 1;
                    tamaño = minuscula.Length;
                    contador++;
                Console.WriteLine("Comntador =======> " + contador);
                    Console.WriteLine("Nuevo tamaño =---------->" + tamaño);
                }
                else
                {
                    x++;
                    y++;
                }

                verdad = false;
                
            }

            return contador;
        }

        public static bool IsSquare(int n)
        {
            double num = Math.Sqrt(Convert.ToDouble(n));
            Console.WriteLine("Numero : ===> " + n);
            Console.WriteLine("Raiz : ===> " + num);
            bool verdad = num.ToString().Contains(",");

            if (verdad)
            {
                return false;
            }
            else
            {
                if (double.IsNaN(num))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool IsSquare2(int n)
        {
            double res = Math.Sqrt(n) % 1;
            if (res == 0)
            {
                return true;
            }
            else
            {
                return  false;
            }
            
        }

        public static string SpinWords(string sentence)
        {
            Console.WriteLine("Oracion : " + sentence);
            string[] arreglo = sentence.Split(' ');

            int x = 0;
            string nuevo = "";
            while(x < arreglo.Length)
            {
                if (arreglo[x].Length > 4)
                {
                    char[] palara = arreglo[x].ToCharArray();
                    Array.Reverse(palara);
                    arreglo[x] = new string(palara);
                    Console.WriteLine("Palabra inversa : " + arreglo[x]);
                }
                if (x == arreglo.Length - 1)
                {
                    nuevo += arreglo[x];
                }
                else
                {
                    nuevo += arreglo[x] + " ";
                }
                x++;
            }

            return nuevo;

        }

        public static int DescendingOrder(int num)
        {
            
            Console.WriteLine("Numero : " + num);
            if (num != 0)
            {
                int[] arreglo = new int[num.ToString().Length];


                for (int i = 0; i < num.ToString().Length; i++)
                {
                    arreglo[i] = Convert.ToInt32(num.ToString().Substring(i, 1));

                }
                string numero = "";
                int[] digitos;
                for (int i = 9; i >= 0; i--)
                {
                    digitos = arreglo.Where(x => x == i).ToArray();

                    if (digitos.Length > 1)
                    {
                        for (int j = 0; j < digitos.Length; j++)
                        {
                            numero += digitos[j];
                        }
                    }
                    else if (digitos.Length == 1)
                    {
                        numero += digitos[0];
                    }
                    else
                    {

                    }

                }



                return Convert.ToInt32(numero);
            }
            else
            {
                return 0;
            }
        }   

        public static string AlphabetPosition(string text)
        {
            Console.WriteLine("Texto : " + text);
            text = text.ToLower();
            string output = Regex.Replace(text, @"[^a-zA-Z]+", "");
            Console.WriteLine("Texto sin caracteres : " + output);

            char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            
            Dictionary<string, string> list = new Dictionary<string, string>();
            for(int i = 0; i<az.Length; i++)
            {
                list.Add(az[i].ToString(), (i+1).ToString());
            }

            string nuevo = "";
            for(int j = 0; j < output.Length; j++)
            {

                nuevo += list[output[j].ToString()] + " ";
            }

            return nuevo.TrimEnd();
        }

        public static string Rgb(int r, int g, int b)
        {
            Console.WriteLine("R : " + r + " G : " + g.ToString()  +" B : " + b.ToString());


            char[] hexadecimal = { '0', '1','2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            int[] conversion(int num)
            {
                if (num > 255)
                {
                    num = 255;
                }

                if (num < 0)
                {
                    num = 0;
                }

                List<int> arreglo = new List<int>();
                int x = num / 16;
                int y = 0;
                int a = num - (x * 16);
                arreglo.Add(a);
                while (x != 0)
                {
                    y = x / 16;
                    a = x - (y * 16);
                    arreglo.Add(a);
                    x = y;
                }

                return arreglo.ToArray();
            }

           

            string rgbHexa = "";

            int[] num1 = conversion(r);
            for(int i = num1.Length - 1; i > -1; i--)
            {
                if (num1.Length == 1)
                {
                    rgbHexa += "0" + hexadecimal[num1[i]];
                }
                else
                {
                    rgbHexa += hexadecimal[num1[i]];
                }
            }

            int[] num2 = conversion(g);
            for (int i = num2.Length - 1; i > -1; i--)
            {
                if (num2.Length == 1)
                {
                    rgbHexa += "0" + hexadecimal[num2[i]];
                }
                else
                {
                    rgbHexa += hexadecimal[num2[i]];
                }
            }
            int[] num3 = conversion(b);
            for (int i = num3.Length - 1; i > -1; i--)
            {
                if (num3.Length == 1)
                {
                    rgbHexa += "0" + hexadecimal[num3[i]];
                }
                else
                {
                    rgbHexa += hexadecimal[num3[i]];
                }
                
            }

            return rgbHexa;
        }

    }
}
