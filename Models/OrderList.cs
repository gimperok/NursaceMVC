namespace NursaceMVC.Models
{
    public class OrderList
    {
        public OrderList(int id, List<OrderString> orderStrings)
        {
            Id = id;
            this.orderStrings = orderStrings;
        }

        /// <summary>
        /// ид заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Список позиций в заказе
        /// </summary>
        public List<OrderString> orderStrings { get; set; }

        /// <summary>
        /// Всего позиций в заказе
        /// </summary>
        public int TotalPosition
        {
            get
            {
                int orderPosition = 0;
                foreach (OrderString ordStr in orderStrings)
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
                foreach (OrderString ordStr in orderStrings)
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
                foreach (OrderString ordStr in orderStrings)
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
    }
}
