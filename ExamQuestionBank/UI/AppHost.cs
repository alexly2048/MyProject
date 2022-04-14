using System.Collections.Generic;
using System.Linq;
using CustomerUI.DBService.CommonService;
using CustomerUI.Model;
namespace CustomerUI
{
    public class AppHost
    {
        public AppHost(AuthoritiesService authoritiesService)
        {
            this.authoritiesService = authoritiesService;
        }
        private readonly AuthoritiesService authoritiesService;
        public static User CurrentUser { get; set; }


        public static List<Authorities> CurrentUserAuthorities => currentUserAuthorities;
        private static  List<Authorities> currentUserAuthorities = new List<Authorities>();

        public  void GetCurrentUserAuthorities()
        {
            if (CurrentUser == null) return;
            var r = authoritiesService.GetAuthoritiesByUserId(CurrentUser.UserId).ToList();
            currentUserAuthorities = r;
        }
    }
}