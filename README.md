

# Converter MyBitToInt64
# C#6  .NET4.6

This function allow You convert byte array to double

----

### Purpose
The destination of this function convertation from byte array to double type. Assume You have byte array of some length and You want save that number in double type. For this destination You can use this project.

----

### Converter class implementation 
```c#
public class Converter
    {

    static public double MyBitToInt64(byte[] arr)
    {
      StringBuilder strbuild = new StringBuilder();
      for (int i = 0; i < 4; i++)
      {
        strbuild.Append(arr[i]);
      }
      return Convert.ToInt64(strbuild.ToString());
    }  
  }
  ```
  ### Description of Converter class
The ###converter class 
