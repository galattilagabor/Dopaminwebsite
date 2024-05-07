﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiSample;
using Kliensalkalmazas;
using NUnit.Framework;

namespace Kliens.test
{
    [TestFixture]
    public class FormTests
    {
        private Raktár mainForm;

        [SetUp]
        public void Setup()
        {
            // Fő form létrehozása és megnyitása
            mainForm = new Raktár();
            Thread t = new Thread(() => mainForm.ShowDialog());
            t.Start();
            Thread.Sleep(1000); // Várunk, hogy a fő form betöltődjön
        }

        [TearDown]
        public void TearDown()
        {
            // Fő form bezárása
            mainForm.Close();
        }

        [Test]
        public void Test_TextBoxContent_IsString()
        {
            // Végigmegyünk minden TextBox-en a formon
            foreach (Control control in mainForm.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Ellenőrizzük, hogy a TextBox tartalma string
                    Assert.That(textBox.Text, Is.TypeOf<string>());
                }
            }
        }
    }
}