using System;
using SQLite;
namespace ICT13580088B2.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        [NotNull]
        [MaxLength(100)]
        public string Name
        {
            get;
            set;
        }
		public string Description
		{
			get;
			set;
		}
		[NotNull]
		[MaxLength(100)]
		public string Category
		{
			get;
			set;
		}
        public decimal ProductPrice
        {
            get;
            set;
        }
        public decimal SalePrice
        {
            get;
            set;
        }
        public int stock
		{
			get;
			set;
		}
    }
}
