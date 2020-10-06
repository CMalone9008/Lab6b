using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
   
   double BMI;
   int len = 10;
   int[] height = new int [len];
   int[] weight = new int [len];

   for (int counter=0; counter < len; counter++)
   {
     Console.WriteLine("Enter height:");
     height[counter] = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter weight:");
     weight[counter] = Convert.ToInt32(Console.ReadLine());
     BMI = (703 * weight[counter]) / (height[counter] * height[counter]);
     

     if (BMI<18.5)
     {
       Console.WriteLine("Underweight");
     }
     else if ((BMI>18.5) && (BMI<24.9))
     {
      Console.WriteLine("Normal or Healthy Weight");
     }
     else if ((BMI>25) && (BMI<29.9))
     { 
      Console.WriteLine("Overweight");
     }
    else
     {
      Console.WriteLine("Obese");
     }
    
  }
 }
}