using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ictshop.Common
{
    [Serializable]
    public class UserLogin
    {
        public int MaNguoiDung { get; set; }
        public string email { get; set; }
    }
}