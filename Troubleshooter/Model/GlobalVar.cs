using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troubleshooter.Model
{
    class GlobalVar
    {   
        private static int _userLgd;
        public  int userLgd
        {
            get { return _userLgd; }
            set { _userLgd = value; }
        }

        private static bool _vld;
        public  bool vld
        {
            get { return _vld; }
            set { _vld = value; }
        }

        private static DataTable _dt = new();
        public DataTable dt { get => _dt; set => _dt = value; }

        internal void limpaVar()
        {
            userLgd =0;
            _userLgd = 0;
            vld = false;
            _vld = false;
            dt.Clear();
            _dt.Clear();

        }
    }
}
