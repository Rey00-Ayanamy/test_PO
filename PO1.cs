using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        

        [TestMethod()]
        public void SortTest1()
        {
            int[] arr = { 9, -6, 18, 66, 0, 84, 14, 7, 4 };
            Program mep = new Program();
            int res = mep.Sort(arr);
            Assert.AreEqual(7, res);
        }
        [TestMethod()]
        public void SortTest2()
        {
            int[] arr = { -3, 7, 2, 6, -8, 0};
            Program mep = new Program();
            int res = mep.Sort(arr);
            Assert.AreEqual(2, res);
        }
        [TestMethod()]
        public void SortTest3()
        {
            int[] arr = { -10, 92, -8, 9, 4};
            Program mep = new Program();
            int res = mep.Sort(arr);
            Assert.AreEqual(9, res);
        }
        [TestMethod()]
        public void SortTest4()
        {
            int[] arr = { 14, 42, 0, 66, -7, 88, -6};
            Program mep = new Program();
            int res = mep.Sort(arr);
            Assert.AreEqual(14, res);
        }


        [TestMethod()]
        public void PalindromeTest1()
        {
            String s = "aga";
            Program mep = new Program();
            int res = mep.Palindrome(s);
            Assert.AreEqual(1, res);
        }

        [TestMethod()]
        public void PalindromeTest2()
        {
            String s = "arozauazora";
            Program mep = new Program();
            int res = mep.Palindrome(s);
            Assert.AreEqual(1, res);
        }


        [TestMethod()]
        public void PalindromeTest3()
        {
            String s = "help";
            Program mep = new Program();
            int res = mep.Palindrome(s);
            Assert.AreEqual(0, res);
        }


        [TestMethod()]
        public void PalindromeTest4()
        {
            String s = "dommod";
            Program mep = new Program();
            int res = mep.Palindrome(s);
            Assert.AreEqual(1, res);
        }


        [TestMethod()]
        public void FactorialTest1()
        {
            int n = -3;
            Program mep = new Program();
            int res = mep.Factorial(n);
            Assert.AreEqual(0, res);
        }

        [TestMethod()]
        public void FactorialTest2()
        {
            int n = 0;
            Program mep = new Program();
            int res = mep.Factorial(n);
            Assert.AreEqual(1, res);
        }

        [TestMethod()]
        public void FactorialTest3()
        {
            int n = 16;
            Program mep = new Program();
            int res = mep.Factorial(n);
            Assert.AreEqual(-1, res);
        }

        [TestMethod()]
        public void FactorialTest4()
        {
            int n = 4;
            Program mep = new Program();
            int res = mep.Factorial(n);
            Assert.AreEqual(24, res);
        }

        [TestMethod()]
        public void FibonnachiTest1()
        {
            int m = 0;
            Program mep = new Program();
            int res = mep.Fibonnachi(m);
            Assert.AreEqual(0, res);
        }
        [TestMethod()]
        public void FibonnachiTest2()
        {
            int m = 1;
            Program mep = new Program();
            int res = mep.Fibonnachi(m);
            Assert.AreEqual(1, res);
        }
        [TestMethod()]
        public void FibonnachiTest3()
        {
            int m = -1;
            Program mep = new Program();
            int res = mep.Fibonnachi(m);
            Assert.AreEqual(1, res);
        }
        [TestMethod()]
        public void FibonnachiTest4()
        {
            int m = 6;
            Program mep = new Program();
            int res = mep.Fibonnachi(m);
            Assert.AreEqual(8, res);
        }

        [TestMethod()]
        public void SootvetstvieTest1()
        {
            String s1 = "puppy";
            String s2 = "pu";
            Program mep = new Program();
            int res = mep.Sootvetstvie(s1, s2);
            Assert.AreEqual(1, res);
        }
        [TestMethod()]
        public void SootvetstvieTest2()
        {
            String s1 = "beeeeee";
            String s2 = "a";
            Program mep = new Program();
            int res = mep.Sootvetstvie(s1, s2);
            Assert.AreEqual(0, res);
        }
        [TestMethod()]
        public void SootvetstvieTest3()
        {
            String s1 = "mama";
            String s2 = "ma";
            Program mep = new Program();
            int res = mep.Sootvetstvie(s1, s2);
            Assert.AreEqual(2, res);
        }
        [TestMethod()]
        public void SootvetstvieTest4()
        {
            String s1 = "aaaaaaaa";
            String s2 = "a";
            Program mep = new Program();
            int res = mep.Sootvetstvie(s1, s2);
            Assert.AreEqual(8, res);
        }

        [TestMethod()]
        public void PrimitiveTest1()
        {
            int a = -3;
            Program mep = new Program();
            int res = mep.Primitive(a);
            Assert.AreEqual(0, res);
        }
        [TestMethod()]
        public void PrimitiveTest2()
        {
            int a = 4;
            Program mep = new Program();
            int res = mep.Primitive(a);
            Assert.AreEqual(0, res);
        }
        [TestMethod()]
        public void PrimitiveTest3()
        {
            int a = 5;
            Program mep = new Program();
            int res = mep.Primitive(a);
            Assert.AreEqual(1, res);
        }
        [TestMethod()]
        public void PrimitiveTest4()
        {
            int a = 13;
            Program mep = new Program();
            int res = mep.Primitive(a);
            Assert.AreEqual(1, res);
        }

        [TestMethod()]
        public void ReverseTest1()
        {
            int x = 0;
            Program mep = new Program();
            int res = mep.Reverse(x);
            Assert.AreEqual(0, res);
        }
        [TestMethod()]
        public void ReverseTest2()
        {
            int x = 14;
            Program mep = new Program();
            int res = mep.Reverse(x);
            Assert.AreEqual(41, res);
        }
        [TestMethod()]
        public void ReverseTest3()
        {
            int x = 204;
            Program mep = new Program();
            int res = mep.Reverse(x);
            Assert.AreEqual(402, res);
        }
        [TestMethod()]
        public void ReverseTest4()
        {
            int x = 666;
            Program mep = new Program();
            int res = mep.Reverse(x);
            Assert.AreEqual(666, res);
        }

        [TestMethod()]
        public void RimNumTest1()
        {
            int num = 5;
            Program mep = new Program();
            String res = mep.RimNum(num);  
            Assert.AreEqual("V", res);
         
        }
        [TestMethod()]
        public void RimNumTest2()
        {
            int num = -6;
            Program mep = new Program();
            String res = mep.RimNum(num);
            Assert.AreEqual("", res);

        }

        [TestMethod()]
        public void RimNumTest3()
        {
            int num = 10;
            Program mep = new Program();
            String res = mep.RimNum(num);
            Assert.AreEqual("X", res);

        }

        [TestMethod()]
        public void RimNumTest4()
        {
            int num = 1000;
            Program mep = new Program();
            String res = mep.RimNum(num);
            Assert.AreEqual("M", res);

        }

    }
}
