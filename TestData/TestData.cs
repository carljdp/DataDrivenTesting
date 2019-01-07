using System;
using System.Dynamic;

namespace TestData
{

    public class TestData
    {

        public ExpandoObject ReadTestDataFromJson()
        {
            
            throw new NotImplementedException();
            
            
            return new ExpandoObject();
        }

        public bool WriteTestDataToJson()
        {
            var success = false;

            throw new NotImplementedException();

            return success;
        }
        
    }
    
    
    
    public static class TestDataHelpers
    {

        public static string GetCurrentDir()
        {
            var baseDirectory = System.AppContext.BaseDirectory;
            
            Console.WriteLine(nameof(baseDirectory), baseDirectory);

            return baseDirectory;
        }
        
    }
}