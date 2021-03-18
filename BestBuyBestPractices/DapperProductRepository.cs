using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace BestBuyBestPractices
{


    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        //Constructor
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public void CreateProduct(string name, double price, int categoryID)
        {
            
             
            
        }

        public IEnumerable<Product> GetAllProducts()
        {
            
                
                return _connection.Query<Product>("SELECT * FROM Departments;");
            
        }
    }
}
    


