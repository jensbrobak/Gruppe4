using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.ServiceModel;
using LT.WCF.Data;
using LT.WCF.Entities;

namespace LT.WCF.Services
{
    // Her specificere vi service behavior med instance context mode for at indikere hvor mange service instancer vil vi have, vi har valgt et pr kald
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class WcfService : IWcfService, IDisposable
    {
        // Db contexten bliver initialiseret således at vi kan kommunikere med dbset klasserne og derfra databasen
        private readonly WcfDbContext _context = new WcfDbContext();

        public IQueryable<OrderAndOrderItemsAndProducts> GetOrders()
        {
            // LINQ query med lambda udtryk som går igennem alle ordre hvor ordre er "Aktiv"
            var oQuery = from o in _context.Orders
                where o.OrderStatus == "Aktiv"
                // vi joiner således vores OrderItem på ordre id hvor det er lig med ordre id fra vores fundne ordre          
                join oi in _context.OrderItems on o.Id equals oi.OrderId
                // her joiner vi så vores Products på produkt id'et fra vores ordrelinje hvor det er lig med produkt id fra produkt
                join p in _context.Products on oi.ProductId equals p.Id
                // her initialisere vi vores model klasse "OrderAndOrderItemsAndProducts" som vi har lavet for at flette entity modellerne sammen og angiver de metoder vi vil have med
                select new OrderAndOrderItemsAndProducts()
                {

                    OrdreDato = o.OrderDate,
                    OrdreId = o.Id,
                    ProduktNavn = p.Name,
                    ProduktBeskrivelse = p.Description,
                    ProduktAntal = oi.Quantity,
                    OrdreStatus = o.OrderStatus

                };
            // her returnere vi vores query og samtidigt sortere vores ordre efter nyeste dato
            return oQuery.OrderByDescending(o => o.OrdreDato);
        }

        public IQueryable<OrderAndOrderItemsAndProducts> GetOrdersById(string id)
          {
            // LINQ query med lambda udtryk som går igennem alle ordre hvor kunde id er lig med angivet id samt er "Aktiv"
            var oQuery = from o in _context.Orders where o.CustomerId == id && o.OrderStatus == "Aktiv"
            // vi joiner således vores OrderItem på ordre id hvor det er lig med ordre id fra vores fundne ordre          
                  join oi in _context.OrderItems on o.Id equals oi.OrderId
            // her joiner vi så vores Products på produkt id'et fra vores ordrelinje hvor det er lig med produkt id fra produkt
                  join p in _context.Products on oi.ProductId equals p.Id
            // her initialisere vi vores model klasse "OrderAndOrderItemsAndProducts" som vi har lavet for at flette entity modellerne sammen og angiver de metoder vi vil have med
                  select new OrderAndOrderItemsAndProducts()
                  {

                      OrdreDato = o.OrderDate,
                      OrdreId = o.Id,
                      ProduktNavn = p.Name,
                      ProduktBeskrivelse =  p.Description,
                      ProduktAntal = oi.Quantity,
                      OrdreStatus = o.OrderStatus
  
                  };
             // her returnere vi vores query og samtidigt sortere vores ordre efter nyeste dato
              return oQuery.OrderByDescending(o => o.OrdreDato);

          }

        public List<Product> GetProducts()
        {
            var pQuery = _context.Products.ToList();

            return pQuery;

        }

        public Product GetProductById(int id)
        {
            var pQuery = _context.Products.Where(p => p.Id == id);

            return pQuery.First();
        }

        // Her angiver vi operation behavior med indikation at det er nødvendigt med transaktion(er)
        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(int id)
        {
            // LINQ query med lambda udtryk som går igennem alle ordre hvor ordre id er lig med angivet id
            var oQuery = _context.Orders.Where(o => o.Id == id);
            // Det første element i queryen fremfindes og ordrestatusen opdateres med "Afsluttet" i model laget
            oQuery.First().OrderStatus = "Afsluttet";
            // Alle ændringer bliver endeligt gemt i databasen
            _context.SaveChanges();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void CreateProduct(string name, string description, double price, int stock)
        {
            var pQuery = _context.Products.First();

            pQuery.Name = name;
            pQuery.Description = description;
            pQuery.Price = price;
            pQuery.Stock = stock;

            _context.Products.Add(pQuery);
            _context.SaveChanges();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateProduct(int id, string name, string description, double price, int stock)
        {
            var pQuery = _context.Products.Where(p => p.Id == id).First();
            pQuery.Name = name;
            pQuery.Description = description;
            pQuery.Price = price;
            pQuery.Stock = stock;

            _context.SaveChanges();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void DeleteProduct(int id)
        {
            var pQuery = _context.Products.Where(p => p.Id == id);

            _context.Products.Remove(pQuery.First());
            _context.SaveChanges();
        }


        public void Dispose()
        {
            // Afslutter løbende kald til databasen
            _context.Dispose();
        }
    }
}
