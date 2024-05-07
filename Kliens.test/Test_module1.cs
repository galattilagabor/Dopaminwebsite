using System;
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
        public void Test_OpenMennyisegSzerkesztesForm()
        {
            // Gomb lenyomása a fő formon
            mainForm.Invoke(new Action(() =>
            {
                mainForm.button_change_quantity.PerformClick();
            }));

            // Megkeressük a megnyílt MennyiségSzerkesztés formot
            MennyiségSzerkesztés mennyiségSzerkesztésForm = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is MennyiségSzerkesztés && form.Visible)
                {
                    mennyiségSzerkesztésForm = (MennyiségSzerkesztés)form;
                    break;
                }
            }

            // Ellenőrizzük, hogy a MennyiségSzerkesztés form bezáródott-e és DialogResult.OK lett-e
            Assert.Multiple(() =>
            {
                Assert.That(mennyiségSzerkesztésForm, Is.Not.Null, "A MennyiségSzerkesztés form nem nyílt meg.");
                Assert.That(mennyiségSzerkesztésForm.DialogResult, Is.EqualTo(DialogResult.OK), "A MennyiségSzerkesztés form DialogResult értéke nem OK.");
            });
        }

        [Test]
        public void Test_OpenModositasForm()
        {
            // Gomb lenyomása a fő formon
            mainForm.Invoke(new Action(() =>
            {
                mainForm.button_change.PerformClick();
            }));

            // Megkeressük a megnyílt Módosítás formot
            Módosítás modositasForm = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Módosítás && form.Visible)
                {
                    modositasForm = (Módosítás)form;
                    break;
                }
            }

            // Ellenőrizzük, hogy a Módosítás form bezáródott-e és DialogResult.OK lett-e
            Assert.Multiple(() =>
            {
                Assert.That(modositasForm, Is.Not.Null, "A Módosítás form nem nyílt meg.");
                Assert.That(modositasForm.DialogResult, Is.EqualTo(DialogResult.OK), "A Módosítás form DialogResult értéke nem OK.");
            });
        }
    }
}