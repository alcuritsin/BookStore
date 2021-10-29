using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.DataBaseModel
{
    public class User:DataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ObservableCollection<string> CollectionEmail { get; set; }
        public Role Role { get; set; }
    }
}
