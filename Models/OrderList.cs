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
                if(OrderStrings != null && OrderStrings.Count > 0)
                {
                    int orderPosition = 0;
                    foreach (OrderString ordStr in OrderStrings)
                    {
                        orderPosition++;
                    }
                    return orderPosition;
                }
                return 0;
            }
        }

        /// <summary>
        /// Всего пар в заказе
        /// </summary>
        public int TotalPairs
        {
            get
            {
                if (OrderStrings != null && OrderStrings.Count > 0)
                {
                    int pairs = 0;
                    foreach (OrderString ordStr in OrderStrings)
                    {
                        pairs += ordStr.TotalCountPairs;
                    }
                    return pairs;
                }
                return 0;
            }
        }

        /// <summary>
        /// Общая сумма заказа
        /// </summary>
        public double OrderTotalMoney
        {
            get
            {
                if (OrderStrings != null && OrderStrings.Count > 0)
                {
                    double orderMoney = 0;
                    foreach (OrderString ordStr in OrderStrings)
                    {
                        orderMoney += ordStr.TotalPrice;
                    }
                    return orderMoney;
                }
                return 0.00;
            }
        }
        
        /// <summary>
        /// Депозит за данный заказ
        /// </summary>
        public double Deposit
        {
            get
            {
                if (OrderTotalMoney != 0)
                {
                    return OrderTotalMoney * 0.3;
                }
                return 0.00;
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
