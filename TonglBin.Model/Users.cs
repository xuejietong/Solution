using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonglBin.Model
{
    public class Users
    {
        private Int32 m_UserId;
        private string m_UserName;
        private string m_Email;
        private string m_Address;

        public Users()
        {
            m_UserId = 0;
            m_UserName = string.Empty;
            m_Email = string.Empty;
            m_Address = string.Empty;
        }

        public Int32 UserId { get => m_UserId; set => m_UserId = value; }
        public String UserName { get => m_UserName; set => m_UserName = value; }
        public String Email { get => m_Email; set => m_Email = value; }
        public String Address { get => m_Address; set => m_Address = value; }
    }
}
