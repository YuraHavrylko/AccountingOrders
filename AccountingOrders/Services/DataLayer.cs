using System;
using System.Collections.Generic;
using System.Linq;
using AccountingOrders.DataBase;
using AccountingOrders.Models;

namespace AccountingOrders.Services
{
    public class DataLayer
    {
        private Context _context;

        public void AddOrder(OrderModel order)
        {
            using (_context = new Context())
            {
                _context.OrderModels.Add(order);
                _context.SaveChanges();
            }
        }

        public void RemoveOrderById(int id)
        {
            using (_context = new Context())
            {
                _context.OrderModels.Remove(_context.OrderModels.FirstOrDefault(x => x.Id == id));
                _context.SaveChanges();
            }
        }

        public void EditOrderById(int id, OrderModel orderModel)
        {
            using (_context = new Context())
            {
                _context.OrderModels.Remove(_context.OrderModels.FirstOrDefault(x => x.Id == id));
                _context.OrderModels.Add(orderModel);
                _context.SaveChanges();
            }
        }

        public OrderModel GetOrderById(int id)
        {
            using (_context = new Context())
            {
                var order = _context.OrderModels.FirstOrDefault(x => x.Id == id);
                order.TotalAmount = Cost(order);
                return order;
            }
        }

        public List<OrderModel> GetAllOrder()
        {
            using (_context = new Context())
            {
               var orders = _context.OrderModels.ToList();
                foreach (var order in orders)
                {
                    order.TotalAmount = Cost(order);
                }
               return orders;
            }
        }

        public List<OrderModel> GetAllOrderByData(DateTime start, DateTime finish)
        {
            using (_context = new Context())
            {
                var orders = _context.OrderModels.ToList();
                orders = orders.Where(x => x.Date >= start).ToList();
                orders = orders.Where(x => x.Date <= finish).ToList();
                foreach (var order in orders)
                {
                    order.TotalAmount = Cost(order);
                }
                return orders;
            }
        }

        public void AddOrderItem(OrderItemModel orderItem)
        {
            using (_context = new Context())
            {
                _context.OrderItemModels.Add(orderItem);
                _context.SaveChanges();
            }
        }

        public void RemoveOrderItemById(int id)
        {
            using (_context = new Context())
            {
                _context.OrderItemModels.Remove(_context.OrderItemModels.FirstOrDefault(x => x.Id == id));
                _context.SaveChanges();
            }
        }

        public List<OrderItemModel> GetOrderItemById(int id)
        {
            using (_context = new Context())
            {
                var orderItems = _context.OrderItemModels.Where(x => x.OrderModelId == id).ToList();
                foreach (var orderItem in orderItems)
                {
                    orderItem.Cost = orderItem.Count * orderItem.Price;
                }
                return orderItems;
            }
        }

        private double Cost(OrderModel order)
        {
            var items = GetOrderItemById(order.Id);
            var sum = 0.0;
            foreach (var item in items)
            {
                sum += item.Price * item.Count;
            }
            return sum;
        }
    }
}