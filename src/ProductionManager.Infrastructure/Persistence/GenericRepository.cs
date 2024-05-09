
using ProductionManager.Domain.Interfaces;
using ProductionManager.DomainBase;
using LanguageExt;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ProductionManager.Domain.Errors;

namespace ProductionManager.Infrastructure.Persistence
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ProductionManagerContext _ctx;
        public GenericRepository(ProductionManagerContext ctx)
        {
            Guid guid = Guid.NewGuid();
            _ctx = ctx;
        }
        async Task<Either<GeneralFailure, int>> IGenericRepository<T>.AddAsync(T entity, CancellationToken cancellationToken)
        {
            try
            {
                await _ctx.AddAsync(entity, cancellationToken);
                return await _ctx.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //Log this error properly
                return GeneralFailures.ProblemAddingEntityIntoDbContext(entity.GuidId.ToString());
            }

        }

        async Task<Either<GeneralFailure, int>> IGenericRepository<T>.UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            try
            {
                _ctx.Update(entity);

                return await _ctx.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //Log this error properly
                return GeneralFailures.ProblemUpdatingEntityInRepository(entity.GuidId.ToString());
            }

        }
        async Task<Either<GeneralFailure, int>> IGenericRepository<T>.DeleteAsync(T entity, CancellationToken cancellationToken)
        {
            try
            {
                var result = _ctx.Remove(entity);
                return await _ctx.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //Log this error properly
                return GeneralFailures.ProblemDeletingEntityFromRepository(entity.GuidId.ToString());
            }

        }

        public async Task<Either<GeneralFailure, T>> GetByGuidAsync(Guid guid, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _ctx.Set<T>().AsNoTracking().FirstOrDefaultAsync(s => s.GuidId.Equals(guid), cancellationToken);
                return entity != null ? entity : GeneralFailures.DataNotFoundInRepository(guid.ToString());
            }
            catch (Exception ex)
            {
                //Log this error properly
                return GeneralFailures.ErrorRetrievingSingleDataFromRepository(guid.ToString());
            }
        }
        async Task<Either<GeneralFailure, List<T>>> IGenericRepository<T>.GetAllAsync(Expression<Func<T, bool>> expression, List<string> includes, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, CancellationToken cancellationToken)
        {
            try
            {
                IQueryable<T> query = _ctx.Set<T>();
                if (expression != null)
                {
                    query = query.Where(expression);
                }
                if (includes != null)
                {
                    foreach (var includeProperty in includes)
                    {
                        query = query.Include(includeProperty);
                    }
                }
                if (orderBy != null)
                {
                    // return Task.FromResult(orderBy(query).ToListAsync(cancellationToken));
                    query = orderBy(query);
                }
                var result = await query.AsNoTracking().ToListAsync(cancellationToken);

                return result;// != null ? entity : GeneralFailure.DataNotFoundInRepository;

            }

            catch (Exception ex)
            {

                //Log this error properly
                return GeneralFailures.ErrorRetrievingListDataFromRepository(ex.ToString());
            }
        }
        //public async Task<Either<GeneralFailure, Task<IReadOnlyList<T>>>> GetAllAsync(Expression<Func<T, bool>> expression = null, List<string> includes = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, CancellationToken cancellationToken = default)
        //{
        //    try
        //    {
        //        IQueryable<T> query = _ctx.Set<T>();
        //        if (expression != null)
        //        {
        //            query = query.Where(expression);
        //        }
        //        if (includes != null)
        //        {
        //            foreach (var includeProperty in includes)
        //            {
        //                query = query.Include(includeProperty);
        //            }
        //        }
        //        if (orderBy != null)
        //        {
        //            // return Task.FromResult(orderBy(query).ToListAsync(cancellationToken));
        //            query = orderBy(query);
        //        }
        //        var result = await query.AsNoTracking().ToListAsync(cancellationToken);
        //        var entity = result as IReadOnlyList<T>;
        //        return Task.FromResult(entity);// != null ? entity : GeneralFailure.DataNotFoundInRepository;

        //    }
        //    catch (Exception)
        //    {

        //        //Log this error properly
        //        return GeneralFailures.ErrorRetrievingListDataFromRepository();
        //    }

        //}

        public async Task<Either<GeneralFailure, T>> GetMatch(Expression<Func<T, bool>> expression, List<string> includes = null, CancellationToken cancellationToken = default)
        {
            try
            {
                IQueryable<T> query = _ctx.Set<T>();
                if (includes != null)
                {
                    foreach (var includeProperty in includes)
                    {
                        query = query.Include(includeProperty);
                    }
                }
                var entity = await query.AsNoTracking().FirstOrDefaultAsync(expression, cancellationToken);
                return entity != null ? entity : GeneralFailures.DataNotFoundInRepository(expression.ToString());

            }
            catch (Exception ex)
            {

                //Log this error properly
                return GeneralFailures.ErrorRetrievingListDataFromRepository(ex.ToString());
            }



        }

    }
}
