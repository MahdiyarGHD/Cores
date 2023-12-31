﻿using EasyMicroservices.Cores.Models;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyMicroservices.Cores.Relational.EntityFrameworkCore;
/// <summary>
/// 
/// </summary>
public abstract class EntityFrameworkCoreDatabaseBuilder : IEntityFrameworkCoreDatabaseBuilder
{
    /// <summary>
    /// 
    /// </summary>
    protected readonly IConfiguration Configuration;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="configuration"></param>
    public EntityFrameworkCoreDatabaseBuilder(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="optionsBuilder"></param>
    public abstract void OnConfiguring(DbContextOptionsBuilder optionsBuilder);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public DatabaseConfig GetEntity()
    {
        return GetDatabases()?
            .Where(x => x.Name.HasValue())
            .FirstOrDefault(x => x.Name.Equals("Entity", System.StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public virtual List<DatabaseConfig> GetDatabases()
    {
        return Configuration?.GetSection("Databases")?.Get<List<DatabaseConfig>>();
    }
}