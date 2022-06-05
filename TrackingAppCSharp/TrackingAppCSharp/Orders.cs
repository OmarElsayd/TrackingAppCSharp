using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingAppCSharp
{
    public class Orders
    {
        /// <summary>
        /// Order Id  ===  Tracking number 
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateAndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderStatus { get; set; }
        
    }
}
