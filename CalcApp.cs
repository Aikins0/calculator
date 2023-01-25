
public class CalcApp 
{
    public string Calc { get; set; }

    public string Name { get; set; }
    public  void GetName()
    {
         Console.WriteLine("Hello, What is your Name?");
       Name =  Console.ReadLine();
     
    }


      public  void SayGreeting()
    {
       var currentDateTime = DateTime.UtcNow; 
       var currentTimeAlone = new TimeSpan(currentDateTime.Hour, currentDateTime.Minute,    currentDateTime.Second); 
       Console.WriteLine(currentTimeAlone);
       
          DateTime currentTime = DateTime.Now;


            if (currentTime.Hour <= 12 && currentTime.Hour >= 1)
            {
                Console.WriteLine($"Good Morning {Name}, What would you like to Calculate");
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour <= 16)
            {
                Console.WriteLine($"Good Afternoon {Name}, What would you like to Calculate");
            }
            else if (currentTime.Hour >= 16 && currentTime.Hour <= 20 )
            {
                Console.WriteLine($"Good Evening {Name}, What would you like to Calculate");
            }
            else if (currentTime.Hour >= 20 && currentTime.Hour <= 1 )
            {
                Console.WriteLine($"Good Night {Name}, What would you like to Calculate");
            }
            else 
            {
                Console.WriteLine($"Good Night {Name}, What would you like to Calculate");
            }   
    }
  public void GetNum()
  {
         
            try
          {

             Console.WriteLine("Enter operation sign('+' , '-' ,'*' ,'/'):");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter your First number:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second number:");
            double number2 = double.Parse(Console.ReadLine());
         //        Console.Write("What would you like to Calculate (ex. 1 + 1): ");
         // string Num = Convert.ToString(Console.ReadLine());
         //  string[] c = Num.Split(' ');
         //  int num1 = Convert.ToInt32(c[0]); 
         //  string operador = c[1]; 
         //  int num2 = Convert.ToInt32(c[2]); 
           
            double result = 0;

                    switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        return;
                    }
                    result = number1 / number2;
                    break;
            }
                Console.WriteLine($"The answer is: {result}");
          }
          catch (Exception e)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Please try again....");
            Console.ResetColor();
          }
             
         
           }
            }
                   
