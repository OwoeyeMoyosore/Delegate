using System;

namespace ClassWork
{
    public delegate int ArithmeticOperationDelegate(int a, int b);//Question 1

    
    public class Program
    {
        static void Main()
        {
            ArithmeticOperationDelegate[] metic = new ArithmeticOperationDelegate[3];//Question 2
            

            ArithmeticOperationDelegate metic1 = new ArithmeticOperationDelegate(ArithmeticOperation.Add);

            ArithmeticOperationDelegate metic2 = new ArithmeticOperationDelegate(ArithmeticOperation.Minus);
            ArithmeticOperationDelegate metic3 = new ArithmeticOperationDelegate(ArithmeticOperation.Multiply);

            metic[0] = metic1;
            metic[1] = metic2;
            metic[2] = metic3;
            // pass the values to the methods by delegate object
            ArithmeticOperation.Add(100, 40);
            ArithmeticOperation.Minus(100, 60);
            ArithmeticOperation.Multiply(9, 3);
            //Console.WriteLine(metic[0]);
            
            for (int i = 0; i < metic.Length; i++)
            {
                switch (i)
                {
                    case 0:
                       metic[i] = ArithmeticOperation.Add;
                        break;
                    case 1:
                        metic[i] = ArithmeticOperation.Minus;
                        break;
                    case 2:
                        metic[i] = ArithmeticOperation.Multiply;
                        break;
                }

                var del = metic[i];
                Console.WriteLine(del(8, 9));


            }
            

        }
    }
    //Question 3
    public class ArithmeticOperation
    {
        public static int Add(int i, int j)
        {
            return i + j;
        }

        public static int Minus(int i, int j)
        {
            return i - j;
        }
        public static int Multiply(int i, int j)
        {
            return i * j;
        }
    }
    
}