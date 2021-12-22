using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            var t = shopCart.listShopItems;
            foreach(var el in t)
            {
                var orderDetail = new OrderDetail()
                {
                    ItemID = el.item.id,
                    orderID = order.id,
                    price = el.item.price
                };
            appDBContent.OrderDetail.Add(orderDetail);
        }
        appDBContent.SaveChanges(); 
        }
    }
}
