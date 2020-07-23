﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using IEntity = BlogApp.Core.Entities.IEntity;

namespace BlogApp.Core {
    public interface IEntityRepository<TEntity>
     where TEntity : class, IEntity, new() {

        TEntity Get(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
