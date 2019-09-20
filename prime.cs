using System;
using System.IO;
using System.Text;

namespace prime
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? j;
         ?? i;
         ?? u;
         ?? f;
         ?? l;
      
         j =0;
         i =1;
         f =0;
         raptor_prompt_variable_zzyz ="l value";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         l= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="u value";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         u= Double.Parse(Console.ReadLine());
         while (!(l>u))
         {
            while (!(i>l))
            {
               if (l % i==0)
               {
                  f =f+1;
               }
               else
               {
               }
               i =i+1;
            }
            if (f==2)
            {
               Console.WriteLine(l+" ");
               j =j+1;
            }
            else
            {
            }
            f =0;
            i =1;
            l =l+1;
         }
         Console.WriteLine("count is "+j);
      }
   }
}
