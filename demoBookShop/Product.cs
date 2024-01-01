using System;
namespace Catalog {


    public class Product
    {
        private int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Title { get; set; }
        public string? Description { get; set; }
        public float UnitPrice { get; set; }
        public string? ImagUrl { get; set; }

        public override string ToString()
        {
            return this.Id + " " + this.Title + " " + this.Description;
        }

    }

}
