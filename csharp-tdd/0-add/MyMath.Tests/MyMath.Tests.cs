using System;
using System.ComponentModel;
namespace MyMath.Tests {

    /// <summary>
    /// A test implementation of a class.
    /// </summary>
    public class Tests
    {
        private Operations _Sum = new Operations();
        /// <summary>
        /// a test method.
        /// </summary>
        [Test]
       public void TestSum()
       {
        int result = Operations.Add(2, 2);
        Assert.That(result, Is.EqualTo(4));
       }
    }
}
