using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMmobile
{
    public class LoginFlyoutPageFlyoutMenuItem
    {
        public LoginFlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(LoginFlyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}