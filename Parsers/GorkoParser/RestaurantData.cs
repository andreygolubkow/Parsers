using System.Collections.Specialized;
using System.Windows.Forms.VisualStyles;
using GorkoRu;

namespace GorkoParser
{
    /// <summary>
    /// Схема, которую нужно вывести в Excel.
    /// </summary>
    public class RestaurantData
    {
        /// <summary>
        /// Средний чек.
        /// </summary>
        public double AvgSum { get; set; }

        /// <summary>
        /// Количество залов.
        /// </summary>
        public int RoomsCount { get; set; }

        /// <summary>
        /// Название банкетного зала.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// При отеле.
        /// </summary>
        public bool AtHotel { get; set; } = false;

        /// <summary>
        /// База отдыха.
        /// </summary>
        public bool IsRecreation { get; set; } = false;

        /// <summary>
        /// Ресторан.
        /// </summary>
        public bool Restaurant { get; set; } = false;

        /// <summary>
        /// Банкетный зал.
        /// </summary>
        public bool Banquet { get; set; } = false;

        /// <summary>
        /// Другие.
        /// </summary>
        public bool Other { get; set; } = false;

        /// <summary>
        /// В городе или за городом(false).
        /// </summary>
        public bool InCity { get; set; } = true;

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Instagram.
        /// </summary>
        public string Instagram { get; set; }

        /// <summary>
        /// Другие ссылки.
        /// </summary>
        public string OtherLinks { get; set; }

        /// <summary>
        /// Вместимость.
        /// </summary>
        public int Capacity { get; set; }

        public static RestaurantData FromRestaurant(Restaurant restaurant)
        {
            var restData = new RestaurantData();
            restData.RoomsCount = restaurant.Rooms.Count;
            restData.Name = restaurant.Name;
            //restData.AtHotel = restaurant.Type.Name
            return restData;
        }
    }
}