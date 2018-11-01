using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Car: IDrawable, IEntity
    {
        public Car()
        {
        }

        public Car(string model)
        {
            this.model = model;
        }

        public Car(string model, double price)
            :this(model)
        {
            Price = price;
        }

        public abstract string GetName();

        public virtual string GetName2()
        {
            return model;
        }

        public double Price { get; set; }

        public User Creator { get; set; }

        public void ResetPrice()
        {
            Price = 0;
        }

        public User GetCreator()
        {
            return Creator;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Id { get; set; }

        private string model;

    }
}
