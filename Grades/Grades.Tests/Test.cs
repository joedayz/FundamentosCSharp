using NUnit.Framework;
using System;
namespace Grades.Tests
{
    [TestFixture()]
    public class Test
    {

        [Test()]
        public void UsingArrays(){

            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        public void AddGrades(float[] grades){
            grades[1] = 89.1f;
        }

        [Test()]
        public void UppercaseString()
        {
            string name = "Joe";
            name = name.ToUpper();

            Assert.AreEqual("JOE", name);
        }
        [Test()]
        public void AddDaysToDateTime(){
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }


        [Test()]
        public void ValueTypePassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);

        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [Test()]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        [Test()]
        public void StringComparaciones()
        {
            string name1 = "Joe";
            string name2 = "joe";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
                                        
        }


        [Test()]
        public void IntVariablesGuardanValor()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);

        }


        [Test()]
        public void GradeBrookVariableDeReferencia()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Joe";
            Assert.AreEqual(g1.Name, g2.Name);

        }
    }
}
