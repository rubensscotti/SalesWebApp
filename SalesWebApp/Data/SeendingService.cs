using Microsoft.EntityFrameworkCore;
using SalesWebApp.Models.Enums;
using SalesWebApp.Models;

namespace SalesWebApp.Data
{
    public class SeendingService
    {
        private SalesWebAppContext _appContext;

        public SeendingService(SalesWebAppContext appContext)
        {
            _appContext = appContext;
        }

        //Responsible to populate the database
        public void Seed()
        {
            if (_appContext.Department.Any() ||
                _appContext.Seller.Any() ||
                _appContext.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 05, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 06, 4), 7000.0, SalesStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 07, 13), 4000.0, SalesStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 09, 1), 8000.0, SalesStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 11, 21), 3000.0, SalesStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 08, 15), 2000.0, SalesStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 08, 28), 13000.0, SalesStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 09, 11), 4000.0, SalesStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 10, 14), 11000.0, SalesStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 10, 7), 9000.0, SalesStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 11, 13), 6000.0, SalesStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 12, 25), 7000.0, SalesStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 02, 20), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2022, 04, 4), 3000.0, SalesStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2022, 07, 12), 4000.0, SalesStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2022, 08, 5), 2000.0, SalesStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2022, 11, 1), 12000.0, SalesStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 11, 24), 6000.0, SalesStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2022, 12, 22), 8000.0, SalesStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2023, 04, 15), 8000.0, SalesStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2023, 05, 17), 9000.0, SalesStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2023, 06, 24), 4000.0, SalesStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2023, 07, 19), 11000.0, SalesStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2023, 08, 12), 8000.0, SalesStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2023, 09, 21), 7000.0, SalesStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2023, 10, 6), 5000.0, SalesStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2024, 01, 13), 9000.0, SalesStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2024, 02, 7), 4000.0, SalesStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2024, 03, 23), 12000.0, SalesStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2024, 04, 12), 5000.0, SalesStatus.Billed, s2);

            _appContext.Department.AddRange(d1, d2, d3, d4);

            _appContext.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _appContext.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _appContext.SaveChanges();
        }

    }
}
