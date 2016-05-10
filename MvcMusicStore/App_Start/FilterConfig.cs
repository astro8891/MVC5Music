using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //this would apply authorization to everything, if you wanted to let unauthorized users access the home page and other attributes you would 
            //need to use [AllowAnonymous], The below applies the AuthorizeAttribute to all controller actions in the application.
            //filters.Add(new AuthorizeAttribute());

            filters.Add(new HandleErrorAttribute());
        }
    }
}
