namespace modernBookstoreForCD.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }

        override
        public string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Price: {Price}";
        }

        public void ValidateTitle()
        {
            if (Title == null)
            {
                throw new ArgumentNullException("Title is null");
            }
            if (Title.Length < 2)
            {
                throw new ArgumentException("Title must be at least 2 charaters: " + Title);
            }
        }

        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException("Price must be greater than 0: " + Price);
            }

        }

        public void Validate()
        {
            ValidateTitle();
            ValidatePrice();
        }
    }
}
