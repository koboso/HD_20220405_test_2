using System;


class Program{
//2. while만 이용하여 2단 4단 6단 구구단을 출력하는 프로그램을 작성하세요.
    static void Main(string[] args){
 
        /*
        2 * 1 = 2
        2 * 2 = 4
        2 * 3 = 6
            ...

        k= k+2;
        k+=2;

        */
        /*
        for(int k = 2; k<=6; k+=2){
            for (int i = 1; i <= 9; i++){
                Console.WriteLine($"{k} * {i} = {i * k}");
            }
            Console.WriteLine(" ");
        }
        */

        int j = 2;
        while (j <= 6){
            int l = 1;
            while (l <= 9){
                Console.WriteLine($"{j} * {l} = {j * l}");
                l++;
            }
            j+=2;
            Console.WriteLine("");
        }
    }
}
