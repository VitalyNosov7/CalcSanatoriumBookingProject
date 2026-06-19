
namespace WPFCSB.Models
{
    public class TabItemBooking
    {

        private String? _header;
        public String Header
        {
            get => _header!;
            set
            {
                _header = value;
                
            }
        }


        private String? _content;
        public String Content
        {
            get => _content!;
            set
            {
                _content = value;

            }
        }
    }
}
