using System;

namespace csharpintro
{
    class Program
    {
        //1
          Boolean tf= true;
        String name= "tony Laing";
         int i=0;

        public Program(){
                tf= false;
     
           /*this is multi line comment  */ name= "Tony Liang";
            for( i =0; i < 5; i ++ ){
                    Console.WriteLine("tf: "+ tf + " name: "+ name + " i "+ i);
                if( i==1){
                    Console.WriteLine("in if loop "+" i \t\t\t\t\t\t\t"+ i);

                }else if(i==0){
                    Console.WriteLine("in if loop "+" i "+ i);

                }else{
                    Console.WriteLine("what is this");

                }
            }

            while (i >0){

                switch(i){
                    case 1: Console.WriteLine("red");
                            break;
                    case 2: Console.WriteLine("blue");
                            break;
                    default : break;

                }
                        Console.WriteLine("tf: "+ tf + " name: "+ name + " i "+ i);
                i--;
            }
             
        }
        static void Main(string[] args)
        {  
            Program p = new Program();
                       
            addition(5, 5);
            var b=6;
            Program.addition(b, b);

        }

         static void addition(int a, int b ){
            Console.WriteLine(a+b);
           

        }
       
    }
}
