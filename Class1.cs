using static System.Console;  
  
namespace Singleton  
{  
  class Singleton  
  {  
    static int instanceCounter = 0;  
    public Singleton()  
    {  
      instanceCounter++;  
      WriteLine("Instances Increment " + instanceCounter);

      instanceCounter--;
      WriteLine("Instances Decrement " + instanceCounter);
    }  
  }  
}  