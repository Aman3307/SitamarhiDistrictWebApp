using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DQSP.Models; 
using DQSP.Data;

namespace DQSP.Repository
{
    public class DistrictQueryRepository
    {
        private readonly DistrictQueryModelDBContext _context;

        public DistrictQueryRepository(DistrictQueryModelDBContext context)
        {
            _context = context;
        }

        public void SaveDistrictQuery(DistrictQueryModel districtQuery)
        {
               _context.Database.ExecuteSqlRaw("EXEC InsertDistrictQuery @Name, @Email, @Comment, @CreatedAt",
                new SqlParameter("@Name", districtQuery.Name),
                new SqlParameter("@Email", districtQuery.Email),
                new SqlParameter("@Comment", districtQuery.Comment),
                new SqlParameter("@CreatedAt", districtQuery.CreatedAt));
        }
    }
}