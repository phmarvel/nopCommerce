using Nop.Data.DataBase;

namespace Nop.Data
{
    /// <summary>
    /// Represents a data provider manager
    /// </summary>
    public partial interface IDataProviderManager<DBType> where DBType: IDBType
    {
        #region Properties

        /// <summary>
        /// Gets data provider
        /// </summary>
        INopDataProvider<DBType> DataProvider { get; }
        #endregion
    }
}
