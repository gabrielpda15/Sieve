using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sieve.API.Extensions;
using Sieve.API.Models.Base;
using Sieve.API.Models.Location;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Location;
using Sieve.API.Security.Authentication;

namespace Sieve.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private IRepository<Country> CountryRepository { get; }
        private IRepository<Region> RegionRepository { get; }
        private IRepository<City> CityRepository { get; }
        private IUserContext UserContext { get; }
        private IUnitOfWork UnitOfWork { get; }

        public LocationController(IUnitOfWork unitOfWork, IUserContext userContext) : base()
        {
            CountryRepository = unitOfWork.GetRepository<IRepository<Country>, Country>();
            RegionRepository = unitOfWork.GetRepository<IRepository<Region>, Region>();
            CityRepository = unitOfWork.GetRepository<IRepository<City>, City>();

            UserContext = userContext;

            UnitOfWork = unitOfWork;
        }

        public class SetValuesObject
        {
            public class RepoObj
            {
                public bool? Added { get; set; } = null;
                public bool? Cleaned { get; set; } = null;
                public int? Count { get; set; } = null;
            }

            public class Status
            {
                public IList<object> Commited { get; set; } = null;
                public Exception Error { get; set; } = null;
            }

            public RepoObj Country { get; set; } = null;
            public RepoObj Region { get; set; } = null;
            public RepoObj City { get; set; } = null;
            public Status UnitOfWork { get; set; } = null;
        }

        [HttpPost("InitialCreate")]
        public async Task<IActionResult> InitialCreate(CancellationToken ct)
        {
            IList<Country> countries = null;
            IList<Region> regions = null;
            IList<City> cities = null;

            try
            {
                countries = JsonConvert.DeserializeObject<IList<Country>>(Properties.Resources.Countries);
                regions = JsonConvert.DeserializeObject<IList<Region>>(Properties.Resources.Regions);
                cities = JsonConvert.DeserializeObject<IList<City>>(Properties.Resources.Cities);
                var test = cities.Where(x => x.Id == 1);
            }
            catch (Exception ex) { return StatusCode(StatusCodes.Status500InternalServerError, JsonConvert.SerializeObject(ex)); }

            try
            {
                var obj = new SetValuesObject()
                {
                    Country = null,
                    Region = null,
                    City = null,
                    UnitOfWork = new SetValuesObject.Status { Commited = new List<object>() }
                };

                var storage = new
                {
                    Countries = await CountryRepository.QueryAsync(x => x, null, ct),
                    Regions = await RegionRepository.QueryAsync(x => x, ct: ct),
                    Cities = await CityRepository.QueryAsync(x => x, ct: ct)
                };

                if (storage.Countries.Count() != countries.Count)
                {
                    if (storage.Countries.Count() > 0)
                        await CountryRepository.DeleteAllAsync(storage.Countries, ct);

                    await CountryRepository.PostAllAsync(countries, UserContext, ct);

                    obj.Country = new SetValuesObject.RepoObj
                    {
                        Added = true,
                        Cleaned = storage.Countries.Count() > 0,
                        Count = countries.Count
                    };

                    await CommitStatus<Country>(obj, ct);

                }
                else
                {
                    obj.Country = new SetValuesObject.RepoObj
                    {
                        Added = false
                    };
                }

                if (storage.Regions.Count() != regions.Count)
                {
                    if (storage.Regions.Count() > 0)
                        await RegionRepository.DeleteAllAsync(storage.Regions, ct);

                    await RegionRepository.PostAllAsync(regions, UserContext, ct);

                    obj.Region = new SetValuesObject.RepoObj
                    {
                        Added = true,
                        Cleaned = storage.Regions.Count() > 0,
                        Count = regions.Count
                    };

                    await CommitStatus<Region>(obj, ct);
                }
                else
                {
                    obj.Region = new SetValuesObject.RepoObj
                    {
                        Added = false
                    };
                }

                if (storage.Cities.Count() != cities.Count)
                {
                    if (storage.Cities.Count() > 0)
                        await CityRepository.DeleteAllAsync(storage.Cities, ct);

                    var test = cities.Where(x => x.Id == 1).ToArray();

                    await CityRepository.PostAllAsync(cities, UserContext, ct);

                    obj.Region = new SetValuesObject.RepoObj
                    {
                        Added = true,
                        Cleaned = storage.Cities.Count() > 0,
                        Count = cities.Count
                    };

                    await CommitStatus<City>(obj, ct);
                }
                else
                {
                    obj.Region = new SetValuesObject.RepoObj
                    {
                        Added = false
                    };
                }

                if (obj.UnitOfWork.Commited.Select(x => (bool)((dynamic)x).Ok).Where(x => x == false).Count() == 0)
                {
                    return CreatedAtAction(nameof(InitialCreate), JsonConvert.SerializeObject(obj));
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, JsonConvert.SerializeObject(obj));
                }
            }
            catch (Exception ex) { return StatusCode(StatusCodes.Status500InternalServerError, JsonConvert.SerializeObject(ex)); }
        }

        [AllowAnonymous]
        [HttpGet("Countries")]
        [ProducesResponseType(typeof(IEnumerable<Country>), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetCountries(CancellationToken ct)
        {
            var query = await CountryRepository.QueryAsync(x => x, x => x.OrderBy(o => o.Name), ct);
            return Ok(query.Select(x => new { x.Id, x.Code, x.Name }).OrderBy(x => x.Name));
        }

        [AllowAnonymous]
        [HttpGet("Regions/{idCountry}")]
        [ProducesResponseType(typeof(IEnumerable<Region>), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRegions([FromRoute]int idCountry, CancellationToken ct)
        {
            var query = await RegionRepository.QueryAsync(x => x.CountryId == idCountry, x => x.OrderBy(o => o.Name), ct);
            return Ok(query.Select(x => new { x.Id, x.Name }).OrderBy(x => x.Name));
        }

        [AllowAnonymous]
        [HttpGet("Cities/{idRegion}")]
        [ProducesResponseType(typeof(IEnumerable<City>), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetCities([FromRoute]int idRegion, CancellationToken ct)
        {
            var query = await CityRepository.QueryAsync(x => x.RegionId == idRegion, x => x.OrderBy(o => o.Name), ct);
            return Ok(query.Select(x => new { x.Id, x.Name }).OrderBy(x => x.Name));
        }

        [NonAction]
        private async Task CommitStatus<TEntity>(SetValuesObject obj, CancellationToken ct) where TEntity : class, IEntity
        {
#if true
            try
            {
                await UnitOfWork.CommitAsync(ct);

                obj.UnitOfWork.Commited.Add(new { Repository = typeof(TEntity).Name, Ok = true });
            }
            catch (Exception ex)
            {
                obj.UnitOfWork.Commited.Add(new { Repository = typeof(TEntity).Name, Ok = false });
                obj.UnitOfWork.Error = ex;
            }
#else

            await UnitOfWork.ExecuteAsync(async (context, ct) =>
            {
                await context.Database.SetIdentityInsertAsync<TEntity>(true, ct);

                try
                {
                    await UnitOfWork.CommitAsync(ct);

                    obj.UnitOfWork.Commited.Add(new { Repository = typeof(TEntity).Name, Ok = true });
                }
                catch (Exception ex)
                {
                    obj.UnitOfWork.Commited.Add(new { Repository = typeof(TEntity).Name, Ok = false });
                    obj.UnitOfWork.Error = ex;
                }

                await context.Database.SetIdentityInsertAsync<TEntity>(false, ct);
            }, ct);
#endif
        }
    }
}