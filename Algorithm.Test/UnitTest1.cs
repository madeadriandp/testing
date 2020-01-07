using System.Linq;
using NUnit.Framework;
using Algorithm;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private Tugas tugas;        
        [SetUp]
        public void Setup()
        {
            tugas = new Tugas();
        }

        [Test]
        public void Test1()
        {
            var result= tugas.hitungjumlahkarakter("makan");
            Assert.AreEqual(5,result);
        }

        [Test]
        public void Test2()
        {
            var result1= tugas.grade(95);
            Assert.AreEqual("A", result1);

            var result2= tugas.grade(80);
            Assert.AreEqual("B", result2);

            var result3= tugas.grade(50);
            Assert.AreEqual("E", result3);
        }

        [Test]
        public void Test3()
        {
            var result1= tugas.ganjilgenap("kantorsbsi");
            Assert.AreEqual("Genap", result1);

            var result2= tugas.ganjilgenap("makan");
            Assert.AreEqual("Ganjil", result2);

        }

        [Test]
        public void Test4()
        {
            var result1= tugas.kabisat(2000);
            Assert.AreEqual("Kabisat", result1);

            var result2= tugas.kabisat(400);
            Assert.AreEqual("Kabisat", result2);

        }

        [Test]
        public void Test5()
        {
            var result1= tugas.filmrating(23);
            Assert.AreEqual("DEWASA", result1);

            var result2= tugas.filmrating(5);
            Assert.AreEqual("SEMUA USIA", result2);

        }

        [Test]
        public void Test6()
        {
            var result1= tugas.looprange(1,3);
            Assert.AreEqual(new List<int>(){1,2,3}, result1);
  
        }

        [Test]
        public void Test7()
        {
            var result1= tugas.ganjil100();

            Assert.AreEqual(new List<int>(){1,3,5}, result1.Take(3));
  
        }
        [Test]
        public void Test8()
        {
            var result1= tugas.kelipatan1000();

            Assert.AreEqual(new List<string>(){"Ganjil", "Kelipatan Seratus"}, result1.TakeLast(2));
  
        }

        
        [Test]
        public void Test9()
        {
            var result1= tugas.balikkata("saya ingin makan nasi goreng");

            Assert.AreEqual("goreng nasi makan ingin saya", result1);
  
        }

        [Test]
        public void Test10()
        {
            var result1= tugas.addtoarray();

            Assert.AreEqual("Celana", result1.Last());
  
        }

        
    }
}