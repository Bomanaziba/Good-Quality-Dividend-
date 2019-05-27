using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodQualityDividend.Interfaces
{
    public interface IDividendQualityCriteria
    {
         decimal PercentageYield(IStock stock);
         decimal PercentagePayoutRatio(IStock stock);
         decimal Percentage10yrGrowthRate(IList<IStock> stockCollection);
         decimal _5_10yrRatio(IList<IStock> stockCollection);
         Task<IList<IDividendCriteria>> GoodQualityDividendList();
    }
}