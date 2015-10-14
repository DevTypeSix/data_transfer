using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonFunctions
{
    public class BuildList<T>
    {
        private List<T> _list;
        private IEnumerable<T> _objects;

        public BuildList(IEnumerable<T> objects)
        {
            _objects = objects;
            _list = new List<T>();
            _list = Build(_objects);
        }

        public List<T> List
        {
            get
            {
                if (_list == null)
                {
                    return Build(_objects);
                }
                return _list;
            }
            set
            {
                value = Build(_objects);
            }
        }

        private IEnumerable<T> Objects { get; set; }

        private List<T> Build(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                _list.Add(item);
            }

            return _list;
        }

        public I

        
        
    }
}
