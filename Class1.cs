using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;


namespace SENG8040_Tests
{
    [TestFixture]
    class SENG8040_Assignment_Tests

    {

        [Test]
        public void GetLength_input3_expectedLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            

            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(l, length);

        }

        [Test]

        public void SetLength_input3_set5_expectedSetLengthEquals5()
        {
            //Arrange
            int l = 3;
            int w = 4;
            int new_length = 5;


            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(5);


            //Assert
            Assert.AreEqual(new_length, length);

        }


   
        [Test]
        public void GetWidth_input3_expectedwidthEquals3()
        {
            //Arrange
            int l = 4;
            int w = 3;


            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(w, width);

        }

        [Test]
        public void SetWidth_input3_set5_expectedSetWidthEquals5()
        {
            //Arrange
            int l = 4;
            int w = 3;
            int new_width = 5;
            
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(5);
            
            //Assert
            Assert.AreEqual(new_width, width);

        }



        [Test]
        public void GetPerimeter_length3_width3_expectedperimeterEquals12()
        {
            //Arrange
            int l = 3;
            int w = 3;
            int p = 12;

            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(p, Perimeter);

        }

        [Test]
        public void GetArea_length3_width3_expectedareaEquals9()
        {
            //Arrange
            int l = 3;
            int w = 3;
            int a = 9;
    

            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(a, Area);

        }

    }
}


