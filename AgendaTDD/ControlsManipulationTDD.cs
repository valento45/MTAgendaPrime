using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using System.Windows.Forms;
using System.Drawing;

namespace AgendaTDD
{
    [TestFixture]
    public class ControlsManipulationTDD
    {
        public TextBox TextBoxTeste = new TextBox();

        [SetUp]
        public void SetUP()
        {
            TextBoxTeste.BorderStyle = BorderStyle.None;
            Graphics g = TextBoxTeste.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Red, 4.0f), TextBoxTeste.Location.X, TextBoxTeste.Location.Y, TextBoxTeste.Width, TextBoxTeste.Height);
        }


        [Test]
        public void GreenForeColorControl(Control ctrl)
        {

        }


    }
}
