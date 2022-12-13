using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Core.Models.TaxiRoutes;
using TaxiBookingApp.Core.Services;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxBookingApp.UnitTests
{
    public class TaxiServiceTests
    {
        private IRepository repo;
        private ILogger<TaxiRouteService> logger;
        private IGuard guard;
        private ITaxiRouteService taxiRouteService;
        private ApplicationDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            guard = new Guard();
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TaxiDatabase")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestTaxiRouteEdit()
        {
            var loggerMock = new Mock<ILogger<TaxiRouteService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            taxiRouteService = new TaxiRouteService(repo, guard, logger);

            await repo.AddAsync(new TaxiRoute()
            {
                TaxiRouteId = 1,
                PickUpAddress = "",
                DeliveryAddress ="",
                ImageUrlRouteGoogleMaps = "",
                Title = "",
                Description = ""
            });

            await repo.SaveChangesAsync();

            await TaxiRouteService.Edit( 1, new TaxiRouteModel()
            {
                TaxiRouteId = 1,
                PickUpAddress = "",
                DeliveryAddress = "",
                ImageUrlRouteGoogleMaps = "",
                Title = "",
                Description = "This taxiRoute is edited",
            });

            var TaxiDatabase = await repo.GetByIdAsync<TaxiRoute>(1);

            Assert.That(TaxiDatabase.Description, Is.EqualTo("This taxiRoute is edited"));
        }

        [Test]
        public async Task TestLast3HousesInMemory()
        {
            var loggerMock = new Mock<ILogger<TaxiRouteService>>();
            logger = loggerMock.Object;
            var repo = new Repository(applicationDbContext);
            taxiRouteService = new TaxiRouteService(repo, guard, logger);

            await repo.AddRangeAsync(new List<TaxiRoute>()
            {
                new TaxiRoute() { TaxiRouteId = 1, PickUpAddress = "", DeliveryAddress = "", ImageUrlRouteGoogleMaps = "", Title = "", Description = "" },
                new TaxiRoute() { TaxiRouteId = 3, PickUpAddress = "", DeliveryAddress = "", ImageUrlRouteGoogleMaps = "", Title = "", Description = "" }
                new TaxiRoute() { TaxiRouteId = 5, PickUpAddress = "", DeliveryAddress = "", ImageUrlRouteGoogleMaps = "", Title = "", Description = "" },
                new TaxiRoute() { TaxiRouteId = 2, PickUpAddress = "", DeliveryAddress = "", ImageUrlRouteGoogleMaps = "", Title = "", Description = "" },
            });

            await repo.SaveChangesAsync();
            var taxiRouteCollection = await taxiRouteService.LastThreeTaxiRoutes();

            Assert.That(3, Is.EqualTo(taxiRouteCollection.Count()));
            Assert.That(taxiRouteCollection.Any(h => h.TaxiRouteId == 1), Is.False);
        }

        [Test]
        public async Task TestLast3HousesNumberAndOrder()
        {
            var loggerMock = new Mock<ILogger<TaxiRouteService>>();
            logger = loggerMock.Object;
            var repoMock = new Mock<IRepository>();
            IQueryable<TaxiRoute> taxiRoutes = new List<TaxiRoute>()
            {
                new TaxiRoute() { TaxiRouteId = 1 },
                new TaxiRoute() { TaxiRouteId = 3 },
                new TaxiRoute() { TaxiRouteId = 5 },
                new TaxiRoute() { TaxiRouteId = 2 }
            }.AsQueryable();
            repoMock.Setup(r => r.AllReadonly<TaxiRoute>())
                .Returns(taxiRoutes);
            repo = repoMock.Object;
            TaxiRouteCollection = new TaxiRouteService(repo, guard, logger);

            var taxiRouteCollection = await TaxiRouteService.LastThreeTaxiRoutes();

            Assert.That(3, Is.EqualTo(taxiRouteCollection.Count()));
            Assert.That(TaxiRouteCollection.Any(h => h.Id == 1), Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}