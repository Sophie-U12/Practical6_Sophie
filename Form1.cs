using Practical6_Sophie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical6_Sophie
{
    public partial class Form1 : Form
    {
        private Animal animal;
        private Mammal mammal;
        private Ungulate ungulate;
        private Bird bird;
        public Form1()
        {
            InitializeComponent();

            animal = new Animal();
            mammal = new Mammal();
            ungulate = new Ungulate();
            bird = new Bird();

            animal.AnimalEvent += Animal_AnimalEvent;
            mammal.MammalEvent += Animal_AnimalEvent;
            ungulate.UngulateEvent += Animal_AnimalEvent;
            bird.BirdEvent += Animal_AnimalEvent;
        }

        private void Animal_AnimalEvent(string obj)
        {
            MessageBox.Show(obj);
        }

        private void btnEventAnimal_Click(object sender, EventArgs e)
        {
            animal.Move();
        }

        private void btnEventMammal_Click(object sender, EventArgs e)
        {
            mammal.Feed();
        }

        private void btnEventUngulate_Click(object sender, EventArgs e)
        {
            ungulate.Hoofbeat();
        }

        private void btnEventBird_Click(object sender, EventArgs e)
        {
            bird.Fly();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
