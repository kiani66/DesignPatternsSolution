using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyService.Implementations
{
    public class ReportCacheProxy
    {
        private readonly Dictionary<string, string> _reportCache = new Dictionary<string, string>();
        public string GenerateReport(string reportId)
        {
            if (_reportCache.ContainsKey(reportId))
            {
                Console.WriteLine($"Fetching report {reportId} from cache.");
                return _reportCache[reportId];
            }

            // شبیه‌سازی ایجاد گزارش
            Console.WriteLine($"Generating report {reportId}...");
            string reportContent = $"Report Content for {reportId} at {DateTime.Now}";
            _reportCache[reportId] = reportContent;

            return reportContent;
        }
    }
}
