using System.ComponentModel.DataAnnotations.Schema;

namespace yuxi_demo.Entity
{
    public class Location
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        
        public TimeOnly OpenHour { get; set; }
       
        public TimeOnly CloseHour { get; set; }
    }
}
