using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Food
    {
        private int id;
        private string name;
        private float price;
        private string description;

        public Food() { }

        public Food(int id, string name, float price, string description)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public int Id { get => this.id; set => this.id = value; }

        public string Name { get => this.name; set => this.name = value; }

        public float Price { get => this.price; set => this.price = value; }

        public string Description { get => this.description; set => this.description = value; }
    }
}
