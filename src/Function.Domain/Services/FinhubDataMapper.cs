using Function.Domain.Models;

namespace Function.Domain.Services
{
    public class FinhubDataMapper : IFinhubDataMapper
    {
        public StockData MapToStockData(FinhubStockData finhubStockData){
            return new StockData(){
                Open = finhubStockData.o+1,
                High = finhubStockData.h+2,
                Low = finhubStockData.l,
                Current = finhubStockData.c,
                PreviousClose = finhubStockData.pc
            };
        }
    }
}