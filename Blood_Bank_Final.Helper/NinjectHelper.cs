using Blood_Bank_Final.Application;
using Blood_Bank_Final.Application.Abstract;
using Blood_Bank_Final.DataAccess;
using Blood_Bank_Final.DataAccess.Abstract;
using Blood_Bank_Final.DataAccess.Abstract.Mongo;
using Blood_Bank_Final.DataAccess.ElasticSearch;
using Blood_Bank_Final.DataAccess.ElasticSearch.Abstract;
using Blood_Bank_Final.DataAccess.Mongo;
using Blood_Bank_Final.Domain;
using Blood_Bank_Final.Domain.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Final.Helper
{
    public class NinjectHelper
    {
        public void BindNinject(IKernel kernel)
        {
            kernel.Bind<IApplicationMethodSQL>().To<ApplicationMethodSQL>();
            kernel.Bind<IDomainMethodSQL>().To<DomainMethodSQL>();
            kernel.Bind<ISqlMethods>().To<SqlMethods>();
			kernel.Bind<IApplicationMethodMongo>().To<ApplicationMethodMongo>();
			kernel.Bind<IDomainMethodMongo>().To<DomainMethodMongo>();
			kernel.Bind<IMongoMethods>().To<MongoMethods>();
			kernel.Bind<IElasticConfig>().To<ElasticConfig>();
			kernel.Bind<IApplicationMethodElasticSearch>().To<ApplicationMethodElasticSearch>();
			kernel.Bind<IDomainMethodElasticSearch>().To<DomainMethodElasticSearch>();





		}
	}
}
