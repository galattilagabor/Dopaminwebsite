using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kliensalkalmazas;
using NUnit.Framework;

namespace Kliens.test
{
    [TestFixture]
    public class RaktarTests
    {
        public Raktár raktarForm;

        [SetUp]
        public void SetUp()
        {
            raktarForm = new Raktár();
        }

        [Test]
        public void TermeklistaNemUres()
        {
            // Arrange

            // Act

            // Assert
            Assert.That(raktarForm.termeklista, Is.Not.Empty);
        }

        // További tesztesetek...

    }
}
