using System;
using Wintellect.PowerCollections;
using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wintellect.PowerCollections.Tests
{
	[TestClass]
	public class StackTests
    {
        //При создании стэка, он пустой
        [TestMethod]
        public void WhenStackCreateIsEmpty()
        {
            Stack<string> stack = new Stack<string>(3);
            Assert.AreEqual(stack.Count, 0);
        }
        //Заполненный стэк
        [TestMethod]
        public void WhenPushedToFullCapacityStackIsFull()
        {   
            Stack<string> stack = new Stack<string>(3);

            stack.Push("help");
            stack.Push("me");
            stack.Push("please");

            Assert.AreEqual(stack.Count, stack.Capacity);
        }
        //Стэк вначале полный, потом не полный
        [TestMethod]
        public void WhenPushedToFullCapacityAndThenPopedStackIsNotFull()
        {
            Stack<string> stack = new Stack<string>(3);

            stack.Push("help");
            stack.Push("me");
            stack.Push("please");
            stack.Pop();

            Assert.AreNotEqual(stack.Count, stack.Capacity);
        }
        //метод топ возвращает верхний элемент стэка
        [TestMethod]
        public void MethodTopReturnsTopElementFromStack()
        {
            Stack<int> stack = new Stack<int>(5);
            int topElement = 0;

            stack.Push(1);
            topElement = stack.Top();
            stack.Push(2);
            topElement = stack.Top();

            Assert.AreEqual(topElement, 10);
        }

        //метод поп забирает верхний элемент стэка
        [TestMethod]
        public void MethodPopReturnsTopElementFromStack()
        {
            Stack<int> stack = new Stack<int>(5);
            int topElement = 0;

            stack.Push(1);
            stack.Push(2);

            int topValue = stack.Top();
            stack.Pop();

            Assert.AreNotEqual(stack.Top(), topValue);
        }

        //стэк пустой метод топ пробует вытащить значение верхнего элемента стэка
        [TestMethod]
        [ExpectedException(typeof(Exception), "Array is Empty")]
        public void MethodTopTriesToReturnNullElementFromStack()
        {
            Stack<int> stack = new Stack<int>(5);
            stack.Top();
        }

        //стэк пустой метод поп пробует вытащить значение верхнего элемента стэка
        [TestMethod]
        [ExpectedException(typeof(Exception), "Array is Empty")]
        public void MethodPopTriesToReturnNullElementFromStack()
        {
            Stack<int> stack = new Stack<int>(5);
            stack.Pop();
        }

        //перезаполнение стэка 
        [TestMethod]
        [ExpectedException(typeof(Exception), "Array is Full")]
        public void MethodPushThrowsOverflowException()
        {
            Stack<int> stack = new Stack<int>(2);

            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
        }

        //проверка свойства count
        [TestMethod]
        public void ExpectedCountEqualsCurrentCount()
        {
            int expectedCount = 10; 
            Stack<int> stack = new Stack<int>(10);
            for (int i = 0; i < stack.Capacity; i++)
            {
                stack.Push(1);
            }
            Assert.AreEqual(stack.Count, expectedCount);
        }
        //проверка свойства capacity
        [TestMethod]
        public void ExpectedCapacityEqualsCurrentCapacity()
        {
            int expectedCapacity = 100; 
            Stack<int> stack = new Stack<int>(expectedCapacity);
            Assert.AreEqual(stack.Capacity, expectedCapacity);
        }
    }
}
