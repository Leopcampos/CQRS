using System.Linq.Expressions;

namespace CQRS.Read.Infrastructure.Persistence.People
{
    public class PersonRepository : IPersonRepository
    {
        private static List<Person> listPersonMemory = new List<Person>();

        public Person Find(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Person> Get(Expression<Func<Person, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            listPersonMemory.Remove(entity);
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}