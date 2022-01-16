using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ungdung_tudien_anhviet
{
    class Tu_tieng_anh
    {
        private string m_id;
        private string m_phienam;
        private string m_nghia;
        



        public Tu_tieng_anh()
        {
            m_id = "";
            m_phienam = "";
            m_nghia = "";
            
        }
        
        public string id
        {
            set { m_id = value; }
            get { return m_id; }
            
        }
        public string phienam
        {
            set { m_phienam = value; }
            get { return m_phienam; }
        }
        public string nghia
        {
            set { m_nghia = value; }
            get { return m_nghia; }
        }
        
    }
}
