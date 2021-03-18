using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace BestBuyBestPractices
{
    public class DapperDepartmentRepository: IDepartmentRepository
    {

            private readonly IDbConnection _connection;
            //Constructor
            public DapperDepartmentRepository(IDbConnection connection)
            {
                _connection = connection;
            }

            public IEnumerable<Department> GetAllDepartments()
            {
                return _connection.Query<Department>("SELECT * FROM Departments;");
            }

        
    }
    
}
