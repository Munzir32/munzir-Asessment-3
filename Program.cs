// See https://aka.ms/new-console-template for more information
/int a; int b;
            int min; int max;
            Console.WriteLine("Enter the first integer: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the second integer: ");
            b = int.Parse(Console.ReadLine());

            max = (a > b) ? a : b;
            min = (a < b) ? b : b;

            if (a!=b){
                Console.WriteLine("The minimum number is: " + min);
                Console.WriteLine("The maximum number is: " + max + "\n");
            }         
            else
            {
                Console.WriteLine("The numbers are both equal therefore there are 0 numbers in between them that are divisible by 5 and results to zero.");
            }

            int arrayspaces = 0; 
            for (int i = min; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    arrayspaces++;
                }
            }

            int counter = 0; int[] arr = new int[arrayspaces]; 
            for (int i = min; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    arr[counter] = i;
                    counter++;
                }
            }
                        
            Console.WriteLine("[{0}]", string.Join(", ", arr));            
            Console.WriteLine("There are {0} numbers that are divisible by 5 and results to zero between the min and max number.", counter);
            Console.ReadLine();


            Console.WriteLine("......2.........");
           int a = 0,b=1,c= 0;
            Console.Write("{0} {1}", a,b);
            for(int i=2; i<len; i++)
            {
                c=a+b;
                Console.Write("{0} , c");
                a= b;
                b= c;
            }
            int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); //printing 0 and 1    
         for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;
         }
            Console.WriteLine("----------------Question3-----------------");
 Console.Write("enter integer firstnumber: ");
 int firstNo = Convert.ToInt32(Console.ReadLine());
 Console.Write("enter secndnumber: ");
 int secondNo = Convert.ToInt32(Console.ReadLine());
 Console.Write("input thirdnumber: ");
 int thirdNo = Convert.ToInt32(Console.ReadLine());
 Console.Write("enter fourthnumber: ");
 int fourthNo = Convert.ToInt32(Console.ReadLine());
 Console.Write("enter fifthnumber: ");
 int fifthNo = Convert.ToInt32(Console.ReadLine());
 if(firstNo>secondNo && firstNo>thirdNo && firstNo>fourthNo && firstNo>fifthNo)
 {
 Console.WriteLine(firstNo);
 }
 else if (secondNo>firstNo && secondNo>thirdNo && secondNo>fourthNo && secondNo>fifthNo)
 {
   Console.WriteLine(secondNo);
 }
 else if (thirdNo>firstNo && thirdNo>secondNo && thirdNo>fourthNo && thirdNo>fifthNo)
 {
 Console.WriteLine(thirdNo);
 }
 else if(fourthNo>firstNo && fourthNo>secondNo && fourthNo>thirdNo && fourthNo>fifthNo)
 {
   Console.WriteLine(fourthNo);
 }
 else
 {
   Console.WriteLine(fifthNo);
 }

        int a = 3, b = 4, c = 5 , d= 7 e = 9;
Console.WriteLine(Math.Max(a,b,c,d,e));

        Console.WriteLine("---------question4--------------");
 Console.Write("enter coefficient of a: ");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.Write("enter coefficient of b: ");
int b = Convert.ToInt32(Console.ReadLine());

 Console.Write("enter coefficient of c: ");
 int c = Convert.ToInt32(Console.ReadLine());
 double x;
 double x2;
 int D =  b*b - 4*a*c;
 Console.WriteLine(D);
 
  if(D < 0)
  {
   Console.WriteLine("it has no real root");
  }
  else if (D==0)
  {
 x= -b/2*a;
 Console.WriteLine(x);
  }
  else
  {
 x = -b - Math.Sqrt(D)/2*a; 
 x2 = -b + Math.Sqrt(D)/2*a;
 Console.WriteLine($"roots of the equation are {x} and {x2}");
        Console.WriteLine("............5..........");
       Random numberGen = new Random();
 int bonus = numberGen.Next(1,10);
 Console.WriteLine(bonus);
  if (bonus == 2 )
  {
    Console.WriteLine(bonus*10);
  }
  else if (bonus == 5)
  {
     Console.WriteLine(bonus *100);
  }else if (bonus ==8 )
  {
     Console.WriteLine(bonus *1000);
  }
  else if (bonus == 0 || bonus>9)
  {
Console.WriteLine("error!!!");
  }
        Console.WriteLine("...........6...........");

int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();

            Console.WriteLine("---------------------Question7-------------");
Console.WriteLine("--------------Question8------------------");

 int t1 = 0;
 int t2 =1;
 Console.Write("enter number: ");
 int input = Convert.ToInt32(Console.ReadLine());
  int term;
  for (int i = 0; i <= input; i++)
  {
   Console.WriteLine("{0}",t1);
   term = t1+t2;
    t1=t2;
    t2=term;
   }
   Console.WriteLine("----------------Question9----------------");
   
Console.Write("Enter the number of the rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of the columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] spiral = new int[rows, columns];
Console.WriteLine("Enter the cells of the matrix:");
for (int row = 0; row < rows; row++)
{
for (int col = 0; col < columns; col++)
{
Console.Write("matrix[{0},{1}] = ",row, col);
spiral[row, col] = Convert.ToInt32(Console.ReadLine());
}
}
for (int row = 0; row < spiral.GetLength(0); row++)
{
for (int col = 0; col < spiral.GetLength(1); col++)
{
Console.Write($"  {spiral[row, col]}");
}
Console.WriteLine();
}

   Console.WriteLine("-------------------Question10-----------------");
  int [] num = new int [20];
  for (int i = 0; i < num.Length; i++)
  {
     Console.Write("enter number: ");
     num[i] = Convert.ToInt32(Console.ReadLine());
     int result = num[i] *5;
     Console.WriteLine(result);
 }





Console.WriteLine("----------------Question11--------------");
int [] number1 = new int [5];
int [] number2 = new int[5];

for (int i = 0; i < number1.Length; i++)
{
  Console.Write("input a number: ");
    number1[i] = Convert.ToInt32(Console.ReadLine()); 
}
Console.WriteLine("second array");
 for (int j = 0; j < number2.Length; j++)
 {
  Console.Write("input a number: ");
  number2[j]= Convert.ToInt32(Console.ReadLine());
 }
 bool isarrayequal = number1.SequenceEqual(number2);
 Console.WriteLine($"is first array equal to second array?? {isarrayequal}");



            Console.WriteLine(".......12.........");
                int  n, i;       
       int[] a = new int[10];     
       Console.Write("Enter the number to convert: ");    
       n= int.Parse(Console.ReadLine());     
       for(i=0; n>0; i++)      
        {      
         a[i]=n%2;      
         n= n/2;    
        }      
       Console.Write("Binary of the given number= ");      
       for(i=i-1 ;i>=0 ;i--)      
       {      
        Console.Write(a[i]);      
       }



            Console.WriteLine("........14.........");
        
  
         Console.Write("Input a Number : ");
        answer = Console.ReadLine();
         
            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);


            Console.WriteLine("........15........");
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;
            
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");
            Console.ReadKey();

            Console.WriteLine("..........16.....");
            int decimalNumber, quotient;
        int i = 1, j, temp = 0;
        char[] hexadecimalNumber = new char[100];
        char temp1;
        Console.WriteLine("Enter a Decimal Number :");
        decimalNumber = int.Parse(Console.ReadLine());
        quotient = decimalNumber;
        while (quotient != 0)
        {
            temp = quotient % 16;
            if (temp < 10)
                temp = temp + 48;
            else
                temp = temp + 55;
            temp1 = Convert.ToChar(temp);
            hexadecimalNumber[i++] = temp1;
            quotient = quotient / 16;
        }
        Console.Write("Equivalent HexaDecimal Number is ");
        for (j = i - 1; j > 0; j--)
            Console.Write(hexadecimalNumber[j]);
        Console.Read();

        Console.WriteLine(".........17.......");
         string hex_value =Console.WriteLine("")

            int int_value = Convert.ToInt32(hex_value, 16);

            Console.WriteLine("hex_value = {0}", hex_value);
            Console.WriteLine("int_value = {0}", int_value);

            Console.ReadLine();
            Console.WriteLine(".........18........");
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return binaryval;
            Console.WriteLine(".........19.........");
            string BinaryStr = "1000101001110";
            int Index = 0;
            int Decimal = 0;
            foreach (char Char in BinaryStr.Reverse())
            {
                if (Index != 0)
                {
                    Decimal += Index * 2 * Convert.ToInt32(Char.ToString());
                    Index = Index * 2;
                }
                else
                {
                    Decimal += Convert.ToInt32(Char.ToString());
                    Index++;
                }
            }
            Console.WriteLine("hexadecimal no for : " + BinaryStr + "   =>  " + Decimal.ToString());
            string Hexa1 = toHex(Convert.ToInt64(Decimal));
 Console.WriteLine("hexadecimal no for : " + BinaryStr + "   =>  " + Hexa1 );


