using Microsoft.EntityFrameworkCore;
using RestaurationModel.DALandBLL.Business;
using RestaurationModel.DALandBLL.Mapper;
using RestaurationModel.DALandBLL.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurationModel.DALandBLL.Service
{
    class RefersToService
    {

        DatabaseContext context;

        public RefersToService()
        {
            context = new DatabaseContext();
        }

        public void Add(RefersToBusiness refersTo)
        {
            var entity = RefersToMapper.Map(refersTo);
            context.RefersTo.Add(entity);
            context.SaveChanges();
        }

        public void Delete(RefersToBusiness refersTo)
        {
            var entity = context.RefersTo.Find(refersTo.Action, refersTo.Role);
            if (entity != null)
            {
                context.RefersTo.Remove(entity);
                context.SaveChanges();
            }
        }

       /* public void Update(RefersToBusiness refersTo)
        {
            var entity = context.RefersTo.Find(refersTo.Action, refersTo.Role);
            if (entity != null)
            {
                entity.Role = refersTo.Role;
                entity.Action = refersTo.Action;
                context.SaveChanges();
            }
        }

        public List<RefersToBusiness> Select()
        {
            return (from p in context.RefersTo.Include(i => i.Role).Include(i => i.Action)
                    select RefersToMapper.Map(p)).ToList();
        }*/
    }
}
