namespace Packet.Shared
{
    public static class Initialize
    {
        public static IServiceCollection InitializeData(this IServiceCollection services)
        {
            using(var context = new ApplicationDbContext())
            {
                context.Companies.AddRange(new Company[] { 
                    new Company{
                        CompanyId = 1,
                        Name = "Super Mart of the West",
                        Address = "702 SW 8th Street",
                        City = "Bentonville",
                        State = "Arkansas",
                        Phone = 8005552797,
                    },
                    new Company{
                        CompanyId = 2,
                        Name = "Electronics Depot",
                        Address = "702 SW 8th Street",
                        City = "Atlanta",
                        State = "Georgia",
                        Phone = 8005953232,
                    },
                    new Company{
                        CompanyId = 3,
                        Name = "K&5 Music",
                        Address = "702 SW 8th Street",
                        City = "Minneapolis",
                        State = "Minnesota",
                        Phone = 6123046073,
                    },
                    new Company{
                        CompanyId = 4,
                        Name = "Tom's Club",
                        Address = "702 SW 8th Street",
                        City = "Issaquah",
                        State = "Washington",
                        Phone = 8009552292,
                    },
                    new Company{
                        CompanyId = 5,
                        Name = "E-Mart",
                        Address = "702 SW 8th Street",
                        City = "Hoffman Estates",
                        State = "Illinois",
                        Phone = 6123046073,
                    },
                    new Company{
                        CompanyId = 6,
                        Name = "Walters",
                        Address = "702 SW 8th Street",
                        City = "Deerfield",
                        State = "Illinois",
                        Phone = 8009552292,
                    },
                    new Company{
                        CompanyId = 7,
                        Name = "StereoShack",
                        Address = "702 SW 8th Street",
                        City = "Fort Worth",
                        State = "Texas",
                        Phone = 8472862500,
                    },
                    new Company{
                        CompanyId = 8,
                        Name = "Circuit Town",
                        Address = "702 SW 8th Street",
                        City = "Oak Brook",
                        State = "Illinois",
                        Phone = 8479402500,
                    },
                    new Company{
                        CompanyId = 9,
                        Name = "Circuit Town",
                        Address = "702 SW 8th Street",
                        City = "Richfield",
                        State = "Minnesota",
                        Phone = 8178200741,
                    },
                    new Company{
                        CompanyId = 10,
                        Name = "ElectrixMax",
                        Address = "702 SW 8th Street",
                        City = "Naperville",
                        State = "Illinois",
                        Phone = 8009552929,
                    },
                    new Company{
                        CompanyId = 11,
                        Name = "Video Emporium",
                        Address = "702 SW 8th Street",
                        City = "Dallas",
                        State = "Texas",
                        Phone = 6122911000,
                    },
                    new Company{
                        CompanyId = 12,
                        Name = "Screen Shop",
                        Address = "702 SW 8th Street",
                        City = "Mooresville",
                        State = "North Carolina",
                        Phone = 6122911000,
                    }
                });
                
                context.Employees.AddRange(new Employee[] { 
                    new Employee {
                        EmployeeId= 1,
                        FirstName="John",
                        LastName="Heart",
                        Title = "Mr.",
                        BirthDate = new DateOnly(1964,3,16),
                        Post = "SEO",
                        CompanyId=1,
                    },
                    new Employee {
                        EmployeeId= 2,
                        FirstName="Olivia",
                        LastName="Peyton",
                        Title="Ms.",
                        BirthDate = new DateOnly (1970,5,12),
                        Post = ".NET Dev",
                        CompanyId=1,
                    },
                    new Employee {
                        EmployeeId= 3,
                        FirstName="Robert",
                        LastName="Reagan",
                        Title="Mr.",
                        BirthDate = new DateOnly (1990,6,26),
                        Post="Director",
                        CompanyId=1,
                    },
                    new Employee {
                        EmployeeId= 4,
                        FirstName="Cynthia",
                        LastName="Stanwick",
                        Title="Ms.",
                        BirthDate = new DateOnly(1995,12,31),
                        Post="DevOps",
                        CompanyId=1,
                    } });
                context.Notes.AddRange(new Note[] { 
                    new Note {
                        NoteId= 1,
                        FirstName = "Harv",
                        LastName = "Mudd",
                        InvoiceNumber = 35703,
                        CompanyId = 1,
                    },
                    new Note {
                        NoteId= 2,
                        FirstName = "Harv",
                        LastName = "Mudd",
                        InvoiceNumber = 35714,
                        CompanyId = 1,
                    },
                    new Note {
                        NoteId= 3,
                        FirstName = "Harv",
                        LastName = "Mudd",
                        InvoiceNumber = 38466,
                        CompanyId = 1,
                    },
                    new Note {
                        NoteId= 4,
                        FirstName = "Jim",
                        LastName = "Packard",
                        InvoiceNumber = 35711,
                        CompanyId = 1,
                    },
                    new Note {
                        NoteId= 5,
                        FirstName = "Todd",
                        LastName = "Hoffman",
                        InvoiceNumber = 35983,
                        CompanyId = 1,
                    },
                    new Note {
                        NoteId= 6,
                        FirstName = "Clark",
                        LastName = "Morgan",
                        InvoiceNumber = 38466,
                        CompanyId=1,
                    } });
                context.Orders.AddRange(new Order[]
                {
                    new Order
                    {
                        OrderId=1,
                        DateOrder=new DateOnly(2013,11,12),
                        CompanyId=1,
                        StoreCity="Las Vegas",
                    },
                    new Order
                    {
                        OrderId=2,
                        DateOrder=new DateOnly(2013,11,14),
                        CompanyId=1,
                        StoreCity="Las Vegas",
                    },
                    new Order
                    {
                        OrderId=3,
                        DateOrder=new DateOnly(2013,11,18),
                        CompanyId=1,
                        StoreCity="San Jose",
                    },
                    new Order
                    {
                        OrderId=4,
                        DateOrder=new DateOnly(2013,11,22),
                        CompanyId=1,
                        StoreCity="Denver",
                    },
                    new Order
                    {
                        OrderId=5,
                        DateOrder=new DateOnly(2013,11,30),
                        CompanyId=1,
                        StoreCity="Seattle",
                    },
                    new Order
                    {
                        OrderId=6,
                        DateOrder=new DateOnly(2013,12,1),
                        CompanyId=1,
                        StoreCity="San Jose"
                    },
                });
                context.SaveChanges();
            }
            return services;
        }
    }
}
