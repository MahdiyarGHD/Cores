﻿using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Database.Interfaces;
using EasyMicroservices.Mapper.Interfaces;

namespace EasyMicroservices.Cores.Database.Logics
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TCreateRequestContract"></typeparam>
    /// <typeparam name="TUpdateRequestContract"></typeparam>
    /// <typeparam name="TResponseContract"></typeparam>
    public class LongIdMappedDatabaseLogicBase<TEntity, TCreateRequestContract, TUpdateRequestContract, TResponseContract> : DatabaseMappedLogicBase<TEntity, long, TCreateRequestContract, TUpdateRequestContract, TResponseContract>
        where TEntity : class, IIdSchema<long>
        where TResponseContract : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="easyReadableQueryable"></param>
        /// <param name="mapperProvider"></param>
        public LongIdMappedDatabaseLogicBase(IEasyReadableQueryableAsync<TEntity> easyReadableQueryable, IMapperProvider mapperProvider) : base(easyReadableQueryable, mapperProvider)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="easyWriteableQueryable"></param>
        /// <param name="mapperProvider"></param>
        public LongIdMappedDatabaseLogicBase(IEasyWritableQueryableAsync<TEntity> easyWriteableQueryable, IMapperProvider mapperProvider) : base(easyWriteableQueryable, mapperProvider)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="easyReadableQueryable"></param>
        /// <param name="easyWriteableQueryable"></param>
        /// <param name="mapperProvider"></param>
        public LongIdMappedDatabaseLogicBase(IEasyReadableQueryableAsync<TEntity> easyReadableQueryable, IEasyWritableQueryableAsync<TEntity> easyWriteableQueryable, IMapperProvider mapperProvider) : base(easyReadableQueryable, easyWriteableQueryable, mapperProvider)
        {
        }

    }
}