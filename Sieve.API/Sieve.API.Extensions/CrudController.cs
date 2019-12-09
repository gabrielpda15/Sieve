using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.API.Models.Base;
using Sieve.API.Repository;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Extensions
{
    public abstract class CrudController<TRepo, TEntity> : Controller
        where TEntity : class, IEntity
        where TRepo : IRepository<TEntity>
    {
        protected TRepo Repository { get; }
        protected IUserContext UserContext { get; }
        protected IUnitOfWork UnitOfWork { get; }

        protected CrudController(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            UnitOfWork = unitOfWork;
            Repository = unitOfWork.GetRepository<TRepo, TEntity>();
            UserContext = userContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<object>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Get(CancellationToken ct)
        {
            var result = await this.Repository.QueryAsync(x => x, ct: ct);
            return Ok(result);
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetById([FromRoute] int id, CancellationToken ct)
        {
            var result = await this.Repository.SingleAsync(id, ct);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(object), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Post([FromBody] TEntity entity, CancellationToken ct)
        {
            try
            {
                var result = await this.Repository.PostAsync(entity, this.UserContext, ct);
                await this.UnitOfWork.CommitAsync(ct);
                return CreatedAtAction(nameof(Post), result);
            }
            catch (Exception ex) { return BadRequest(ex); }
        }

        [HttpPost("PostAll")]
        [ProducesResponseType(typeof(IEnumerable<object>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PostAll([FromBody] IEnumerable<TEntity> entities, CancellationToken ct)
        {
            try
            {
                var result = await this.Repository.PostAllAsync(entities, this.UserContext, ct);
                await this.UnitOfWork.CommitAsync(ct);
                return CreatedAtAction(nameof(PostAll), result);
            }
            catch (Exception ex) { return BadRequest(ex); }
        }

        [HttpPut]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Put([FromBody] TEntity entity, CancellationToken ct)
        {
            try
            {
                var result = await this.Repository.PutAsync(entity, this.UserContext, ct);
                await this.UnitOfWork.CommitAsync(ct);
                return Ok(result);
            }
            catch (Exception ex) { return BadRequest(ex); }
        }

        [HttpPut("PutAll")]
        [ProducesResponseType(typeof(IEnumerable<object>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> PutAll([FromBody] IEnumerable<TEntity> entities, CancellationToken ct)
        {
            try
            {
                var result = await this.Repository.PutAllAsync(entities, this.UserContext, ct);
                await this.UnitOfWork.CommitAsync(ct);
                return Ok(result);
            }
            catch (Exception ex) { return BadRequest(ex); }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken ct) 
        {
            try
            {
                var obj = await this.Repository.SingleAsync(id, ct);

                if (obj == null) return NotFound();

                await this.Repository.DeleteAsync(obj, ct);

                await this.UnitOfWork.CommitAsync(ct);

                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex); }
        }

        [HttpDelete("DeleteAll/{ids}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Exception), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<int>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteAll([FromRoute] string ids, CancellationToken ct)
        {
            try
            {
                var itemList = new List<TEntity>();
                var notFoundItems = new List<int>();
                foreach (var id in ids.Split(",").Select(x => int.Parse(x)))
                {
                    var item = await this.Repository.SingleAsync(id, ct);

                    if (item == null) notFoundItems.Add(id);
                    else itemList.Add(item);
                }

                if (notFoundItems.Count > 0) return NotFound(notFoundItems.ToArray());

                await this.Repository.DeleteAllAsync(itemList.ToArray(), ct);

                await this.UnitOfWork.CommitAsync(ct);

                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex); }
        }

    }
}
