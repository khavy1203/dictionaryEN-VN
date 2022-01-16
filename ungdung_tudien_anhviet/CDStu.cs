using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ungdung_tudien_anhviet
{
    class CDStu_tieng_anh
    {
        private List<Tu_tieng_anh> ds;
        
        public CDStu_tieng_anh()
        {
            ds = new List<Tu_tieng_anh>();
        }
        public void clear()
        {
            ds.Clear();
        }
        public void them(Tu_tieng_anh tu)
        {
            ds.Add(tu);
        }
        public bool xoa(string id)
        {
            Tu_tieng_anh _tu ;
            _tu=tim(id);
            if (_tu == null) return false;
            else
            {
                ds.Remove(_tu);
                return true;
            }
            

        }
        public List<Tu_tieng_anh> trave_danhsach()
        {
            return ds;
        }
        public Tu_tieng_anh tim(string id)
        {
            
            foreach(Tu_tieng_anh _tu in ds)
            {
                if(id==_tu.id)
                {
                    return _tu;
                }
            }
            return null;

        }

    }
}
