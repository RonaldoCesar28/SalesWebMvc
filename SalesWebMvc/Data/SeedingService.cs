using System;
using System.Linq;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded 
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Ronaldo", "ronaldo@gmail.com", new DateTime(1986, 8, 29), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@gmail.com", new DateTime(1999, 2, 19), 3500.0, d2);
            Seller s3 = new Seller(3, "Silvana", "silvana@gmail.com", new DateTime(1991, 12, 11), 2200.0, d1);
            Seller s4 = new Seller(4, "Marcio", "marcio@gmail.com", new DateTime(1975, 5, 23), 3000.0, d4);
            Seller s5 = new Seller(5, "Aline", "aline@gmail.com", new DateTime(1994, 11, 7), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex", "alex@gmail.com", new DateTime(1982, 7, 14), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 01, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 01, 28), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 02, 14), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 02, 8), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 03, 5), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 03, 19), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 04, 30), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 04, 6), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 05, 9), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 05, 2), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 06, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 06, 17), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 07, 27), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2022, 07, 9), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2022, 08, 11), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2022, 08, 16), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2022, 09, 18), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 09, 1), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2022, 10, 10), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2022, 10, 3), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2022, 01, 7), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2022, 02, 8), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2022, 03, 12), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2022, 04, 19), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2022, 05, 14), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2022, 06, 27), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2022, 07, 22), 9000.0, SaleStatus.Billed, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2022, 08, 4), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2022, 09, 8), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2022, 10, 15), 5000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                                         r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                                         r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.SaveChanges();
        }
    }
}
