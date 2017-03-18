using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TonglBin.Model
{
    [DataContract]
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

        [DataMember]
        public Int32 UserId
        {
            get => m_UserId;
            set => m_UserId = value;
        }

        [DataMember]
        public String UserName
        {
            get => m_UserName;
            set => m_UserName = value;
        }

        [DataMember]
        public String Email
        {
            get => m_Email;
            set => m_Email = value;
        }

        [DataMember]
        public String Address
        {
            get => m_Address;
            set => m_Address = value;
        }
    }
}
