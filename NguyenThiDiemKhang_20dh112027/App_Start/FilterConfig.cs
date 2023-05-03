using System.Web;
using System.Web.Mvc;

namespace NguyenThiDiemKhang_20dh112027
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
