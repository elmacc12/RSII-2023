﻿using Microsoft.EntityFrameworkCore;
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
                      Slika = Convert.FromBase64String("/9j/4QAYRXhpZgAASUkqAAgAAAAAAAAAAAAAAP/sABFEdWNreQABAAQAAABaAAD/4QNxaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLwA8P3hwYWNrZXQgYmVnaW49Iu+7vyIgaWQ9Ilc1TTBNcENl" +
                      "aGlIenJlU3pOVGN6a2M5ZCI/PiA8eDp4bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIiB4OnhtcHRrPSJBZG9iZSBYTVAgQ29yZSA1LjYtYzE0NSA3OS4xNjM0OTksIDIwMTgvMDgvMTMtMTY6NDA6MjIgICAgICAgICI+IDxyZGY6UkRGIHhtbG" +
                      "5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyI+IDxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PSIiIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdFJlZj0iaHR0c" +
                      "DovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bXBNTTpPcmlnaW5hbERvY3VtZW50SUQ9InhtcC5kaWQ6MzI3MUVENzQ1QzIwNjgxMThBNkQ4NEZERDU5N0Z" +
                      "ENDkiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6NEQwREZGNzdDN0ZCMTFFOTgxOTBEOTc3RTVBQzUwQjYiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6NEQwREZGNzZDN0ZCMTFFOTgxOTBEOTc3RTVBQzUwQjYiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGh" +
                      "vdG9zaG9wIENTNiAoTWFjaW50b3NoKSI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjMwMUM2ODE1RjEyMTY4MTE4MjJBRTA2MDMxQjMwOTYwIiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjMyNzFFRDc0NUMyMDY4MTE4QTZE" +
                      "ODRGREQ1OTdGRDQ5Ii8+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiA8P3hwYWNrZXQgZW5kPSJyIj8+/+4ADkFkb2JlAGTAAAAAAf/bAIQAAQEBAQEBAQEBAQIBAQECAgIBAQICAgICAgICAgMCAwMDAwIDAwQEBAQEAwUFBQUFBQcHBwcH" +
                      "CAgICAgICAgICAEBAQECAgIFAwMFBwUEBQcICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgI/8AAEQgCWAJYAwERAAIRAQMRAf/EANYAAQACAQUBAQEAAAAAAAAAAAAICQcDBAUGCgIBCwEBAAEFAQEBAQAAAAAAAAAAAAcEBQYICQoDAQI" +
                      "QAAEEAQIDBAUHCAYHBQkAAAABAgMEBREGIRIHMUETCFFhwSIUcYGRoTIVCbFCUmJygrIj0ZKiwjMW4YOjVCUXCkNTNIS0c5Oz00R0lBgZEQEAAgECBAEIBQgHBQcDBQAAAQIDEQQhEgUGMUFRYXEiEwcIgZGhscHwMkJSkiMUCdHhYqKyMxVygsJDJPFTY3M0JRbSk6PTVCYXN//aAA" +
                      "wDAQACEQMRAD8A9/AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAab5Yo9PEkbHr2cyomv0nzvlpXxmIfsQ07NurSrTXblmOpTrMWSxble2OKNjU1VznOVERETtVVPtSs2nSOMy/mZ0Va9Q/wAaP8Ovpr1fx" +
                      "/RvNdfaWTyzpJ4tz7wxkUmQ21t+SGJz0bkcnX1hYr3N8NEYr1R3B3KnElDY/BvuDPsp3MYtKxppWZ0tbXzV8fTx04MW3nevTcGeMV78Z14/oxp57eEerXVgDM/9RD+G/if+YCs3huHIM2kyum0ZIsBZZ/nCxPzIsOHbO5j3KxUTmdO2JuioqKqF5r8Beu/u+b3cTfx9qPZ/2vX5IrrK2x8Rum" +
                      "zz8vNPL/Znj6vRHlmdI9KdP4ePnl2p+IT5ek6+7R2Xd2BThz2YwF7bV+xFalisYqSNUek0LWNckkU0bl0T3XKreOmq4R352dboe/8A4abxk9mLRMRp4+j1x+LIugdZrv8AbRlivLxmNOE+HpjgnQYWvQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAB8uc1jXPe5GMYiq96roiInFVVVPy1oiNZ8BCLqB5por2Wzu3endmOGjt2KSXM7xk5XRu8NUYqQa8Eairxe7uTh6TRL4r/ADTZtxny9P7f43xxPNmmNa+MRpjjyzzTprPDzRLJNl0eK6Wy+E+T+l5vPND+M70+2rkcxj+ma3+te6q73xt3DZvWqGBgka5Go7xOEkiIv5sbE+UuX" +
                      "wl/lWfEbvbLHUe8OpZtjgvpaKUyWvubRPGPCYxYPNpEXnTyxPBiHXvjV0vYxNNnSMto4azwpr99vshRT17/ABDfNN5ovvLbe/etmZt7JsIiTdKsNkrOH2zDC1VbyWGNmdJM30rM/RfQduPgd8vfanw+6bXp/SqZMk1nWcmfLbNlmfLM3yTaYjzRHLWPJDXrubv3qPU7TbLbSs8NKxpGnmiI8ftlCX" +
                      "qXNubGdPNs7X2E7BUZOouVTH5nLz1rDYqFd2sSPYrkakq83a5zkbx4Kqkld37neWrjw4OSJyW0mZ14R6I8rGOlVwTmtkzc8xjrrERpxn0+Z0vLbVyk3Vjphs3c2apW6OIpOyUOVZj0Zahd4iV5nVIpZPDV/gxq+Jz9WsdprqYvuMee/UKUma61prEzE+Ph4a/9i6bfPSu1tkjm0tbSYifJ4+P5avUn5" +
                      "U/xwdl9B8v0F8i/ka8qVnH9P8JuzBY3e+W3dna9zdm4H7iybPjbEEFKOtE2eZZvdne5WJoicqJoRL1r4bzvr7jedQz65axOkVjSI0j2ZmJ48qR+k924cFcO32uOYxzOmtp+vjx1t59Ze3M1bS4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "YR8yG4n7V6GdTMxDK6GzFi54qr2qrXeLYRK7dFTv1eQ18w3cNul9kdQ3NZmLVwX008dZjSNPrV/S8fPuKx6VJOe3dhOl/l961dQdyyLXweCxjYsjPyOe7wljVrkRGcV5lc1OHpOWfwl7I6p1Tbz0/pkR/Gbi+LDh1nl9ueMTNvJEac0zpw010lknV+o4dvWcuWf3dIm1vLwh4Xd9bc6QYzM7myu59938p" +
                      "t7I2LD9v4q/bbjWVa8k7pWNbFRe2SRWIqNa5XJwT3kVT1E9m9l9yYun4bdzdRiclK1i9MM8lLTERrzXn2rRPlisU9ctM+r9d2Nstq9O2sazM6Wv7Ux6q+ET65n1OExu5cNlYK9HYm2XQYNOEGSdXdXrycdFdEjG+JKvDXWJrlXvJU6d1TaWrybKkzTzxGlZ9dp4z9GssbzdP3FZ5txb2vTxn6vJ9OjW6ubY" +
                      "3Bu3LbK6cZvcDtvbCiihtW1qV48ffluVHstJFZlljmTldI9fdja3RqavVVRWmO9wdO3O83NaZLRTFXjpWOM2jwi0z5NfNEeeZ8iv6TvsO3pbJSvNkmdOM6xp4a1j1ef1QxdR6H9St1daspL1C6wrWu7ZpNTZsWEYlKaKveid4KRLbicita6NqyJxc/iuqJqYzg6B1bcby2bPuIi9Y0ryRppE66RpMcIifHh" +
                      "MyvN+tbDDtYx4sOtLTrbmnXjHj4T5tdPCIds8sW8N9eXfcO4vNJsDcDs/wBcOlN+WbA7xy+NhyePvZmmskTLD6mRZrOkCKx8ayM5I3ojtOGhao6Tz9LzWva175Na2txjnmPHx0tp4RrOkR5lzjqnut/irWta0rxivD2Yn1cInx8OMvd3/wBOf5nvNh5numfmV3L5mOoWS6qR4/PYOTbe78laktNju38U6e/Tp" +
                      "LHFDXZXiVGL4ULGtY52iJoQ98Z+3tl0623pgpWlpp7URpx4+Mz4zPpnx8iRexOr7jeUy3yTNoi+kTMacNI4aeH5ceL0ikIs9AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQx89eZWh0UhxLHaSblzOMqq3X7Uccq2pE/qxGovzsdXtt+yLYa+OfNhp9" +
                      "HPFrf3Yle+gU13GvmiVGnne3/ALb6ZeRjqBb3VUsW8Xv+zPhJoqvKk2uSgfVa9HScG8nI5yOXsdoa0/Ld8Ler929b2HTembmNpubbic8Zba+zXb8tp0iJibTP5sRrGsTPkiXy7r67t+nbPJnzUnJSI5eXzzbhx9DxI3WeXHpvafYlSPceefK1tKxmb6ZO5z/mNbq13M/1Nj5lXvPR/wBL7Q6J0asZeo7n+Kzx+" +
                      "leY01/s44mft5pambvrXUt/ace1xxipHkpHH6bcNPo0d8x2W3HuixXSxe/5e4nIPY2o+SpLWu2GPVOXw66tkuP48G+41CSendwfxUa4omtI8JmvLr6onjp9EQxbedL9x+f7dvLx109fk+2XWt47Nze+PMPjcJnM7bni2finXNt4OeNrXrbkgbUfdsuRXNkex0fM5r29nBNV1UwvqWwtuerWta8/u661rEeEzw5p" +
                      "8k6T5/REL3sd5GHp/s1iOe2kzr4xHHljzax5mOtq9L6WYyXWGxnN9ZDcPVfprJI/G7jpyrHLXxMVWSxG5a70Vsj3q5U0eirona1NEMe23Rrz77JfNe26xzPtR4xWI1jWvh988PIu246nWsYq0xVrt8keE+E2mdJ0nx+5oYfH7fd5b73UbEb2yslx9iNd23JLEVuLLNsWtLXjwsTSF3hrw0T0IicT4bjb1/gKZve3t" +
                      "jtpNuOsW1n2pnzT6PMqsGSa72cPu61tGsV4aaaRw09D+h7/ANN7SzNf8Pr4lu5IstsC1uvMN6dYNuHXHTY2tGkXjpJbVrPj/GkdzpOiaJxZqqtXSB/jfXDXq8VpXTSkcddYmPJw8nDyfSlP4fWy26dE3nWZmfJppx4x6ePlX/kNs4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAVr/iCZlrrHSfbKScfFyWSli9UMDKjF0+WZdDnx89/Vda9N2cTHHJkyTHnilOWPtvDJO36fn29EQ8/n4yXULamzfKN0/6bb1wSZba/VVz4MzbltupV6r60kWRiV8zPeR7n6ciJ2o1xcfkx+DODuvu3Zxffzsf9Pw/xGteXnye8m1JrXn1iKxEzzTpMxrXSInixrv7uPL07YWtjxe9nJPLx10jy6" +
                      "zpx9Xh63kWp7/6QbTyEGB6a7WkzW45VX4evhMfYvZaVf8NVW09JLCN7lcsjGId3Oj4u1Oi5uXbRO43M/pccuSfV5vo5Ya1763Wd/TXL+7xR5OFKR/T/AHpZY6dN6nZPc9aWeLG9K9fEsRUWxw5zcT/CjWZPE8JJa8D1001e96ovrJK6fuuq7i3PfHXBj806WvMeqOEfTMz6GI7+myx4piLTlt6NYr5vGeM/RER6WI9pb" +
                      "Gh3v1e6s7jzvWC5PvbCulr7VpurV6ra9OZjlkR1WWXxHtjc/TmaiIqrzN466R9sOn5M263GX302yRzVjhpy1n+zrrOkzwnh54mZZNud5TFtcNPdxFJ0meOusx6dNOMR+EscbR6LbPf0g3tloNx52DekH3hDvG5Vylh+XyzqjJVRs0DZlR0cqtZzRq/VETjy66Fm2vaWGOk2mtssX0mbzFtZvp5LRE8Ynx014eVddz3Bln" +
                      "f1iYxzTWIrE14V1/VmY8Y8+nHyOayOH6RbZ6P9J7eMlx9atLksdLn/AAbdeKZ6SK5ksckcDVbzIrvsq1V4a6qvBa3Pstht8O30iPdxaPL46xx4ev8AKVNg3O7zZ83NMzeYnyebw/L7n9Pr8FRMx/8AzD8pz8ver5DxMLd+6ZqzUZG3Htzd1lZmiMZxbG1EXh85q78VJiev59I04x90Ju7RraOm4ubx5YWlkfMjAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAVB+d7KLluuuLxLF527ewdWNETiqSX7Usypp8kbTlL86/V4z96YdvHjg22v05bz/APpwy/oVNNvM+efu/wC15tPx7usO19oWOk/R3qHtvG5LZWVx0eQoXcgsjkXJ0FdXcyvHE5i+JFHLzK7Xgjzb/wCRT4Pdo9Z69uup9U3d8" +
                      "W56fTHhpipfk5sd6Vva1pj2pra0cukTHGmuqNPiP17qu2wUxbTHFoyazNpjXSYnhHHh6eOvqec7CdS8jnqzsT0i6bz/AHJG3SbLLXjw2GiauujpLEiQxu104+85fSinZztfrnSdrj9z0TbRNfLasaR67ZJ8fXMzLW/q/Td5lye86jmnm8kTP+GkeH0RDKHT6rl7U+bS1u5Jc1ToTzQ1sBTklpVHLpE5ZLlnwmv05+xjF1X" +
                      "TjpqZrXdb6+K1sl6xbTwpGsR/vT4z9iwZ8WCk1iKzy6xrzTpM/RCL23OnPT29huu02+d75GTqJVuXG7n3w64tCwqNrKldEkqK1FjRETn1byrwTv4xRte3dpOyz+8y2jJrbnvry+Hq8n5Qzrd9W3Ndxh5KVnHpHJXTX7J8rpmb2D5e6XQLYe8cHenw01+3Xg3LnIMvYqfeMTVVl6NWzuVr14td/L4aO14rwLZuei9Hx9Pw5O" +
                      "ea47TETMWmOePLwnx09ELjj6h1O2+yY5rFrxE6RyxPL5vVr5NWTMjt/pxt7eXQbI7O23HuDEbhoW6mC2y2o6xYtyJoymqQtR0j5ZZZV5UVyIq6e7oXjcbXZbbqWK1IiKTT2dfR4Tp9PlW/aX3W42d6W195FuPr8sfg/q8eQrpnkuj3kw8svTvNx5eDP7f2bhF3FSztqS5lauRt02XrVaaSREVPAmmfExmnuNaje41A7y6h/F" +
                      "dVzZeE63njXwnThrHr8dfL4p+6Ptvc7WlOPCsePilwY0uQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACk7rBfdu3zN75fH/ADYmZqpj41XuZQrwwORPke1xxp+Nm9jqvxL3czxiuXFij1UrXWPotNmbbKvJtK+qZeU38cPr9Yxnmqs9Otz7Wq5/EYehUvbL58dHfm" +
                      "VbCcsrmyzMcxi88eitTjwTu0OpPyG9s/DWvT9313fzOXqc5748lbWmKUpjmYxxy6xSdazFtZ1nWZ9SGPiTk7gvmrt9rPJh5YmJiOMzPjx4z9Sku/ujr31CtuhwXT52Fx9dW+FnNwSOoUIUVEc3w2yIr36IvBIY1Q6l9H7y3PVMVf8AS9t+5/Rtb2cf0cI1/wB2JQVve38OyvP8Zl/eeWI9q/06TOn0yyptLofuuLGZncO++" +
                      "qWTy2djg0xG3sK9mGpskla5WyrG5VnliYqa6u0a5dOGmpkmXo3U4xzfc7i0z+rjjlrGv2zp48dPUst+rbPnimDFXSZ8b8ZnT7ImUYchsLaTPLtujcth+Qyed3Xcjl3Feyd6J9++yO7HE900NWRdI5JWuVG6c2nYpHW/6JtI6PzXi1pvaJmbTxtx8sRPl4+HFmO16puJ6jFaaRFYmIiscI4eSZ8vh6HfN84foJSzXRfHS4jBy4" +
                      "6B0cuTwTmMRjfFqo2OZlSXmbyo5NFVznele8retdL6XG5w0mKTyzPCZ8ImOE6a8I+tS9M3/UPc5ba3jXy+edeMa+WWSen23crvnzC7X290XwF7ec+8qeKp7HwG26E8k9fJWbzkjfAkWnhuRrmojNUVUTX0qn7h3m1wb3Je0xyRjjjHGK+uZ8I8mniqqbTc58FKRrF+fy8Jnj9sx46+D+tjsTE5PAbH2bgs1lJs3mMLisdUy2" +
                      "Zso1LFuzWpxwyzyo1z0R8j2q52jl4r2qaO73JW+a1qxpEzMxHo1bGY4mKxq7WUz+wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPl72xsfI9eVjEVXOXsRETVT8taIjWRRVsi0u4OqdrcFr3VzOVyN/3uOrrNiadifMjkOF/QeuYt93ZfdXn/ADs+a8fTa0x9miQtximuHl" +
                      "80RDyifiVZ7q5/+23WXHbgo3Jtu7XusftrKR0kgoQ0bUDbEapenaxqv0do/R/BeCndD5Gc3wj6P2Hg6taNvTqWTX+Ivl0nJ76JmJiItrMaaezy18NOLWr4lbfuPc9Stt8fvJw/oRWdI5fTppPr1n6FQO5evF6m+ddvbesZ63A97GSuc1jJJGprrFLM+Jqpr3tc43aw/MBh6pkinSsOXcz+tWs1pHpm1tPuR5//AFll2tNd5emGPNMxMz6IiP6XTKWV8wu+2fHzSQbIwbpGrLJXjSRUcrV1V9qdK8XPyquuqPXjwL7TB3FvI1z3rhrPkr7VuPp4R96itHR9twpW2S0efhH0R4/c3/U3oNtPbGw+kONpz3oMfuLLxPza2Mmvh5aOVnLMyVkr4FfCxyczeHKi6r2KUfW+y9vgjBimbe75vaibfnefWOHCPJ5n26Z3TlyXzWiI54jhpX83zaePGfK7rlr/AJf8f1i6dY6Pb" +
                      "uLrWocPYdHbq0Us1omrpHXdY5OdVc3lerFdrw46FRk23S8fU4rFaRflnjEcIjya+nR/Nc2/ybGZm1piLRwmeMz5dIS9/DE6E73803nTpdMfL66S5FR3Zg83nNyNvufQw+3sTdqyz2FZI9jn/DovBrPe1doiaa6WTN1zZdP6bucmv7uJmsacYtMxwrHm9cr/ALTpm43W9wxaPaiItOvjERPi/qhGlDYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABt7cHxNWzW5uX4iN7Ob0c7Vbr9Z8dxi95jmvniY+t+1nSdVB1W7d2lnLeLtxOpZvbFyepfh+y+OevK6J306ap6lPNb1Hdb/ofVcu1y603G1y3pPnia2mNY9ExpMeeJiUuctMlYtHGtoQo/Eo6CXOu/RDci4CslnO5OjrjayOjj8S3XlZM6JJHqjWeM1Far" +
                      "teGvE2Y+Xf4gdE6H3z0/rPU6RfZTkj30aa+FZjXTy6TNbaeXRjHc/T9xuNhkxYLcuXlnll5K+o+1cV0VzNTAZ/Ztavu10fM3D3Hq6OFmqt5pHxRzOdx/Ra5F7OB6SegfNt291T9127tM++pHlx05KRw89tPtiGo9vhZ1GYnLvdxTD65m1p+78Ufczu7rnnbKQ7Xix+1qL3u+HyT6PvN/Wikysj+VV/URvydxJvS+pd4dSjW+PHssc+ERMWv9Mz+ErVuOm9D2nCL33F9NJ1jSPqj8W72T0kv53e9HdXVvct7qFZoxSOggn+LuuVypytZEjuRrNHcddFTgZR0ntKmPP7zcXtmyR4TOs/fp9y19Q6xb3PJhrXHX6IZ/6NdBt37r6zbs2v0L6Wbo6l2d4+Cy1PicDkMlVoXZYljfA1ateSJjlVU5nc+jV1T3ikxfwWzzZq2vWlbcZtaYiI4cYjX8vWq5xbzdYcd4pa01nwiJmZ80zP" +
                      "9Pr4PRr+Bx+DB5u+iHmJ6Y9eesmyLPl86a9GbmXuYnb+Tvwybj3FYuUpqUcb6uPeqRV1SzzPdMqKvLy8i66pEHfXevR8XRp2O1t7y08NY8IjXXWZ8/DhER5fFJXbPbu/nqH8VnjkjzeXXTTThrw9c+MeHle2c1rSsAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAU/ebnZ0WC6/W8hXj8OrvzG1b8mnYtuqq0pV+VWsjOHH8wLtTF0rv2N5WNK7zBF59N8c8lp+mvJ9SR+2s832vL5azp+LH+dwNbL9JKkkkKc0c8scki9quieqd/6rtPmNcqbvDk7Sw54iNYy2rM+mttPumI+hdopPvZj0KLfNL+HBmOtfV7D7+2zmKu36cuO+B3NHJXllsv8Od0sMtd7OVrVTmc1yK9NeB0y+Sz+YTXsDtjcdMvsL73mvz47UtSkRa" +
                      "YiJrebTrpw1iaxafGNEQfEH4Ux1ndUyxl93pwmNNdY9EeH1uX6a/hYdItvz/H70oSbltOVrHOszT89h3dpFUdDzuVU00ervkLz8Uv5qnxDz4ddp/DdMradIjHSc+W0z4RW2SIibeiMUz5nz6L8D+j4J/ec+af7U8sR9Ef0vRl5LPw3vLF0n6Z4vKbj8t207W88vZmv17OVwGOyF2jWlRjYI9bsUvhuRGc6o3RUVyoba/L13f3/uu1ce47k3mfNvNxack1vMVnHS2nJSa0itYmKxFrRpwtaYfTfdD6Xgz6bbFStY4cI8fpnWVnmNxmNw9KDG4jHwYrHVWo2rQrRRwQxtTuayJGtRPkQlfJktadbTrL9iNG+P4foAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAArh85MNa71J2HHqiTUsPedYVNFc1stuJGLp+4444fzNdx" +
                      "gydwdNwzPtRgzzPn0m+KIn64ln3aFZ9zefTH3MVU8REnT/EUbKJJDclnsvb+k10yo36URDTfonRaY+09tgyTzVyXvk9cTeeX640ZRM/vJn6HVr+JpLDyyRNjrU9Xta1qIiIjdVUzLb7rHtcEzwrSsaz5oiOKl5dbelN3y29Dtv4jBY7qNuPFR5DdmfYk+KbOxHtxtJ/GJkbHIqJI5Pee/t46JwQ6dfKH8vWx2PS8XX+o44ydR3VeevNETGDHbjSlI4xFpjSb28bWnx0iIjC+4OrWvknFSfYj7ZS/N62LgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAqr8weZdn+s28XRuR0eDjp4ur38YYfiH6fvzqnzHny+fHuy3VPiNvK0nWNrjxYI9cVnJb67ZYj6Eq9sbfk2lf7Ws/h+De5qFtKji8aiafCV4YuX1tYirr86lg7m29dp" +
                      "jwbWP+XjpXT1VjX7ZXPFxrNvPLomWrrYqOrMRVdefDXY1O9Z5mxafOjizb7FOfHXbxxnLelNPPz3rX7pfGOE6+bVbpjKceOxuPx8TeWKjBFDG1OxGxRoxE+o9HHTtlXbbemKvCtKxWPVEaIfvbmmZ87fFa/kAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAANOaaOvDLPK7kiga58r17Ea1OZV+hD55stcdJtbhERrP0P2I1U3VLUu7N5WcrKi8+6MtNaf3qjbNt0yJ8zFRDzDda6tfuLuu+4txne7y1/wDdtkm1fqpFY+hNO3x+6xRH6tfwZM3PKr8nL2+65+nycyon1ISL3xu+bq1580z9Wv8AU/cNf3UNhtqmmT3lsfHKnMl3M49r26cOVk6SLr/VL/8AC7bf6h3b0zbaa8+7xa+qs834KDfzyYL2/sytYPQyiMAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGLOt2fdtnpPvvKxrpOmPlr1V10XxbulNip60dKikI/Mj3bbofYfUd5X8+uC8V/wBq8clfttC5dHwe83VK+n7uKtPpdVkm3JVWSNqVsVC+WN6aqvMjeVupwF+DPSsmXuTHN6x7vBS1ony6xGka+ryedK25yaYp9LsOam8TIyapx5UVf3lVe8r+ubmcnUL+fhP1yqNNKw7V0jrrd6tbAg5eZIrNiwvq8CnI/X5idPlS2P8AF/Efp1NNYrbLk/ZxW/pWTr9uXZ3+iPtWaHeVFQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIh+cfLurbB27go1Vrs/loVm0XTWKnE+dUVO/3laaAfzG+542fY2PaRPtbrc46+uKa5J/wwyntPDzb" +
                      "ibfqxP8AQjR0rrJBjs9kX9rlSNF9TGOd7UObvwS2sY9tutzPmiv1VmZ+2YZtueOkOByE3Nl77nO15Ujbp60br7SLr5+fqWWdfDlj8fxXPJHswy35eoUs9YMO5E1+AxuRlX1czY4Nf7Rt98juznN8Scdp/wCVtc1vrtjrr9ssY7otps59NoWLHbRGgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIF+czIK/K9OcQn2YWX7TvWr/ChT+FTk5/M56rzZek7TzWzZPqrWkf4pZz2dTSuS3qhjzY8KVdieOqaLcfO75U50jT+E1h+HmGuDtO+SeHPzz9sVj7mS345YhjK69yZLJToieGj3cy9/u8DXaszG9zZI/N1n7F1yT4JDeVdI7vUrctxio9lHCRsTTudPca5fn0Yb9fy65x7vvff566TGLZ4q+qb5JmfsrDEO75mu2rHnt" +
                      "P3J/HZBHYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAK2/N5edP1QwVROLcXhkXT0OmsyO/IiHFX+ZL1muXvTZbavGcW1tM+jnycPr5fsSH2lSY21p89vwa2PhSlsnEV0dz6wRKq9mviO8VfymC7baxte0cWOJ11pX+9PNP3rzSdc7ANPJLYW6sy83vyIjl728yml3Znc9t1XL73jpa0RPo5p0XvdYtJjRKryb02uznUvJMTVjW4+FHJ+sssnsOl/8AKz6Tj/1Hre6p4c2Cmv0XswnvfJPJjr6/wTyOwyPgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAVb+Zyyl3rVmYGrzJTpY6D5FfH4i/wARwH+fbqf8V8Us+OOPutvgp9Nua0/ek7trHpso9My7rn2tpY" +
                      "OGDTRtWONmno8KD/QZB3/WNr0SMfkpFY/Zr/Urtnxyoj0ZHM53tXRHOXmTsTTicwOwd1bFSbRPGZ4wyjdV1T28mMTVw3UG21NPGyFWPX/2dZV/vncL+VdjrbonVc0fpbqsfs4q/wD1Iz72n95SPRP3pqnVVg4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKoOrTly3XndkTfe5srTquX1RMiaqHnj+ZPL/AKh8XN/Wvj/EYcc/7tacPtSt0eOXZU9UyyHvmdrcPed+rOuvo5YnKZd8cN/GLouS3k0vP1UlVdNrrkRJr6pEi6rqqcfYczu1ccxg5o8f62S55WK+TWr4ewNzXO34zMypzenw6sKf3jvf/K06X7nsTdZvGcu8yTr6qY4RZ3tfXc1jzV/GUvTpgw0AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAFSjpFzXXDN3FXnbNnL87l9UHNp/Ah5zOrZf9S+Ke6y+PPvs1p9VImP8AhhLmCOTa1jzVh3nqBLpgrqa6KsNj+BE7vlL18wG5/wDYMkeemT/Dp+Kq6XH7z6kXYuDNUXiicPyd5z17avEYItHDh+Xiv+aFmXlDjRnSR0mmi2Mrfe75USNn909DX8sfBFfhbS0fp7jPP96I/BE3ec/9b9EJRHQliYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAaFmZK9axOvBIGPeqr+q1Xewp93mjHitef0Ymfqh+1jWVSHTnW7vfI33Lz6NyVjn/WmsKiL/aPN/wDCz/qO6sueZ1/9TfX03yT/APUmLPwxxHqd26ivVmAscdOaGb63MQu/zC5uXoV/Tjv9vLH4vt0uPbRpj08Ny69iaadpoN0mum2" +
                      "nXzfl/wBi/Xnis/8AKW3l6NYx3b4t7IO1/wDMK32Ho0/lpYeX4R7Sf1smef8A8to/BEPeM676fVH3JLm+zFgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA6nvy9927J3bf5uVauNuva7s0VK79PrML+JHVP4Lt/d5/Dkw5J+qsqnZU5s1Y88wq66NMVX5iy9uqxUqrOb0rK9XL2/snnu+AN5vk3Ga0eGHHH02mZn7kt7yOMet2PqbLy4OVPTCvD5Zo0Ph8yu8inRJjw1pP23pCp6VX20dm/4Tk7tNNTSHY2tG0mIjTgvMx7S1TyuQeD0V2qvfO+9Iv716X+g9LX8vfZ+5+EfTY/WjJP15boc7strv7/AEfdCQZugxwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAM" +
                      "O+YC+uO6NdQbDV0kfj5Io19cypH/AHjXH5u+s22Hw06rmrOlv4e8R67Ry/iu/QcfNvKR6Vf3TF8WPwO5Lsr0bG2arDz9yI2NeH9o4ofCncYtl0nd57zpWLY66/R/Wk3JWbXiI9LcdUJf+GOZrwbCxU+ew3+gxD5n8/8A7Zyf2K/bkr/Qr+kxxn1/gj9zL4cnHm4dhpxXNP8ADW080fl/SuenFbR5a28vRPY360VpfpvTKeoD5FsXJ8JulR/4Uz9eS6F+55139/X+EM6G2awgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABGrzZX1qdHclXaujsrex1VU17WyWWq76kNLvn96rXb/DTcY54++yYcf7WSsT9jI+1aa7yJ80TP2IQ4dVqbEtcqorr2RVVVO/womHGPcZ7bbtHJp45dx/hrVJe1rrm9UNLfd1t3FTuavOsccDXr2rqr0ev5TD/AI69cpvelWmJ1mtccT65tE/irNjjms/" +
                      "WwyqfylTu+s1lpw2s83mVemsrb/Lfp/yT2Hp/u9j/ANbMeo75Iq6fCjpP/kf8dkLdy/8Arr+v8IZvNqVjAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACHfnLvpFsraOL19/J5druX0pVrSTflRDnP8AzKOqcnamz2v/AH27r/cpe/31hl3Z9Nc1reav3oqV3J/k3AsibyI+Wy5ycE1VHozX6jlh3RuKX7e28Y/Zib5J+mJiuv2JB2Nf3k/Q6xn9Uwt1qrrrJHp8iKhAHfF7V6NmrP69fH1xovFPzoY2VdInacSLMfHaTpx1h+a6Stv8tyovRPYen+72P/WzHqU+Sb//ACnpP/kR/ishXuX/ANdf1/gzgbSrGAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEB/ObklXOdMsMi66NyVxzf2Wx10X+2co/5mfWKxl6Rtdf0" +
                      "82SfVWkU++8M57Op7OS3qhgZFVu2ttM73xTv0/bsPObPcFtOhbKvnre315LSzzZ/n2n8vB1nPpphrLkXVzns493aQz31SI6Nknx1tX74XLH+cxs5NWPRU7O0i3HTm2szPDh+Xj4vyfztFtnlqdzdEdi8ddIbSfRenPUn8kc6/CjpP/kf8dkLdy/8Arr+v8GdDadYgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAArU83OQ+J6vYCgi6tw+D53J6HW7bl/JCcS/5mHWve94bPbR/ydra0+j3mSIj6/dz9SRuz8em3mfPb7oY4k0TA7Xai/wD0KOX96RzjSnuSdOk7GP8AwIn67TLMdn+db1uu55P+BWP22rr6OJEve8f+w3/2q/4oXDH+exgv2F1b2IvMupEuLX+G4xpw/L0nlWzeWGRH9Etmon/Zpdb9F+Y9R/yN35vhP0n/AMmf8d0K9zf+uv6/whn02vWIAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKpfMfebe66bvXXVuJpY2qq+hUgdYVP8AbHAT5/OrxufiVua/9zgwU/x3/wCKEodsU5dnX0zMuHvK2LFbVj11cuOrq7t4cyqqGs3e2euLY9Pp5f4bHr9OujKthGvNPpcJfry3cJlfB05ajUlk5l/Na5EXTTvI36zssu+6Hufd+GOIvOs+SLRrp+CtiYreNfKxU5vK1eZeKdy/6SGdtkn+HmbePp/r8Yfs19pap5U5vF6L4Fv/AHNm+xf/AMt7vaeoD5Bs/vPhJ0v0UvH1ZboX7pj/AK+/0fdCRxuEx8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKbermQTJdWurd1q6tblZIG/wDla0VdU+linmr+cTrEbjvzrOaJ8M3L/wDbw0r98Jd6Fj022OPR98uc3K1IrWLrouqVaFJmno/ko72kYfGD" +
                      "HGPqOHFH/L2+GP7urIOmf5cz55lx3iJBtvckyrwkjijbr6Xydhh+1y1wdt7/ACTPC1a1/alU5eOSsOoYenVyb307THJzRudFM381UVNCx/Dvo+z6nW21z1njSZiY8nH8tFPu8lqcY86xbykOVvSp9RV1+Eyl9rHelqyIqL856Gv5e+K+P4U7LHb9C+esemIzX0n6YRJ3ZMTvrfR90JQG6rHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB+KuiKq9iH5MikDLWky+4d55BHcyZfN5SRr/0my35Ub9SoeWr4y72Oo9f6hlmdYy7vcfTrmtWPs0hNGwry46x5qx9zJe70RNw3Ik7IGQxp+5C1pa/jXFbdz5a+StaR9VYhd+mf5MOHyCJHtDIqnDx7Vdnr4czjDes464+z8+n6WXHH1cX3n/Oj1OC2wxUu8698S6r+8fT4Q7bl3PP/AOH+Kl308PpWJeVSJGdMnTImjbF+y5vycyL7T0Sf" +
                      "I9t4p8MthMeFq3t+1ktKIO5Z/wCtv9H3JMG2ixAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADYZW0yji8ldkXRlOvNK9fVHGr1/IUXUtzGDb3yT4VrM/VGr+8ddbRCjrazVuNwv6WQtQvVPT407Xrr9J5UOed7usUx/zs1Lft5YtP3ps8NfRH3QypuR/i7kzjuGnxD2oq+hujfYUfxQ3Hvu5d5b/wAWY+qIhddjXTDWPQ47OOVm04WIuiWL3FdO6OFV1+lSw94XnH2nSsf8zc/dWfxf3Xjmn0Q2G3I9OeTscyJNXdy8dTKPhftOXFOTXWeSOKg3duOix3ywQ+F0gwDlTRbD5ZF9fNynom+Tfa+5+F/Sa+fbY5/ajX8UQdw213uT1ykGbMLMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOgdV7yY3ph1DvK/w/hsJk3Nf6H" +
                      "fBSIn1kefFzqcbLtXf55nTk22afqx2VnTqc24pH9qPvU/bCg1y+0KenBLNbmTTuYvN7DzK9ndPn/WOn4p8uXH/d1n8EwXv7NvVLuGRk8bKZSdeKPszLp2f9q4wLufdRn6rucs+XNk/xSvuCNMdY9ENDcjuTb2EjVfeknsv17OCNa3u+Up/iBk5O3Nnj8JtlyW+qIh+Y/wDNtPoho4j+TQuWHe74cTtdO9GsVTNuzsnuOlZctuE1pOvm4VmdVBuI1vELOPL/AFkrdJdoNRNEkr830uVvsPSv8vGwja9i9NxRw5dtij+5VC3Vra7q8/2p+9mUmVbwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABgnzM23UuhPUd7V5XWKTK6L/8AdWYq6/U81x+bzfW2/wAM+qWidJtt7V/bmKf8S79ArrvKev7lZ/TmFH7s24rk0bAr5V+SOFynAD4d4KZO6tpr4Uta37OOyUcnDHP5eVvVVXumeujvEkc7" +
                      "XXtRXKvtIK3F/eXyW1iZta0+PntMsmrwiHzu5NcftqLRVTw7D+VP15UT2FV8U6f9F0+mmvsZJ+u0eX6HxwfnWlp11RuAyr0XTWvLw9C+GvAzvp8RHbu4t58Vv8M8Fvv/AJsetar0eg+G6ZbNh00VlNuv9dx6h/hrs/4ft7aYv1cOOPqrCEN7bXNafTLJRmymAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEWfOJkHUui12s1V/4vk8XWVE70+JSwv1RGmPz9dYnafDXcVj/AJuTDT68tZn7IZF2vj5t3HoiZ+xAjp43TcLZOxaVC7Iq96K2Dl9pxB+HN4jr/PH6G3z3+qsR+KSLx7HrmHzBosSIq8dEXT16GvO2n9xrpxmIZPpxfO8nfzMFAif4VJjlb2aLJI9xd/izbXcbPDH6O3rP7VrT+Cl2/hafSMajNuXdV0SSNGr8r1RntJF6Vt//AGKcdv0+Ws/71or9uq33/wAzVbj0+gStsna8KJ" +
                      "py0oF0/aZze09T/QMPu9jjr5qx9yC8s62l3Au7+AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABC7zt3/C2Fs3Ep25PORPX5K1OdfyvQ55fzJerRh7L2+38uXdU/uUvb+hlXaWPXPafNX75hDbYyqybc9n/d8TYRHeuRzWHHPszLOP+OzeWmzyf3piEhxGs1jz2hpsTVrUTT83Th9RB+GkcsR6mROs9VM/9yZGu+PG2MssFWqySvWY1yxs8Pnc96vc1rWN14qqp6ic8PwQ6z3v3JfHsLYcWHZbXHfNlz3jHhxV04c95idOaZ0iNOMrHuOqY9tj9rWZtM6RHGZ9UO0SQWIsLTjsxoxb60XwORzHtfFLKxUVro1c1U46cFM27j+GPVe3d3tum7+lYtkzbaaWraL48lLZqaXxXjhes+eOMeWIlS4d7TNSb1nwidfPE6T4wuA2xH4W28BH+hSqp/sGnpX2VdMNY9Efche3i5wqX4AAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIBeeC618/SvEo731mydl7fQjIoY2r/aU5Y/zO+p6bHpm2r+dOTLf9mkR/xSzXs+nG8+iIRk2eiR4XfFlP8Ada8Sf6ywnccquiWnH0Tq2WfH3GOn7V/D+pnmKv72kemWmxvM9id6qnD1kP7StZvWNeMzC+y4jeOboVtzZfbUr3uye4X1YsVBD70sr60KOVnIjXKre9dO9DaTt7c9W3+27l6Ds+n7jexu8W1nnwUm04bbea3rOSIiZmlpiY0iJtOk8sTPhjO893TJiyWvFdJnx8uvmamPuSXL1DDxJIyjRyNRsbHxI1irLO2RyMcq6pyq1dWqnaSV2ruMG57V6Hs7WrbNXrcVxU1/eYsMWpbJW9J9qlZy1tNa2iPRGihz61zZbRHD3XGfJM8dPXwXQ4yPwcbj4uzwoIW/1Y0Q9COGNKRHoRLLfH0AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAABWn50raS9TdjUWrqtPDzSyJqnDx7jmfWkZxu/mZ9T17h6dgj9HBlt+1etfwZ92jT9zafTH3MJ7aarNn7olTgk1uhEn7qukXj8xzkpFo7T6haP0s2Cvj5Inmlm21j99X1SU2K+3WYjftvjRU7V1VyEa9GxTfeYq6eNq/evF59mXCbmdhbt/dtTKOZSnkyED8PnJK/iRRWK8v+HLMxrnwtVE1RzeGqcUU3X+Enee6ydJ650vHurdLnPu8d8O+/eVwRnw8PcZs1In3cXjSazbhE+MeScN6rt6+9x3mOfSJ1rw10nyxE+Ls+Gr27GV2o23dblHz5Ko2O6j4p0eyNHO4TQ686et2qp9RKG9w93bnvboGPuHFivuZ3VZruqVpNtxStL2iZzYvZzVrMa1mYi0a8fFR1nbxtcs4ZnTl/N48J9U+C4mNOVjGp2NRET5kO50QjF9n6AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAACqPzYWlt9eLcHOrkxeIx8TW/o+Jzz/3jhP/ADFOpzm+IUYtdfdbXHH7VrSkntemm0189pdFxK+FsSRfspcyyaf6msq8fpNHurZ4p2XaPD3u9j+5jmWXbKv7/wBVfxbjDs58tjmonBZY/wCJDEuzcEX6xgiPCb1++Fyzzpjlh7dWN37LvCruPEZ6TB7BZkJoN4PrNY+1N4k6OSPR6SN5Fbr9tmirwRUU3t+Vb4hdN7I6bu+u7/Budzs911C+3y6ZKzs8Vbae3uMHGb39qZrM10mscsWiZ0thXcG3vuMkY6zEWiuscPan1T5mYunMlW/vTalavVhhczPS13vqxyRQ2Y4GuSKxySfZWRq6qiEvR230LafE7t3D07+Hi98mbJlptclr7aPYy+6vSkzNcNslJi16V8J8ddNVu99ltsc0310iIiOaOPk19frXGpwREOzaPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAp16/Xn5Lr11GmV2vwk" +
                      "tSqz1JXqMZoeeP53erxufiZv5n9CMNP2aa/ilToGPl2dI8+sttB/K2Nt1iImti/flVPSjWsjT8pq13Re1e0dlX9fc57fREcsfeybYf5tvVDfbcai5qkruxrub5OVqu9hafhtWs9exa+Tj9UTKu3WvupYHyO98jtzcd1I9vW81XvVXyNqRq5ad+R8/J8NY5Y3cifnc6qmnBU4m3HyVz0LpPSuo9U6z1LY02/Ucd8UbXcZL+3MZI1tlpWk6Rpze7vXW0Tx0Yj3JOS+StKUtM1nXWI9Hkn70nOlS0cp1G6cfd9axXqOuOkSjaa9s8CtaxFjc5zW+Jy82iSInvJx7dSY/gn2b2/0/wCMvT9v0TdV3ewrTPkpaItFqxyVryXm1a8015tIv+lGkzx1UPU9xlv0205K8tuEf1rYTt4jMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKSeod9cj1V6p5H7Xj5u81nH82N/ht+pp5nPmV6pG77/AOq5Z/8A3V4/" +
                      "YrWsJe6XTl21I/sw7RYb4W2NkQpwSSC3Oq/rS2dEX6GkPd+RanQulUnhE48159dskafZEsg6fHt39cfc3e305MhJLpwgr2H82uuvLA7+ktvwztE9UnJP6GO8/VSf6VXvY0pp6YYury3ks46jNNVrYnIPckUuQgR1bn4royZqI6N7nN05ubRPQbRfKF17qVNttuhdy7THn6DvqZZ2kbjHFMc7ideWuLdRHNjtkvXln2p0nTSOPHEuv46TecmK0xkrpzaTx09NfLpCQPQLJUNy9Rum2SxyLHFar2J5KivWX4eaOVrHx86oiu0VnBTcD4N/D7Y9B+N212e2rfFp0++W+K965LYMl5xc2KcleFuThx8dJ4rD1PeWzdMm06T7ekTHDWI146LUzrowEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAfL3tjY+R66NYiq5fUian5a0RGskKGnXHZDJ7jySrq7I5K9MrvTzWnqn1IeVn4idVnc9Y3u6njbJuM9tfR" +
                      "zzEfZEJn29OWta+aIZeyrUjpbSq6+9Biq7tO3jLJJJ3fKWH4l6Rj6dgmeNNnjn9u1pXjp0cLT/afuKckUOcm108GhZX08XNRvtLD2Lk91j3mTXjTbZPtjRV7vjyx6UetsX7svUPc+Om3bK/CQ4qxI3CsrSWa1a22vzsfbjZGsMkaO/NfzOTm14JodPflA65lwfDv+Fw9M3Ftlnw5K5N3vZnNsaZ4mZry7eNYpt9Z5cmasRpxm08JmI667jid5rN45omNK14W09fn80Jj+V+xWzHUXZORqUUx0UmJfYkoMidDHFNLrzoxj0RWt1bwT2EhfLd0voEfG3df6NOO20xbKs64rTfF7zJaJy+6vaZmcfNXSvHTSNI4KbrV8v+m195rzTby8J0jw1jzrRjrIwMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAcDuq4mO2xuPIK7lSjQuTK70eHXe/2Fl7l3kbfp2bLP6GO8/VWZfXBXmvEeeVEOEe5+LjmXtsK+Rf" +
                      "V4jlf7TyddZ3Vr7O2afG/Pb9q02/FNVI9tnncyKzI0YW6N+Gx+PjVOHDSq1y/xF7+NFeXrNKRP+XtsFfqpr+K5dL/AMr1zLZ115MHuebinLUaz/3krWmO9vaU6P1DJH/cxH7VtH33EzzV9bG7IINtSYrflGOviaVNy8mbaqryXGsaszJ3TK5WrI5FTl4IqImiG7/Wu6+6qY+1u5e27ZrbLDs8O0nHji9613GK9q5sOXHETERnraNLWj24mLa+zEsLx4MM2zYsunNNptrPDhMcJifR9iYvlulqZbqu7K0oPhqs+LjsQ1k0VIviEfIrU07tXcPUbp/LR2lsel/Gnr2DaRFcWLFh0rHhjnJa97U/3bTMaeTw8jH+ubi1+nYpt4zM/Tpw1WJHTRhYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAxZ1wyDcV0g6j3nLypDiLqKvZ/iQrH/eIo+O3V67DsvqG4mdIpt8s/3JV/S6c25pHphS/hYVTHY2H7LnNjYvDXirU" +
                      "aeXbqPNOwx4/LNax9NtITBjj29WcN28rtzZWNq6eEsULPV4cDI/YXP4035+691WP0ZrSI/wBnHWPvXTpkaYK/l5XHyKse19yu11WRasS/PIqr+QxXYZPddq7+0Txm2Kv97WfsVO4jXLX6Ufc9uuDqXhMhisf04yud3Dt6wytntsIkVOLMUsX7jLUaQuejnxLGiOa5Uc9q8yJoinYfsTsnuH/S9rm23Wtr0frePbVndY9veNxO422PHHJnvtsca13NKaUtNYmbRETrGmiL9zucXvLROO2THrwmfZ0mZ8NZ8kysO8p8bp98ZW4+slN0WIqNWsmipG5yc6t1Th7qu0Ln/L6wYc3dvW9ziyzuKaYaxlmJrOX8+/vJraZtWbTfXS06+c7umYwYomNPHh5vDgsHOrrAwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABHTzY3vgegW/9H8i3YIK6evxrMbdPnNW/nT6nG1+GHU7eHNi5f2piF67dprvKetVbgYPHv4Srpqs1iuxE/ama08" +
                      "7G423vN/gwxH52bFH13rCU6TwmfRLKOflZNuLOyfpWrGnrRsit9hZPiZua5u497fTjObJ9lpr+C+bGNMVfVDb5FVZtC7ypzOs3YGMb6dI3OT8p88e0vm7SvjpPtZtzjrGvCPDhrPk4zx1fme+mbXzRLqGxXZCbI2bc+OnxNvCSthtyO4LWtKiStYj2ro53KqK7TgmqIvabQV+Wfvb4SdyT1G1Znb7bJSlN3SNK+95K3mIrM800mbzim0xy3msx5YY1Xq+23+Ll8to15fR/T5U4/K1C6Td++7j9PE5IWvVERqauYx66InBOKnQ3+XVltu951ze3isXy7mkzyxy11nFS06R5I1meHkYn3jHLGKvmr+KcB09YQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIh+dm4kHRb4Pm0dk8vjIuXvc1syyqn9k0b/mH7vk+GmXFrp73Nhr6495EzH1QyTtWv8A1evmiVe+yIPG3XteJU1T42uun7L0ev5Dhh2zhjP3Nsa+fcVn6uP4JI10x29T" +
                      "s9mTxr12dftyTTO19PNIq9xEvce7jJ1DPlt4WyXn67SyPb19iIjzPjcOn+U6FdJW11u3n6zv+y1GxtZzO07m68TL9t0zabnoWy2+fJ7rb5t5EZL/AKlOFbWn/ZiZnj5lJuslovaYjWYrwdf2Pt3cW2srax2dyVjJ27SzT5LJSRMigvvdKxzJYkhXk05Wt5kTjq3iqrqdOvmQzZelUv0fHvt/bBW2OkYd3SMtM2LDxxZ9tu68LY9Z57UtNr6zETMcujBOifvLe8mtdeM614aTPjFq+fyJ6eVGBVu9QrSpwWxCxi+psTU9hPX8tfZzXo/VM0/p7vh/u4sdfviVq71trlpHmr+MpmHSphYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgl57rj27S6d4xq8L2adJI31V6cj0+tUObP8zLqF6drbHBX/mbusz6qUtb74hl3aNf3tp/s/iht05ai7wwz9NUrePMqejwq0j/Ycgvh3TXuna2jwpOS/wCzjvP3s8v/AJc/R97k26PRV7UdqvL85" +
                      "BG7mbxNo8s/fLKMcPvcrJZdu4DEx/DuZm5po7EFtqrXkR0rWMSR0SskY1HL9pj2qnbrwNuPl/8AiZn7b6j0raWvijZ9Syzh3Vc2OuTHfDbLWJ5otHDl1mYmJjTxnWIY31zZxlx3tx5qRrXSdJ10cLsbF2cTls9iW2H+Htq5NjcxjJLMlh8FhXPnqSKsmnGSu3iqpqqpr2KbZ/H3oGPZdGmNph3ew2uHqOXbxtMt5ybb2cd703G1m8c1a2pw5KT7uvNOkcIljvRsk2y+1NbWmkTzRGk+McJ/LVYF5T4UTE7zsacZMg5uvqa5yG0n8tra8vZO4yfr7zP9l5j8Fi70t/1UR/ZhLg6FsQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAFcfnpvrJuLpThtdWtjydx7O73UjgRf7RyN/mk9enH/pW1ieM2zX+qta/wDEzns/FrW9vUjT05RVz1uwvBKmOyEnN6F8BY0/iOZXw/tp1u94/wCXtc9vp5OWP8TMpjWvrmPvb+NNGaa9miKhBGela4Jj" +
                      "WYmPN/SyjHrq2W/8TTzuF2/t3IZWfCUMtUsQ3cvW4Wa0dlzmLLGui6OanFF04dpsP8O69B/+V9u061Xn2ETFssTEzE1m2ut4jxpExE38nJFteGqx9T977nL7v87yfl9zadN8Ps7EJNT2rDAlzGNpUt034bclpb9mLHQvjsSLI97vEbE5sblXRVXu7TpB87mXFva9J30bmuS18U193iyRfBNOStozY6RM8ka/u4nxtWY18GG9sRyzkpp4T4zGk+qfP51i/lSg5dk5y0qe9aylpeb0okiohsb/AC7NrNPhvS8xp7zcbi3/AOW2n2LF3hP/AFs+iI+5KQ3qYuAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKs/OnkksdY9q43XX7rwTnqnoW1bX/5RxP8A5m3UaZ+69ltpn/K217ftZIj/AIUhdpV029p88/gw50/RUduudU0bBi5Wovaus1iJhz87N0rl6hm/U2do/bvSPwZdSZnlj+03rERGqqLwXvTuIO3lqxSZ8k/l62S4ofm8Jpas+ESG" +
                      "TwZK9CPw5NGu08RHIvB6KnYvehIHcnfXV+1uudO3vTck4N1tdvS1LxETyzaLRPC0TE6xOkxMTE6+C2222PPjtW8a1tMuS2hDjkow2KlNtTIyOkZmEjarIJVjcngyNbp9tWuVHqirronZ2G13V/ij0zvLpe06pXb4dv1aZy13nucU4qZJi0e5vp+bN5rNuaaeXx8kLBttlfb5LUmZmnDl1nWY8/4LA/K5FydMYZv95tWH6/K465fITt+T4V9Pt+vFr/tXmUe91zrv7+hI43EY6AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKgfNXeZf8wu4Gpo77rxmMrKvodyyzr/8RDgl/MF31M/xJyxHH3e1w0+ub2/FJfbVZjZx65l1TYvuYXek3esVKFE7/fsudp8/IaZ9t7iKdM6tePHkwU/ayWn/AIWT4a63p9P3NdF/l/Z46Lx7uzsIU3kc2OK6cdOP/YyPHw4updasri8PXyFrKTOh+76EK4nlfKxX5KKJJ6ca+A171a+drGvRrVXlVeCpqbs/AH" +
                      "f7bB8YdrjzbO+9r/DTi5aY4y2xzbDMRmjHPs293M8YnSNJmfHSJxPrkWnYzMW5eOvGdNePhr6XetlRxVcFRi8C1UyEEKJuCvd18dL3LzyKuqNRqLzaNaicERPSZZ8Xe2+yOjb6uHtmmbDirjmM+LNF4yYs1LTWOaMntVtkpEZLVj2Y1rMfnPj0vNuMlZnNpM68JjwmJ9Xm8Fjflrh8LpJt1ypxn8R/9Zx18+Srae4+FfSa+fb1n6+KN+5La7/J62ejaNZAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABSh1yt/H9fOqtrn5mtvxQRORe6vRhi0+lFPOZ84vULbj4l9Vya6xW+OkeiK4qa/bMpW6JXTaUj0fi3u0mJHs3cM2nGxdpRovp8OKST2munS6Rj7W399OOTc4a/s1m34shw8c1fRWWrGnMsTFTRHLyt4+lfWQ3kvXJmx0mIjW0R9csgpGkS2266uHv7m3BXz2HXNYn4Z8U0bGRTSwSSV0gjkijm0R70c7RG+vVOKG+fyw5eqT8UeqY9thzZMOXZ" +
                      "ZcGa+DjmwY70xx77FWJ5r2peKzy09rlm0xEzGk4X3BFP4SmsxExaJjXwmY14S1tlZ67uDbzczkorFXIureFcp2meHPG6qj67Fe1eKOWNjFfxX3tURV01L18xfc3Tt51P/ps+Tc5Nts8WHLmyY74rZsuOt9cnJkiL8azWs2mPamvjOj+OhYb1x+1ERE2mYiJ10idOHBaL0LrJV6WbSjRNOaujvpVTtb8uewjbdh9Nxx5Ntj/wwjHrF+bdXn+1LLZNC2gAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACiDeNtMl1L6mZHxPEZYz+WWN3pay4+JNP6h5jfjt1Sd53n1XL4xbeZY19FLcv8Awpe2NIrhpH9mGQ9vRSpsFXRsWRbeVlVURPzYqzGa/S4jLFttxPZd5pWbe83t54fq1x1rr9cr1tpj3/H9X8WtTjk+MpwvarVkkZ9pqp2vT0kY9N2Oaep4MeSsxM3p4xp+lHn++F7m8e7nTzS6/uh1Cxnc78dBNI10vLBNDIsb4Va9EV6aaaqiJwJp+HPffaXSe+d" +
                      "9l67Xd0reZrjz7TLOPNt7axHvIjWIvGnjWfoiZWHqW1z5NvWMfLw8YtGsT6HJYW7YlxGaZahSeOKqrKN9Gp4zXRI9Od7ux3jMajn+hXenXXfv5tPiJ0LqXQc2LLuNv1SLbHHG13WOsRuseWlInJG6mNK8uWtuaIjhFuaukaccX7e2uWmWJiJp7U81Z/NmPJy+pbD0ng+H6c7Pi000pQr9LdTrT8KNp/D9sbLH+rgxx/chHm+trntPplkMkBSgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGjZekdeeRV0SNjnKvyNVT5Zr8tJnzQ/Y8Xn7x9l15+TyUnvPyNq1YevpWaw+VV/tHlU7n6p/F77PnnxyZst/wBrJafxTPTHyxEeiGfMLXkk2Ht9jWI7xrN2RVVqO1V8zYWomrm8VVuiFRh2V8/Ze0isRMWy5rcYieNskUrEa2rxtMaRprr4K/DPLmt6obui3mzG34XMcxsatVfca1Hc0nNw4uVU4aLqvaWDoPTZy9c2GO1ZiKRr+bERM2trw42nThpOs8LRpGnF" +
                      "WZcumO0oIs87/luynX/qJ5fMn1Cq7X6tbQyjqs+1st/w91102kkTqcs6pHOj0dwRjubhxahmnc3ytd0YdvfrU4ve7XPa94vT2uSOadYvEca6aceEx6dWW77srquDp+Ldxjm+HJSLRNeMxGsx7UeMcYnj4elO+rDB/lRrq6t8OWB3vN0VNXu9Xylzp2/XB29SlI0rasRw0/St6PWj7Fn5skrV9jQpX2dtmFE08OlXTT/VoemTtjb+56bgp+rjpH92EKZra3mfS7WXx8wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADqHUDJfc+w96ZbXRcbishOi+uKpI/wBhi/e/U/4Lou53H/d4slv2azP4KjaY+bLWPPMKG8CxWYfHoq8fDYq+nXlQ8qWO2m15p/Vj7kyz+ckdW5q+0toQV+ZbXwyzshTm5V8W3I/Vyo1eKKiaekzTqM32/bPTsWHWc3uueIjXlnmy2trMxW2kxOk1jyzr46cKrbxrltM+Gv4NfFavzNOZbST/AA8blkYrvejkax8jmomicNeOvpUfDzH77uH" +
                      "Bk977zkrxiZ40tpa1qxGkezrOvNPGZmfQ/rfzphnho80u0fJDD1j/ABCsb5jeqGDx/U7o51Mu71yG8tpZOpZZWr0aL8rtmjF4jXIk8nxFeKRnh6OauiovMh34+XbsvP8A/FenbjWs4LV1tWddePGfXEzPHSWxPxE+YnYdD6Fk7dx48mPqGPZ7eMWasxpFrTjyTGn6MxHNxnXm1cd0q8wnXvof5/aHlk2Zu7NV+h2Z3tDhMN0x3CtvMJDg53sV0tG5k0SysPM1/gu53I1mnahBHx5+EHbuXNueTB7m1bxNfd+zr7VdNa+ExPlnTWfOmPF8Ku3+t/BSO6M01v1THgm170msa35pr+8rXhE6aeSNZe9XCRJBhsVCiaJHXhRE+SNDotsacuCseasfc5M1nWNXKFU/QAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADCnmPya4joT1Vutdyv+5rcLF/WtM+GT65CD/mX6vOx+H3VM0eMbXLEeu1JrH2yufRsfNu6R6YUxUGJFRrt00RjU0+ZDzH9Vye62V+T9Gv3JdwzE3jV" +
                      "I2ee3Qo7RhhbG5lbHVJFje5E/mrE5de1F7Hki91dT3uwwdNpjikxj22K2lp09vknSY4xPCLT6NVRs8dbc2vlmW3xHjLbs3JokTwKk7I2s5dOWGBUREXXiui9qlt+FWXNHWv4nPWKxTFNYmNNOWlfRMzMxE6zM8Z+h9OpUicM1j8tXmb8hPUXrL0r/EK330/6xbxyPSXpvv1d1W8LsnctyLHYm5dtXHTY74dMo9IFke+RHokTuZ2i6anfb5e+59nm2+1rs91S+15Ii3LeJpNuTh5dPHy8PM3O+ZLtvt7r/wAN6dR6bhpu9/t8e3rzY45suOtYiMnPFfaiI8J5o0jWEjp/PfS81Xmp8rXQy50jh2Hv3pZ1fvQS7zrvhuQZPCYmS7VbG2STSzDLwYj2I58aproqIiIXD4yd1Y+q9PtsrY9L0z44i0eWPeVjzax6tZifQjq3yvdT7J7Dv3LG7jJtOobKtbYpia2rkyxFo4azS0RET7XC0Tw01e1Gqzw6tZn6EbE+hqG01a6Ro58V8G4P1/QAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAABF3zkZBlLy/bwgcujstNi6kfyy5OBy/U1TUr55ep123wv38TOnvIx0/by0hfe26a7yvo1n7FTkOvw0adyouq/Meczua8Y9jeY8safWlLbxrfikTuBlhl6pXZWklZXqVImPZI5qK6Oq3VEROHDvUzv4xV3VOq0w48OS9a4sVYmt5rxrjjWIjw9mOM2+iZ4Qr+l8vu9ZmPGfH1tHGzc8m4ryw+C9lKdHR8dGryI3TjovrUwjsvq1s256jvLY/d3rt76148J5YjTjpOvDWdYjjMq7dY9K0rrrxR0390l6a9W8FJtfqLs/H7tw9r3X0btaObRXcFcxzk5mu072qi+sfCD4m7zomTH/DZZx31jhE+Prjy/TD+9l1DfdN3cbrZZb4c1fC1Jms/XHj6p4I49Ifwtuk/RLzXdGOuvSvP3cRhdsZOZt3p/aVbcDnX60lZrq8r15o+RzkVUVF1RO3U6tdofHTddS6ls+n5689s+4w1i3hMaW5p18/CJ9OqXPiH80/c3cfZN+g9TjHlpWa2rlisVv7PktFdK218+kaPUyz7DPkT8h2LlonD6Px+gAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEKvPbeZB0gwtDm0lym4KDWN9LYYLFhfo5ENDP5jPUIxfDv3Xly7nDH1TN5/wALJu1K67qZ81ZVr04kkfSgTisrmNT95yIcC+5dpbPh91+tasfXaISXtpitkjdwzvXO5GNthWMjk8Lw1fGsbWIjOZOVrXPRFVvH0knfFPqV/wD5BnrGWYituXSbUmsV9nWOWK2yRW01jm1j2vJGir6fSPdRw/L7nEV5Xy43d1tz/EfJA7nfrqiukkRO3RCK+2d9fcdP6tu725rXpMTOuvG1tPNHk8OEeqFx3NeWaVjyImX2Tbe60z5n4iWenksFjYcZh4a8ll881h7LE1x0kau5WRSQOrI1zWoiqq6qqnWftX4AT3L8AekbHtraYMmTcXncbncTaItS+G02tTWK2ta95j3dY4RHLyzMRojfL1T3XU72zWmIjhEeifL+KeO2a0028em8cjV+Hy1qlexkmquSWvIxz2uRXI1dPlRFTs7tVxrffCrD2x8Zei7Hb3vk2ue1Nxim8aXivJfWt40idaW88ROkxrGsSqv4+c/TMtpjS1eE6eH0LSE4Ii" +
                      "eg7VowfoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACvXz/W9MR0oxvP8A+IyWQseH6fh6bY9fm8Y5j/zOd/NehdNwa/n7m0/s4rR/xMx7Pr7d59Efeg/tuJbGfwFZE5vGtVW8qeuZupxmnHOTqm0x6cL7jHH9+GfYp4W9TOeajdNuJzI2pK67OrnJzMa5rZJVbrxbrpp36mRfEbbXzd0Vx44i85smsxrWJiLXmNdJrrpER466/QuWytEYNZ8kfg4+SVrdtbknjZysd4UTE4arrLqqqqdq+swPab3H/wDG+pZcdeWk2x448NZ9vjMzHCZ4+PCZ+hWZqz7ykT5plHLLW8Nd6j7UwlbMMw+S29HTyGUkyU00HK64msa04oVVk8b1e7/E91ujubRdDrv8p/y0dydK7a2nVendw5Nh0nd7XBnmulL1jdWtMWpMW9mtInliYjS19eW08EY9c6pivmtS2KLXiZj6POm7sWPMW+rGyY8/d+8Ms28vjTo1rWJFFC7kaxrVVEa1OGnHjrqpaul5e6t18wOyw9xXpk3u3m8ROOs0xzijHa1LUr" +
                      "M2mItz6zrMzzax5IVGSMFej2nDExWfP4668dVm52JRwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKv8Az7X3y756Y4nm/l1MdkLPL+tPZii1/wBkchv5nXV5nqPS9r5Irmv9c0r/AEs77Pp+7vPphGrp/Csu8tuR9ulmNyr6mIr/AGHMDtSkZu6dhj/8Xm/ZiZ/BmMzpitPoZPdPTsWbP8lJZVkV3JG+NZNGeI6RUc5UVFXgvq0LH1XqfTt3vcmtIvl59dKWpN9K+8nJMWma2ra3szw/NisxGq94aXrWOOkfZ5NGytSNg2Tcc5eMtqFqu1XijWq4w3ZXinYWTz5M9I9ekTKp3H/qPVCMmEyMG8d+5vEZvGy4+DZ9i5ib1evLVtXXwSLzqrkexFgRkjXOYjHrxVV1X7J3A+C3wT6/2B8NbbTufHTqnQdzSubNtscWnNtNZi/NSJn97TWIvkivJalo56Rbiinf9Qxbnec2GeTLE6RM+FvX5vR9SwPo9D949XtoXUgdWZIliWOo6RZPBayBrEYirrwTXRP9Jinw3+IW174+YDB1XbUm" +
                      "m3ptclMcW05uSlaxzWiNdJtNp8s6RpHjqqt9tLbbpE47TrM2jX6VlZ1xR2AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKjPOvk/juu2Ooa6phMFTj5fQ6e1PYVfochxF/mR9XjN3xtsEf8AK2v+O9p/BI3adNNtM+e34MV9MWa7yx8un/hY7UuvrZWcqflNCPh/hme7dvf/ALqmW/1Y7fjLJpmPczHnmPvd9kWtH4j2zSQKiO0dy83Dwkcirq1ddX6tVOzRTDOtZNnim+SMl8c1i2k8vNw5ImJnWkxMzk1pNdYjktza8F/wxadI0if+3+ji2Ofev+T6r3K2N1m296qjUa1OSLTsTRNNTHeu7i2Tsvb3tpFsu4tOkRFY9mmnCI4RHHyR6X93jTPaPNCNO0c3t291UzFzaOUlv4y7bsWszha8LVbVu2rLrFlktidF8RqSrrEjUTlRy6OPQH0X5kugdJ7Xxd3dW2m723U821wba+G+PJ7vLyWnltWdJxxFue0xa01mYmK2jVEF+lZcmb+HpNZpFpnWNNY/FZB0Mq1k6vYqOjK6xQqVbb" +
                      "6U8iIkjonIxGq9E7HcdF04a9nAgH5Wdr0fL8bd3k6Tp/AVw5rYtNdIpe2OYiNeMaTrGnk008i8dwWyR0ukZPz9Y1+jVYcdgUcAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAClvzS325HzH7404sx0OLqtX1sose5PpcpwB+fXqkbj4nbmI4+6w4a/3ZtP3pQ7dpy7KvpmXCdL9G5vK2HKjfhcZcdzr2JzMRmq/SakfDrcWjrme9p093tM1tZ8I1iK6z6OLIclY5I08sw7dHVc34yKmxj3pG5niaNVkqO0aqMRrl0d3p2kY5+kXr/EU2dazaMdq82kct4nSJjHWtp0t5a682mnGYZDjv8Amzbz/V63znFjr4na7LUCyQRTyTXK+iczmMkYjm6L3qiKmhWbvqePpfTOkTuKTalMt8l6zHGYpemtZidPGImOOnpfHNjnJbJp46R9zBO0sBDD1kjwWfo5Csudu3JYMxFFHWxDMZOiztyVO4r0ibDC3R0sD3ao5qojNFQ9PuTrncfc/Udpu+nfwvUe0t/giuTHMRGTFrX86PGLxM+zNJ0tWf" +
                      "JwQZGPFgrat9aZ6z4+SVgvlpjfa6jPlc7xW0sbLyzoiIj0fOiI5ETXRHI3VENEfkz7WxdN+LXWdri44tpS+OnHX2ff2isa+WYrWImfPE+XVlXdGeb9PxWnxtpP2LBDrQjwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAUUdY765Xrz1XuIqPazNWK8bu5W1WpAn8J5ufm36tO6+I3Vcmv5uWKfRSlY+9LXRqabSkehznTlmlHetpE1WLGrHr65pWt0Nfu19P4XrGafGm0mv7dohfK1nnpHpb1Gt5W6NRNV4L8nA1U3+OkV4RpMz4/l+Uswxub3LolHb8Dk4pWcv8AXkX+gln4o64+ldMxT41wTP7Vv6lu2sa3vPpcDh9s4ncXxVDNQOu46JGypj3SSJXfIruKvjaqNdqidjkVCUPll796/sLZ8Wz3u42+OKx7OPLeleM8dYrMRrw4T4+aVq6xscNtJtWJn0xqmb5aa7G7+3E5jeVlbGwNano55nr7Dqt/Li2/N3N1XJx4YcEazx4zfJM8fHXyzr4+LBO950w449M/gnIdc0dAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADz65e/96743zlkXVuQzGUmavbqjrLzy4/GPqkb7unqWfyZN1l+y+n4Jn2NOTFSPNWPuZW2GxY9qb1n1XSVcfCn706uX6kI12HNi7Y6zmr+nO3xx9N+P2LthjXPjjzay3PFz0VdNNeKIv8AQaxdSvNr620018n5ebyssxOZ3UqskxsXb4NOHl9OrtVXUlf41c1NztMM+FNrj+3mlbdh+bafPaW42fEquvvVeGkaJx466qpl/wAvm2nTc5J/N0rH06zKk6rPGsJfeWSvzbl3tbVNeSKnHzaftu9p2f8A5a+25s/V839vDX6q2n8Uad9W/wAuPRKZh1QR8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAcVn" +
                      "bqY3CZnIudytx9WxO53oSKF0mv1FD1Tdxg218s/o1mfqjV/eOutoh56MDIs8M9r7S2XyyKvp8SZzvr1PKL1jqEbnLbLE/5mW9vXreZ/FNlKzX6kgdoo2Lp/ln66LbylVi/JFC6Qs/8V7vsPdz5cm9x1+itZsuG1rruq+isvuNq+LG3VNeZNETuNcMlefcUrE8eaI9Xh9DKK8Icru1/Ll/Dd7zYI4GIieqJF9pJ/wAcsv8A/Ipxzx93jxV+qkT+K39O/wAnXzzP3uW2lFysuScycznJqzvTtJL+Bmz5Npnya8bWjh5Y8fFRdSt7UQmN5XYtX76s6fbsQNRf2YUX2naP+Whs9OkdVzfr7qsfs4qR+KL++7/vsceav4pbnTJgoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABi7rdk/ufpB1KyPP4awYXII1" +
                      "/oWSu6JPrcRx8YOrRse1N9n105Nvln+5Kt6dTm3FY9MKKtvQeFjaiK1dFjj09OvKiqeWDPuojBSI8ldfrhM2OOMpDYeLwenWLXijreTsSI71RV2s/vFv7ntGL4e4LRwnLvMlv2cfL+K6dNrrup9FWnW1dYh1X3nPan0uIE6Vktm6hi1nxvX/EyO0aUn1N7up6JuG7w10cxET1JG1PYSN8bcmndu5nzWr9lKrb03/Ir+Xldh2uxq17j05v5jkRy8NE4dyoTD8FcOL/Tst6TM81uPmjh4RKh6jrzxEpneVuHTCbssf8AeZFzU4dzImIduv5bGCY7N3eSf095k/u1pH4Ip75n/qqx5qwlQdEGFgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEbvNzfZR8vfUVrncrshXgqxet09qJun0amsvzkdVrs/hl1O0zpzYZr+1MR+K9dvU5t5T1qi8RRkfXhiYzgxNFXj3cO88xXcG7tWk1xxMzMf1Ji21NZZ4xD6L9vY3D3rtej93vlfGkjpedzplRVVUYioicOGplOy/gOodu4On73Nhw+5ve0Re1+" +
                      "aZvPGZ5Y4Rw0jVW45tjyTasTOvqb2tQwjLVZ7s9T5GPaqqiz9yov6JQdF7F7b22/wAWW2/2+lb1nhOSfCYn9VVZd7mtWYis/Y5PP7Ulu25cvRstnhtaOjcio6N3dwc31Gd/FL4H5+qb2/U9jlrkpm9qJiYms8IjhauvDSPNKi2HU60rFLxpMNPBNWhFZrXeWtPz6oiqicycqcU7ik+GGC3Stpk2295cWXnmdJmI5o0jjHk+r6eL6b2ee0WrxjRNryuRp/kXK2kXm+LydpzXelEdy+w7k/y2MdZ+GkZonWMu63Nonzx7yYj7kSd8T/1+nmrH3JLm/jEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACJPnR/m9HI6KuVrb+ZxkbtO9EldJp86tNDv5kO7yY/hbnpTxyZcNfrvE/gyjtGsfxkT5olXfV8KnEjGokj2JommmjfkQ89+4m+OPbnnyR9UeqEs49PJ4PxEfbsNhgjdJYn+xE33nOVE1XRE7ewwnfdHvvNxGPFSbZb+ERxtOnHhHl4KumbljjPBtmyqr0Y3i9XcqR9io7s0MMy7LW/LW" +
                      "J1mdNPL9Sqrldrjs5/bMjfefXil9DkkryfOmrV7PlM+x5O5+0M/sWtirafJMWx3++k6xH+1EeZ/PNiz148fvdxx+Ru56J6T46N0at0bYcnK1y/q6oq/QTd2517q/c22tG522OaTGkWtGlZn0RMTP1TMa+VQ5K4sM+zaU9fLdVbT6dsrInK+K3ZSVunY5X8/z8Hdp3m/l99Ir074Z7faRwnFkyxPrm82+nx4T5URd5Zeff2t54j7mfzdhiwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABFDzo461c6G5O9VjV67fyOMv2FT82GKwjHrw7kR5ph8//Qs2++F2891GtsU48n0UvEzP1ask7UyxXexr5YmFaVeVJWMfG5HIqasVPQvrQ86+/wBlW1ovXSfN9P8ASlXDk8j7pWZaVpVge74xy80dyNyo+JvZp+qnrQtOyzV2l5rim0bmeMZK+NI839mPPMePqff87x8HL2L1zKSsndEk1n7D7ccSNklVdE95zE0VfX2lD1TqfUerWi8Y+fLrp7ymPS1tdI9q9eEz5NdInzy+1K1p5dI82rIWL289iQ/" +
                      "Eok9Nqc0Fdzl0bJpxc5vFHL6+xPQbH9pfCzJiikbisX29farW0zwvpxtavGLW4+PCK+ERrxWzNvYn82eP4M89Pem2a3taa2qz4DDwKiXcy9vuN07Wxpw5n+rsTvN4Pgn8v/Uu7c8e7j3W0pOl8sxw4fo0j9K3q4R5Z8k431TrFNtXjxtPk/pTp23tzGbVxFbDYmJY6tfVXPcvM+R7vtPcveqnXzsTsbp/bnTKbHZV5cVPPxmZnxtM+WZ/qjgjnd7u+fJN7eMueMwUwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABtL9CjlaVrG5KpHfx96N0VynKxskUsb00c1zXaoqKhS73ZYdzhtiy1i9LRMTExrExPjExPjD+q3ms6xwlCPqB5LsNZlnyXS7NLteZ6q5dt2uefHqq6rpE7Xni9ScUOaXxq/lsdD6re267fy/wOaePu5ibYZn0R+dT6J09DL+n93ZKcMsc0efy/1o4X+iG9NnePFuXa1x8Su5pspUatmB6IunB9ZHO5f2kQ0a6v8mncPb2K2HqGyyZaTOs5cUzaJ4+GtPa5fRavBk2Lr+HLxr" +
                      "aI9Eu0bb2hns4+Ktt3aV66yP3WK2rJXrs0/SksoxvyrxM97K+DPcXUJrh2GyyRSvCI5Jx0rHpm/LE+meMvluOpYacb2jX65SV2X5fcvJPBb3nZhp0maOfiKrlklk7+V8ujUanpRqfObo/Dj5MNxbNXN1rJXkjxx45mZn0Wvw0j0Vj6WO7zuWNNMUfTKV1GjTxlSChj6zKlOq1GwV40RrWtT0Ihv/0vpW22O3rg29Ix4qRpFaxpER6IYlkyWtOszrMt2V7+AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAfioipoqaovagBERqaNRGp6E4H5EaD9P0AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                      "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP/9k="),
                      ProductTypeId = 1,
                      StateMachine = "Active"
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
                      StateMachine = "Active"
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
                       StateMachine = "Active"
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
                      StateMachine = "Active"
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
                     StateMachine = "Active"
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
                     StateMachine = "Active"
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
                     StateMachine = "Active"
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
                     StateMachine = "Active"
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
                     StateMachine = "Active"
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
                     StateMachine = "Active"
                 }
                 ) ;

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

            modelBuilder.Entity<Transactions>().HasData(
                new Transactions
                {
                    TranskcijaId = 1,
                    OrderHeaderId = 1, 
                    Amount = 10,
                    TransactionStatus = "Success",
                    TransId = "PAYID-MXPGHDI82U242769W004564J"
                },
                new Transactions
                {
                    TranskcijaId = 2,
                    OrderHeaderId = 2, 
                    Amount = 20,
                    TransactionStatus = "Success",
                    TransId = "PAYID-MXPGFSA64135549VN997594K"
                }

            );
           
        }
    
}
}
