using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entity;

namespace Core.Specification
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get;}
        public List<Expression<Func<T, object>>> Includes{get;} = new List<Expression<Func<T, object>>>();
        public BaseSpecification(Expression<Func<T,bool>> criteria)
        {
            Criteria=criteria;
        }

        public BaseSpecification()
        {
        }

        protected void AddInclude(Expression<Func<T,object>> include)
        {
            Includes.Add(include);
        }
    }
}