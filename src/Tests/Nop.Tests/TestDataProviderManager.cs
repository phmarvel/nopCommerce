using Nop.Data;
using Nop.Data.DataBase;

namespace Nop.Tests
{
    /// <summary>
    /// Represents the data provider manager
    /// </summary>
    public partial class TestDataProviderManager<DBType> : IDataProviderManager<DBType> where DBType: IDBType
    {
        #region Properties

        /// <summary>
        /// Gets data provider
        /// </summary>
        public INopDataProvider<DBType> DataProvider => new SqLiteNopDataProvider<DBType>();

        #endregion
    }
}
