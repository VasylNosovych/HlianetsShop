using DAL.Models;
using DAL.Repository;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HlianetsContext _db;
        private GenericRepository<User> _users;
        private GenericRepository<UserRole> _roles;

        public UnitOfWork(HlianetsContext db)
        {
            _db = db;
        }

        #region PROPS
        public GenericRepository<User> Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new GenericRepository<User>(_db);
                }
                return _users;
            }
        }

        public GenericRepository<UserRole> Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new GenericRepository<UserRole>(_db);
                }
                return _roles;
            }
        }
        #endregion

        public async Task<int> Save()
        {
            return await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
