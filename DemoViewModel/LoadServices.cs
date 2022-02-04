using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DemoViewModel
{
    public class LoadServices
    {
       
        List<Services> services = BaseConnect.BaseModel.Services.ToList();
        public List<Services> Services
        {
            get
            {
                return services;
            }
        }
        public string Title
        {
            get
            {
                DemoViewModel.Services s = new Services();
                return s.Title;
            }
        }
        public LoadServices()
        {
          //  BaseConnect.BaseModel = new Entities();
        }

        
    }
}
