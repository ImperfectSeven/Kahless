using System;

namespace DataGrabber
{
    // Use this class to create queries needed to access Yahoo Financial.
    public class QueryBuilder
    {
        #region URL Constants
        const string BASE_URL = "https://query.yahooapis.com/v1/public/yql?";
        #endregion

        // Query historical data for a single symbol.
        public string HistoricalQuery(string tickerSym, DateTime startDate, DateTime endDate)
        {
            // Form the YQL statement.
            string temp = "q=SELECT * FROM yahoo.finance.historicaldata WHERE ";
            temp = String.Concat(temp, "symbol = ", tickerSym);
            temp = String.Concat(temp, " AND startDate = ", startDate.Date);
            temp = String.Concat(temp, " AND endDate = ", endDate.Date);

            // Form the properties of the query.
            temp = String.Concat(temp, "&diagnostics=false");

            // Form the URL.
            temp = String.Concat(BASE_URL, temp);
            
            return new Uri(temp).AbsoluteUri;
        }
    }
}
