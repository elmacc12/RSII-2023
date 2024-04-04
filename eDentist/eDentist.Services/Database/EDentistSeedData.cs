using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Database
{
    public partial class EDentistDbContext
    {


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(
               new Roles()
               {
                   RoleID = 1,
                   RoleName = "Zaposlenik"
               },
               new Roles()
               {
                   RoleID = 2,
                   RoleName = "Pacijent"
               }
           );
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "Bosnia and Herzegovina"
                }
            );

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    CityId = 1,
                    CityName = "Sarajevo",
                    ZipCode = "71000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 2,
                    CityName = "Banja Luka",
                    ZipCode = "78000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 3,
                    CityName = "Tuzla",
                    ZipCode = "75000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 4,
                    CityName = "Mostar",
                    ZipCode = "88000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 5,
                    CityName = "Zenica",
                    ZipCode = "72000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 6,
                    CityName = "Doboj",
                    ZipCode = "74000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 7,
                    CityName = "Bihac",
                    ZipCode = "77000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 8,
                    CityName = "Brcko",
                    ZipCode = "76101",
                    CountryId = 1
                },
                new City
                {
                    CityId = 9,
                    CityName = "Trebinje",
                    ZipCode = "89000",
                    CountryId = 1
                },
                new City
                {
                    CityId = 10,
                    CityName = "Visegrad",
                    ZipCode = "73300",
                    CountryId = 1
                }
            );
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   UserId = 1,
                   Name = "Elma",
                   Surname = "Comor",
                   Email = "elmacomor@gmail.com",
                   Username = "admin",
                   PasswordHash = "Ec2E8HEyY+K7jgCZxIq6xN1mMC0=",
                   PasswordSalt = "hIKCvFbPgvV3+1ee/YT0ag==",
                   Adress = "Put za topli do bb",
                   CityId = 5,
                   Slika = null,
                   RoleID = 1,
               },
                new User
                {
                    UserId = 2,
                    Name = "Korisnik",
                    Surname = "Prezime",
                    Email = "korisnik@gmail.com",
                    Username = "korisnik",
                    PasswordHash = "zKoUC9Xl5ULYE9GgvkhJ8OfrP7U=",
                    PasswordSalt = "AaqPcOkG3IxMF79mKa3H9w==",
                    Adress = "Sehovina bb",
                    CityId = 5,
                    Slika = null,
                    RoleID = 2,
                }
           );
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = 1,
                    UserId = 2,
                    Datum = DateTime.Now,
                    Vrijeme = "10:00 AM",
                    TerminZatvoren = false
                }
            );

            modelBuilder.Entity<DentalService>().HasData(
                  new DentalService
                  {
                      DentalServiceId = 1,
                      ServiceName = "Čišćenje zuba",
                      ServiceDescription = "Profesionalno čišćenje za sjajan osmijeh.",
                      ServicePrice = 80
                  },
                  new DentalService
                  {
                      DentalServiceId = 2,
                      ServiceName = "Popunjavanje karijesa",
                      ServiceDescription = "Efikasno popunjavanje dentalnih karijesa.",
                      ServicePrice = 120
                  },
                  new DentalService
                  {
                      DentalServiceId = 3,
                      ServiceName = "Vađenje zuba",
                      ServiceDescription = "Sigurno uklanjanje problematičnih zuba.",
                      ServicePrice = 150
                  },
                  new DentalService
                  {
                      DentalServiceId = 4,
                      ServiceName = "Dentalni rendgen",
                      ServiceDescription = "Dijagnostički rendgen za procjenu dentalnog zdravlja.",
                      ServicePrice = 90
                  },
                  new DentalService
                  {
                      DentalServiceId = 5,
                      ServiceName = "Ortodontska konsultacija",
                      ServiceDescription = "Konsultacija za bravice i ortodontske tretmane.",
                      ServicePrice = 200
                  }
                );

            modelBuilder.Entity<MedicalCard>().HasData(
                new MedicalCard
                {
                    MedicalCardId = 1,
                    UserId = 2, // Replace with an existing user ID
                    DentalServiceId = 1, // Replace with an existing dental service ID
                    DoctorsOppinion = "Sample Doctors Opinion",
                    datumDijagnoze = DateTime.Now
                }
            );
            modelBuilder.Entity<ProductType>().HasData(
    new ProductType
    {
        TypeId = 1,
        TypeName = "Četkice za zube"
    },
    new ProductType
    {
        TypeId = 2,
        TypeName = "Dentalni konac"
    },
    new ProductType
    {
        TypeId = 3,
        TypeName = "Dentalne paste"
    },
    new ProductType
    {
        TypeId = 4,
        TypeName = "Vodica za usta"
    },
    new ProductType
    {
        TypeId = 5,
        TypeName = "Elektricne cetkice"
    },
    new ProductType
    {
        TypeId = 6,
        TypeName = "Dentalni materijali"
    },
    new ProductType
    {
        TypeId = 7,
        TypeName = "Oprema za čišćenje"
    },
    new ProductType
    {
        TypeId = 8,
        TypeName = "Oprema za popravak"
    },
    new ProductType
    {
        TypeId = 9,
        TypeName = "Oprema za rezanje i oblikovanje"
    },
    new ProductType
    {
        TypeId = 10,
        TypeName = "Svjetiljke i instrumenti"
    },
    new ProductType
    {
        TypeId = 11,
        TypeName = "Ostalo"
    }
);

            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      ProductId = 1,
                      ProductName = "CURAPROX CS 3960",
                      Barcode = "123456789001",
                      ProductDescription = "Zahvaljujuci 3960 mekanih i tankih Curen vlakana nježna je za desni – i pruža ucinkovitost cišcenja. 3960 Curen vlakana promjera su 0,12 mm. Odaberite svoju najdražu boju.\r\n\r\nZubne cetkice Curaprox sprjecavaju oštecenja uzrokovana cetkanjem i vrlo ucinkovito i temeljito uklanjaju zubne naslage tj. plak. Curen® vlakna su cvršca od najlonskih vlakana te zadržavaju svoj oblik i cvrstocu cak i kada su vlažna. Upravo zahvaljujuci tim svojstvima moguce je proizvesti mekane cetkice s velikim brojem tankih vlakana.\r\n\r\nNe sadrži štetne tvari poput bisfenola A (BPA), ftalata ili azo-boja.",
                      ProductPrice = 5,
                      Slika = null,
                      ProductTypeId = 1,
                      StateMachine = "draft"
                  },
                  new Product
                  {
                      ProductId = 2,
                      ProductName = "LISTERINE Coolmint",
                      Barcode = "123456789002",
                      ProductDescription = "Listerine coolmint rastvor za ispiranje usne duplje pomaže u sprIJecavanju pojave plaka i gingivitisa.\r\n\r\nKlinicki je dokazano da svakodnevna upotreba tecnosti za ispiranje usta može da poboljša oralnu higijenu, a klinicka istraživanja su pokazala da ispiranje od 30 sekundi sa Listerine tecnošcu za ispiranje usta, u kombinaciji sa pranjem zuba cetkicom i upotrebom konca, pomaže u kontroli zubnog plaka – glavnog uzrocnika oboljenja desni.",
                      ProductPrice = 10,
                      Slika = null,
                      ProductTypeId = 4,
                      StateMachine = "draft"
                  },
                   new Product
                   {
                       ProductId = 3,
                       ProductName = "Colgate Total",
                       Barcode = "123456789003",
                       ProductDescription = "Colgate Total pasta za zube pruža dugotrajnu sveobuhvatnu zaštitu vaših zuba i desni. Smanjuje plak, jača zubnu gleđ i pruža svež dah.",
                       ProductPrice = 7,
                       Slika = null,
                       ProductTypeId = 2,
                       StateMachine = "draft"
                   },
                  new Product
                  {
                      ProductId = 4,
                      ProductName = "Oral-B Pro 1000",
                      Barcode = "123456789004",
                      ProductDescription = "Električna četkica za zube Oral-B Pro 1000 pruža učinkovito čišćenje zuba i desni. Ima senzor pritiska koji vas upozorava ako previše pritiskate prilikom četkanja.",
                      ProductPrice = 40,
                      Slika = null,
                      ProductTypeId = 3,
                      StateMachine = "draft"
                  },
                 new Product
                 {
                     ProductId = 5,
                     ProductName = "Sensodyne Pronamel",
                     Barcode = "123456789005",
                     ProductDescription = "Sensodyne Pronamel pasta za zube štiti od erozije zubne gleđi i pomaže u smanjenju osetljivosti zuba na toplo, hladno, slatko ili kiselo.",
                     ProductPrice = 8,
                     Slika = null,
                     ProductTypeId = 2,
                     StateMachine = "draft"
                 },
                 new Product
                 {
                     ProductId = 6,
                     ProductName = "Crest 3D White",
                     Barcode = "123456789006",
                     ProductDescription = "Crest 3D White pasta za beljenje zuba uklanja mrlje s površine zuba i pruža sjajno beli osmeh. Formulirana s aktivnim sastojcima za izbeljivanje.",
                     ProductPrice = 12,
                     Slika = null,
                     ProductTypeId = 1,
                     StateMachine = "draft"
                 },
                 new Product
                 {
                     ProductId = 7,
                     ProductName = "Listerine Total Care",
                     Barcode = "123456789007",
                     ProductDescription = "Listerine Total Care rastvor za ispiranje usta pruža sveobuhvatnu zaštitu od gingivitisa, kamenca, lošeg daha i drugih problema s ustima.",
                     ProductPrice = 15,
                     Slika = null,
                     ProductTypeId = 4,
                     StateMachine = "draft"
                 },
                 new Product
                 {
                     ProductId = 8,
                     ProductName = "Waterpik Aquarius",
                     Barcode = "123456789008",
                     ProductDescription = "Waterpik Aquarius je električni uređaj za oralno ispiranje koji pomaže u uklanjanju zubnog plaka i poboljšava zdravlje desni. Idealan za korišćenje kod kuće.",
                     ProductPrice = 50,
                     Slika = null,
                     ProductTypeId = 3,
                     StateMachine = "draft"
                 },
                 new Product
                 {
                     ProductId = 9,
                     ProductName = "Arm & Hammer Advance White",
                     Barcode = "123456789009",
                     ProductDescription = "Arm & Hammer Advance White pasta za zube sadrži posebne sastojke koji pomažu u beljenju zuba i pružaju dugotrajan osećaj svežine.",
                     ProductPrice = 9,
                     Slika = null,
                     ProductTypeId = 2,
                     StateMachine = "draft"
                 },
                 new Product
                 {
                     ProductId = 10,
                     ProductName = "Philips Sonicare DiamondClean",
                     Barcode = "123456789010",
                     ProductDescription = "Philips Sonicare DiamondClean je električna četkica za zube koja nudi naprednu tehnologiju čišćenja i pomaže u uklanjanju do 10 puta više plaka u poređenju s ručnim četkama.",
                     ProductPrice = 120,
                     Slika = null,
                     ProductTypeId = 3,
                     StateMachine = "draft"
                 }
                 );

            modelBuilder.Entity<Favorite>().HasData(
               new Favorite
               {
                   FavoriteId = 1,
                   UserId = 2,
                   ProductId = 1
               }
           );

            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<OrderHeader>().HasData(
                    new OrderHeader
                    {
                        OrderHeaderId = i,
                        OrderDate = DateTime.Now,
                        UserId = 2,
                        TotalPrice = i * 10,
                        Status = null
                    }
                );

                modelBuilder.Entity<Transactions>().HasData(
                    new Transactions
                    {
                        TranskcijaId = i,
                        OrderHeaderId = i,
                        Amount = i * 10,
                        TransactionStatus = "Success",
                        TransId = "PAYID-MXPGHDI82U242769W004564J"
                    }
                );


                for (int j = 1; j <= 3; j++)
                {
                    int orderId = (i - 1) * 3 + j;

                    modelBuilder.Entity<Order>().HasData(
                        new Order
                        {
                            OrderId = orderId,
                            OrderHeaderId = i,
                            ProductId = j,
                            Quantity = 2
                        }
                    );
                }
            }
        }


        }
    }
