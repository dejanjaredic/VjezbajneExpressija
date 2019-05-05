using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;

namespace VjezbanjeExpresija
{
    public class TestingClass
    {
        public static bool Test(int value1, int value2)
        {
            Func<int, bool> test = i => i > value2;
            return test(value1);
        }

        public static Expression BinExp()
        {
            Expression<Func<int, bool>> exp = i => i > 5;
            BinaryExpression binary = (BinaryExpression)exp.Body;
            Console.WriteLine(binary.Left);
            Console.WriteLine(binary.NodeType);
            Console.WriteLine(binary.Right);
            return binary;
        }
        // Func<int, bool> test = i => i > 5
        public static Expression FinalBinExp()
        {
            ConstantExpression constExp =  Expression.Constant(5, typeof(int));
            ParameterExpression parExp = Expression.Parameter(typeof(int), "i");
            BinaryExpression binExp = Expression.MakeBinary(ExpressionType.GreaterThan, parExp, constExp);
            Expression<Func<int, bool>> lambda = 
                Expression.Lambda<Func<int, bool>>(binExp, parExp);
            //return constExp.NodeType;
            return lambda;
        }

        public static void ArayExample()
        {
            int[] ints = new[] {1, 9, 2, 7, 4, 3, 6, 5};
            IEnumerable<int> result =
                ints.Where(i => i < 5);
            List<int> num = new List<int>();
            foreach (var i in result)
            {
               
               Console.WriteLine(i);
            }  
        }
    }
}
