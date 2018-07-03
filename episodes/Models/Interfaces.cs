using System;

namespace episodes.Models
{
    public interface IEmailSender
    {
        void SendMessage(string receiver, string title, string message);
    }

    public interface IDatabase
    {
        bool IsConnected {get;}
        void Connect();
        User GetUser(string email);
        Order GetOrder(int id);
        void SaveChanges();
    }
    public class Database : IDatabase
    {
        public bool IsConnected => throw new System.NotImplementedException();

        public void Connect()
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(string email)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IOrderProcessor
    {
        void ProcessOrder(string email, int orderId);
    }
    class OrderProcessor : IOrderProcessor
    {
        private readonly IDatabase _database;
        private readonly IEmailSender _emailSender;
        public OrderProcessor(IDatabase database, IEmailSender emailSender)
        {
            _database = database;
            _emailSender = emailSender; 
        }
        public void ProcessOrder(string email, int orderId)
        {
            User user = _database.GetUser(email);
            if(user == null)
                throw new Exception("User cannot be null.");
            Order order = _database.GetOrder(orderId);
            if(order == null)
                throw new Exception("Order cannot be null.");

            user.PurchaseOrder(order);
            _database.SaveChanges();
            _emailSender.SendMessage(email,"Order purchased","You have purchased an order.");


        }

    }
    public class FakeEmailSener : IEmailSender
    {
        public void SendMessage(string receiver, string title, string message)
        {
            throw new NotImplementedException();
        }
    }
    public class FakeDatabase : IDatabase
    {
        public bool IsConnected => throw new NotImplementedException();

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
    public class Shop
    {
        public void CompleteOrder()
        {
            IDatabase database = new Database();
            IEmailSender emailSender = new EmailSender();
            IOrderProcessor orderProccesor = new OrderProcessor(database,emailSender);
        }
        public void CompleteFakeOrder()
        {
            IDatabase database = new FakeDatabase();
            IEmailSender emailSender = new FakeEmailSener();
            IOrderProcessor orderProccesor = new OrderProcessor(database,emailSender);
        }
        
    }

    public class EmailSender : IEmailSender
    {
        public void SendMessage(string receiver, string title, string message)
        {
            throw new System.NotImplementedException();
        }
    }
}