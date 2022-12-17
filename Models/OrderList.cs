namespace NursaceMVC.Models
{
    public class OrderList
    {
        /// <summary>
        /// ид заказа
        /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// Всего позиций в заказе
        /// </summary>
        public int TotalPosition
        {
            get
            {
                int orderPosition = 0;
                foreach (OrderString ordStr in OrderStrings)
                {
                    orderPosition++;
                }
                return orderPosition;
            }
        }

        /// <summary>
        /// Всего пар в заказе
        /// </summary>
        public int TotalPairs
        {
            get
            {
                int pairs = 0;
                foreach (OrderString ordStr in OrderStrings)
                {
                    pairs += ordStr.TotalCountPairs;
                }
                return pairs;
            }
        }

        /// <summary>
        /// Общая сумма заказа
        /// </summary>
        public int OrderTotalMoney
        {
            get
            {
                int orderMoney = 0;
                foreach (OrderString ordStr in OrderStrings)
                {
                    orderMoney += ordStr.TotalPrice;
                }
                return orderMoney;
            }
        }
        
        /// <summary>
        /// Депозит за данный заказ
        /// </summary>
        public int Deposit
        {
            get
            {
                return OrderTotalMoney / 3;
            }
        }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime DateCreate
        {
            get
            {
                return DateTime.Now;
            }
        }
        
        /// <summary>
        /// Дата изменения заказа
        /// </summary>
        public DateTime DateModify { get; set; }

        /// <summary>
        /// Навигационное свойство клиент
        /// </summary>
        public Client Client { get; set; } = new();

        /// <summary>
        /// Список позиций в заказе
        /// </summary>
        public List<OrderString>? OrderStrings { get; set; }
    }
}
