using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PPC.Data
{
    public class GenericRepository<TEntidade, TContexto>
       where TEntidade : class
       where TContexto : DbContext, new()
    {
        private bool disposed = false;
        protected TContexto ctx;

        public GenericRepository()
        {

            if (ctx == null)
            {
                ctx = Activator.CreateInstance<TContexto>();
            }
        }

        public ICollection<TEntidade> ObterTodos()
        {
            List<TEntidade> query = (ctx.Set(typeof(TEntidade)) as IEnumerable<TEntidade>).ToList();
            return query;
        }

        public ICollection<TEntidade> ObterTodos(Expression<Func<TEntidade, bool>> predicate)
        {

            return (this.ctx.Set(typeof(TEntidade)) as IQueryable<TEntidade>).Where(predicate).ToList();

        }

        public ICollection<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate)
        {

            return (this.ctx.Set(typeof(TEntidade)) as IQueryable<TEntidade>).Where(predicate).ToList();
        }

        public TEntidade Obter(Expression<Func<TEntidade, bool>> predicate)
        {
            return (TEntidade)this.ctx.Set(typeof(TEntidade)).Find(predicate);
        }

        public void Criar(TEntidade entidade)
        {
            try
            {
                ctx.Set(typeof(TEntidade)).Add(entidade);
                ctx.SaveChanges();
                //ctx.Dispose();
            }
            catch (Exception ex)
            {
                string msgErro = string.Empty;
                var erros = ctx.GetValidationErrors();
                foreach (var erro in erros)
                {
                    foreach (var detalheErro in erro.ValidationErrors)
                        msgErro += detalheErro.ErrorMessage + "\n";
                }
                throw new InvalidOperationException(msgErro);
            }
        }

        public bool Editar(TEntidade entidade, Expression<Func<TEntidade, bool>> predicate)
        {
            if (entidade != null)
            {
                //var model = Obter(predicate);
                //if (model != null)
                //{
                try
                {
                    this.ctx.Entry(entidade).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                catch (Exception)
                {

                    return false;
                }

                //}
            }
            return true;
        }

        public void Remover(Expression<Func<TEntidade, bool>> predicate)
        {
            var model = Obter(predicate);
            if (model != null)
            {
                this.ctx.Set(typeof(TEntidade)).Remove(model);
                ctx.SaveChanges();
            }
        }

        public void SaveChanges() {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (ctx != null)
                    {
                        ctx.Dispose();
                        ctx = null;
                    }
                }
            }
            disposed = true;
        }
    }
}