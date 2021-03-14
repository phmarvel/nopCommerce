using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Data.DataBase;
using Nop.Data.DataProviders;

namespace Nop.Data
{
    /// <summary>
    /// Represents the data provider manager
    /// </summary>
    public partial class DataProviderManager<DBType> :IDataProviderManager<DBType> where DBType: IDBType
    {
    
        #region Methods

        /// <summary>
        /// Gets data provider by specific type
        /// </summary>
        /// <param name="dataProviderType">Data provider type</param>
        /// <returns></returns>
        public static INopDataProvider<DBType> GetDataProvider(DataProviderType dataProviderType)
        {
            return dataProviderType switch
            {
                DataProviderType.SqlServer => new MsSqlNopDataProvider<DBType>(),
                DataProviderType.MySql => new MySqlNopDataProvider<DBType>(),
                DataProviderType.PostgreSQL => new PostgreSqlDataProvider<DBType>(),
                _ => throw new NopException($"Not supported data provider name: '{dataProviderType}'"),
            };
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets data provider
        /// </summary>
        public INopDataProvider<DBType> DataProvider
        {
            get
            {
                var dataProviderType = Singleton<DataSettings>.Instance.DataProvider;

                return GetDataProvider(dataProviderType);
            }
        }
        #endregion
    }
}
