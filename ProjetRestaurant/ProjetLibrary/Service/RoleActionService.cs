using ProjectLibrary.Business;
using ProjectLibrary.Mapper;
using ProjectLibrary.Persistance;

namespace ProjectLibrary.Service
{
    class RefersToService
    {

        DatabaseContext context;

        public RefersToService()
        {
            context = new DatabaseContext();
        }

        public void Add(RoleActionBusiness refersTo)
        {
            var entity = RoleActionMapper.Map(refersTo);
            context.RefersTo.Add(entity);
            context.SaveChanges();
        }

        public void Delete(RoleActionBusiness refersTo)
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
