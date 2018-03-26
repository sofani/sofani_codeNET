using System;
using System.Reflection;

namespace Certif70483
{

    //Type and Value Validation
    //Encription Techniques
    public class TypeValueValidation
    {
         public int AddNum(int numb1, int numb2) {
             int result1  = numb1 + numb2;
             return result1;
         }

         public string doOperation(string operationName, int numb1, int numb2) {
             object[] mParam = new object[]{numb1, numb2};
             MyClass myClassObj = new MyClass();
             Type myTypeObj = myClassObj.GetType();
             MethodInfo myMethodInfo = myTypeObj.GetMethod(operationName);
             return myMethodInfo.Invoke(myClassObj, mParam).ToString();
         }
        
    }

    internal class MyClass
    {
    }
}
