using System;
using System.Collections.Generic;
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

        public List<Order> GetOrders(string id)
        {
            // LINQ query med lambda udtryk som går igennem alle ordre hvor kunde id er lig med angivet id samt sortere efter nyeste ordredato
            var oQuery = _context.Orders.Where(o => o.CustomerId == id).OrderByDescending(o => o.OrderDate);

            return oQuery.ToList();
        }

        public List<OrderItem> GetOrderItems(int id)
        {

            // LINQ query med lambda udtryk som går igennem alle ordre hvor ordre id er lig med angivet id
            var oiQuery = _context.OrderItems.Where(oi => oi.OrderId == id);

            return oiQuery.ToList();
        }

        public List<Product> GetProducts(int id)
        {
            // LINQ query med lambda udtryk som går igennem alle produkter hvor produkt id er lig med angivet id
            var pQuery = _context.Products.Where(p => p.Id == id);

            return pQuery.ToList();

        }

        // Her angiver vi operation behavior med indikation at det er nødvendigt med transaktion(er)
        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(int id)
        {
            // LINQ query med lambda udtryk som går igennem alle ordre hvor ordre id er lig med angivet id
            var oQuery = _context.Orders.Where(o => o.Id == id);
            // Det første element i queryen fremfindes og ordrestatusen opdateres med "afsluttet" i model laget
            oQuery.First().OrderStatus = "Afsluttet";
            // Alle ændringer bliver endeligt gemt i databasen
            _context.SaveChanges();
        }

        public void Dispose()
        {
            // Afslutter løbende kald til databasen
            _context.Dispose();
        }
    }
}
