using System;


namespace c__learning
{
    class Program //class container that we can contain code.
    {
        static void Main(string[] args) //main
        {
            /*int[] luckynumbers={2,8,13,65,15,34};
            string[] friends=new string[3];
            friends[0]="jim";
            friends[1]="jane";
            friends[2]="jay";
            friends[3]="emilly";
            Console.WriteLine(string[2] friends);*/
            /*Sayhi("Mike!!",12);
            Sayhi("John!",45);
            Sayhi("Jim!",17);
            /*static void Sayhi(string name,int age){ /*function to use.
            Console.WriteLine("Hello "+name+ " you are " +age+" years old.");
            }*/
            //--------class &objects:
            /*double num1,num2;
            string opr;
            Console.Write("pls enter your number : ");
            num1=Convert.ToDouble(Console.ReadLine());
            Console.Write("pls enter your operator: ");
            opr=Console.ReadLine();
            Console.Write("pls enter the second number: ");
            num2=Convert.ToDouble(Console.ReadLine());
            if(opr == "+"){
                double sum;
                sum=num1+num2;
                    Console.WriteLine(+num1+ "+" +num2+ "=" +sum);
            }
            else if(opr == "/"){
                double divide;
                divide=num1/num2;
                Console.WriteLine(+num1+ "/" +num2+ "=" +divide);
            }*/
            //===========================--------calculator:
            double num1;
            string op,option;
            double num2;
            Console.WriteLine("this is a calcultor program with using c#.\n");
            do{
            Console.Write("pls enter a number: ");
            num1= Convert.ToDouble(Console.ReadLine());    
            Console.Write("pls enter a operator(*,/,+,-,%): ");
            op= Console.ReadLine();
            Console.Write("pls enter a number: ");
            num2=Convert.ToDouble(Console.ReadLine());     
            if(op=="+"){
                double sum;
                sum=num1+num2;
            Console.WriteLine(+num1+ "+" +num2+ "=" +sum);
            }
            else if(op=="-"){
                double minus;
                minus=num1-num2;
            Console.WriteLine(+num1+ "-" +num2+ "=" +minus);
            }
            else if(op=="*"){
                double multiple;
                multiple=num1*num2;
            Console.WriteLine(+num1+ "*" +num2+ "=" +multiple);
            }
            else if(op=="/"){
                double divide;
                divide=num1/num2;
            Console.WriteLine(+num1+ "/" +num2+ "=" +divide);
            }
            else if(op=="%"){
                double remainder;
                remainder=num1%num2;
                Console.WriteLine(+num1+ "%" +num2+ "=" +remainder);
            }
            else{
            Console.WriteLine("error");
            }
            Console.Write("want to continue?: ");
            option=Console.ReadLine();
            }while(option=="y");

        }   
        
        
            
    }

}
