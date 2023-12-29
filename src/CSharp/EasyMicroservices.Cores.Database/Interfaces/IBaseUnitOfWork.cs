﻿using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Models;
using EasyMicroservices.Database.Interfaces;
using EasyMicroservices.Mapper.Interfaces;
using EasyMicroservices.Serialization.Interfaces;
using System;
using System.Threading.Tasks;

namespace EasyMicroservices.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBaseUnitOfWork : IDisposable
#if (!NETSTANDARD2_0 && !NET45)
        , IAsyncDisposable
#endif
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IDatabase GetDatabase();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IMapperProvider GetMapper();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ITextSerializationProvider GetTextSerialization();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IUniqueIdentityManager GetUniqueIdentityManager();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<string> GetCurrentUserUniqueIdentity();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool HasUniqueIdentityRole();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<WhiteLabelInfo> InitializeWhiteLabel();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IContentResolver GetContentResolver();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TEntity, TEntity, TEntity, long> GetLongLogic<TEntity>()
           where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContract"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TContract, TContract, TContract, long> GetLongContractLogic<TEntity, TContract>()
         where TContract : class
         where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TEntity, TEntity, TEntity, long> GetLongReadableLogic<TEntity>()
         where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContract"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TContract, TContract, TContract, long> GetLongReadableContractLogic<TEntity, TContract>()
           where TContract : class
           where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TId"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TEntity, TEntity, TEntity, TId> GetLogic<TEntity, TId>()
           where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TEntity, TEntity, TEntity, TEntity> GetLogic<TEntity>()
           where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContract"></typeparam>
        /// <typeparam name="TId"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TContract, TContract, TContract, TId> GetContractLogic<TEntity, TContract, TId>()
         where TContract : class
         where TEntity : class;


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TId"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TEntity, TEntity, TEntity, TId> GetReadableLogic<TEntity, TId>()
         where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContract"></typeparam>
        /// <typeparam name="TId"></typeparam>
        /// <returns></returns>
        IContractLogic<TEntity, TContract, TContract, TContract, TId> GetReadableContractLogic<TEntity, TContract, TId>()
           where TContract : class
           where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TContract"></typeparam>
        /// <typeparam name="TCreateRequestContract"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        IContractLogic<TEntity, TContract, TCreateRequestContract, TContract, long> GetLongContractLogic<TEntity, TCreateRequestContract, TContract>()
            where TContract : class
            where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TResponseContract"></typeparam>
        /// <typeparam name="TCreateRequestContract"></typeparam>
        /// <typeparam name="TUpdateRequestContract"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        IContractLogic<TEntity, TCreateRequestContract, TUpdateRequestContract, TResponseContract, long> GetLongContractLogic<TEntity, TCreateRequestContract, TUpdateRequestContract, TResponseContract>()
            where TResponseContract : class
            where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TCreateRequestContract"></typeparam>
        /// <typeparam name="TUpdateRequestContract"></typeparam>
        /// <typeparam name="TResponseContract"></typeparam>
        /// <typeparam name="TId"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        IContractLogic<TEntity, TCreateRequestContract, TUpdateRequestContract, TResponseContract, TId> GetContractLogic<TEntity, TCreateRequestContract, TUpdateRequestContract, TResponseContract, TId>()
            where TResponseContract : class
            where TEntity : class;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IEasyQueryableAsync<TEntity> GetQueryableOf<TEntity>()
             where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IEasyReadableQueryableAsync<TEntity> GetReadableOf<TEntity>()
             where TEntity : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IEasyWritableQueryableAsync<TEntity> GetWritableOf<TEntity>()
             where TEntity : class;
    }
}
