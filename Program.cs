
using CompProgramming;

var w = Int32.Parse(System.Console.ReadLine());
 Watermelon.GetResult(w);

 public class Watermelon {

        public static void GetResult(int w){
            if (w<=100 && w >=1)
            {
            if (w%2 ==0 && w >3)
            {
                System.Console.WriteLine("YES");
            }
            
            else{
                System.Console.WriteLine("No");
            } 
                
            }else
            {
                System.Console.WriteLine("No");
            }
        }
    }