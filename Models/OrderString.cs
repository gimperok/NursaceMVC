namespace NursaceMVC.Models
{
    /// <summary>
    /// Класс описывающий строку заказа
    /// </summary>
    public class OrderString
    {
        /// <summary>
        /// id заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Код модели
        /// </summary>
        public string Kod { get; set; } = string.Empty;

        /// <summary>
        /// Кожа модели
        /// </summary>
        public string Leather { get; set; } = string.Empty;

        /// <summary>
        /// Цвет модели
        /// </summary>
        public string Color { get; set; } = string.Empty;

        /// <summary>
        /// 35ый размер
        /// </summary>
        public int Size35 { get; set; } = 0;

        /// <summary>
        /// 36ой размер
        /// </summary>
        public int Size36 { get; set; } = 0;

        /// <summary>
        /// 37ой размер
        /// </summary>
        public int Size37 { get; set; } = 0;

        /// <summary>
        /// 38ой размер
        /// </summary>
        public int Size38 { get; set; } = 0;

        /// <summary>
        /// 39ый размер
        /// </summary>
        public int Size39 { get; set; } = 0;

        /// <summary>
        /// 40ой размер
        /// </summary>
        public int Size40 { get; set; } = 0;

        /// <summary>
        /// 41ый размер
        /// </summary>
        public int Size41 { get; set; } = 0;

        /// <summary>
        /// Всего пар в этой строке
        /// </summary>
        public int TotalCountPairs 
        {
            get { return Size35 + Size36 + Size37 + Size38 + Size39 + Size40 + Size41; } 
        }

        /// <summary>
        /// Цена одной позиции
        /// </summary>
        public double Price { get; set; } = 0.00;

        /// <summary>
        /// Общая цена серии
        /// </summary>
        public double TotalPrice
        {
            get { return TotalCountPairs * Price; }
        }

        /// <summary>
        /// Заметка
        /// </summary>
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Навигационное свойство лист заказа
        /// </summary>
        public OrderList OrderList { get; set; }
    }
}
