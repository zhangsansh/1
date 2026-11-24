using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1.SqlHepler
{
    internal class SqlSugarHelper
    {
        private static readonly SqlSugarScope _db;

        static SqlSugarHelper()
        {
            var config = new ConnectionConfig
            {
                // 改成 SqliteCore
                DbType = DbType.Sqlite,
                ConnectionString = "Data Source=C:\\Users\\zjl15\\Desktop\\1\\1.db",
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute,

            };

            _db = new SqlSugarScope(config);
        }

        /// <summary>
        /// 获取数据库实例
        /// </summary>
        public static SqlSugarScope Db => _db;

        #region 同步
        /// <summary>
        /// 新增单条
        /// </summary>
        public static bool Insert<T>(T entity) where T : class, new()
        {
            return _db.Insertable(entity).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        public static bool InsertList<T>(List<T> list) where T : class, new()
        {
            return _db.Insertable(list).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 根据主键更新
        /// </summary>
        public static bool Update<T>(T entity) where T : class, new()
        {
            return _db.Updateable(entity).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        public static bool Delete<T>(object id) where T : class, new()
        {
            return _db.Deleteable<T>(id).ExecuteCommand() > 0;
        }

        /// <summary>
        /// 根据主键查询单条
        /// </summary>
        public static T GetById<T>(object id) where T : class, new()
        {
            return _db.Queryable<T>().InSingle(id);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        public static List<T> GetAll<T>() where T : class, new()
        {
            return _db.Queryable<T>().ToList();
        }

        /// <summary>
        /// 自定义条件查询
        /// </summary>
        public static async Task<List<T>> GetListAsync<T>(Expression<Func<T, bool>> whereExp) where T : class, new()
        {
            return await _db.Queryable<T>().Where(whereExp).ToListAsync();
        }

        /// <summary>
        /// 执行原生 SQL（查询）
        /// </summary>
        public static List<T> SqlQuery<T>(string sql, params SugarParameter[] pars)
        {
            return _db.Ado.SqlQuery<T>(sql, pars);
        }

        /// <summary>
        /// 执行原生增删改 SQL
        /// </summary>
        public static int ExecuteSql(string sql, params SugarParameter[] pars)
        {
            return _db.Ado.ExecuteCommand(sql, pars);
        }
        #endregion

        #region 异步
        public static async Task<bool> InsertAsync<T>(T entity) where T : class, new()
        {
            return await _db.Insertable(entity).ExecuteCommandAsync() > 0;
        }

        public static async Task<bool> InsertListAsync<T>(List<T> list) where T : class, new()
        {
            return await _db.Insertable(list).ExecuteCommandAsync() > 0;
        }

        public static async Task<bool> UpdateAsync<T>(T entity) where T : class, new()
        {
            return await _db.Updateable(entity).ExecuteCommandAsync() > 0;
        }

        public static async Task<bool> DeleteAsync<T>(object id) where T : class, new()
        {
            return await _db.Deleteable<T>(id).ExecuteCommandAsync() > 0;
        }

        public static async Task<T> GetByIdAsync<T>(object id) where T : class, new()
        {
            return await _db.Queryable<T>().InSingleAsync(id);
        }

        public static async Task<List<T>> GetAllAsync<T>() where T : class, new()
        {
            return await _db.Queryable<T>().ToListAsync();
        }

        public static async Task<List<T>> SqlQueryAsync<T>(string sql, params SugarParameter[] pars)
        {
            return await _db.Ado.SqlQueryAsync<T>(sql, pars);
        }

        public static async Task<int> ExecuteSqlAsync(string sql, params SugarParameter[] pars)
        {
            return await _db.Ado.ExecuteCommandAsync(sql, pars);
        }
        #endregion

        #region 事务
        public static void BeginTran(Action action)
        {
            try
            {
                _db.Ado.BeginTran();
                action.Invoke();
                _db.Ado.CommitTran();
            }
            catch
            {
                _db.Ado.RollbackTran();
                throw;
            }
        }

        public static async Task BeginTranAsync(Func<Task> action)
        {
            try
            {
                _db.Ado.BeginTran();
                await action.Invoke();
                _db.Ado.CommitTran();
            }
            catch
            {
                _db.Ado.RollbackTran();
                throw;
            }
        }
        #endregion
    }
}
